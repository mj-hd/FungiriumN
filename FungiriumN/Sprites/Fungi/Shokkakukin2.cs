using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shokkakukin2 : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しょっかくきん 2号",
			InternalName = "Shokkakukin2",
			Power = 70
		};

		public Shokkakukin2 ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Shokkakukin2.Metadata;
		}
	}
}

