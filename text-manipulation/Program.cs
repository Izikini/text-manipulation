//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

Console.WriteLine("Podaj zdanie:");
string tekst = Console.ReadLine();
Console.WriteLine("Podaj zakazane slowo:");
string zakazane_slowo = Console.ReadLine().ToLower();


if (tekst.ToLower().Contains(zakazane_slowo))
{
    tekst = tekst.Replace(zakazane_slowo, "***", StringComparison.OrdinalIgnoreCase);
    Console.WriteLine("Nowy tekst: " + tekst);
}