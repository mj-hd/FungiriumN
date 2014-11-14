using System;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public interface IFungus
	{
		SKSpriteNode Sprite
		{
			get;
		}

		State State {
			get;
			set;
		}

		void Update (double delta);
	}

	// Fungusの状態
	public enum State
	{
		Stop,
		Move,
		Eat,
		Happy,
		Dead
	}
}

