using System;

namespace FungiriumN.Sprites.Fungi
{
	public class ChochinkinM : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "ちょうちんきん",
			InternalName = "Chochinkin_m"
		};

		public ChochinkinM ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return ChochinkinM.Metadata;
			}
		}
 	}
}

