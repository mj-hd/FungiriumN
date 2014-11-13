using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class TestTubeScene : SKScene
	{
		protected ZoomScrollScene MainView;

		public TestTubeScene (SizeF size) : base (size)
		{
			BackgroundColor = new UIColor (1.0f, 1.0f, 1.0f, 1.0f);

			this.MainView = new ZoomScrollScene (size);

			// 試験管を追加
			var testTube = new Sprites.TestTubeSprite () {
				Position = new PointF (Frame.X + Frame.Width / 2, Frame.Y + Frame.Height / 2),
			};

			this.MainView.AddContainer (testTube);

			AddChild (this.MainView);
		}

		public override void Update (double currentTime)
		{
			base.Update (currentTime);
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			// ウラワザ: 無理やりthis.ContainerのDidMoveToViewを呼び出している
			this.MainView.DidMoveToView (view);
		}
	}
}
