using System;
using System.Drawing;

using MonoTouch.SpriteKit;
using MonoTouch.UIKit;

namespace FungiriumN.Scenes
{
	public class TestTubeScene : ZoomScrollScene
	{
		public TestTubeScene (SizeF size) : base (size)
		{
			BackgroundColor = new UIColor (0.5f, 0.5f, 0.5f, 1.0f);

			// Physicsの設定
			this.PhysicsWorld.ContactDelegate = new PhysicsDelegate ((contact) => this._DidBeginContact (contact));

			// 試験管を追加
			var testTube = Sprites.TestTubeSprite.Instance;
			testTube.Position = new PointF (Frame.X + Frame.Width / 2, Frame.Y + Frame.Height / 2);

			this.AddContainer (testTube);

			// DEBUG
			foreach (var t in Sprites.Fungi.Population.FungusType)
			{
				Items.Refrigerator.Instance [t].Count = 5;
			}
			Items.Inventory.Instance.Increment (typeof(Items.Greenbull));

		}

		public override void Update (double currentTime)
		{
			base.Update (currentTime);
			Sprites.TestTubeSprite.Instance.Update (currentTime);
		}

		public override void DidMoveToView (SKView view)
		{
			base.DidMoveToView (view);

			this.View.AddGestureRecognizer (new UITapGestureRecognizer((sender) => {
				var p = sender.LocationInView (this.View);
				var locationInNode = this.ConvertPointFromView (p);
				var locationInTestTube = this.ConvertPointToNode (locationInNode, Sprites.TestTubeSprite.Instance);

				Sprites.TestTubeSprite.Instance.Fungi.Treat (locationInTestTube);
			}));

		}


		protected virtual void _DidBeginContact (SKPhysicsContact contact)
		{
			Sprites.TestTubeSprite.Instance.DidContactBegin (contact);
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
