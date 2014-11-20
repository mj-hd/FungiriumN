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
	[Register ("ShopTableController")]
	partial class ShopTableController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView ShopTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ShopTable != null) {
				ShopTable.Dispose ();
				ShopTable = null;
			}
		}
	}
}
