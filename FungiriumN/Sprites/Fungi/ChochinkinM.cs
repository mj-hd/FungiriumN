using System;

namespace FungiriumN.Sprites.Fungi
{
	public class ChochinkinM : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "ちょうちんきん",
			InternalName = "Chochinkin_m",
			Power = 80
		};

		public ChochinkinM ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return ChochinkinM.Metadata;
		}
 	}
}

