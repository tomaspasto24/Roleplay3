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
            if (heroesList.Count == 0)
            {
                Console.WriteLine("No hay suficiente cantidad de heroes para comenzar un encuentro");
            }
            else if (enemiesList.Count == 0)
            {
                Console.WriteLine("No hay suficiente cantidad de villanos para comenzar un encuentro");
            }
            else
            {
                Console.WriteLine($"Un encuentro ha comenzado. Hay {heroesList.Count} heroes y {enemiesList.Count} villanos.");
                
                while (!AllHeroesAreDead() && !AllEnemiesAreDead())
                {
                    int j;
                    for (int i = 0; i < enemiesList.Count; i++)
                    {
                        if (AllHeroesAreDead())
                        {
                            break;
                        }

                        Enemy villian = enemiesList[i];
                        if (!(villian.CurrentHealth() > 0))
                        {
                            continue;
                        }
                        
                        j = i;

                        while (j >= heroesList.Count || !(heroesList[j].CurrentHealth() > 0))
                        {
                            if (j == 0)
                            {
                                j = heroesList.Count;
                            }
                            j--;
                        }

                        Hero hero = heroesList[j];
                        Console.WriteLine($"El villano {villian.ReturnName()} ataca a {hero.ReturnName()}.");
                        villian.AttackEnemy(hero);
                        if (!(hero.CurrentHealth() > 0))
                        {
                            Console.WriteLine($"{villian.ReturnName()} ha matado a {hero.ReturnName()}");
                        }
                    }
                    Console.WriteLine();
                    // Ahora los heroes que quedaron vivos atacan a los enemigos.
                    // Todos los heroes sobrevivientes atacan a cada enemigo 1 vez.
                    foreach (Hero hero in heroesList)
                    {
                        if (AllEnemiesAreDead() || AllHeroesAreDead())
                        {
                            break;
                        }
                        if (!(hero.CurrentHealth() > 0))
                        {
                            continue;
                        }

                        foreach (Enemy villian in enemiesList)
                        {
                            if (!(villian.CurrentHealth() > 0))
                            {
                                continue;
                            }

                            Console.WriteLine($"El heroe {hero.ReturnName()} ataca a {villian.ReturnName()}.");
                            hero.AttackEnemy(villian);
                                                        
                            if  (!(villian.CurrentHealth() > 0))
                            {
                                Console.WriteLine($"{hero.ReturnName()} ha matado a {villian.ReturnName()}");
                                hero.AddVictoryPoints(villian.ReturnVictoryPoints());
                                if (hero.ReturnVictoryPoints() > 5)
                                {
                                    Console.WriteLine($"Se ha curado a {hero.ReturnName()} por tener mas de 5 VP");
                                    hero.ResetVictoryPoints();
                                    hero.RestoreHealth();
                                }
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine("El encuentro ha terminado");

            if (AllEnemiesAreDead())
            {
                Console.WriteLine("Los heroes han ganado el encuentro.");
            }
            else
            {
                Console.WriteLine("Los enemigos han ganado el encuentro.");
            }
        }

        public bool AllHeroesAreDead()
        {
            foreach (Hero hero in heroesList)
            {
                if (hero.CurrentHealth() > 0)
                {
                    return false;
                }
            }
            return true;
        }
        public bool AllEnemiesAreDead()
        {
            foreach (Enemy enemy in enemiesList)
            {
                if (enemy.CurrentHealth() > 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}