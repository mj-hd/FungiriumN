using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Susukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "すすきん",
			InternalName = "Susukin"
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

