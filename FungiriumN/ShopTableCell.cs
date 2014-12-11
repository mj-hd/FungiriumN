using System;

using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class ShopTableCell : UITableViewCell
	{
		public static string Key = "ShopTableCell";

		public ShopTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new System.Drawing.RectangleF (this.Frame.Location, new System.Drawing.SizeF (this.Frame.Width, 50.0f));

			// 背景画像の設定
			var backgroundImageView = new UIImageView (UIImage.FromFile ("Table/Cell.png")) {
				ContentMode = UIViewContentMode.TopLeft,
				ContentScaleFactor = UIScreen.MainScreen.Scale,
			};

			this.BackgroundView = backgroundImageView;

			// セパレータを隠蔽
			this.SeparatorInset = new UIEdgeInsets (0.0f, 0.0f, 0.0f, this.Bounds.Size.Width);
		}

		public UIButton BuyButton { 
			get {
				return this._BuyButton;
			}
			set {
				this._BuyButton = value;
			} 
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
		public UILabel PriceLabel { 
			get {
				return this._PriceLabel;
			}
			set {
				this._PriceLabel = value;
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
		public UILabel NameLabel {
			get {
				return this._NameLabel;
			}
			set {
				this._NameLabel = value;
			}
		}
	}
}
