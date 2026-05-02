using NUnit.Framework;

namespace May_I_Learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Tests
    {
        public static bool FixedTest()
        {
            return Program.ReturnTrue();
        }
    }
}
