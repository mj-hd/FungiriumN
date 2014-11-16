using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.SpriteKit;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class TestTubeScene : ZoomScrollScene
	{
		protected Sprites.TestTubeSprite TestTube;

		public TestTubeScene (SizeF size) : base (size)
		{
			BackgroundColor = new UIColor (0.5f, 0.5f, 0.5f, 1.0f);

			// Physicsの設定
			this.PhysicsWorld.ContactDelegate = new PhysicsDelegate ((contact) => this._DidBeginContact (contact));

			// 試験管を追加
			this.TestTube = new Sprites.TestTubeSprite () {
				Position = new PointF (Frame.X + Frame.Width / 2, Frame.Y + Frame.Height / 2),
			};

			this.AddContainer (this.TestTube);

			var sampleFungus = new Sprites.Fungi.Susukin();
			this.TestTube.AddChild (sampleFungus);
		}

		public override void Update (double currentTime)
		{
			base.Update (currentTime);
			this.TestTube.Update (currentTime);
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);
		}


		protected virtual void _DidBeginContact (SKPhysicsContact contact)
		{
			this.TestTube.DidContactBegin (contact);
		}

		public override void TouchesBegan (NSSet touches, UIEvent evt)
		{
			base.TouchesBegan (touches, evt);

			var touch = (UITouch)touches.AnyObject;

			if (this.TestTube.ContainsPoint (touch.LocationInView (this.View))) {
				this.TestTube.TouchesBegan (touches, evt);
			}
		}


		class PhysicsDelegate : SKPhysicsContactDelegate {

			public PhysicsDelegate (Action<SKPhysicsContact> action)
			{
				this.DidBeginContactAction = action;
			}

			public Action<SKPhysicsContact> DidBeginContactAction;

			public override void DidBeginContact (SKPhysicsContact contact)
			{
				if (DidBeginContactAction != null)
					DidBeginContactAction (contact);
			}

		}
	}
}
