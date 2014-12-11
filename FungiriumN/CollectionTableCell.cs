using System;
using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class CollectionTableCell : UITableViewCell
	{
		public static string Key = "CollectionTableCell";

		public CollectionTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new System.Drawing.RectangleF (this.Frame.Location, new System.Drawing.SizeF (this.Frame.Width, 50.0f));
		}

		public UILabel NameLabel { 
			get {
				return this._NameLabel;
			}
			set {
				this._NameLabel = value;
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
		public UIImageView FungusIcon {
			get {
				return this._FungusIcon;
			}
			set {
				this._FungusIcon = value;
			}
		}
	}
}
