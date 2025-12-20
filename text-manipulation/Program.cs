//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

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
