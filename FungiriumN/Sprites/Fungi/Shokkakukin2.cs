using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shokkakukin2 : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しょっかくきん 2号",
			InternalName = "Shokkakukin2"
		};

		public Shokkakukin2 ()
			: base ()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Shokkakukin2.Metadata;
			}
		}
	}
}

