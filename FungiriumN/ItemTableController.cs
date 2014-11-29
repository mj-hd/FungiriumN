using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class ItemTableController : UITableViewController
	{
		public ItemTableController (IntPtr handle) : base (handle)
		{
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Items.Inventory.Instance.Count;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{

			var inventory = Items.Inventory.Instance;
			var stat = inventory.GetValueAt (indexPath.Item);
			var item = stat.Instance;

			var cell = new UITableViewCell (UITableViewCellStyle.Subtitle, item.GetMetadata ().InternalName);

			cell.TextLabel.Text = item.GetMetadata ().Name;
			cell.DetailTextLabel.Text = stat.Count.ToString ();

			return cell;
		}
	}
}
