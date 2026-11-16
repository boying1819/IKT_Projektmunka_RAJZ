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

            static void Sinus(char karakter, ConsoleColor szin)
            {
                Console.Write("Add meg a szélességet: ");
                int szelesseg = int.Parse(Console.ReadLine());

                Console.Write("Add meg a magasságot: ");
                int magassag = int.Parse(Console.ReadLine());

                int kozep = magassag / 2;
                int amplitudo = magassag / 3;

                Console.Clear();
                Console.ForegroundColor = szin;

                for (int x = 0; x < szelesseg; x++)
                {
                    double szog = x * 2 * Math.PI / szelesseg;

                    int y = kozep - (int)(Math.Sin(szog) * amplitudo);

                    Console.SetCursorPosition(x, y);
                    Console.Write(karakter);
                }
                Console.ResetColor();
            }
            static void MintaBetoltes(ConsoleColor szin)
            {
                try
                {
                    string[] sorok = System.IO.File.ReadAllLines("minta.txt");

                    int szelesseg = Console.WindowWidth;
                    int magassag = Console.WindowHeight;

                    if (sorok.Length > magassag)
                    {
                        Console.Beep();
                        Console.WriteLine("A minta túl magas!");
                        return;
                    }

                    foreach (string sor in sorok)
                    {
                        if (sor.Length > szelesseg)
                        {
                            Console.Beep();
                            Console.WriteLine("A minta túl széles!");
                            return;
                        }
                    }

                    Console.Clear();

                    Console.ForegroundColor = szin;

                    for (int i = 0; i < sorok.Length; i++)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write(sorok[i]);
                    }

                    Console.ResetColor();
                }
                catch
                {
                    Console.Beep();
                    Console.WriteLine("Hiba! Nem sikerült betölteni a mintát.");
                }
            }
        }

        static void Main(string[] args)
        {
            Sinus('#', ConsoleColor.Cyan);
            MintaBetoltes(ConsoleColor.Cyan);
        }
    }
}
