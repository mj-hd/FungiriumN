using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Amebakin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "あめーばきん",
			InternalName = "Amebakin",
			Description = "アメーバのようにうねうねとした菌",
			Power = 100,
			Calorie = 20,
			Price = 100,
			Category = Metadata.FungusCategory | (1 << 2)
		};

		public Amebakin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Amebakin.Metadata;
		}

		public override Type GetNextForm ()
		{
			return typeof (ChochinkinM);
		}
 	}
}

