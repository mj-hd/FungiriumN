using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Kuragekin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "くらげきん",
			InternalName = "Kuragekin",
			Description = "くらげのような見た目をしている菌。海に生息している。",
			Power = 30,
			Calorie = 40,
			Price = 110,
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

