using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class TestTubeScene : SKScene
	{
		public TestTubeScene (SizeF size) : base (size)
		{
			BackgroundColor = new UIColor (1.0f, 1.0f, 1.0f, 1.0f);

			// 試験管を追加
			var testTube = new Sprites.TestTubeSprite () {
				Position = new PointF (Frame.X + Frame.Width / 2, Frame.Y + Frame.Height / 2),
			};

			AddChild (testTube);
		}

		public override void Update (double currentTime)
		{
			base.Update (currentTime);
		}
	}
}
