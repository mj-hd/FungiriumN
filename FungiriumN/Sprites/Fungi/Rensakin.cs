using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Rensakin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "れんさきん",
			InternalName = "Rensakin",
			Power = 60
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

