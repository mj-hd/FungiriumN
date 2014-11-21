using System;

namespace FungiriumN.Items
{
	public class Item : ICloneable
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんぷるあいてむ",
			InternalName = "SampleItem",
			Description = "これはサンプルのアイテムです。",
			Price = 100
		};

		#region ICloneable

		object ICloneable.Clone()
		{
			return this.Clone ();
		}

		public virtual Item Clone()
		{
			Item instance = (Item)Activator.CreateInstance (this.GetType ());

			// TODO: コピー処理

			return instance;
		}

		#endregion

		public Item ()
		{
		}

		public virtual bool UseToTestTube (Sprites.TestTubeSprite testTube)
		{
			// TODO: 使用処理

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

