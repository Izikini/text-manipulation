//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

class Program
{
 
    static void zadanie1()
    {
        Console.WriteLine("Prosze o wpisanie dowolnego zdania");
        string sentence = Console.ReadLine();
        Console.WriteLine(sentence.Length + "- Dlugosc zdania\n");
        Console.WriteLine(sentence.ToUpper() + "- Tekst sylko duzymi");
        Console.WriteLine(sentence.ToLower() + "- Tekst sylko malymi");
    }

    static void zadanie2()
    {
        Console.WriteLine("Podaj tekst:");
        string sentence = Console.ReadLine();
        Console.WriteLine("Wpisałeś: " + sentence.Trim());
        Console.WriteLine("Długość: " + sentence.Trim().Length);
        string firstLetter = sentence.Trim().Substring(0, 1);
        Console.WriteLine("Pierwsza litera:" + firstLetter);
        string lastLetter = sentence.Substring(sentence.Length - 1, 1);
        Console.WriteLine("Ostatnia litera:" + lastLetter);
    }
    static void zadanie3()
    {
        Console.WriteLine("Podaj tekst :");
        string tekst = Console.ReadLine();
        Console.WriteLine("Podaj znak do wyszukiwania");
        char znak = Console.ReadLine()[0];

        int wystapienia = 0;
        for (int i = 0; i < tekst.Length; i++)
        {
            if (tekst[i] == znak)
            {
                wystapienia++;
            }
        }
        Console.WriteLine($"Znak {znak} wystepuje w tekscie {wystapienia} razy.");
    }
    static void zadanie4()
    {
        Console.WriteLine("Podaj zdanie :");
        string sentence = Console.ReadLine();
        Console.WriteLine("Podaj znak za ktory chcesz zamiec spacje");
        string znak = Console.ReadLine();
        Console.WriteLine("Podaj znak ktory chcesz zamienic w zdaniu");
        string znak2 = Console.ReadLine();
        Console.WriteLine("Podaj znak ktory chcesz zamienic w zdaniu");
        string znak3 = Console.ReadLine();
        sentence = sentence.Replace(" ", znak);
        Console.WriteLine("Zdanie po zmianie spacji: " + sentence);
        sentence = sentence.Replace(znak3, znak2);
        Console.WriteLine("Zdanie po zamianie znaku: " + sentence);
    }
    static void zadanie5()
    {
        Console.WriteLine("Podaj teks:");
        string tekst = Console.ReadLine();

        for (int i = tekst.Length - 1; i >= 0; i--)
        {

            Console.Write(tekst[i]);

        }
    }
    static void zadanie6()
    {
        Console.WriteLine("Podaj teks:");
        string tekst = Console.ReadLine().ToLower().Replace(" ", "");

        string naodwrot = "";

        for (int i = tekst.Length - 1; i >= 0; i--)
        {
            naodwrot += tekst[i];
        }

        if (tekst == naodwrot)
        {
            Console.WriteLine("Tekst jest palindromem");
        }
        else
        {
            Console.WriteLine("Tekst nie jest palindromem");
        }
    }
    static void zadanie7()
    {
        Console.WriteLine("Podaj teks:");
        string tekst = Console.ReadLine();
        string[] tekst_words = tekst.Split(' ');
        int ilosc_slow = 0;
        for (int i = 0; i < tekst_words.Length; i++)
        {
            tekst_words[i].Trim();
            ilosc_slow++;
        }
        Console.WriteLine("Ilosc slow w tekscie: " + ilosc_slow);

    }
    static void zadanie8()
    {
        Console.WriteLine("Podaj teks:");
        string[] tekst = Console.ReadLine().Split(' ');
        string skrot = "";
        foreach (string word in tekst)
        {
            word.Trim();
            if (word == "of")
            {
                word.Replace("of", "");
            }
            else
            {
                skrot = skrot + word[0];
            }

        }
        Console.WriteLine("Skrót to: " + skrot.ToUpper());
    }
    static void zadanie9()
    {
        Console.WriteLine("Podaj mail:");
        string tekst = Console.ReadLine();
        int index = tekst.IndexOf('@');
        string domena = tekst.Substring(index + 1);
        Console.WriteLine("Domena to: " + domena);
    }
    static void zadanie10()
    {
        Console.WriteLine("Podaj zdanie:");
        string tekst = Console.ReadLine();
        Console.WriteLine("Podaj slowa zakazane. Oddziel je pojedyncza spacja.:");
        string[] zakazane_slowa = Console.ReadLine().Split(' ');
        string nowy_tekst = tekst;
        foreach (string zakazane in zakazane_slowa)
        {
            if (nowy_tekst.ToLower().Contains(zakazane))
            {
                nowy_tekst = nowy_tekst.Replace(zakazane, "***", StringComparison.OrdinalIgnoreCase);

            }
        }
        Console.WriteLine("Tekst po cenzurze:" + nowy_tekst);

    }
    static void zadanie11()
    {
        Console.WriteLine("podaj tekst z liczbami");
        string tekst = Console.ReadLine();
        string[] liczby_slownie = new string[] { "zero", "jeden", "dwa", "trzy", "cztery", "piec", "szesc", "siedem", "osiem", "dziewiec" };
        string[] liczby_cyfrowo = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        for (int i = 0; i < liczby_cyfrowo.Length; i++)
        {
            if (tekst.Contains(liczby_cyfrowo[i]))
            {
                tekst = tekst.Replace(liczby_cyfrowo[i], liczby_slownie[i]);
            }
        }
        Console.WriteLine("Tekst po zamianie liczb słownie na cyfry: " + tekst);
    }
    static void zadanie12()
    {
        Console.WriteLine("Wpisz tu tekst lub artykul");
        string tekst = Console.ReadLine();
        Console.WriteLine("Podaj slowo ktorego index potrzebujesz");
        string slowo = Console.ReadLine();
        if (tekst.Contains(slowo))
        {
            Console.WriteLine(tekst.IndexOf(slowo));
        }
        else
        {
            Console.Write("Slowo nie istnieje w tym tekscie");
        }
    }
    static void zadanie13()
    {
        Console.WriteLine("Podaj imie i nazwisko");
        string tekst = Console.ReadLine();
        tekst = tekst.Trim();
        string[] imie_nazwisko = tekst.Split(' ');
        string imie = imie_nazwisko[0];
        string nazwisko = imie_nazwisko[1];
        string imiePoprawne = char.ToUpper(imie[0]) + (imie.Substring(1).ToLower());
        string nazwiskoPoprawne = char.ToUpper(nazwisko[0]) + (nazwisko.Substring(1).ToLower());
        imie_nazwisko[0] = imiePoprawne;
        imie_nazwisko[1] = nazwiskoPoprawne;
        Console.WriteLine($"Poprawiona wersja to:{imie_nazwisko[0]} {imie_nazwisko[1]} ");
       
    }
    static void zadanie14()
    {
        Console.WriteLine("Podaj tekst");
        string tekst = Console.ReadLine();
        string sponge_tekst = "";
        for (int i = 0; i < tekst.Length; i++)
        {
            if (i % 2 == 0)
            {
                sponge_tekst += tekst[i].ToString().ToLower();
            }
            else if (i % 2 == 1)
            {
                sponge_tekst += tekst[i].ToString().ToUpper();
            }

        }
        Console.WriteLine(sponge_tekst);
    }
    static void Main(string[] args)
    {
        //zadanie1();
        //zadanie2();
        //zadanie3();
        //zadanie4();
        //zadanie5();
        //zadanie6();
        //zadanie7();
        //zadanie8();
        //zadanie9();
        zadanie14();
    }
}