using System;

namespace LineCamparison_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Length length = new Length();
            length.addCartesianPoints(2, 3, 0, 4);
            length.addCartesianPoints(0, 2, 3, 4);
            length.computeLength();
            Console.ReadKey();
        }
    }
}
