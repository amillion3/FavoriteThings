﻿using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Honda = new HondaRC51.HondaRC51();
            var Triumph = new TriumphStreetTriple.TriumphStreetTriple();

            Honda.PrintStuff();
            Triumph.PrintStuff();
        }
       
    }
}
