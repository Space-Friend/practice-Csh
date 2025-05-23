namespace final_test_ig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = "jquinjqwnqwi1ocnnx nqwxdnqn nqwoi noy ";
            Console.WriteLine(a+"\n");
            if (a.Contains("1"))
            {
                a = a[..a.IndexOf('1')];
                Console.WriteLine(a);
            }
            
        }
    }
}
