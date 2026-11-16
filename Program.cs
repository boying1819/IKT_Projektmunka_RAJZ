namespace Rajzoló_Console_App
{
    internal class Program
    {
        static ConsoleColor Szinkeres()
        {
            Console.WriteLine("Válassz színt: ");
            Console.WriteLine("1. Piros");
            Console.WriteLine("2. Zöld");
            Console.WriteLine("3. Kék");
            Console.WriteLine("4. Sárga");
            Console.WriteLine("5. Lila");
            Console.WriteLine("6. Fehér");
            Console.WriteLine("7. Fekete");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    return ConsoleColor.Red;
                case 2:
                    return ConsoleColor.Green;
                case 3:
                    return ConsoleColor.Blue;
                case 4:
                    return ConsoleColor.Yellow;
                case 5:
                    return ConsoleColor.Magenta;
                case 6:
                    return ConsoleColor.White;
                case 7:
                    return ConsoleColor.Black;
                default:
                    return ConsoleColor.White;
            }
            static bool Kilepes()
            {
                Console.WriteLine("Biztosan szeretnél kilépni? (I/N)");
                string valasz = Console.ReadLine();
                if (valasz.ToUpper() == "I")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            static void Main(string[] args)
            {

            }
        }
    }
}
