using System;
using System.Collections.Generic;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class Fungi : List<IFungus>
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
			const int ProducingBubblePerc = 60; // %で
			var rand = new Random ();

			foreach (var fungus in this)
			{
				// TODO: 一秒よりもっと細かく呼び出すべき
				fungus.Update (1.0);

				if (rand.Next (100) < ProducingBubblePerc) {
					this._ProduceBubble (fungus);
				}
			}
		}

		protected void _ProduceBubble (IFungus fungus)
		{
			var textures = SKTextureAtlas.FromName ("Fungi");
			var bubble = new SKSpriteNode (textures.TextureNamed ("Fungus_Bubble")) {
				Position = fungus.Sprite.Position,
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

