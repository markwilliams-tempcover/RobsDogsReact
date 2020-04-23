using System.Collections.Generic;

namespace Ui.Entities
{
    interface IDogOwner
    {
        string OwnerName { get; set; }
        List<string> DogNames { get; set; }
    }
}