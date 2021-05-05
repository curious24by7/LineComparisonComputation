using System;

namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation.");
            Console.WriteLine("Enter x, y coordinates of the line 1::");
            Console.WriteLine("X1");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("X2");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x, y coordinates of the line 2::");
            Console.WriteLine("A1");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A2");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B1");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B2");
            int B2 = Convert.ToInt32(Console.ReadLine());
            double L1 = Math.Sqrt(Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2));
            Console.WriteLine("Length of L1 is:: "+ L1);
            double L2 = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            Console.WriteLine("Length of L2 is:: " + L2);
            Console.WriteLine("---------------------------------------------------");
            bool result = L1.Equals(L2);
            if (result == false)
            {
                Console.WriteLine("Lines L1 and L2 are NOT EQUAL.");
            }
            else
            {
                Console.WriteLine("Lines L1 and L2 are EQUAL.");
            }
            Console.WriteLine("---------------------------------------------------");
            double diff = L1.CompareTo(L2);
            if (diff < 0)
            {
                Console.WriteLine("Length of Line L1 is less than L2.");
            }
            if (diff > 0)
            {
                Console.WriteLine("Length of Line L1 is greater than L2.");
            }
            if (diff == 0)
            {
                Console.WriteLine("Both Lines are equal in Length.");
            }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Press any Key to Exit.");
            Console.ReadKey();
        }
    }
}
