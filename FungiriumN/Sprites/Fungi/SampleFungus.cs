using System;
using System.Drawing;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class SampleFungus : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんぷる菌",
			InternalName = "SampleFungus"
		};

		public SampleFungus ()
			: base ()
		{
		}

		public override Metadata GetMetadata ()
		{
			return SampleFungus.Metadata;
		}
	}
}

