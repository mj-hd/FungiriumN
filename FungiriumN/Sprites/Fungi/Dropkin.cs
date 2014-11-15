using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Dropkin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "どろっぷきん",
			InternalName = "Dropkin"
		};

		public Dropkin ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Dropkin.Metadata;
			}
		}
 	}
}

