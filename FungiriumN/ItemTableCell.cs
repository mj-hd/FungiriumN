using System;
using System.Drawing;

using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class ItemTableCell : UITableViewCell
	{
		public static string Key = "ItemTableCell";

		public ItemTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new RectangleF (this.Frame.Location, new SizeF (this.Frame.Width, 50.0f));

			// 背景画像の設定
			var backgroundImageView = new UIImageView (UIImage.FromFile ("Table/Cell.png")) {
				ContentMode = UIViewContentMode.TopLeft,
				ContentScaleFactor = UIScreen.MainScreen.Scale,
			};

			this.BackgroundView = backgroundImageView;

			// セパレータの隠蔽
			this.SeparatorInset = new UIEdgeInsets (0.0f, 0.0f, 0.0f, this.Bounds.Size.Width);
		}

		public UILabel CountLabel {
			get {
				return this._CountLabel;
			}
			set {
				this._CountLabel = value;
			}
		}
		public UILabel DetailLabel { 
			get {
				return this._DetailLabel;
			}
			set {
				this._DetailLabel = value;
			}
		}
		public UILabel NameLabel {
			get {
				return this._NameLabel;
			}
			set {
				this._NameLabel = value;
			}
		}
		public UIImageView ItemIcon { 
			get {
				return this._ItemIcon;
			}
			set {
				this._ItemIcon = value;
			}
		}
		public UIButton UseButton { 
			get {
				return this._UseButton;
			}
			set {
				this._UseButton = value;
			}
		}

		private bool _isSetPushedUse = false;
		public event EventHandler PushedUse
		{
			add {
				if (!this._isSetPushedUse) {
					this._isSetPushedUse = true;
					this.UseButton.TouchUpInside += value;
				}
			}
			remove {
				if (this._isSetPushedUse) {
					this._isSetPushedUse = false;
					this.UseButton.TouchUpInside -= value;
				}
			}
		}
	}
}
