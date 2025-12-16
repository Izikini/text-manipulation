//Zadanie 2

Console.WriteLine("Podaj tekst:");
string sentence = Console.ReadLine();
Console.WriteLine("Wpisałeś: "+ sentence.Trim());
Console.WriteLine("Długość: " + sentence.Trim().Length);
string firstLetter = sentence.Trim().Substring(0, 1);
Console.WriteLine("Pierwsza litera:" + firstLetter);
string lastLetter = sentence.Substring(sentence.Length - 1, 1);
Console.WriteLine("Ostatnia litera:" + lastLetter);