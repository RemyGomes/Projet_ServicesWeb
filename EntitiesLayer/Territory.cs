using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Territory : EntityObject
    {
        private House owner;
        private TerritoryType typeOfTerritory;

        public Territory(House owner, TerritoryType typeOfTerritory)
        {
            this.owner = owner;
            this.typeOfTerritory = typeOfTerritory;
        }


        // Getters
        public House GetOwner()
        {
            return owner;
        }

        public TerritoryType GetTypeOfTerritory()
        {
            return typeOfTerritory;
        }

        // Setters
        public void SetOwner(House owner)
        {
            this.owner = owner;
        }

        public void SetTypeOTerritory(TerritoryType typeOfTerritory)
        {
            this.typeOfTerritory = typeOfTerritory;
        }
    }
}
