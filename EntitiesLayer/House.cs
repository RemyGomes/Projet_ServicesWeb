using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class House : EntityObject
    {
        private String houseName { get; set; }
        private int numberOfUnities { get; set; }
        private List<Character> housers { get; set; }



        public House(String houseName)
        {
            this.houseName = houseName;
            this.numberOfUnities = 0;
            this.housers = new List<Character>();
        }

        public void AddHousers(Character character)
        {
            housers.Add(character);
            numberOfUnities++;
        }
    }
}
