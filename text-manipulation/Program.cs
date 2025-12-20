//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

Console.WriteLine("Podaj teks:");
string[] tekst = Console.ReadLine().Split(' ');
string skrot = "";
foreach (string word in tekst)
{
    word.Trim();
    if(word == "of")
    {
        word.Replace("of", "");
    }
    else
    {
        skrot = skrot + word[0];
    }

}
Console.WriteLine("Skrót to: " + skrot.ToUpper());