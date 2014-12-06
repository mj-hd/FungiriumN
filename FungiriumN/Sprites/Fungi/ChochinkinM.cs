using System;

namespace FungiriumN.Sprites.Fungi
{
	public class ChochinkinM : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "ちょうちんきん",
			InternalName = "Chochinkin_m",
			Description = "ワビサビを心から理解している温和な菌。",
			Power = 80,
			Calorie = 60,
			Price = 120,
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

		public override Type GetNextForm ()
		{
			return typeof(Dropkin);
		}
 	}
}

