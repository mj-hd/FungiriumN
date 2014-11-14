using System;
using System.Drawing;
using System.Collections.Generic;

using MonoTouch.UIKit;
using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites
{
	public class TestTubeSprite : SKSpriteNode
	{
		const float GapForShape = 255.0f;
		public static PointF[] Shape = {
			new PointF(67.140f *2.0f, 475.325f *2.0f - GapForShape),
			new PointF(67.140f *2.0f, -427.81f *2.0f - GapForShape),
			new PointF(0.016f  *2.0f, -475.22f *2.0f - GapForShape),
			new PointF(-67.140f*2.0f, -427.81f *2.0f - GapForShape),
			new PointF(-67.140f*2.0f, 475.325f *2.0f - GapForShape),
			// HACK: 図形を閉じるために、初めの点を繰り返す
			new PointF(67.140f *2.0f, 475.325f *2.0f - GapForShape),
		};
		public static bool DoesShapeContains (PointF p)
		{
			// HACK: Shape外の座標を指定したいのだが、staticな為どこがShape外だかわからない。よって、適当な座標を設定
			var p1 = new PointF (-2000.0f, -2000.0f);
			var p2 = p;
			var p3 = new PointF (0.0f, 0.0f);
			var p4 = new PointF (0.0f, 0.0f);
			var contactCount = 0;

			for (int i = 0; i < Shape.Length -1; i++) {

				p3 = Shape [i];

				p4 = Shape [i + 1];

				// from http://www5d.biglobe.ne.jp/~tomoya03/shtml/algorithm/Intersection.htm
				// X軸について
				if (p1.X >= p2.X) {
					if ((p1.X < p3.X && p1.X < p4.X) || (p2.X > p3.X && p2.X > p4.X)) {
						continue;
					} else if ((p2.X < p3.X && p2.X < p4.X) || (p1.X > p3.X && p1.X > p4.X)) {
						continue;
					}
				}
				// Y軸について
				if (p1.Y >= p2.Y) {
					if ((p1.Y < p3.Y && p1.Y < p4.Y) || (p2.Y > p3.Y && p2.Y > p4.Y)) {
						continue;
					} else if ((p2.Y < p3.Y && p2.Y < p4.Y) || (p1.Y > p3.Y && p1.Y > p4.Y)) {
						continue;
					}
				}
	
				// 交差チェック
				if (((p1.X - p2.X) * (p3.Y - p1.Y) + (p1.Y - p2.Y) * (p1.X - p3.X)) *
					((p1.X - p2.X) * (p4.Y - p1.Y) + (p1.Y - p2.Y) * (p1.X - p4.X)) > 0) {
					continue;
				}
				if (((p3.X - p4.X) * (p1.Y - p3.Y) + (p3.Y - p4.Y) * (p3.X - p1.X)) *
					((p3.X - p4.X) * (p2.Y - p3.Y) + (p3.Y - p4.Y) * (p3.X - p2.X)) > 0) {
					continue;
				}

				contactCount++;

			}

			return (contactCount == 1);
		}


		public Fungi.Fungi Fungi;

		public TestTubeSprite ()
			: base()
		{
			var testTube = new SKSpriteNode ("TestTube.png");

			this.Size = testTube.Size;

			// 基準点を中心に設定
			this.AnchorPoint = new PointF (
				this.Size.Width / 2.0f,
				this.Size.Height / 2.0f
			);

			// 試験管を追加
			testTube.ZPosition = 2.0f;
			this.AddChild (testTube);

			// 溶液を追加	
			var solution = new TestTubeSolutionSprite () {
				Position = new PointF(0.0f, -GapForShape),
				ZPosition = 0.0f,
			};
			this.AddChild (solution);

			// Fungiコレクションの初期化
			this.Fungi = new Fungi.Fungi (this);
		}

		// Fungus用のAddChildを定義
		public void AddChild (Fungi.IFungus fungus)
		{
			fungus.Sprite.ZPosition = 1.0f;

			this.AddChild (fungus.Sprite);

			this.Fungi.Add (fungus);
		}

		public void Update (double time)
		{
			this.Fungi.Update (time);
		}

	}
}

