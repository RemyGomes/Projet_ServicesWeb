using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    class Fight : EntityObject
    {
        private House houseChallenger1 { get; set; }
        private House houseChallenger2 { get; set; }
        private House winningHouse { get; set; }
    }
}
