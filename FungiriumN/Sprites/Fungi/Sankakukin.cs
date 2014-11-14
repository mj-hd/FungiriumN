using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Sankakukin : SampleFungus, IFungus
	{
		static string InternalName = "Sankakukin"; 

		public Sankakukin ()
			: base ()
		{
		}

		protected override string _InternalName { get { return Sankakukin.InternalName; }}
	}
}

