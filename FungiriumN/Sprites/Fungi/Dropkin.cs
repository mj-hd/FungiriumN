using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Dropkin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "どろっぷきん",
			InternalName = "Dropkin",
			Power = 50
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

