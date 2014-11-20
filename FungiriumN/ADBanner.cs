using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN

{
	partial class ADBanner : MonoTouch.iAd.ADBannerView
	{
		public ADBanner (IntPtr handle) : base (handle)
		{
			this.WillLoad += (sender, e) => {
				this._hidden = true;
				{
					var newOne = this.Frame;
					newOne.Offset (new PointF (0, this.Frame.Height));
					this.Frame = newOne;
				}
			};

			this.AdLoaded += (sender, e) => 
				UIView.Animate (1.0, () => {
					if (this._hidden) {

						var newOne = this.Frame;
						newOne.Offset (new PointF(0, -this.Frame.Height));
						this.Frame = newOne;

						this._hidden = false;
					}
				});

			this.FailedToReceiveAd += (sender, e) => 
				UIView.Animate (1.0, () => {
					if (!this._hidden) {

						var newOne = this.Frame;
						newOne.Offset (new PointF(0, this.Frame.Height));
						this.Frame = newOne;

						this._hidden = true;
					}
				});
		}

		private bool _hidden;
	}
}
