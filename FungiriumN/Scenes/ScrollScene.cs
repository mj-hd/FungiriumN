using System;
using System.Drawing;

using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class ScrollScene : SKScene
	{
		public SKSpriteNode Container;
		public ScrollDirection ScrollDirection;

		public ScrollScene (SizeF size)
			: base (size)
		{
			this.ScrollDirection = ScrollDirection.Vertical;
		}

		public void AddContainer (SKSpriteNode container)
		{
			this.Container = container;

			base.AddChild (container);
		}

		public override void AddChild(SKNode child)
		{
			this.Container.AddChild (child);
		}

		public override SKNode[] Children {
			get
			{
				return this.Container.Children;
			}
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			// Recognizerを追加する
			view.AddGestureRecognizer (new UIPanGestureRecognizer((sender) => {
				this._onPanGesture (sender);
			}));
		}

		private void _onPanGesture (UIPanGestureRecognizer sender)
		{

			if (sender.State == UIGestureRecognizerState.Began) {

				sender.SetTranslation (new PointF(0, 0), this.View);

			} else if (sender.State == UIGestureRecognizerState.Changed) {

				PointF basePoint = sender.TranslationInView (this.View);

				switch (this.ScrollDirection) {
				case ScrollDirection.Vertical:
					basePoint.X = 0;
					break;
				case ScrollDirection.Horizontal:
					basePoint.Y = 0;
					break;
				case ScrollDirection.Both:
					break;
				}

				this.Container.Position = new PointF(
					this.Container.Position.X + basePoint.X,
					this.Container.Position.Y - basePoint.Y
				);

				sender.SetTranslation (new PointF(0, 0), this.View);
			}

		}
	}

	public enum ScrollDirection
	{
		Vertical,
		Horizontal,
		Both
	}
}

