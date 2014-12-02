using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class ShopTableController : UITableViewController
	{
		public ShopTableController (IntPtr handle) : base (handle)
		{
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			this._selectedIndex = indexPath.Item;

			tableView.BeginUpdates ();
			tableView.EndUpdates ();
		}

		public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			if (indexPath.Item == this._selectedIndex) {
				return 150.0f;
			}
			return 50.0f;
		}

		private int _selectedIndex = 0;
	}
}
