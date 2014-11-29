using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class RefrigeratorTableController : UITableViewController
	{
		public RefrigeratorTableController (IntPtr handle) : base (handle)
		{
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return base.NumberOfSections (tableView);
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return base.RowsInSection (tableview, section);
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			return base.GetCell (tableView, indexPath);
		}

	}
}
