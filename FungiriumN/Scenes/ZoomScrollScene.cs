using System;
using System.Drawing;

using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class ZoomScrollScene : ScrollScene
	{
		public ZoomScrollScene (SizeF size)
			: base (size)
		{
			this.ScrollDirection = ScrollDirection.Both;
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			// Recognizerを追加
			view.AddGestureRecognizer (new UIPinchGestureRecognizer((sender) =>
				{
					this._OnPinchGesture (sender);
				}));
		}

		private void _OnPinchGesture(UIPinchGestureRecognizer sender)
		{

			if (sender.State == UIGestureRecognizerState.Began) {

			} else if (sender.State == UIGestureRecognizerState.Changed) {

				// TODO: ピンチしても座標がずれないようにする

				//PointF basePoint = sender.LocationInView (this.View);
				//basePoint = this.ConvertPointFromView (basePoint);

				//PointF nodeBasePoint = this.ConvertPointFromNode (basePoint, this.Container);
				//SizeF translation = new SizeF (basePoint.X - nodeBasePoint.X, basePoint.Y - nodeBasePoint.Y);

				this.Container.XScale *= sender.Scale;
				this.Container.YScale *= sender.Scale;
				//this.Container.Position = new PointF (this.Container.Position.X - translation.Width, this.Container.YScale - translation.Height);

				sender.Scale = 1.0f;

			} else if (sender.State == UIGestureRecognizerState.Ended) {

			}
		}
	}
}

