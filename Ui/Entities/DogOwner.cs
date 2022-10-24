using System.Collections.Generic;
using Ui.Interfaces;

namespace Ui.Entities
{
	public class DogOwner : IDogOwner
	{
		public string OwnerName { get; set; }
		public IEnumerable<string> DogNames { get; set; }
	}
}