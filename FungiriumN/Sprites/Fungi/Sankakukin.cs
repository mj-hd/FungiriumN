using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Sankakukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんかくきん",
			InternalName = "Sankakukin",
			Description = "三角巾に生息する菌。",
			Power = 30,
			Calorie = 30,
			Price = 80,
			Category = Metadata.FungusCategory | (1 << 8)
		};

		public Sankakukin ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Sankakukin.Metadata;
		}
	}
}

