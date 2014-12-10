using System;
using System.Drawing;

namespace FungiriumN.Sprites.Fungi
{
	public class Susukin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "すすきん",
			InternalName = "Susukin",
			Description = "すすきんはすすきん。それ以外の何者でもない.。",
			Power = 50,
			Calorie = 30,
			Price = 60,
			Category = Metadata.FungusCategory | (1 << 11)
		};

		public Susukin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Susukin.Metadata;
		}

		public override Type GetNextForm ()
		{
			return typeof(Shakkin);
		}

		protected override SizeF _PhysicsSize
		{
			get {
				return new SizeF (15.0f, 40.0f);
			}
		}
 	}
}

