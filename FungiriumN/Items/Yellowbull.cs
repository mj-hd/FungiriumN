using System;

namespace FungiriumN.Items
{
	public class Yellowbull : Item
	{
		public static Metadata Metadata = new Metadata () {
			Name = "イェローブル",
			InternalName = "Yellowbull",
			Description = "菌たちが幸せになる栄養をギュッと凝縮したやつ",
			Price = 500,
			PreservationStyle = PreservationStyle.Room
		};

		public Yellowbull ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Yellowbull.Metadata;
		}

		public override bool UseToTestTube ()
		{
			throw new NotImplementedException ();
		}
	}
}

