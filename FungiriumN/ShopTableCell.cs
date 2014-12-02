using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class ShopTableCell : UITableViewCell
	{
		public static string Key = "ShopTableCell";

		public ShopTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new System.Drawing.RectangleF (this.Frame.Location, new System.Drawing.SizeF (this.Frame.Width, 50.0f));
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
