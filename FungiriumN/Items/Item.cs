using System;

namespace FungiriumN.Items
{
	public class Item
	{
		public static Metadata Metadata = new Metadata () {
			Name = "さんぷるあいてむ",
			InternalName = "SampleItem",
			Description = "これはサンプルのアイテムです。",
			Price = 100,
			PreservationStyle = PreservationStyle.Room
		};

		public Item ()
		{

		}

		public virtual Metadata GetMetadata ()
		{
			return Item.Metadata;
		}

		public virtual bool UseToTestTube ()
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
		public PreservationStyle PreservationStyle;
	}

	public enum PreservationStyle
	{
		Refrigerated,
		Room
	}
}

