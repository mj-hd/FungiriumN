using System;
using System.Drawing;

using MonoTouch.SpriteKit;

namespace FungiriumN.Sprites.Fungi
{
	public class SampleFungus : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんぷる菌",
			InternalName = "SampleFungus",
			Power = 100,
			Calorie = 100,
			Category = Metadata.FungusCategory | (1 << 7)
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

