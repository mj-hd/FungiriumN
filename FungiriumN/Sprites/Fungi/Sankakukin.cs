using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Sankakukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんかくきん",
			InternalName = "Sankakukin"
		};

		public Sankakukin ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Sankakukin.Metadata;
		}
	}
}

