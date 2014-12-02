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
		}
		public RefrigeratorTableCell () : base ()
		{
		}

		public UILabel NameLabel
		{
			get {
				return this._Name;
			}
			set {
				this._Name = value;
			}
		}

		public UIImageView FungusIcon
		{
			get {
				return this._FungusIcon;
			}
			set {
				this._FungusIcon = value;
			}
		}

		public UIButton PutButton
		{
			get {
				return this._PutButton;
			}
			set {
				this._PutButton = value;
			}
		}

	}
}
