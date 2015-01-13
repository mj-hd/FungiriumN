using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class Fungi : List<Fungus>
	{
		public Fungi ()
			: base ()
		{
			this._BubbleAnimation = SKAction.Sequence (
				SKAction.RepeatAction (
					SKAction.MoveBy (0.0f, 15.0f, 1.0f),
					5
				),
				SKAction.RemoveFromParent ()
			);
		}

		public const int MaxNumberOfFungi = 100;

		public new void Add (Fungus fungus)
		{
			if (this._Count > MaxNumberOfFungi) {
				return;
			}

			this._Count++;

			base.Add (fungus);
			Sprites.TestTubeSprite.Instance.AddChild (fungus);
			Population.Instance.Increment (fungus.GetType ());
		}

		public new void Remove (Fungus fungus)
		{
			this._Count--;

			base.Remove (fungus);
			fungus.RemoveFromParent ();

			Population.Instance.Decrement (fungus.GetType ());
		}

		public void Eat (Fungus strong, Fungus weak)
		{
			if ((strong.State == State.Dead) ||
			    (weak.State == State.Dead))
				return;

			weak.State = State.Dead;
			strong.State = State.Eat;
			strong.Energy += (float)weak.GetMetadata ().Calorie;
		}

		public void Treat (PointF p)
		{
			foreach (var fungus in this)
			{
				if (fungus.ContainsPoint (p)) {
					// TODO: 幸福値の操作など
					fungus.State = State.Happy;

					const int MetamorphosePerc = 10; // %
					var rand = new Random ();

					if (rand.Next(100) < MetamorphosePerc) {
						fungus.Request = Request.Metamorphose;

						Console.WriteLine ("Metamol!! {0}", fungus.GetType ().ToString ());
					}
				}
			}
		}
			
		public void Update (double time)
		{
			if (time - 1.0f > this._PreviousTime) {
				this._PreviousTime = time;

				this._UpdateForASecond ();
			}
		}

		private int _Count = 0;
		public int Count {
			get {
				return this._Count;
			}
		}

		protected SKAction _BubbleAnimation;

		protected void _UpdateForASecond ()
		{
			var wantedList = new List<Fungus> ();
			var divideList = new List<Fungus> ();
			var metamoList = new List<KeyValuePair<Fungus, Type>> ();

			const int ProducingBubblePerc = 60; // %で
			var rand = new Random ();

			foreach (var fungus in this)
			{
				switch (fungus.Request) {
				case Request.Clean: // 死亡

					wantedList.Add (fungus);

					continue;
				case Request.Divide: // 分裂

					divideList.Add (fungus);

					fungus.Request = Request.None;

					break;
				case Request.Metamorphose:

					metamoList.Add (new KeyValuePair<Fungus, Type> (fungus, fungus.GetNextForm ()));

					fungus.Request = Request.None;

					break;
				}

				// TODO: 一秒よりもっと細かく呼び出すべき
				fungus.Update (1.0);

				if (rand.Next (100) < ProducingBubblePerc) {
					this._ProduceBubble (fungus);
				}
			}

			// 死亡した菌を片付ける
			foreach (var fungus in wantedList)
			{
				this.Remove (fungus);
			}

			// 菌を分裂させる
			foreach (var fungus in divideList)
			{
				this.Add ((Fungus)fungus.Clone ());
			}

			// 突然変異
			foreach (var fungusAndType in metamoList)
			{
				var fungus = (Fungus) Activator.CreateInstance (fungusAndType.Value);

				fungus.Position = fungusAndType.Key.Position;
				fungus.ZRotation = fungusAndType.Key.ZRotation;

				this.Remove	(fungusAndType.Key);
				this.Add (fungus);

				this._ProduceStars (fungus);
			}
		}

		protected void _ProduceBubble (Fungus fungus)
		{
			var textures = SKTextureAtlas.FromName ("Fungi");
			var bubble = new SKSpriteNode (textures.TextureNamed ("Fungus_Bubble")) {
				Position = fungus.Position,
				ZPosition = 0.1f,
				Scale = 0.05f,
				Alpha = 0.4f
			};

			Sprites.TestTubeSprite.Instance.AddChild (bubble);

			bubble.RunAction (this._BubbleAnimation);
		}

		protected void _ProduceStars (Fungus fungus)
		{
			var particleSystem = NSKeyedUnarchiver.UnarchiveFile ("Metamorphose.sks") as SKEmitterNode;

			particleSystem.Position = fungus.Position;
			particleSystem.ParticleTexture = SKTexture.FromImageNamed ("Star.png");

			Sprites.TestTubeSprite.Instance.AddChild (particleSystem);
		}

		private double _PreviousTime = 0.0;


	}
}

