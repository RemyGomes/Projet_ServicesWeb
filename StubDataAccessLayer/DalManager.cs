using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StubDataAccessLayer
{
    public class DalManager
    {
        private List<House> listOfHouses;
        private List<Territory> listOfTerritories;
        private List<Character> listOfCharacters;

        public DalManager()
        {
            this.listOfHouses = new List<House>();
            this.listOfTerritories = new List<Territory>();
            this.listOfCharacters = new List<Character>();
            // Ajout de maisons
            listOfHouses.Add(new House("Simpson"));
            listOfHouses.Add(new House("Bouvier"));
            listOfHouses.Add(new House("Tuches"));
            listOfHouses.Add(new House("Guy", 250));
            // Ajout de Territoires 
            listOfTerritories.Add(new Territory(new House("Simpson"), TerritoryType.LAND));
            listOfTerritories.Add(new Territory(new House("Bouvier"), TerritoryType.SEA));
            listOfTerritories.Add(new Territory(new House("Tuches"), TerritoryType.DESERT));
            // Ajout de Personnages 
            listOfCharacters.Add(new Character("Homer", "Simpson", 1000));
            listOfCharacters.Add(new Character("Marge", "Bouvier", 3000));
            listOfCharacters.Add(new Character("Jeff", "Tuche", -50));

        }


        //Retourner la liste de l’ensemble des maisons existantes
        public List<House> GetHouses()
        {
            return listOfHouses;
        }


        //Retourner la liste de l’ensemble des maisons avec plus de 200 unités existantes
        public List<House> GetHouses200()
        {
            List<House> houses200 = new List<House>();
            foreach(House h in listOfHouses)
            {
                if(h.GetNumberOfUnities() > 200)
                {
                    houses200.Add(h);
                }
            }
            return houses200;
        }

        //Retourner la liste de l’ensemble des terrains existants
        public List<Territory> GetTerritories()
        {
            return listOfTerritories;
        }

        //Retourner la liste de l’ensemble des personnages existants
        public List<Character> GetCharacters()
        {
            return listOfCharacters;
        }

        //Retourner la liste de l’ensemble des caractéristiques des personnages existantes
    }

}
