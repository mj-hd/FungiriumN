using System;
using System.Drawing;

using MonoTouch.UIKit;
using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites
{
	public class TestTubeSprite : SKSpriteNode
	{
		public TestTubeSprite ()
			: base()
		{
			var testTube = new SKSpriteNode ("TestTube.png");

			this.Size = testTube.Size;

			// 基準点を中心に設定
			this.AnchorPoint = new PointF (
				this.Size.Width / 2.0f,
				this.Size.Height / 2.0f
			);

			// 試験管を追加
			testTube.ZPosition = 2.0f;
			this.AddChild (testTube);

			// 溶液を追加	
			const float gap = -255.0f;
			var solution = new TestTubeSolutionSprite () {
				Position = new PointF(0.0f, gap),
				ZPosition = 0.0f,
			};
			this.AddChild (solution);
		}

		// Fungus用のAddChildを定義
		public void AddChild (Fungi.IFungus fungus)
		{
			fungus.Sprite.ZPosition = 1.0f;

			this.AddChild (fungus.Sprite);
		}

	}
}

