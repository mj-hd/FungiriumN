using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Rensakin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "れんさきん",
			InternalName = "Rensakin",
			Description = "他の菌との上下の関係を強く意識している菌。寿命が短い。",
			Power = 60,
			Calorie = 80,
			Price = 10,
			Category = Metadata.FungusCategory | (1 << 6)
		};

		public Rensakin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Rensakin.Metadata;
		}
 	}
}

