using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Amebakin : SampleFungus, IFungus
	{
		static string InternalName = "Amebakin";

		public Amebakin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Amebakin.InternalName; }}
 	}
}

