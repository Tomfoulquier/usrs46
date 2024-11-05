using System;

namespace ExemplePOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Maison[] CatalogueMaisons = new Maison[] { UneMaison, UneAutreMaison, UneDerniereMaison };

            foreach (Maison M in CatalogueMaisons)
            {
                Console.WriteLine(M);
            }

            Terrain UnTerrain = new Terrain("33 boulevard, 69001 Lyon", 856f, 2, false);
            Terrain DeuxTerrain = new Terrain("33 boulevard, 69001 Paris", 325f, 2, true);

            Terrain[] CatalogueTerrain = new Terrain[] { UnTerrain, DeuxTerrain };

            foreach (Terrain T in CatalogueTerrain)
            {
                Console.WriteLine(T);
            }

        }
    }
}