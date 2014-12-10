﻿using System;

using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Configure the view.
			var skView = (SKView)View;
			skView.ShowsFPS = true;
			skView.ShowsDrawCount = true;
			skView.ShowsNodeCount = true;
			skView.ShowsPhysics = true;

			// Create and configure the scene.
			var scene = new Scenes.TestTubeScene (skView.Bounds.Size);
			scene.ScaleMode = SKSceneScaleMode.AspectFill;

			// Present the scene.
			skView.PresentScene (scene);

		}

		public override bool ShouldAutorotate ()
		{
			return true;
		}

		public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations ()
		{
			return UIInterfaceOrientationMask.AllButUpsideDown;
		}
	}
}
