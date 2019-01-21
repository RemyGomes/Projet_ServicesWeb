using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Character : EntityObject 
    {

        private String firstName;
        private String lastName;
        private int bravoury;
        private int crazyness;
        private int pv;



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




        // Getters
        public String GetFirstName()
        {
            return firstName;
        }

        public String GetLastName()
        {
            return lastName;
        }
        public int GetBravoury()
        {
            return bravoury;
        }
        public int GetCrazyness()
        {
            return crazyness;
        }
        public int GetPv()
        {
            return pv;
        }

        // Setters
        public void SetFirstName(String name)
        {
            this.firstName = name;
        }

        public void SetLastName(String name)
        {
            this.lastName = name;
        }
        public void SetBravoury(int bravoury)
        {
            this.bravoury = bravoury;
        }
        public void SetCrazyness(int crazyness)
        {
            this.crazyness = crazyness;
        }
        public void SetPv(int pv)
        {
            this.pv = pv;
        }
    }
}
