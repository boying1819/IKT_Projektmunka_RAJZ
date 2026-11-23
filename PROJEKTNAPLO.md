# Projektnapló – Konzolos rajzoló

## Csapat és munkamegosztás

| Név vagy GitHub-felhasználónév | Vállalt feladatok és szerep | Saját menüfunkció |
|                 Nagy Bálint                              |                        Szabó Bence                            |				
| Szín választás funkció, Kilépés, Ugrás középre           | Minta betöltése, Cella törlése, Karakter választása (gomb)    |
| Golden Ratio kirajzolása, menü és rajzlap                | Sinusz fügvény kirajzolása megadott adatok / függvény alapján |

## Közös megállapodások

- A rajzlap mérete és helye: A terminál 3/4 körülbelül
- A két munkarész kapcsolódási pontja: ...
- A módosítások egyeztetése a main ágon: …

## Munkanapló

| Dátum | Ki | Mi készült el vagy miben állapodtunk meg? | Következő lépés vagy commit |
| 2026.11.16 | Nagy Bálint | Menü eltervezése képileg, Szín választás funkció létrehozása, Kilépés gomb elkészítése | Ugrás a középre gomb elkészítése, Menü megalakításának utánna keresése, Golden Ratio kirajzolási funckiójának eltervezése / megalakítása|
| 2026.11.16 | Szabó Bence | Sinus függvény alapjai, Minta betöltése alapjai | Karakter választása |
| 2026.11.17 | Nagy Bálint | Ugrás a középre gomb elkészítése, Menü megalakításának utánna keresése, Golden Ratio kirajzolási funckiójának eltervezése / megalakítása | Menü vizuális megjelenítése, miután készen van a maradék gomb, ami Bencére van bízva. Mozgatás elkészítése.|
| 2026.11.20 | Szabó Bence | Karakter választása, Cella törlése funkciók alapjai | Menü vizuális megjelenítése és felosztása, tesztelések és finomítások |
| 2026.11.20 | Nagy Bálint | Előmenü kidolgozása, breakelési lehetőségek megakadályozása a rajzlap méretezésénél, rajzlap létrehozása | A menü vizuális megjelenítése és felosztása Bencével, kódnak átvizsgálása, kódnak maradék breakelési lehetőségeit lekezelni|
| 2026.11.22 | Nagy Bálint | A menü és a rajzoló felület alap tervrajz kidolgozása | A menü és rajzlap szebbítése, breakelési lehetőségek megakadályozása, tesztelések elkezdése |
| 2026.11.23 | Nagy Bálint | A rajzlap méretét növeltem és átállítottam 48×12-re, a bal oldali panelen kiírtam a pozíciót, a karaktert, a színt és az eszköz állapotát, és megcsináltam az F1–F12 nyomdákat (X, kereszt, négyzet, rombusz) és a Console.Beep-es részeket például amikor kimész a határon. | Ha maradt olyan amit javítani kell és Bencének nem megy abba besegíteni. |

## Másik pár tesztje

- Tesztelt commit: …
- Visszajelzés és saját javítás: …
- Újrateszt eredménye: …

## Otthoni AI-használat

Aki használt AI-t, írja le a nevét, miben kért segítséget, és mit tanult meg belőle.

- Név: Szabó Bence
- Miben kértem segítséget: Fájlbeolvasásban
- Mit tanultam meg: File.ReadAllLines()	--> Beolvassa a fájl összes sorát.

- Név: Szabó Bence
- Miben kértem segítséget: Hibajelzésben
- Mit tanultam meg: catch  -->	Kezeli a betöltési hibákat.

- Név: Szabó Bence
- Miben kértem segítséget: Értékek ellenőrzésében
- Mit tanultam meg: string.IsNullOrEmpty(karakter) -->	Megvizsgálja, hogy a változó üres vagy null értékű-e.

- Név: Nagy Bálint
- Miben kértem segítséget: Golden Ratio kirajzolásával
- Mit tanultam meg: 1. Math.sqrt() --> A szám négyzetgyökét adja vissza. Math.abs() --> A szám abszolút értékét adja vissza.

- Név: Nagy Bálint
- Miben kértem segítséget: A rajzolt cellák színének tárolásához kértem segítséget. 
- Mit tanultam meg: Megértettem, hogy a karakterek mellé külön színtömb (lapSzin) kell, különben színváltáskor az egész rajz átszíneződne.

- Név: Nagy Bálint
- Miben kértem segítséget: A golden ratio rajzolási funkció helyesítésére / kijavítására.
- Mit tanultam meg: Az golden ratio rajzolásánál megtanultam, hogy a konzolkarakter kb. kétszer olyan magas, mint széles, ezért a magasságot szélesség / phi / 2 alapján számoljuk.