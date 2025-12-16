//Zadanie 3

Console.WriteLine("Podaj zdanie :");
string sentence = Console.ReadLine();
Console.WriteLine("Podaj znak za ktory chcesz zamiec spacje");
string znak = Console.ReadLine();
sentence = sentence.Replace(" ", znak);
Console.WriteLine("Zdanie po zmianie spacji: "+sentence);