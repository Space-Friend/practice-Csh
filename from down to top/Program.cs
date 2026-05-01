namespace from_down_to_top
{
    internal class Program
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
            float x = Convert.ToSingle(first_num)/Convert.ToSingle(second_num);
            Console.WriteLine(x);

            /*
             * 
             * Урон
             * 
             */
            int health = 100;
            int armor = 1;
            int damage;
            Console.WriteLine("{0}hp. Введ" +
                "ите урон: ", health);
            //damage = Convert.ToInt16(Console.ReadLine());
            damage = 100;
            if (damage > armor)
            {
                health -= damage-armor;
            }
            Console.WriteLine(health);

            /*
             * 
             * Еда
             * 
             */
            int money = 100;
            int food;
            int foodPrice = 10;
            bool isAbleToPay;
            Console.WriteLine("Сколько еды?");
            //food = Convert.ToInt16(Console.ReadLine());
            food = 5;
            isAbleToPay = money >= food * food;
            food *= Convert.ToInt32(isAbleToPay);
            money -= food * foodPrice;
            Console.WriteLine($"money {money}, food {food}");

            if (isAbleToPay)
            {
                money -= food * foodPrice;
                Console.WriteLine($"money {money}, food {food}");
            }
            Console.WriteLine();

        }
    }
}
