using System;

namespace FungiriumN.Sprites.Fungi
{
	public class ChochinkinM : SampleFungus, IFungus
	{
		static string InternalName = "Chochinkin_m";

		public ChochinkinM ()
			: base()
		{
		}

		protected override string _InternalName { get { return ChochinkinM.InternalName; }}
 	}
}

