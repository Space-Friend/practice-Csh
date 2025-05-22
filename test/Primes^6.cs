using System;
namespace test
{
    public class Pr1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Prime Numbers between 2 and 100 are : ");
            for (int i = 1; i <= 100/6; i++)
            {
                int counter = 0;

                int i1 = 6 * i - 1;

                for (int j = 2; j <= i1 / 2; j++)
                {
                    if  (i1 % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                
                if (counter == 0)
                {
                    Console.Write($"{i1}, ");
                }
                counter = 0;

                int i2 = 6 * i + 1;

                for (int j = 2; j <= i2 / 2; j++)
                {
                    if (i2 % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                
                if (counter == 0)
                {
                    Console.Write($"{i2}, ");
                }
            }
            Console.WriteLine("\n5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 - Правильно");
            Console.ReadKey();
        }
    }
}