using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of a class
            var Honda = new HondaRC51.HondaRC51();
            var Triumph = new TriumphStreetTriple.TriumphStreetTriple();
            var Suzuki = new SuzukiGSXR750.SuzukiGSXR750();
            var Kawasaki = new KawasakiKR1S.KawasakiKR1S();

            // Call method on newly created instances
            Honda.PrintStuff();
            Triumph.PrintStuff();
            Suzuki.PrintStuff();
            Kawasaki.PrintStuff();
        }
       
    }
}
