using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shikakukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しかくきん",
			InternalName = "Shikakukin"
		};

		public Shikakukin ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Shikakukin.Metadata;
		}
	}
}

