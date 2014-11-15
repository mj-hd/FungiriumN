using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Kuragekin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "くらげきん",
			InternalName = "Kuragekin"
		};

		public Kuragekin ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Kuragekin.Metadata;
			}
		}
 	}
}

