using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Susukin : SampleFungus, IFungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "すすきん",
			InternalName = "Susukin"
		};

		public Susukin ()
			: base()
		{
		}

		Metadata IFungus.Metadata
		{
			get {
				return Susukin.Metadata;
			}
		}
 	}
}

