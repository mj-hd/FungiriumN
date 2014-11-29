using System;

namespace FungiriumN.Items
{
	public class RefrigeratedFungus: Item
	{
		public static Metadata Metadata = new Metadata () {
			Name = Sprites.Fungi.SampleFungus.Metadata.Name,
			InternalName = Sprites.Fungi.SampleFungus.Metadata.InternalName,
			Description = Sprites.Fungi.SampleFungus.Metadata.Description,
			Price = 50,
			PreservationStyle = PreservationStyle.Refrigerated
		};

		public RefrigeratedFungus ()
		{
		}

		public override bool UseToTestTube (Sprites.TestTubeSprite testTube)
		{
			/*var fungus = (Sprites.Fungi.FungiStatistics[Metadata.InternalName].Type); //

			testTube.Fungi.Add (fungus);*/

			return true;
		}


	}
}

