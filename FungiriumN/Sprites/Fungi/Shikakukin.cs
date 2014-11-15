using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shikakukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しかくきん",
			InternalName = "Shikakukin",
			Power = 30,
			Calorie = 30,
			Category = Metadata.FungusCategory | (1 << 9)
		};

		public Shikakukin ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Shikakukin.Metadata;
		}
	}
}

