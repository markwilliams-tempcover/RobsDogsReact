using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RobsDogs.Models.Api;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Data;
using RobsDogs.Models.Domain;

namespace RobsDogs.Repositories
{
    public class DogOwnerRepository : IDogOwnerRepository
    {
        private readonly DogOwnerDataContext _dataContext;

        public DogOwnerRepository(DogOwnerDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task Save(DogOwner dogOwner)
        {
            var dogOwnerData = new DogOwnerData
            {
                OwnerName = dogOwner.OwnerName, 
                DogNames = string.Join(",", dogOwner.DogNames)
            };

            _dataContext.DogOwners.Add(dogOwnerData);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<DogOwner> GetDogOwner(long id)
        {
            var dogOwnerData = await _dataContext.DogOwners.FindAsync(id);
            var dogOwner = new DogOwner(dogOwnerData.Id,
                dogOwnerData.OwnerName,
                dogOwnerData.DogNames.Split(","));
            return dogOwner;
        }

        public async Task<IEnumerable<DogOwner>> GetAllDogOwners()
        {
            var dogOwnerData = _dataContext.DogOwners.ToList();
            var dogOwners = dogOwnerData.Select(x =>
                new DogOwner(x.Id,
                    x.OwnerName,
                    x.DogNames.Split(",")));
            return dogOwners;
        }
    }
}