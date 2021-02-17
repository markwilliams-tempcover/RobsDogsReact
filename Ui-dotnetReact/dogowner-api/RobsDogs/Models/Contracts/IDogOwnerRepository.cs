using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RobsDogs.Models.Api;
using RobsDogs.Models.Domain;

namespace RobsDogs.Models.Contracts
{
    public interface IDogOwnerRepository
    {
        Task Save(DogOwner dogOwner);
        Task<DogOwner> GetDogOwner(long id);
        Task<IEnumerable<DogOwner>> GetAllDogOwners();
    }
}