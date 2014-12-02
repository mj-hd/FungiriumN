using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class CollectionTableController : UITableViewController
	{
		public CollectionTableController (IntPtr handle) : base (handle)
		{
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return Sprites.Fungi.Population.Instance.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var population = Sprites.Fungi.Population.Instance;
			var stat = population.GetValueAt (indexPath.Item);
			var fungus = stat.Instance;

			var cell = new UITableViewCell (UITableViewCellStyle.Subtitle, fungus.GetMetadata ().InternalName);

			cell.TextLabel.Text = fungus.GetMetadata ().Name;
			cell.DetailTextLabel.Text = stat.IsRevealed.ToString ();

			return cell;
		}

	}
}
