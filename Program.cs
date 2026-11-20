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
            static void Közepre()
            {
                int x = Console.WindowWidth / 2;
                int y = Console.WindowHeight / 2;
                Console.SetCursorPosition(x, y);
            }
            static void goldenRatio()
        {
            Console.Write("Add meg a szélességet: ");
            int szelesseg = int.Parse(Console.ReadLine());

            Console.Write("Add meg a magasságot: ");
            int magassag = int.Parse(Console.ReadLine());

            double arany = (double)szelesseg / magassag;
            double goldenRatio = (1 + Math.Sqrt(5)) / 2;

            Console.Clear();

            Console.WriteLine($"A szélesség/magasság arány: {arany}");
            Console.WriteLine($"Az aranyarány: {goldenRatio}");

            if (Math.Abs(arany - goldenRatio) < 0.01)
            {
                Console.WriteLine("Ez az arány közel áll az aranyarányhoz!");
            }
            else
            {
                Console.WriteLine("Ez az arány nem közel áll az aranyarányhoz.");
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
        static char KarakterValasztas()
        {
            Console.WriteLine("Add meg a rajzkaraktert: ");

            string karakter = Console.ReadLine();

            if (string.IsNullOrEmpty(karakter))
            {
                Console.Beep();
                Console.WriteLine("Nem adtál meg karaktert!");
                return '#';
            }

            return karakter[0];
        }
        static void CellaTorles(int x, int y, int rajzlapX, int rajzlapY)
        {
            int regiX = Console.CursorLeft;
            int regiY = Console.CursorTop;

            Console.SetCursorPosition(rajzlapX + x, rajzlapY + y);

            Console.Write(' ');

            Console.SetCursorPosition(regiX, regiY);
        }
        static void eloMenuEsRajzlap()
        {
            Console.Clear();
            Console.WriteLine("1. Rajzlap létrehozása");
            Console.WriteLine("2. Rajzlap törlése");
            Console.WriteLine("3. Kilépés");
        }
        static void RajzlapLétrehozása()
        {
            Console.Clear();
            Console.WriteLine("Add meg a rajzlap szélességét: ");
            int szelesseg = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a rajzlap magasságát: ");
            int magassag = int.Parse(Console.ReadLine());

            Console.Clear();

            for (int y = 0; y < magassag; y++)
            {
                for (int x = 0; x < szelesseg; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write('.');
                }
            }
            if (szelesseg < Console.WindowWidth / 3 && magassag > Rajzoló_Console_App.WindowHeight - 2)
            {
                Console.Beep();
                Console.WriteLine("A rajzlap túl nagy lett változtass a méretein!");

            }
        }
        static void eloMenü()
        {
            while (true)
            {
                eloMenuEsRajzlap();
                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "1":
                        RajzlapLétrehozása();
                        break;
                    case "2":
                        Console.Clear();
                        break;
                    case "3":
                        if (Kilepes())
                        {
                            return;
                        }
                        break;
                    default:
                        Console.Beep();
                        Console.WriteLine("Érvénytelen választás!");
                        Console.Clear();
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
