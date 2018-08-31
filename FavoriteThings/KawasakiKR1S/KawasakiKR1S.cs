using System;


namespace FavoriteThings.KawasakiKR1S
{
    class KawasakiKR1S : BaseType.BaseType
    {
        public KawasakiKR1S() : base("249 cc", 2, "Kawasaki KR-1S")
        {
        }
        public void KawasakiSound()
        {
            Console.WriteLine("The Kawasaki says, WeeeeeeWeeeeeeeee!!");
            Console.WriteLine("");
        }
    }
}
