using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Kuragekin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "くらげきん",
			InternalName = "Kuragekin",
			Power = 30
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

