namespace destruction
{
    internal class Program
    {
        static class Helper
        {
            public static int X { get; set; }
            public static int Y { get; set; }

            static Helper()
            {
                X = 10;
                Y = 20;
            }
        }
        class Ahhh(string s)
        {
            private string[] zzz = new string[4];
            public string Name { get; set; } = s;

            public string this[int index]
            {
                get
                {
                    return zzz[index];
                    //svo
                }
                set
                {
                    zzz[index] = value;
                }
            }
            public static Ahhh operator +(Ahhh human1, Ahhh human2)
            {
                string ship = human1.Name + " loves " + human2.Name + "! :3";
                Ahhh res = new Ahhh(ship);
                return res;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Helper.X);
            Ahhh yamete = new Ahhh("Stanely");
            Ahhh kudasai = new Ahhh("You");
            int[] kuda = [0, 1, 2];
            yamete[0] = "Yamete";
            yamete[1] = "Kudasaii";
            foreach (var i in kuda)
            {
                Console.WriteLine(yamete[i]);
            }
            Ahhh ans = yamete + kudasai;
            Console.WriteLine("WARNING! " + ans.Name);

        }
    }
}
