using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Kuragekin : SampleFungus, IFungus
	{
		static string InternalName = "Kuragekin";

		public Kuragekin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Kuragekin.InternalName; }}
 	}
}

