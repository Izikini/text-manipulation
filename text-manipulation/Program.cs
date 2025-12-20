//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

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
