using System.Collections.Generic;
using Ui.Entities;

namespace Ui.Data
{
    public class DogOwnerRepository : IDogOwnerRepo
    {
        private readonly List<DogOwner> _dogOwners;

        public DogOwnerRepository(){
            _dogOwners = new List<DogOwner>
            {
                new DogOwner
                {
                    OwnerName = "Rob",
                    DogNames = new List<string> { "Willow", "Nook", "Sox" }
                }
            };
        }

        public List<DogOwner> GetAllDogOwners()
        {

			return _dogOwners;
		} 
	}
}