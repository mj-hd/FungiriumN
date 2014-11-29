using System;
using MonoTouch.UIKit;
using MonoTouch.SpriteKit;
using MonoTouch.Foundation;

namespace FungiriumN
{
	partial class StatisticsTableController : UITableViewController
	{

		private Sprites.Fungi.Population Population = Sprites.Fungi.Population.Instance;

		public StatisticsTableController (IntPtr handle) : base (handle)
		{
		}

		public override int NumberOfSections (UITableView tableView)
		{
			return 1;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return this.Population.Count;
		}


		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var stat = this.Population.GetValueAt (indexPath.Item);
			var fungus = stat.Instance;

			var cell = new UITableViewCell (UITableViewCellStyle.Subtitle, fungus.GetMetadata ().InternalName);

			cell.TextLabel.Text = fungus.GetMetadata().Name;

			cell.DetailTextLabel.Text = stat.Count.ToString () + " 匹";

			var fungusImage = new UIImageView (UIImage.FromFile ("Fungi/"+fungus.GetMetadata().InternalName+".png"));

			cell.AddSubview (fungusImage);

			return cell;
		}



		public override void WillDisplay (UITableView tableView, UITableViewCell cell, NSIndexPath indexPath)
		{
		}
	}
}
