﻿using System.Collections.Generic;

namespace Ui.Entities
{
	public class DogOwner : IDogOwner
	{
		public string OwnerName { get; set; }
		public List<string> DogNames { get; set; }
	}
}