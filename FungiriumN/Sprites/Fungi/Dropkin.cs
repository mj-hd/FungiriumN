using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Dropkin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "どろっぷきん",
			InternalName = "Dropkin",
			Power = 50,
			Calorie = 80,
			Category = Metadata.FungusCategory | (1 << 4)
		};

		public Dropkin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Dropkin.Metadata;
		}
 	}
}

