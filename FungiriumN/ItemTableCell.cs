using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class ItemTableCell : UITableViewCell
	{
		public static string Key = "ItemTableCell";
		public ItemTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new System.Drawing.RectangleF (this.Frame.Location, new System.Drawing.SizeF (this.Frame.Width, 50.0f));

			var backgroundImageView = new UIImageView (UIImage.FromFile ("Table/Cell.png")) {
				ContentMode = UIViewContentMode.TopLeft,
				ContentScaleFactor = UIScreen.MainScreen.Scale,
			};

			this.BackgroundView = backgroundImageView;

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
	}
}
