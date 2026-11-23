namespace Rajzoló_Console_App
{
    internal class Program
    {
        const int lapSzelesseg = 48;
        const int lapMagassag = 12;
        const int panelSzelesseg = 22;

        static char[,] lap = new char[lapMagassag, lapSzelesseg];
        static ConsoleColor[,] lapSzin = new ConsoleColor[lapMagassag, lapSzelesseg];
        static int x = lapSzelesseg / 2, y = lapMagassag / 2;
        static char karakter = '#';
        static ConsoleColor szin = ConsoleColor.Cyan;
        static bool rajzol = false;
        static bool voltHiba = false;
        static DateTime utolsoHangjelzes = DateTime.MinValue;

        static void Hangjelzes()
        {
            voltHiba = true;
            if ((DateTime.Now - utolsoHangjelzes).TotalMilliseconds > 400)
            {
                Console.Beep();
                utolsoHangjelzes = DateTime.Now;
            }
        }

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
            if (!int.TryParse(Console.ReadLine(), out int szinSzam))
            {
                Console.Beep();
                Console.WriteLine("Hibás szám, a szín nem változott!");
                Console.ReadKey(true);
                return szin;
            }
            switch (szinSzam)
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
                    Console.Beep();
                    Console.WriteLine("Nincs ilyen szín, a szín nem változott!");
                    Console.ReadKey(true);
                    return szin;
            }
        }
        static string Szinnev(ConsoleColor kapottSzin)
        {
            switch (kapottSzin)
            {
                case ConsoleColor.Red: return "piros";
                case ConsoleColor.Green: return "zöld";
                case ConsoleColor.Blue: return "kék";
                case ConsoleColor.Yellow: return "sárga";
                case ConsoleColor.Magenta: return "lila";
                case ConsoleColor.White: return "fehér";
                case ConsoleColor.Black: return "fekete";
                case ConsoleColor.Cyan: return "cián";
                default: return kapottSzin.ToString();
            }
        }
        static bool Kilepes()
        {
            Console.WriteLine("Biztosan szeretnél kilépni? (I/N)");
            string valasz = Console.ReadLine() ?? "";
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
            x = lapSzelesseg / 2;
            y = lapMagassag / 2;
        }
        static void Beir(int oszlop, int sor)
        {
            lap[sor, oszlop] = karakter;
            lapSzin[sor, oszlop] = szin;
        }
        static void goldenRatio()
        {
            double phi = (1 + Math.Sqrt(5)) / 2;
            int maxSzelesseg = (int)(lapMagassag * 2 * phi);

            Console.Write($"Add meg a szélességet (8-{maxSzelesseg}): ");
            bool szamOk = int.TryParse(Console.ReadLine(), out int szelesseg);

            if (!szamOk || szelesseg < 8 || szelesseg > maxSzelesseg)
            {
                Console.Beep();
                Console.WriteLine("Hibás méret! Nyomj meg egy billentyűt.");
                Console.ReadKey(true);
                return;
            }

            int magassag = (int)Math.Round(szelesseg / phi / 2);

            int keretOszlop = 0, keretSor = 0, keretSzelesseg = szelesseg, keretMagassag = magassag;

            for (int oszlop = 0; oszlop < keretSzelesseg; oszlop++)
            {
                Beir(keretOszlop + oszlop, keretSor);
                Beir(keretOszlop + oszlop, keretSor + keretMagassag - 1);
            }
            for (int sor = 0; sor < keretMagassag; sor++)
            {
                Beir(keretOszlop, keretSor + sor);
                Beir(keretOszlop + keretSzelesseg - 1, keretSor + sor);
            }

            bool fuggolegesVagas = true;
            while (true)
            {
                if (fuggolegesVagas)
                {
                    int negyzetOldal = keretMagassag * 2;
                    if (keretSzelesseg - negyzetOldal < 2) break;
                    for (int sor = 0; sor < keretMagassag; sor++) Beir(keretOszlop + negyzetOldal - 1, keretSor + sor);
                    keretOszlop += negyzetOldal - 1;
                    keretSzelesseg -= negyzetOldal - 1;
                }
                else
                {
                    int negyzetOldal = keretSzelesseg / 2;
                    if (keretMagassag - negyzetOldal < 2) break;
                    for (int oszlop = 0; oszlop < keretSzelesseg; oszlop++) Beir(keretOszlop + oszlop, keretSor + negyzetOldal - 1);
                    keretSor += negyzetOldal - 1;
                    keretMagassag -= negyzetOldal - 1;
                }
                fuggolegesVagas = !fuggolegesVagas;
            }
        }

        static void Sinus(char karakter, ConsoleColor szin)
        {
            Console.Write($"Add meg a szélességet (1-{lapSzelesseg}): ");
            bool szelessegOk = int.TryParse(Console.ReadLine(), out int szelesseg);

            Console.Write($"Add meg a magasságot (1-{lapMagassag}): ");
            bool magassagOk = int.TryParse(Console.ReadLine(), out int magassag);

            if (!szelessegOk || !magassagOk || szelesseg < 1 || szelesseg > lapSzelesseg || magassag < 1 || magassag > lapMagassag)
            {
                Console.Beep();
                Console.WriteLine("Hibás méret! Nyomj meg egy billentyűt.");
                Console.ReadKey(true);
                return;
            }

            int kozep = magassag / 2;
            int amplitudo = magassag / 3;

            for (int oszlop = 0; oszlop < szelesseg; oszlop++)
            {
                double szog = oszlop * 2 * Math.PI / szelesseg;

                int sor = kozep - (int)(Math.Sin(szog) * amplitudo);

                lap[sor, oszlop] = karakter;
                lapSzin[sor, oszlop] = szin;
            }
        }
        static bool MintaBetoltes(ConsoleColor szin)
        {
            try
            {
                string[] sorok = System.IO.File.ReadAllLines("minta.txt");

                if (sorok.Length > lapMagassag)
                {
                    Console.Beep();
                    Console.WriteLine("A minta túl magas!");
                    return false;
                }

                foreach (string sor in sorok)
                {
                    if (sor.Length > lapSzelesseg)
                    {
                        Console.Beep();
                        Console.WriteLine("A minta túl széles!");
                        return false;
                    }
                }

                Array.Clear(lap, 0, lap.Length);

                for (int sorSzam = 0; sorSzam < sorok.Length; sorSzam++)
                {
                    for (int oszlopSzam = 0; oszlopSzam < sorok[sorSzam].Length; oszlopSzam++)
                    {
                        if (sorok[sorSzam][oszlopSzam] != ' ')
                        {
                            lap[sorSzam, oszlopSzam] = sorok[sorSzam][oszlopSzam];
                            lapSzin[sorSzam, oszlopSzam] = szin;
                        }
                    }
                }
                return true;
            }
            catch
            {
                Console.Beep();
                Console.WriteLine("Hiba! Nem sikerült betölteni a mintát.");
                return false;
            }
        }
        static char KarakterValasztas()
        {
            Console.WriteLine("Add meg a rajzkaraktert: ");

            string ujKarakter = Console.ReadLine();

            if (string.IsNullOrEmpty(ujKarakter))
            {
                Console.Beep();
                Console.WriteLine("Nem adtál meg karaktert! Marad a régi.");
                Console.ReadKey(true);
                return karakter;
            }

            return ujKarakter[0];
        }
        static void CellaTorles()
        {
            lap[y, x] = '\0';
        }

        static void Nyomda(int tipus, int sugar)
        {
            if (x - sugar < 0 || x + sugar >= lapSzelesseg || y - sugar < 0 || y + sugar >= lapMagassag)
            {
                Hangjelzes();
                return;
            }

            for (int sorEltolas = -sugar; sorEltolas <= sugar; sorEltolas++)
            {
                for (int oszlopEltolas = -sugar; oszlopEltolas <= sugar; oszlopEltolas++)
                {
                    bool jeloltCella = false;
                    switch (tipus)
                    {
                        case 0:
                            jeloltCella = Math.Abs(oszlopEltolas) == Math.Abs(sorEltolas);
                            break;
                        case 1:
                            jeloltCella = oszlopEltolas == 0 || sorEltolas == 0;
                            break;
                        case 2:
                            jeloltCella = Math.Max(Math.Abs(oszlopEltolas), Math.Abs(sorEltolas)) == sugar;
                            break;
                        case 3:
                            jeloltCella = Math.Abs(oszlopEltolas) + Math.Abs(sorEltolas) == sugar;
                            break;
                    }
                    if (jeloltCella) Beir(x + oszlopEltolas, y + sorEltolas);
                }
            }
        }
        static void Mozgas(int oszlopValtozas, int sorValtozas)
        {
            int ujX = x + oszlopValtozas;
            int ujY = y + sorValtozas;
            if (ujX < 0 || ujX >= lapSzelesseg || ujY < 0 || ujY >= lapMagassag)
            {
                Hangjelzes();
                return;
            }
            x = ujX;
            y = ujY;
            if (rajzol) Beir(x, y);
        }
        static void Kiir()
        {
            Console.SetCursorPosition(0, 0);

            string[] panel = new string[lapMagassag + 1];
            panel[0] = "KONZOLOS RAJZOLÓ";
            panel[1] = "M: Menü";
            panel[2] = "X: Kilépés";
            panel[4] = $"Pozíció: ({x}, {y})";
            panel[5] = $"Karakter: {karakter}";
            panel[6] = $"Szín: {Szinnev(szin)}";
            panel[7] = $"Eszköz: {(rajzol ? "letéve" : "felemelve")}";
            panel[9] = "Nyilak: mozgás";
            panel[10] = "Szóköz: eszköz";
            panel[11] = "F1-F12: nyomda";

            for (int sor = 0; sor <= lapMagassag; sor++)
            {
                Console.ResetColor();
                Console.Write((panel[sor] ?? "").PadRight(panelSzelesseg) + "│ ");

                if (sor == 0)
                {
                    Console.Write("RAJZLAP".PadRight(lapSzelesseg));
                }
                else
                {
                    int lapSor = sor - 1;
                    for (int oszlop = 0; oszlop < lapSzelesseg; oszlop++)
                    {
                        if (lapSor == y && oszlop == x)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write('█');
                        }
                        else if (lap[lapSor, oszlop] == '\0')
                        {
                            Console.Write(' ');
                        }
                        else
                        {
                            Console.ForegroundColor = lapSzin[lapSor, oszlop];
                            Console.Write(lap[lapSor, oszlop]);
                        }
                    }
                }
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        static void Menu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENÜ - írd be a menüpont számát, majd Enter");
                Console.WriteLine("1. Karakter választása");
                Console.WriteLine("2. Szín választása");
                Console.WriteLine("3. Minta betöltése (minta.txt)");
                Console.WriteLine("4. Cella törlése");
                Console.WriteLine("5. Ugrás középre");
                Console.WriteLine("6. Szinusz rajzolása");
                Console.WriteLine("7. Aranyarány rajzolása");
                Console.WriteLine("8. Kilépés");
                Console.WriteLine("0. Vissza a rajzhoz");

                string valasztas = Console.ReadLine();
                bool ervenyesValasztas = true;
                switch (valasztas)
                {
                    case "0":
                        break;
                    case "1":
                        karakter = KarakterValasztas();
                        break;
                    case "2":
                        szin = Szinkeres();
                        break;
                    case "3":
                        while (!MintaBetoltes(szin))
                        {
                            Console.WriteLine("Újra próbálod? (I/N)");
                            if ((Console.ReadLine() ?? "").ToUpper() != "I") break;
                        }
                        break;
                    case "4":
                        CellaTorles();
                        break;
                    case "5":
                        Közepre();
                        break;
                    case "6":
                        Sinus(karakter, szin);
                        break;
                    case "7":
                        goldenRatio();
                        break;
                    case "8":
                        if (Kilepes()) Environment.Exit(0);
                        break;
                    default:
                        ervenyesValasztas = false;
                        break;
                }

                if (ervenyesValasztas) break;

                Console.Beep();
                Console.WriteLine("Hibás választás! Nyomj meg egy billentyűt az újrapróbáláshoz.");
                Console.ReadKey(true);
            }
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.Clear();

            while (true)
            {
                Kiir();
                ConsoleKeyInfo gomb = Console.ReadKey(true);

                switch (gomb.Key)
                {
                    case ConsoleKey.UpArrow:
                        Mozgas(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        Mozgas(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        Mozgas(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        Mozgas(1, 0);
                        break;
                    case ConsoleKey.Spacebar:
                        rajzol = !rajzol;
                        if (rajzol) Beir(x, y);
                        break;
                    case ConsoleKey.M:
                        Menu();
                        break;
                    case ConsoleKey.X:
                        if (Kilepes()) return;
                        Console.Clear();
                        break;
                    default:

                        int fGombSorszam = (int)gomb.Key - (int)ConsoleKey.F1;
                        if (fGombSorszam >= 0 && fGombSorszam <= 11)
                        {
                            Nyomda(fGombSorszam / 3, fGombSorszam % 3 + 1);
                        }
                        break;
                }

                if (voltHiba)
                {
                    while (Console.KeyAvailable) Console.ReadKey(true);
                    voltHiba = false;
                }
            }
        }
    }
}