using System;
using System.Collections.Generic;
using System.Collections;

namespace FungiriumN.Items
{
	public class Inventory : IEnumerable<Statistics>
	{
		// シングルトン

		private static Inventory _instance = null;
		public static Inventory Instance
		{
			get {
				if (_instance == null) {
					_instance = new Inventory ();
				}

				return _instance;
			}
		}

		public static Type[] Types = new Type[] {
			typeof(Greenbull),
			typeof(Yellowbull),
		};
		protected virtual Type[] ItemType
		{
			get { return Inventory.Types; }
		}

		public Inventory ()
		{
			this._statistics = new Statistics[ItemType.GetLength (0)];

			foreach (var type in ItemType) {
				this [type] = new Statistics ((Item)Activator.CreateInstance (type)) {
					Count = 0,
				};
			}

		}

		public void Increment (Type type)
		{
			for (int i = 0; i < ItemType.GetLength(0); i++)
			{
				if (type == ItemType[i]) {
					this [type].Count++;
					return;
				}
			}

			throw new KeyNotFoundException ();
		}

		public void Decrement (Type type)
		{
			for (int i = 0; i < ItemType.GetLength(0); i++)
			{
				if (type == ItemType[i]) {
					this [type].Count--;
					return;
				}
			}

			throw new KeyNotFoundException ();
		}

		public bool Contains (Type type)
		{
			foreach (var t in ItemType)
			{
				if (t == type)
					return true;
			}

			return false;
		}

		public bool Reset (Type type)
		{
			foreach (var t in ItemType)
			{
				if (t == type) {

					this [t].Count = 0;

					// TODO: インスタンスも初期化すべき?

					return true;
				}
			}

			return false;
		}

		public void ResetAll ()
		{
			foreach (var t in ItemType)
			{
				this [t].Count = 0;
			}
		}

		public Statistics this [Type type]
		{
			set {
				this.SetValue (type, value);
			}
			get {
				return this.GetValue(type);
			}
		}

		public void SetValue (Type type, Statistics value)
		{
			for (int i = 0; i < ItemType.GetLength (0); i++)
			{
				if (ItemType[i] == type) {
					this._statistics [i] = value;
					return;
				}
			}

			throw new KeyNotFoundException ("指定されたアイテムが見つかりませんでした。");
		}

		public Statistics GetValue(Type type)
		{
			for (int i = 0; i < ItemType.GetLength(0); i++ )
			{
				if (ItemType[i] == type)
				{
					return this._statistics [i];
				}
			}

			throw new KeyNotFoundException ("指定されたアイテムが見つかりませんでした。");
		}

		public Statistics GetValueAt(int i)
		{
			if ((i < 0) || (i >= ItemType.GetLength (0)))
				throw new IndexOutOfRangeException ("指定されたアイテムが見つかりませんでした。");

			return this._statistics [i];
		}

		public int Count
		{
			get {
				return ItemType.GetLength (0);
			}
		}


		private Statistics[] _statistics;

		#region IEnumerable implementation

		public IEnumerator<Statistics> GetEnumerator ()
		{
			foreach (var t in ItemType)
			{
				yield return this [t];
			}
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return this.GetEnumerator ();
		}

		#endregion

	}

	public class Statistics
	{
		public int Count;
		public Item Instance {
			get {
				return this._instance;
			}
		}

		public Statistics (Item instance) 
		{
			this._instance = instance;
			this.Count = 0;
		}


		private Item _instance;
	}
}

