using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class RefrigeratorTableCell : UITableViewCell
	{
		public static string Key = "RefrigeratorTableCell";

		public RefrigeratorTableCell (IntPtr handle) : base (handle)
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
		public UIImageView FungusIcon {
			get {
				return this._FungusIcon;
			}
			set {
				this._FungusIcon = value;
			}
		}
		public UIButton PutButton {
			get {
				return this._PutButton;
			}
			set {
				this._PutButton = value;
			}
		}
		public UILabel PowerLabel {
			get {
				return this._PowerLabel;
			}
			set {
				this._PowerLabel = value;
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
		public UILabel CalorieLabel {
			get {
				return this._CalorieLabel;
			}
			set {
				this._CalorieLabel = value;
			}
		}

	}
}
