using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Rensakin : SampleFungus, IFungus
	{
		static string InternalName = "Rensakin";

		public Rensakin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Rensakin.InternalName; }}
 	}
}

