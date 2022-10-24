using System.Collections.Generic;
using System.Linq;
using Ui.Data;
using Ui.Entities;
using Ui.Interfaces;

namespace Ui.Services
{
	public class DogOwnerService : IDogOwnerService
	{
        private readonly IDogOwnerRepository _dogOwnerRepository;

        public DogOwnerService(IDogOwnerRepository dogOwnerRepository)
		{
			_dogOwnerRepository = dogOwnerRepository;
		}

		public List<DogOwner> GetAllDogOwners()
		{
            return _dogOwnerRepository.GetAllDogOwners();
		}
	}
}