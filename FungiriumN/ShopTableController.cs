using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class ShopTableController : UITableViewController
	{
		public ShopTableController (IntPtr handle) : base (handle)
		{
			this.TableView.SeparatorColor = UIColor.Clear;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Items.Inventory.Instance.RevealedCount;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var stat = Items.Inventory.Instance.GetRevealedAt(indexPath.Item);
			var item = stat.Instance;

			var cell = tableView.DequeueReusableCell (ShopTableCell.Key) as ShopTableCell;
			cell.NameLabel.Text = item.GetMetadata ().Name;
			cell.DetailLabel.Text = item.GetMetadata ().Description;
			cell.PriceLabel.Text = item.GetMetadata().Price.ToString()+ " Z";
			cell.CountLabel.Text = stat.Count.ToString () + "個";

			return cell;
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
