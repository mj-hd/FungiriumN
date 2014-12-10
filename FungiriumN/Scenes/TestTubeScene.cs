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

			// DEBUG
			Items.Refrigerator.Instance.Increment (typeof(Sprites.Fungi.Amebakin));
			Items.Inventory.Instance.Increment (typeof(Items.Greenbull));

		}

		public override void Update (double currentTime)
		{
			base.Update (currentTime);
			this.TestTube.Update (currentTime);
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			this.View.AddGestureRecognizer (new UITapGestureRecognizer((sender) => {

				var p = sender.LocationInView (this.View);
				var locationInNode = this.ConvertPointFromView (p);
				var locationInTestTube = this.ConvertPointToNode (locationInNode, this.TestTube);

				this.TestTube.Fungi.Treat (locationInTestTube);

			}));

		}


		protected virtual void _DidBeginContact (SKPhysicsContact contact)
		{
			this.TestTube.DidContactBegin (contact);
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
