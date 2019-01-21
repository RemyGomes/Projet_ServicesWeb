using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        private String houseName;
        private int numberOfUnities;
        private List<Character> housers;



        public House(String houseName)
        {
            this.houseName = houseName;
            this.numberOfUnities = 0;
            this.housers = new List<Character>();
        }

        public House(String houseName, int numberOfUnities)
        {
            this.houseName = houseName;
            this.numberOfUnities = numberOfUnities;
            this.housers = new List<Character>();
            for (int i = 0; i < numberOfUnities; i++)
            {
                this.housers.Add(new Character("" + i , "" + i , i));
            }
        }

        public void AddHousers(Character character)
        {
            housers.Add(character);
            numberOfUnities++;
        }




        // Getters
        public int GetNumberOfUnities()
        {
            return numberOfUnities;
        }

        public String GetHouseName()
        {
            return houseName;
        }

        public List<Character> GetHousers()
        {
            return housers;
        }

        // Setters
        public void SetNumberOfUnities(int number)
        {
            this.numberOfUnities = number;
        }

        public void SetHouseName(String name)
        {
            this.houseName = name;
        }

        public void SetHousers(List<Character> housers)
        {
            this.housers = housers;
        }
    }
}
