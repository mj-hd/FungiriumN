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
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		ADBanner AD { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton CollectionButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ItemButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton RefrigeratorButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton ShopButton { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton StatisticsButton { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (AD != null) {
				AD.Dispose ();
				AD = null;
			}
			if (CollectionButton != null) {
				CollectionButton.Dispose ();
				CollectionButton = null;
			}
			if (ItemButton != null) {
				ItemButton.Dispose ();
				ItemButton = null;
			}
			if (RefrigeratorButton != null) {
				RefrigeratorButton.Dispose ();
				RefrigeratorButton = null;
			}
			if (ShopButton != null) {
				ShopButton.Dispose ();
				ShopButton = null;
			}
			if (StatisticsButton != null) {
				StatisticsButton.Dispose ();
				StatisticsButton = null;
			}
		}
	}
}
