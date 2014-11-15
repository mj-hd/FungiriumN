using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Amebakin : SampleFungus, IFungus
	{
		public static Metadata Metatada = new Metadata () {
			Name = "あめーばきん",
			InternalName = "Amebakin"
		};

		public Amebakin ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Amebakin.Metadata;
			}
		}
 	}
}

