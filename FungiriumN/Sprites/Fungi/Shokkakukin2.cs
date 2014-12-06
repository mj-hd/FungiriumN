using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shokkakukin2 : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しょっかくきん 2号",
			InternalName = "Shokkakukin2",
			Description = "触覚がたくさん生えている、ちょっと気持ち悪い菌。一号が存在するのかは不明。",
			Power = 70,
			Calorie = 40,
			Price = 10,
			Category = Metadata.FungusCategory | (1 << 10)
		};

		public Shokkakukin2 ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Shokkakukin2.Metadata;
		}

		public override Type GetNextForm ()
		{
			return typeof(Susukin);
		}
	}
}

