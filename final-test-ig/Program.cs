class Program
{
    static void Main(string[] args)
    {
        string[] words = {
            "home",
            "programming",
            "victory",
            "C#",
            "football",
            "sport",
            "book",
            "learn",
            "dream",
            "fun"
        };

        string letter = Console.ReadLine();

        int count = 0;
        //if (!words.Any(word => word.Contains(letter)))
        //{
        //    Console.WriteLine("No match");
        //}
        //else
        //{
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(letter))
            {
                Console.WriteLine(words[i]);
                count += 1;
            }
        }
        //}
        if (!Convert.ToBoolean(count))
        {
            Console.WriteLine("No match");
        }
    }
}