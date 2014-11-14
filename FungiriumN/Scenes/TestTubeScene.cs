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
		protected Sprites.TestTubeSprite TestTube;

		public TestTubeScene (SizeF size) : base (size)
		{
			BackgroundColor = new UIColor (0.5f, 0.5f, 0.5f, 1.0f);

			this.MainView = new ZoomScrollScene (size);

			// 試験管を追加
			this.TestTube = new Sprites.TestTubeSprite () {
				Position = new PointF (Frame.X + Frame.Width / 2, Frame.Y + Frame.Height / 2),
			};

			this.MainView.AddContainer (this.TestTube);

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
