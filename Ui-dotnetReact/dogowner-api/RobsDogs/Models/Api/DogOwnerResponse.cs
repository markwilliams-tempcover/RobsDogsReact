using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class DogOwnerResponse
    {
        public long Id { get; }
        public string OwnerName { get; }
        public IEnumerable<string> DogNames { get; }

        public DogOwnerResponse(long id, 
            string ownerName,
            IEnumerable<string> dogNames)
        {
            Id = id;
            OwnerName = ownerName;
            DogNames = dogNames;
        }
    }
}