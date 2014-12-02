using System;

namespace FungiriumN.Items
{
	public class Refrigerator : Inventory
	{
		private static Refrigerator _instance = null;
		public static Refrigerator Instance
		{
			get {
				if (_instance == null) {
					_instance = new Refrigerator ();
				}

				return _instance;
			}
		}

		public static Type[] Types = new Type[] {
		};

		protected override Type[] ItemType{
			get { return Refrigerator.Types; }
		}

		public Refrigerator ()
			: base()
		{
		}

	}
}

