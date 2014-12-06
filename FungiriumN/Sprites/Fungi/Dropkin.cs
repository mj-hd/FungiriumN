using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Dropkin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "どろっぷきん",
			InternalName = "Dropkin",
			Description = "美味しい飴玉に生息する菌。",
			Power = 50,
			Calorie = 80,
			Price = 140, 
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

		public override Type GetNextForm ()
		{
			return typeof(Fungus);
		}
 	}
}

