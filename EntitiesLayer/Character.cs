using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject 
    {

        private String firstName { get; set; }
        private String lastName { get; set; }
        private int bravoury { get; set; }
        private int crazyness { get; set; }
        private int pv { get; set; }



        public Character(String firstName, String lastName, int bravoury)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.bravoury = bravoury;
            this.crazyness = 0;
            this.pv = 100;

        }


        public void AddRelatives()
        {

        }

        override
        public string ToString()
        {
            return firstName + " " + lastName;
        }



    }
}
