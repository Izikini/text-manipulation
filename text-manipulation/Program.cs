//zadanie 5
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

Console.WriteLine("Podaj mail:");
string tekst  = Console.ReadLine();
int index = tekst.IndexOf('@');
string domena = tekst.Substring(index + 1);
Console.WriteLine("Domena to: " + domena);