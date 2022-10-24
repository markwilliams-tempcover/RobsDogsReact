using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Interfaces
{
    interface IDogOwner
    {
        string OwnerName { get; set; }
        IEnumerable<string> DogNames { get; set; }
    }
}
