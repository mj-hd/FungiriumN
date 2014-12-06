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
			Description = "サンプルの菌",
			Power = 100,
			Calorie = 100,
			Price = 100,
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

		public override Type GetNextForm ()
		{
			return typeof(Sankakukin);
		}
	}
}

