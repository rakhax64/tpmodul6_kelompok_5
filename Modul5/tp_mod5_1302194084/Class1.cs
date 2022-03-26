using System;

namespace tp_mod5_1302194084
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo saya = new SayaTubeVideo("Tutorial Design By Contract - Rakha Pratama Wahyudi");
            saya.IncreasePlayCount(0);
            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo("Rakha Pratama Wahyudi");
            saya1.IncreasePlayCount(1000000000);
            saya1.PrintVideoDetails();
        }
    }
}
