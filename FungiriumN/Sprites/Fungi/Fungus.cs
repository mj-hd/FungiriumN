using System;
using System.Drawing;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class Fungus : SKSpriteNode, ICloneable
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんぷる菌",
			InternalName = "SampleFungus",
			Description = "サンプルの菌",
			Power = 100,
			Calorie = 100,
			Price = 150,
			Category = Metadata.FungusCategory | (1 << 1)
		};

		#region ICloneable

		object ICloneable.Clone()
		{
			return this.Clone ();
		}

		public virtual Fungus Clone()
		{
			Fungus instance = (Fungus)Activator.CreateInstance (this.GetType ());

			// TODO: Clone的にはこうだけど、本当にプロパティを全部コピーするかどうか
			//instance.State  = this.State;
			//instance.Energy = this.Energy;

			return instance;
		}

		#endregion

		public Fungus ()
			: base ()
		{
			this._SetTextures ();

			this._MoveAround (1.0f);

			this.State = State.Move;
		}

		public virtual Metadata GetMetadata ()
		{
			return Fungus.Metadata;
		}

		public virtual Type GetNextForm ()
		{
			return typeof(Susukin);
		}

		public State State
		{
			get {
				return this._State;
			}
			set {
				if (this._State == State.Dead)
					return;

				this._SwitchAnimation (value);
				this._State = value;
			}
		}

		public Request Request
		{
			get {
				return this._Request;
			}
			set {
				this._Request = value;
			}
		}

		public float Energy
		{
			get {
				return this._Energy;
			}
			set {
				this._Energy = value;
			}
		}

		public void Update (double delta)
		{
			// エネルギー
			this._Energy -= (float)delta * 3.0f;

			if (this._Energy < 0.0f) {

				this._SwitchAnimation (State.Dead);

			}

			// 移動
			if (this.State == State.Move) {

				const int MovePerc = 30; // %
				var rand = new Random ();

				if (rand.Next(100) < MovePerc) {

					this._MoveAround (1.0f);

				}

				// 分裂
				const int DividePerc = 10; // %

				if (rand.Next(100) < DividePerc) {

					this.Request = Request.Divide;

				}

			}
		}


		protected State _State;
		protected Request _Request;
		protected float _Energy = 100.0f;
		protected SKAction _MoveAnimation;
		protected SKAction _EatAnimation;
		protected SKAction _HappyAnimation;
		protected SKAction _DeadAnimation;

		protected virtual void _SetTextures ()
		{
			var textures = SKTextureAtlas.FromName ("Fungi");
			var fungusId = this.GetMetadata ().InternalName;

			var moveTexture = new SKTexture[] {
				textures.TextureNamed (fungusId),
				textures.TextureNamed (fungusId + "_Move")
			};
			var eatTexture  = new SKTexture[] {
				textures.TextureNamed (fungusId + "_Eat1"),
				textures.TextureNamed (fungusId + "_Eat2")
			};
			var happyTexture = new SKTexture[] {
				textures.TextureNamed (fungusId + "_Happy")
			};
			var deadTexture = new SKTexture[] {
				textures.TextureNamed (fungusId + "_Dead")
			};

			var moveAnimation = SKAction.AnimateWithTextures (moveTexture, 0.5);
			var eatAnimation = SKAction.AnimateWithTextures (eatTexture, 0.5);
			var happyAnimation = SKAction.AnimateWithTextures (happyTexture, 0.5);
			var deadAnimation = SKAction.AnimateWithTextures (deadTexture, 2.0);

			this._MoveAnimation = SKAction.RepeatActionForever (moveAnimation);
			this._EatAnimation = SKAction.Sequence (
				eatAnimation,
				SKAction.Run(() => {
					this.State = State.Move;
				})
			);
			this._HappyAnimation = SKAction.Sequence (
				happyAnimation,
				SKAction.Run (() => {
					this.State = State.Move;
				})
			);
			this._DeadAnimation = SKAction.Sequence (
				deadAnimation,
				SKAction.Run (() => {
					this._Request = Request.Clean;
				}),
				SKAction.RemoveFromParent ()
			);
	
			this.NormalTexture = moveTexture [0];
			this.Texture = moveTexture [0];
			this.Size = moveTexture [0].Size;

			var body = SKPhysicsBody.CreateRectangularBody (this.Size);
			body.CategoryBitMask = this.GetMetadata ().Category;
			body.ContactTestBitMask = Metadata.FungusCategory;
			body.CollisionBitMask = 0;
			body.AffectedByGravity = false;

			this.PhysicsBody = body;
		}

		protected virtual void _SwitchAnimation (State state)
		{
			SKAction action;

			switch (state) {
			case State.Move:
				action = this._MoveAnimation;
				break;
			case State.Eat:
				action = this._EatAnimation;
				break;
			case State.Happy:
				action = this._HappyAnimation;
				break;
			case State.Dead:
				action = this._DeadAnimation;
				break;
			default:
				throw new NotImplementedException ();
			}

			this.RunAction (action);
		}

		protected virtual bool _MoveAround (float duration)
		{
			var attemptCount = 5; // 5回まで移動の試行
			var resultPoint = this.Position;
			var resultAngle = 0.0f;
			var rand = new Random ();

			const double MaxDistanceToMove = 30.0;

			while (attemptCount-- > 0) {

				var angleToMove = rand.NextDouble () * 2.0 * Math.PI;
				var distToMove = rand.NextDouble () * MaxDistanceToMove;

				var attemptPoint = new PointF (
					this.Position.X +  (float)(distToMove *Math.Cos(angleToMove)),
					this.Position.Y +  (float)(distToMove *Math.Sin(angleToMove))
				);

				// TestTubeにattemptPointが含まれているかどうか
				if (Sprites.TestTubeSprite.DoesShapeContains (attemptPoint)) {
				
					resultPoint = attemptPoint;
					resultAngle = (float)angleToMove;

					break;
				}

			}

			if (attemptCount == 0) {
				return false;
			} else {

				// 移動させる
				this.RunAction (SKAction.Group (
					SKAction.RotateToAngle (resultAngle - (float)Math.PI/2.0f, duration, true),
					SKAction.MoveTo (resultPoint, duration)
				));

				return true;
			}

		}
	}

	// Fungusの基本情報
	public struct Metadata : FungiriumN.IMetadata
	{
		public string Name { get; set; }
		public string InternalName { get; set; }
		public string Description { get; set; }
		public int Power;
		public int Calorie;
		public uint Category;
		public int Price;

		public const uint FungusCategory = (1 << 0);
	};

	// Fungusの状態
	public enum State
	{
		Stop,
		Move,
		Eat,
		Happy,
		Dead
	}

	// FungusからFungiへの要求
	public enum Request
	{
		None,
		Clean,
		Divide,
		Metamorphose
	}
}

