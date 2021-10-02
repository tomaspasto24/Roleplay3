using System;
using System.Collections.Generic;

namespace Library
{
    public class Encounter
    {
        private List<Hero> heroesList = new List<Hero>();
        private List<Enemy> enemiesList = new List<Enemy>();
        public void AddCharacter(Character pj)
        {
            if (pj is Hero)
            {
                heroesList.Add(pj as Hero);
            }
            else if (pj is Enemy)
            {
                enemiesList.Add(pj as Enemy);
            }
        }
        public void DoEncounter()
        {
            int heroesCount = heroesList.Count;
            int enemiesCount = enemiesList.Count;
            while (heroesCount != 0 && enemiesCount != 0)
            {
                for (int coso = 0; coso < Math.Min(heroesCount,enemiesCount); coso++)
                {
                    
                }
            }
        }
    }
}