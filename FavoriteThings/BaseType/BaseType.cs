using System;

namespace FavoriteThings.BaseType
{
    abstract class BaseType
    {
        private readonly string _bikeName;
        private readonly string _bikeDisplacement;
        private readonly int _bikeCylinders;
        private readonly int _bikeWheels;
        private readonly int _bikeSpeeds;

        public void MotorCycleBase(string bikeName, string bikeDisplacement, int bikeCylinders)
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
        }
    }
}
