using System;

namespace FungiriumN.Sprites.Fungi
{
	public class ChochinkinM : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "ちょうちんきん",
			InternalName = "Chochinkin_m",
			Power = 80,
			Calorie = 60,
			Category = Metadata.FungusCategory | (1 << 3)
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

