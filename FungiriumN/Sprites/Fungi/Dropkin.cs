using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Dropkin : SampleFungus, IFungus
	{
		static string InternalName = "Dropkin";

		public Dropkin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Dropkin.InternalName; }}
 	}
}

