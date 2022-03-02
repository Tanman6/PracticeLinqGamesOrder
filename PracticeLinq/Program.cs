using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>();
            var game1 = "Red Dead Redemtion";
            var game2 = "Fallout";
            var game3 = "Horizon: Forbidden West";
            var game4 = "Halo Infinite";
            var game5 = "Returnal";
            var game6 = "Ghost of Tsushima";

            games.Add(game1);
            games.Add(game2);
            games.Add(game3);
            games.Add(game4);
            games.Add(game5);
            games.Add(game6);

            var orderGames = games.OrderBy(x => x.Length);

            foreach (var game in orderGames)
            {
                Console.WriteLine(game);
                Console.WriteLine();
            }
        }
    }
}
