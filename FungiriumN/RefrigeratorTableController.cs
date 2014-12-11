using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace FungiriumN
{
	partial class RefrigeratorTableController : UITableViewController
	{
		public RefrigeratorTableController (IntPtr handle) : base (handle)
		{
			this.TableView.SeparatorColor = UIColor.Clear;
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Items.Refrigerator.Instance.AvailableCount;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var refrigerator = Items.Refrigerator.Instance;

			var stat = refrigerator.GetAvailableAt (indexPath.Item);
			var item = stat.Instance as Items.RefrigeratedFungus;
			var meta = Sprites.Fungi.Population.Instance [item.FungusType].Instance.GetMetadata ();
			var fungusImage = UIImage.FromFile ("Fungi/"+item.GetMetadata().InternalName+".png");

			var cell = (RefrigeratorTableCell)tableView.DequeueReusableCell (RefrigeratorTableCell.Key);

			cell.NameLabel.Text = item.GetMetadata ().Name;
			cell.CountLabel.Text =  item.Count.ToString() + "個";
			cell.SetFungusIcon (fungusImage);
			cell.CalorieLabel.Text = meta.Calorie.ToString() + " cal";
			cell.PowerLabel.Text = meta.Power.ToString ();
			cell.CurrentLabel.Text = Sprites.Fungi.Population.Instance[item.FungusType].Count.ToString() +" 匹";

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
