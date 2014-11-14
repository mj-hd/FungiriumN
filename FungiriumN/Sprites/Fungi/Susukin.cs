using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Susukin : SampleFungus, IFungus
	{
		static string InternalName = "Susukin";

		public Susukin ()
			: base()
		{
		}

		protected override string _InternalName { get { return Susukin.InternalName; }}
 	}
}

