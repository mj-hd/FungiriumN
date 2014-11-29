using System;

namespace FungiriumN.Items
{
	public class Greenbull : Item
	{
		public static Metadata Metadata = new Metadata () {
			Name = "グリーンブル",
			InternalName = "Greenbull",
			Description = "菌たちが元気になる栄養をギュッと凝縮したやつ",
			Price = 500,
			PreservationStyle = PreservationStyle.Room
		};

		public Greenbull ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Greenbull.Metadata;
		}

		public override bool UseToTestTube (Sprites.TestTubeSprite testTube)
		{
			throw new NotImplementedException ();
		}
	}
}

