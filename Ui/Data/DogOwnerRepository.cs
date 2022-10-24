using System.Collections.Generic;
using Ui.Entities;
using Ui.Interfaces;

namespace Ui.Data
{
	public class DogOwnerRepository : IDogOwnerRepository
	{
		public List<DogOwner> GetAllDogOwners()
		{
			return new List<DogOwner>
            {
                new DogOwner
                {
                    OwnerName = "Rob",
                    DogNames = new List<string> {"Willow", "Nook", "Sox"},
                }
            }; ;
		} 
	}
}