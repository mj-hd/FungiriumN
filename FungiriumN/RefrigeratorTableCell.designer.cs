// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	[Register ("RefrigeratorTableCell")]
	partial class RefrigeratorTableCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView _FungusIcon { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _Name { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton _PutButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (_FungusIcon != null) {
				_FungusIcon.Dispose ();
				_FungusIcon = null;
			}
			if (_Name != null) {
				_Name.Dispose ();
				_Name = null;
			}
			if (_PutButton != null) {
				_PutButton.Dispose ();
				_PutButton = null;
			}
		}
	}
}
