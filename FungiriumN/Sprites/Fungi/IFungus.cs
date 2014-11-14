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

		Request Request {
			get;
			set;
		}

		float Energy {
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

	// FungusからFungiへの要求
	public enum Request
	{
		None,
		Clean,
		Divide
	}
}

