using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Chochinkin : SampleFungus, IFungus
	{
		static string InternalName = "Chochinkin";

		public Chochinkin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Chochinkin.InternalName; }}
 	}
}

