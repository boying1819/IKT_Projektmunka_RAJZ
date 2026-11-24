# IKT_Projektmunka_RAJZ
Nagy Bálint - Szabó Bence

Konzolos rajzoló

C# konzolprogram, amellyel szabad kézzel lehet rajzolni, alakzatokat (nyomdákat) elhelyezni, szinuszgörbét és aranytéglalapot rajzolni, valamint szövegfájlból mintát betölteni.

Indítás

Szükséges: .NET SDK (Visual Studio 2022 vagy a dotnet parancs).

Visual Studióval

Nyisd meg a projektet (.sln vagy .csproj fájl).
Indítsd az F5 gombbal (vagy Ctrl+F5-tel hibakeresés nélkül).

Parancssorból

git clone <a repó HTTPS-címe>
cd <a projekt mappája>
dotnet run

A mintafájl: a minta.txt a program munkamappájában kell, hogy legyen. Visual Studióban kattints a fájlra a Solution Explorerben, és a Tulajdonságoknál (Properties) állítsd a Copy to Output Directory értéket Copy if newer-re. Ekkor a fájl automatikusan a futtatható program mellé kerül. A hangjelzések (Beep) Windows alatt hallhatók.

Ajánlott konzolablak-méret: legalább 80 oszlop × 20 sor.

A képernyő

A bal oldalon a menü- és állapotpanel látható (pozíció, karakter, szín, eszköz állapota), a jobb oldalon a 48×12 cellás rajzlap. A rajzlap bal felső cellájának koordinátája (0, 0). A kurzort a █ jelzi.

Vezérlés
Billentyű    Funkció
Nyilak    A kurzor mozgatása cellánként
Szóköz    Az eszköz felemelése / letétele
F1 / F2 / F3    X alakzat (3×3 / 5×5 / 7×7)
F4 / F5 / F6    Kereszt (3×3 / 5×5 / 7×7)
F7 / F8 / F9    Négyzetkeret (3×3 / 5×5 / 7×7)
F10 / F11 / F12    Rombuszkeret (3×3 / 5×5 / 7×7)
M    Menü megnyitása
X    Kilépés (megerősítéssel)

Az eszköz kezdetben felemelt állapotban van. Letett eszköznél a kurzor minden lépésnél az aktuális karaktert és színt hagyja maga után. A nyomda az aktuális pozíciót veszi középpontnak, és felemelt és letett eszközzel is működik. A kurzor és az eszköz állapota nem változik.

Menü

A menüpont számát kell beírni, majd Entert nyomni.

Szám    Funkció
1    Rajzkarakter választása
2    Rajzszín választása
3    Minta betöltése (minta.txt)
4    Cella törlése
5    Ugrás középre
6    Szinusz rajzolása
7    Aranyarány rajzolása
8    Kilépés
0    Vissza a rajzhoz
