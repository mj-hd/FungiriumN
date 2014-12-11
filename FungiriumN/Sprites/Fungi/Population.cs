using System;
using System.Collections;
using System.Collections.Generic;

namespace FungiriumN.Sprites.Fungi
{
	public class Population : IEnumerable<Statistics>
	{
		#region シングルトン

		private static Population _instance = null;
		public static Population Instance
		{
			get {
				if (_instance == null) {
					_instance = new Population ();
				}

				return _instance;
			}
		}

		#endregion

		public static Type[] FungusType = new Type[] {
			typeof(Amebakin),
			typeof(ChochinkinM),
			typeof(Dropkin),
			typeof(Fungus),
			typeof(Kuragekin),
			typeof(Rensakin),
			typeof(SampleFungus),
			typeof(Sankakukin),
			typeof(Shikakukin),
			typeof(Shokkakukin2),
			typeof(Susukin),
			typeof(Shakkin)
		};

		public Population ()
		{
			this._statistics = new Statistics[FungusType.GetLength (0)];

			foreach (var type in FungusType)
			{
				this [type] = new Statistics ((Fungus)Activator.CreateInstance (type)) {
					Type = type,
					Count = 0,
					IsRevealed = false
				};
			}

		}

		public Statistics this [Type type]
		{
			set {
				this.SetValue (type, value);
			}
			get {
				return this.GetValue (type);
			}
		}

		public void Increment (Type type)
		{
			foreach (var t in FungusType)
			{
				if (t == type) {
					this [t].Count++;
					this [t].IsRevealed = true;

					return;
				}
			}

			throw new KeyNotFoundException ("指定された菌クラスが見つかりませんでした。");
		}

		public void Decrement (Type type)
		{
			foreach (var t in FungusType)
			{
				if (t == type) {
					this [t].Count--;

					if (this [t].Count < 0)
						this [t].Count = 0;

					return;
				}
			}

			throw new KeyNotFoundException ("指定された菌クラスが見つかりませんでした。");
		}

		public void ResetAll ()
		{
			foreach (var t in FungusType)
			{
				this[t].Count = 0;
				this[t].IsRevealed = false;
			}
		}

		public bool Contains (Type type)
		{
			foreach (var t in FungusType)
			{
				if (t == type)
					return true;
			}

			return false;
		}

		public bool Reset (Type type)
		{
			foreach (var t in FungusType)
			{
				if (t == type) {
					this [t].Count = 0;
					this [t].IsRevealed = false;

					// TODO: インスタンスも初期化すべき


					return true;
				}
			}

			return false;
		}

		public void SetValue (Type type, Statistics stat)
		{
			for (int i = 0; i < FungusType.GetLength (0); i++)
			{
				if (FungusType[i] == type) {
					this._statistics [i] = stat;
					return;
				}
			}

			throw new KeyNotFoundException ("指定された菌クラスが見つかりませんでした。");
		}

		public Statistics GetValue (Type type)
		{
			for (int i = 0; i < FungusType.GetLength (0); i++)
			{
				if (FungusType[i] == type) {
					return this._statistics [i];
				}
			}

			throw new KeyNotFoundException ("指定された菌クラスが見つかりませんでした。");
		}

		public Statistics GetValueAt (int i)
		{
			if ((i >= this.Count) || (i < 0))
				throw new ArgumentOutOfRangeException ();

			return this._statistics [i];

		}


		public Statistics GetAvailableAt (int i)
		{
			var count = 0;
			Statistics result = null;

			foreach (var stat in this)
			{
				if (stat.Count > 0)
					count++;

				if (count-1 == i) {
					result = stat;
					break;
				}
			}

			if (result == null)
				throw new IndexOutOfRangeException ("指定されたアイテムが見つかりませんでした。");

			return result;
		}

		public Statistics GetRevealedAt (int i)
		{
			var count = 0;
			Statistics result = null;

			foreach (var stat in this)
			{
				if (stat.IsRevealed)
					count++;

				if (count-1 == i) {
					result = stat;
					break;
				}
			}

			if (result == null)
				throw new IndexOutOfRangeException ("指定されたアイテムが見つかりませんでした。");

			return result;
		}

		public int Count
		{
			get {
				return FungusType.GetLength (0);
			}
		}


		public int AvailableCount
		{
			get {
				var count = 0;
				foreach (var stat in this)
				{
					if (stat.Count > 0)
						count++;
				}

				return count;
			}
		}

		public int RevealedCount
		{
			get {
				var count = 0;
				foreach (var stat in this)
				{
					if (stat.IsRevealed)
						count++;
				}

				return count;
			}
		}

		private Statistics[] _statistics;

		#region IEnumerable implementation

		public IEnumerator<Statistics> GetEnumerator ()
		{
			foreach (var t in FungusType)
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

	public class Statistics {
		public Type Type;
		public int Count;
		public bool IsRevealed;
		public Fungus Instance {
			get {
				return this._instance;
			}
		}

		public Statistics (Fungus instance)
		{
			this._instance = instance;
			this.Count = 0;
			this.Type = null;
			this.IsRevealed = false;
		}

		private Fungus _instance;
	}
}

