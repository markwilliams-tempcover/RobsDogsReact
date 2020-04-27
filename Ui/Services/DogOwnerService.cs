using System.Collections.Generic;
using Ui.Data;
using Ui.Entities;

namespace Ui.Services
{
	public class DogOwnerService : IDogOwnerService
	{
        private readonly IDogOwnerRepo _dogOwnerRepo;

        public DogOwnerService(IDogOwnerRepo dogOwnerRepo) {
            _dogOwnerRepo = dogOwnerRepo;
        }

		public List<DogOwner> GetAllDogOwners()
		{
			return _dogOwnerRepo.GetAllDogOwners();
		}
	}
}