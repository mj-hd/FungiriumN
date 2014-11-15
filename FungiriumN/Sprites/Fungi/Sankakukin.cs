using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Sankakukin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんかくきん",
			InternalName = "Sankakukin"
		};

		public Sankakukin ()
			: base ()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Sankakukin.Metadata;
			}
		}
	}
}

