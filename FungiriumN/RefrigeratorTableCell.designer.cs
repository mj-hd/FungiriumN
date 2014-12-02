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
		UILabel _CalorieLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _CountLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _CurrentCount { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView _FungusIcon { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _NameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel _PowerLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton _PutButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (_CalorieLabel != null) {
				_CalorieLabel.Dispose ();
				_CalorieLabel = null;
			}
			if (_CountLabel != null) {
				_CountLabel.Dispose ();
				_CountLabel = null;
			}
			if (_CurrentCount != null) {
				_CurrentCount.Dispose ();
				_CurrentCount = null;
			}
			if (_FungusIcon != null) {
				_FungusIcon.Dispose ();
				_FungusIcon = null;
			}
			if (_NameLabel != null) {
				_NameLabel.Dispose ();
				_NameLabel = null;
			}
			if (_PowerLabel != null) {
				_PowerLabel.Dispose ();
				_PowerLabel = null;
			}
			if (_PutButton != null) {
				_PutButton.Dispose ();
				_PutButton = null;
			}
		}
	}
}
