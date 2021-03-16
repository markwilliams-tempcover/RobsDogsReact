using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RobsDogs.Models.Api;
using RobsDogs.Models.Contracts;
using RobsDogs.Models.Domain;
using RobsDogs.Repositories;

namespace RobsDogs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobsDogsController : ControllerBase
    {
        private readonly IDogOwnerRepository _repository;

        public RobsDogsController(IDogOwnerRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> PostDogOwner(DogOwnerRequest request)
        {
            if (request == null)
            {
                return BadRequest();
            }
            
            var dogOwner = new DogOwner( request.OwnerName, request.DogNames);
            await _repository.Save(dogOwner);

            return CreatedAtAction(nameof(PostDogOwner), new {id = dogOwner.Id}, null);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDogOwner(long id)
        {
            var dogOwner = await _repository.GetDogOwner(id);
            if (dogOwner == null)
            {
                return NotFound();
            }
            
            var response = new DogOwnerResponse(dogOwner.Id,
                dogOwner.OwnerName,
                dogOwner.DogNames);

            return Ok(response);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllDogOwners()
        {
            var dogOwners = await _repository.GetAllDogOwners();

            var dogOwnerResponses = dogOwners.Select(x =>
                new DogOwnerResponse(x.Id,
                    x.OwnerName,
                    x.DogNames));

            return Ok(dogOwnerResponses);
        }
    }
}