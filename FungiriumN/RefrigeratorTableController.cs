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
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Items.Refrigerator.Instance.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var refrigerator = Items.Refrigerator.Instance;

			var stat = refrigerator.GetValueAt (indexPath.Item);
			var item = stat.Instance;

			var cell = new UITableViewCell (UITableViewCellStyle.Subtitle, item.GetMetadata ().InternalName);

			cell.TextLabel.Text = item.GetMetadata ().Name;
			cell.DetailTextLabel.Text = item.Count.ToString ();

			return cell;
		}

	}
}
