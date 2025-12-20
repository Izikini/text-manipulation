//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.ExceptionServices;

Console.WriteLine("Podaj teks:");
string tekst = Console.ReadLine().ToLower().Replace(" ","");

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