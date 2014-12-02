using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shikakukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しかくきん",
			InternalName = "Shikakukin",
			Description = "ハンカチに生息する菌。",
			Power = 30,
			Calorie = 30,
			Price = 50,
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

