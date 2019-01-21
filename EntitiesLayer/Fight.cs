using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Fight : EntityObject
    {
        private House houseChallenger1;
        private House houseChallenger2;
        private House winningHouse;

        public Fight(House hChall1, House hChall2, House winner)
        {
            this.houseChallenger1 = hChall1;
            this.houseChallenger2 = hChall2;
            this.winningHouse = winner;
        }



        // Getters 
        public House GetHouseChallenger1()
        {
            return houseChallenger1;
        }

        public House GetHouseChallenger2()
        {
            return houseChallenger2;
        }

        public House GetWinningHouse()
        {
            return winningHouse;
        }
        // Setters

        public void SetHouseChallenger1(House hChall1)
        {
            this.houseChallenger1 = hChall1;
        }

        public void SetHouseChallenger2(House hChall2)
        {
            this.houseChallenger2 = hChall2;
        }

        public void SetWinningHouse(House winner)
        {
            this.winningHouse = winner;
        }
    }
}
