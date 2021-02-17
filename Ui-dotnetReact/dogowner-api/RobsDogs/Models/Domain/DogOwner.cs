using System.Collections.Generic;

namespace RobsDogs.Models.Domain
{
    public class DogOwner
    {
        public long Id { get; }

        public string OwnerName { get; }

        public IEnumerable<string> DogNames { get; }

        public DogOwner(long id,
            string ownerName,
            IEnumerable<string> dogNames)
        {
            Id = id;
            OwnerName = ownerName;
            DogNames = dogNames;
        }
        
        public DogOwner(string ownerName,
            IEnumerable<string> dogNames)
        {
            OwnerName = ownerName;
            DogNames = dogNames;
        }
    }
}