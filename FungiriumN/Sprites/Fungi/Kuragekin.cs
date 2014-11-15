using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Kuragekin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "くらげきん",
			InternalName = "Kuragekin",
			Power = 30,
			Calorie = 40,
			Category = Metadata.FungusCategory | (1 << 5)
		};

		public Kuragekin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Kuragekin.Metadata;
		}
 	}
}

