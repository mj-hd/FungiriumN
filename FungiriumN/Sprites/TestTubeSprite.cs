using System;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites
{
	public class TestTubeSprite : SKSpriteNode
	{
		public TestTubeSprite ()
			: base()
		{
			var texture = SKTexture.FromImageNamed ("TestTube.png");

			this.Texture = texture;
			this.NormalTexture = texture;

			this.Size = texture.Size;


			// 溶液を追加	
			var solution = new TestTubeSolutionSprite () {
				ZPosition = -1.0f,
			};
			this.AddChild (solution);
		}
	}
}

