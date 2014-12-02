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
	[Register ("CollectionTableCell")]
	partial class CollectionTableCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _DetailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView _FungusIcon { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _NameLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (_DetailLabel != null) {
				_DetailLabel.Dispose ();
				_DetailLabel = null;
			}
			if (_FungusIcon != null) {
				_FungusIcon.Dispose ();
				_FungusIcon = null;
			}
			if (_NameLabel != null) {
				_NameLabel.Dispose ();
				_NameLabel = null;
			}
		}
	}
}
