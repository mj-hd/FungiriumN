using System;

namespace FungiriumN.Sprites.Fungi
{
	public class Shakkin : Fungus
	{
		public static Metadata Metadata = new Metadata () {
			Name = "しゃっ菌",
			InternalName = "Shakkin",
			Description = "非常に後ろめたい過去のある菌。あ、こいつが増えてもお金は減らないから安心して。",
			Power = 130,
			Calorie = 50,
			Price = 200,
			Category = Metadata.FungusCategory | (1 << 12)
		};

		public Shakkin ()
			: base()
		{
		}

		public override Metadata GetMetadata ()
		{
			return Shakkin.Metadata;
		}

		public override Type GetNextForm ()
		{
			return typeof (ChochinkinM);
		}
 	}
}

