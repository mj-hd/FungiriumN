using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shokkakukin2 : SampleFungus, IFungus
	{
		static string InternalName = "Shokkakukin2"; 

		public Shokkakukin2 ()
			: base ()
		{
		}

		protected override string _InternalName { get { return Shokkakukin2.InternalName; }}
	}
}

