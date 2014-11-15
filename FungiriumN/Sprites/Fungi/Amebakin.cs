using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Amebakin : Fungus
	{
		public static Metadata Metatada = new Metadata () {
			Name = "あめーばきん",
			InternalName = "Amebakin",
			Power = 100
		};

		public Amebakin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Amebakin.Metadata;
		}
 	}
}

