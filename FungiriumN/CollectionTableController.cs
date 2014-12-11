using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class CollectionTableController : UITableViewController
	{
		public CollectionTableController (IntPtr handle) : base (handle)
		{
			this.TableView.SeparatorColor = UIColor.Clear;
		}


		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Sprites.Fungi.Population.Instance.RevealedCount;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var population = Sprites.Fungi.Population.Instance;
			var stat = Sprites.Fungi.Population.Instance.GetRevealedAt (indexPath.Item);
			var fungus = stat.Instance;
			var fungusImage = UIImage.FromFile ("Fungi/"+fungus.GetMetadata().InternalName+".png");

			var cell = tableView.DequeueReusableCell (CollectionTableCell.Key) as CollectionTableCell;

			cell.NameLabel.Text = stat.Instance.GetMetadata ().Name;
			cell.FungusIcon.Image = fungusImage;
			cell.DetailLabel.Text = stat.Instance.GetMetadata ().Description;

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
			var isSelected = (indexPath.Item == this._selectedIndex);
			if (isSelected) {
				return 150.0f;
			}
			return 50.0f;
		}

		private int _selectedIndex = 0;
	}
}
