using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace FungiriumN
{
	partial class RefrigeratorTableCell : UITableViewCell
	{
		public static string Key = "RefrigeratorTableCell";

		public RefrigeratorTableCell (IntPtr handle) : base (handle)
		{
			this.Frame = new System.Drawing.RectangleF (this.Frame.Location, new System.Drawing.SizeF (this.Frame.Width, 50.0f));

			var backgroundImageView = new UIImageView (UIImage.FromFile ("Table/Cell.png")) {
				ContentMode = UIViewContentMode.TopLeft,
				ContentScaleFactor = UIScreen.MainScreen.Scale,
			};

			this.BackgroundView = backgroundImageView;

			this.SeparatorInset = new UIEdgeInsets (0.0f, 0.0f, 0.0f, this.Bounds.Size.Width);
		}


		public UILabel NameLabel {
			get { 
				return this._NameLabel;
			}
			set {
				this._NameLabel = value;
			}
		}
		public void SetFungusIcon (UIImage fungus) {

			var solution = UIImage.FromFile ("Table/Solution.png");
			var cup = UIImage.FromFile ("Table/Cup.png");
	
			UIGraphics.BeginImageContextWithOptions (this._FungusIcon.Frame.Size, false, 0);

			const float SizeRatio = 0.65f;
			solution.Draw (new RectangleF (0.0f, 18.0f * SizeRatio, solution.Size.Width * SizeRatio, solution.Size.Height * SizeRatio));
			fungus.Draw (new RectangleF (2.0f, 18.0f * SizeRatio, fungus.Size.Width * SizeRatio, fungus.Size.Height * SizeRatio));
			cup.Draw (new RectangleF (-2.0f * SizeRatio, -4.5f * SizeRatio, cup.Size.Width * SizeRatio, cup.Size.Height * SizeRatio));
	
			this._FungusIcon.Image = UIGraphics.GetImageFromCurrentImageContext ();

			UIGraphics.EndImageContext ();
		}
		public UIButton PutButton {
			get {
				return this._PutButton;
			}
			set {
				this._PutButton = value;
			}
		}
		public UILabel PowerLabel {
			get {
				return this._PowerLabel;
			}
			set {
				this._PowerLabel = value;
			}
		}
		public UILabel CountLabel { 
			get {
				return this._CountLabel;
			}
			set {
				this._CountLabel = value;
			}
		}
		public UILabel CalorieLabel {
			get {
				return this._CalorieLabel;
			}
			set {
				this._CalorieLabel = value;
			}
		}
		public UILabel CurrentLabel {
			get {
				return this._CurrentCount;
			}
			set {
				this._CurrentCount = value;
			}
		}

	}
}
