using EntitiesLayer;
using StubDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public class ThronesTournamentManager
    {

        DalManager dal;
        private List<Fight> listOfFights;


        public ThronesTournamentManager()
        {
            this.listOfFights = new List<Fight>();
        }




        public void DisplayHouses()
        {
            List<House> houses = dal.GetHouses();
            foreach(House h in houses)
            {
                Console.WriteLine(h.GetHouseName() + " possède " + h.GetNumberOfUnities() + " unités");
            } 
        }
        
        public void DisplayHouses200()
        {
            List<House> houses = dal.GetHouses200();
            foreach(House h in houses)
            {
                Console.WriteLine(h.GetHouseName() + " possède " + h.GetNumberOfUnities() + " unités");
            }
        }

        public void DisplayCharacters()
        {
            List<Character> characters = dal.GetCharacters();
            foreach(Character c in characters)
            {
                Console.WriteLine(c.GetFirstName() + " " + c.GetLastName() + " possède " + c.GetBravoury() 
                    + " point(s) de bravoure, " + c.GetCrazyness() + " point(s) de folie et " + c.GetPv() + " point(s) de vie");
            }
        }

        public void DisplayTerritories()
        {
            List<Territory> territories = dal.GetTerritories();
            foreach(Territory t in territories)
            {
                Console.WriteLine(t.GetOwner() + " est la famille propriétaire de ce terrain. " + "Ce terrain est de type " + t.GetTypeOfTerritory() + "." );
            }
        }

    }
}
