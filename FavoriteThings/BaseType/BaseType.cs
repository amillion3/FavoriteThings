using System;

namespace FavoriteThings.BaseType
{
    abstract class BaseType
    {
        private readonly string _bikeName;
        private readonly string _bikeDisplacement;
        private readonly int _bikeCylinders;

        public BaseType(string bikeDisplacement, int bikeCylinders, string bikeName)
        {
            _bikeName = bikeName;
            _bikeDisplacement = bikeDisplacement;
            _bikeCylinders = bikeCylinders;

            int _bikeWheels = 2;
            int _bikeSpeeds = 6;
        }

        public void PrintStuff()
        {
            Console.WriteLine($@"The {_bikeName},");
            Console.WriteLine($@"with { _bikeCylinders} cylinders and {_bikeDisplacement}.");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
