using System;

namespace FungiriumN.Items
{
	public class RefrigeratedFungus: Item
	{
		public RefrigeratedFungus ()
			: this (typeof(Sprites.Fungi.SampleFungus))
		{
		}
		public RefrigeratedFungus (Type type)
			: base ()
		{
			this._FungusType = type;
		}

		public override bool UseToTestTube (Sprites.TestTubeSprite testTube)
		{
			/*var fungus = (Sprites.Fungi.FungiStatistics[Metadata.InternalName].Type); //

			testTube.Fungi.Add (fungus);*/

			return true;
		}

		public virtual Type FungusType
		{
			get {
				return this._FungusType;
			}
		}

		public override Metadata GetMetadata ()
		{
			var metadata = new Metadata ();
			var meta = Sprites.Fungi.Population.Instance [this._FungusType].Instance.GetMetadata ();

			metadata.Name = meta.Name;
			metadata.InternalName = meta.InternalName;
			metadata.Description = meta.Description;
			metadata.Price = meta.Price;
			metadata.PreservationStyle = PreservationStyle.Refrigerated;

			return metadata;
		}

		protected Type _FungusType;


	}
}

