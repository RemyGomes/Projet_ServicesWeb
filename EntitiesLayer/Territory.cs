using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    class Territory : EntityObject
    {
        public House owner { get; set; }
        public TerritoryType typeOfTerritory { get; set; }

        public Territory(House owner, TerritoryType typeOfTerritory)
        {
            this.owner = owner;
            this.typeOfTerritory = typeOfTerritory;
        }



    }
}
