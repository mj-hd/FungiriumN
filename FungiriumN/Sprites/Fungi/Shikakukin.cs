using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shikakukin : SampleFungus, IFungus
	{
		static string InternalName = "Shikakukin";

		public Shikakukin ()
			: base ()
		{
		}

		protected override string _InternalName { get { return Shikakukin.InternalName; }}
	}
}

