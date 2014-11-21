using System;

namespace FungiriumN
{
	public interface IMetadata
	{
		string Name { get; set; }
		string InternalName { get; set; }
		string Description { get; set; }
	}
}

