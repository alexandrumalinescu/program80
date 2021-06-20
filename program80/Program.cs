using System;

namespace program80
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string number = Console.ReadLine();

            while ( number != "x")
            {
                int sum = Convert.ToInt32(number);
                count += sum;
                number = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
