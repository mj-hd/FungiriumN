using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Susukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "すすきん",
			InternalName = "Susukin",
			Power = 50
		};

		public Susukin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Susukin.Metadata;
		}
 	}
}

