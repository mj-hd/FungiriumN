using System;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites
{
	public class TestTubeSolutionSprite : SKSpriteNode
	{
		public TestTubeSolutionSprite ()
			: base()
		{
			var texture = SKTexture.FromImageNamed ("TestTubeSolution.png");

			this.Texture = texture;
			this.NormalTexture = texture;
			this.Size = texture.Size;
		}
	}
}

