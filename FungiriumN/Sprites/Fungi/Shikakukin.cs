using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shikakukin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しかくきん",
			InternalName = "Shikakukin"
		};

		public Shikakukin ()
			: base ()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Shikakukin.Metadata;
			}
		}
	}
}

