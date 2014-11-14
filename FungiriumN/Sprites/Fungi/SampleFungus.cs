using System;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class SampleFungus : IFungus
	{
		static string InternalName = "SampleFungus";

		public SampleFungus ()
		{
			this._Sprite = new SKSpriteNode ();

			this._SetTexturesFromFungusID (this._InternalName);

			this.State = Fungi.State.Move;
		}

		public SKSpriteNode Sprite
		{
			get {
				return this._Sprite;
			}
		}

		public Fungi.State State
		{
			get {
				return this._State;
			}
			set {
				this._SwitchAnimation (value);
				this._State = value;
			}
		}


		protected virtual string _InternalName { get { return SampleFungus.InternalName; }}
		protected SKSpriteNode _Sprite;
		protected Fungi.State _State;
		protected SKAction _MoveAnimation;
		protected SKAction _EatAnimation;
		protected SKAction _HappyAnimation;
		protected SKAction _DeadAnimation;

		protected virtual void _SetTexturesFromFungusID (string fungusId)
		{
			var textures = SKTextureAtlas.FromName ("Fungi");

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
			var deadAnimation = SKAction.AnimateWithTextures (deadTexture, 0.5);

			this._MoveAnimation = SKAction.RepeatActionForever (
				SKAction.Group(
					moveAnimation,
					SKAction.Run(() => {
						// 移動処理
					})
				)
			);
			this._EatAnimation = SKAction.RepeatActionForever (eatAnimation);
			this._HappyAnimation = SKAction.Sequence (
				happyAnimation,
				SKAction.Run (() => {
					this._SwitchAnimation (Fungi.State.Move);
				})
			);
			this._DeadAnimation = SKAction.Sequence (
				deadAnimation,
				SKAction.Run (() => {
					// 死後の処理
				})
			);
	
			this._Sprite.NormalTexture = moveTexture [0];
			this._Sprite.Texture = moveTexture [0];
			this._Sprite.Size = moveTexture [0].Size;
		}

		protected virtual void _SwitchAnimation (Fungi.State state)
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

			this._Sprite.RunAction (action);
		}
	}
}

