using System.Numerics;
using System.Security.AccessControl;
using System.Text.RegularExpressions;


namespace from_down_to_top
{
    internal class Challenges
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Основные типы переменных
             * 
             */
            byte b;
            sbyte sb;
            short s;
            ushort us;
            int i;
            uint ui;
            long l;
            ulong ul;

            // С плавающей точкой
            float f = 5.7f;
            double d = 5.7;

            //Символьные
            char c = 'a';
            string str = "string";

            // Логические
            bool bo;
            int first_num = 5;
            int second_num = 2;
            float x = Convert.ToSingle(first_num) / Convert.ToSingle(second_num);
            //Console.WriteLine(x);

            /*
             * 
             * Урон
             * 
             */
            int health = 100;
            int armor = 1;
            int damage;
            //Console.WriteLine("{0}hp. Введ" +
            //    "ите урон: ", health);
            //damage = Convert.ToInt16(Console.ReadLine());
            damage = 100;
            if (damage > armor)
            {
                health -= damage - armor;
            }
            //Console.WriteLine(health);

            /*
             * 
             * Еда
             * 
             */
            int money = 100;
            int food;
            int foodPrice = 10;
            bool isAbleToPay;
            //Console.WriteLine("Сколько еды?");
            //food = Convert.ToInt16(Console.ReadLine());
            food = 5;
            isAbleToPay = money >= food * food;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodPrice;
            //Console.WriteLine($"money {money}, food {food}");

            if (isAbleToPay)
            {
                money -= food * foodPrice;
                //Console.WriteLine($"money {money}, food {food}");
            }
            Console.WriteLine();

            double[] abc = [0, 4, 2, 5];
            double[] abd = [1.346, 1.1532, 1.8734, 1.8723];
            string tex = "everything_is_fine";
            string tex2 = "helloEdabit";
            //Console.WriteLine(ToCamelCase(tex));
            //Console.WriteLine(ToSnakeCase(tex2)+" ");
            //Console.WriteLine(abc.Max());
            //Console.WriteLine(Convert.ToString(FindMinMax(abd)[0]) +" "+ Convert.ToString(FindMinMax(abd)[1]));
            //var ah = Convert.ToString(Console.ReadLine());
            //Console.WriteLine(EncodeMorse2("cum cumm"));
            //BigInteger huge = BigInteger.Parse("12345678901234567890123456789012345678910000000000000000000000000000000000000");
            //Console.WriteLine(Fibonacci(7));
            Console.WriteLine(SumSmallest([-1, 10, 2, 3, -5, 5]));
        } // Конец Main

        // Функции
        public static string ToSnakeCase(string str)
        {
            return Regex.Replace(str, "[A-Z]", "_$0").ToLower();
        }
        public static string ToCamelCase(string str)
        {
            return Regex.Replace(str, @"_\w", m => m.Value[1].ToString().ToUpper());
        }
        public static double[] FindMinMax(double[] values) => new[] { values.Min(), values.Max() };
        public static string EncodeMorse(string str)
        {
            var _out = "";
            foreach (char c in str)
            {
                _out += c switch
                {
                    ('A' or 'a') => ".- ",
                    ('B' or 'b') => "-... ",
                    ('C' or 'c') => "-.-. ",
                    ('D' or 'd') => "-.. ",
                    ('E' or 'e') => ". ",
                    ('F' or 'f') => "..-. ",
                    ('G' or 'g') => "--. ",
                    ('H' or 'h') => ".... ",
                    ('I' or 'i') => ".. ",
                    ('J' or 'j') => ".--- ",
                    ('K' or 'k') => "-.- ",
                    ('L' or 'l') => ".-.. ",
                    ('M' or 'm') => "-- ",
                    ('N' or 'n') => "-. ",
                    ('O' or 'o') => "--- ",
                    ('P' or 'p') => ".--. ",
                    ('Q' or 'q') => "--.- ",
                    ('R' or 'r') => ".-. ",
                    ('S' or 's') => "... ",
                    ('T' or 't') => "- ",
                    ('U' or 'u') => "..- ",
                    ('V' or 'v') => "...- ",
                    ('W' or 'w') => ".-- ",
                    ('X' or 'x') => "-..- ",
                    ('Y' or 'y') => "-.-- ",
                    ('Z' or 'z') => "--.. ",
                    _ => "   ",
                };
            }
            return _out;
        }
        public static string EncodeMorse2(string str)
        {
            var morse = new Dictionary<char, string>()
                {
                  {'a', ".-"},
                  {'b', "-..."},
                  {'c', "-.-."},
                  {'d', "-.."},
                  {'e', "."},
                  {'f', "..-."},
                  {'g', "--."},
                  {'h', "...."},
                  {'i', ".."},
                  {'j', ".---"},
                  {'k', "-.-"},
                  {'l', ".-.."},
                  {'m', "--"},
                  {'n', "-."},
                  {'o', "---"},
                  {'p', ".--."},
                  {'q', "--.-"},
                  {'r', ".-."},
                  {'s', "..."},
                  {'t', "-"},
                  {'u', "..-"},
                  {'v', "...-"},
                  {'w', ".--"},
                  {'x', "-..-"},
                  {'y', "-.--"},
                  {'z', "--.."},
                  {'0', "-----"},
                  {'1', ".----"},
                  {'2', "..---"},
                  {'3', "...--"},
                  {'4', "....-"},
                  {'5', "....."},
                  {'6', "-...."},
                  {'7', "--..."},
                  {'8', "---.."},
                  {'9', "----."},
                  {' ', " "},
                  {':', "---..."},
                  {'!', "-.-.--"},
                  {'?', "..--.."},
                  {',', "--..--"},
                  {'.', ".-.-.-"},
                  {'\'', ".----."}
                };

            var parts = new List<string>();

            foreach (char c in str.ToLower())
            {
                parts.Add(morse[c]);
            }

            return string.Join(" ", parts);
        }
        public static string Fibonacci(int n)
        {
            if (n <= 2) { return "1"; }
            ;
            BigInteger n_2 = 1;
            BigInteger n_1 = 1;
            BigInteger _last = 1;
            for (int i = 3; i <= n; i++)
            {
                _last = n_2 + n_1;
                n_2 = n_1;
                n_1 = _last;
            }
            return Convert.ToString(_last);
        }
        public static int SumSmallest(int[] values) => values.Where(x => x >= 0).OrderBy(x => x).Take(2).Sum();
        // Конец функций
    }
}