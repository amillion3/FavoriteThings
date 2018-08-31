using System;

namespace FavoriteThings.TriumphStreetTriple
{
    class TriumphStreetTriple : BaseType.BaseType
    {
        public TriumphStreetTriple() : base("765 cc", 3, "Triumph Street Triple")
        {
        }
        public void TriumphSound()
        {
            Console.WriteLine("The Triumph says, RnnnngRnnnnng!!");
            Console.WriteLine("");
        }
    }
}
