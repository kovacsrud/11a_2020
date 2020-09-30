# OOP - Objektum-orientált programozás

Struktúrált programozás - utasítások, elágazások, ciklusok, függvények. -> Egy adott bonyolultság felett, már nem elegendő.

1990-es évek közepe -> Windows 95 megjelenése - egyre bonyolultabb programok.

A mai programok nagy méretű osztálykönyvtárakon alapulnak. Ezek gyakorlatilag újrafelhasználható forráskódok. 
Java, C# , Python, Android

Objektum - osztály

Az objektum a programban egy futó folyamat, vagy éppen egy megjeleníthető elem pl. gomb lehet. Minden objektumnak van egy terve, ez az osztály(class). A terv alapján számos objektumot (példányt) lehet egy programban létrehozni. 

Az osztály két fajta dolgot tartalmazhat:
-tulajdonságok (ezek gyakorlatilag adatok, másképpen mondva: változók)
-metódusok (ezek gyakorlatilag függvények) ezek határozzák meg, hogy az objektum mit tud majd megcsinálni.

Az egymással összezárt adatok és metódusok jelentik az osztályt.

Példa:

Osztály
Tanulo
----------
Nev

Magassag

Suly

Szuletesi Ev

Anyja Neve

----
Tanul()

Pihen()

Eszik()

Alszik()
-------------

példány:
Kiss Ubul

180

70

2001

Nagy Éva


Az osztály egy jól körülhatárolható egység. Az adatait és a metódusait magába zárja, és a külvilág felé csak az lesz látható, ami szükséges.

```c#
public class Tanulo
    {
        public string nev;
        public int magassag;
        public int suly;
        public int szulev;
        public string anyjaNeve;




    }
```
