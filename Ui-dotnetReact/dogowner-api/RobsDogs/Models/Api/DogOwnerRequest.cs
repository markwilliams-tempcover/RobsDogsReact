using System.Collections.Generic;

namespace RobsDogs.Models.Api
{
    public class DogOwnerRequest
    {
        public string OwnerName { get; set; }

        public IEnumerable<string> DogNames { get; set; }
    }
}