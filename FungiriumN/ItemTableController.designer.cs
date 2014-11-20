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
	[Register ("ItemTableController")]
	partial class ItemTableController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView ItemTable { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (ItemTable != null) {
				ItemTable.Dispose ();
				ItemTable = null;
			}
		}
	}
}
