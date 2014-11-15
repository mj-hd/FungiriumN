using System;
using System.Collections.Generic;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class Fungi : List<Fungus>
	{
		public Fungi (SKSpriteNode testTube)
			: base ()
		{
			this._TestTube = testTube;

			this._BubbleAnimation = SKAction.Sequence (
				SKAction.RepeatAction (
					SKAction.MoveBy (0.0f, 15.0f, 1.0f),
					5
				),
				SKAction.RemoveFromParent ()
			);
		}

		public new void Add (Fungus fungus)
		{
			base.Add (fungus);
			this._TestTube.AddChild (fungus);
		}

		public void Eat (Fungus strong, Fungus weak)
		{
			weak.State = State.Dead;
			strong.State = State.Eat;
			strong.Energy += (float)weak.GetMetadata ().Calorie;
		}
			
		public void Update (double time)
		{
			if (time - 1.0f > this._PreviousTime) {
				this._PreviousTime = time;

				this._UpdateForASecond ();
			}
		}

		protected SKAction _BubbleAnimation;

		protected void _UpdateForASecond ()
		{
			var wantedList = new List<Fungus>();
			var divideList = new List<Fungus> ();

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

			this._TestTube.AddChild (bubble);

			bubble.RunAction (this._BubbleAnimation);
		}

		private SKSpriteNode _TestTube;
		private double _PreviousTime = 0.0;


	}
}

