using System;

namespace Mod_using_repeated_Substraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers");
            try
            {

            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int z = mod_Substract(x, y);

            Console.WriteLine("Output using repeated substraction is:" + z);

            }
            catch (Exception)
            {

                Console.WriteLine("Enter valid integer numbers");
            }

        }

        static int mod_Substract(int x, int y)
        {
            int result = x;
            while (result >= y)
                result -= y;

            return result;
        }
    }
}
