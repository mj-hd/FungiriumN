using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Rensakin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "れんさきん",
			InternalName = "Rensakin"
		};

		public Rensakin ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Rensakin.Metadata;
			}
		}
 	}
}

