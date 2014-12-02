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
	[Register ("ShopTableCell")]
	partial class ShopTableCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton BuyButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView ItemIcon { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Name { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (BuyButton != null) {
				BuyButton.Dispose ();
				BuyButton = null;
			}
			if (ItemIcon != null) {
				ItemIcon.Dispose ();
				ItemIcon = null;
			}
			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}
		}
	}
}
