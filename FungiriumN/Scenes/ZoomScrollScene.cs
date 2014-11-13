using System;
using System.Drawing;

using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class ZoomScrollScene : SKScene
	{
		public SKSpriteNode Container;

		public ZoomScrollScene (SizeF size)
			: base (size)
		{

		}

		public void AddContainer (SKSpriteNode container)
		{

			this.Container = container;

			this.AddChild (container);

		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			// Recognizerを追加
			view.AddGestureRecognizer (new UIPanGestureRecognizer((sender) => 
				{
					this._OnPanGesture (sender);
				}));
			view.AddGestureRecognizer (new UIPinchGestureRecognizer((sender) =>
				{
					this._OnPinchGesture (sender);
				}));
		}

		protected void _OnPanGesture(UIPanGestureRecognizer sender)
		{

			if (sender.State == UIGestureRecognizerState.Began) {

				sender.SetTranslation (new PointF(0.0f, 0.0f), this.View);

			} else if (sender.State == UIGestureRecognizerState.Changed) {

				PointF basePoint = sender.TranslationInView (this.View);
				PointF contPoint = this.Container.Position;

				basePoint = new PointF (-1 * basePoint.X, basePoint.Y);

				this.Container.Position = new PointF(contPoint.X - basePoint.X, contPoint.Y - basePoint.Y);

				sender.SetTranslation (new PointF (0.0f, 0.0f), this.View);

			} else if (sender.State == UIGestureRecognizerState.Ended) {

				// 特になし

			}
		}

		//private float _pinchBaseScale;
		//private float _pinchBasePoint;
		protected void _OnPinchGesture(UIPinchGestureRecognizer sender)
		{

			if (sender.State == UIGestureRecognizerState.Began) {

				//this._pinchBasePoint = sender.LocationInView (this.View);
				//this._pinchBaseScale = sender.Scale;

			} else if (sender.State == UIGestureRecognizerState.Changed) {

				PointF basePoint = sender.LocationInView (this.View);
				basePoint = this.ConvertPointFromView (basePoint);

				PointF nodeBasePoint = this.ConvertPointFromNode (basePoint, this.Container);
				SizeF translation = new SizeF (basePoint.X - nodeBasePoint.X, basePoint.Y - nodeBasePoint.Y);

				this.Container.XScale *= sender.Scale;
				this.Container.YScale *= sender.Scale;
				this.Container.Position = new PointF (this.Container.Position.X - translation.Width, this.Container.YScale - translation.Height);

				sender.Scale = 1.0f;

			} else if (sender.State == UIGestureRecognizerState.Ended) {

			}
		}

		public override void TouchesBegan (MonoTouch.Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);
		}

		public override void TouchesMoved (MonoTouch.Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesMoved (touches, evt);
		}

		public override void TouchesEnded (MonoTouch.Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesEnded (touches, evt);
		}

		public override void TouchesCancelled (MonoTouch.Foundation.NSSet touches, UIEvent evt)
		{
			base.TouchesCancelled (touches, evt);
		}
	}
}

