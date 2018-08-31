using System;

namespace FavoriteThings.SuzukiGSXR750
{
    class SuzukiGSXR750 : BaseType.BaseType
    {
        public SuzukiGSXR750() : base("749 cc", 4, "Suzuki GSX-R 750")
        {
        }
        public void SuzukiSound()
        {
            Console.WriteLine("The Suzuki says, BraaapBraaaap!!");
            Console.WriteLine("");
        }

    }
}
