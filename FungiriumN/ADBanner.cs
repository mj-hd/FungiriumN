using System;

using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class ADBanner : MonoTouch.iAd.ADBannerView
	{
		public ADBanner (IntPtr handle) : base (handle)
		{
			this.WillLoad += (sender, e) => {
				this.Hidden = true;
				this.Alpha = 0.0f;
			};

			this.AdLoaded += (sender, e) => { 
				if (this.Hidden) {
					this.Hidden = false;
					UIView.Animate (1.0, () => {
						this.Alpha = 1.0f;
					});
				}
			};

			this.FailedToReceiveAd += (sender, e) => {
		 		if (!this.Hidden) {
					this.Hidden = true;
					UIView.Animate (1.0, () => {
						this.Alpha = 0.0f;
					});
				}
			};
		}
	}
}
