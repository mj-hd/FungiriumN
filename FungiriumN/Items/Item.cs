using System;

namespace FungiriumN.Items
{
	public class Item
	{
		public Item ()
		{
		}

		public virtual bool UseToTestTube (Sprites.TestTubeSprite testTube)
		{

			return true;
		}
	}

	public struct Metadata : FungiriumN.IMetadata
	{
		public string Name { get; set; }
		public string InternalName { get; set; }
		public string Description { get; set; }
	
		public int Price;
	}
}

