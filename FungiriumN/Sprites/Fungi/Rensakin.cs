using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Rensakin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "れんさきん",
			InternalName = "Rensakin",
			Power = 60,
			Calorie = 80,
			Category = Metadata.FungusCategory | (1 << 6)
		};

		public Rensakin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Rensakin.Metadata;
		}
 	}
}

