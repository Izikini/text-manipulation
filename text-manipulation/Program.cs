//Zadanie 3

Console.WriteLine("Podaj zdanie :");
string sentence = Console.ReadLine();
Console.WriteLine("Podaj znak za ktory chcesz zamiec spacje");
string znak = Console.ReadLine();
Console.WriteLine("Podaj znak ktory chcesz zamienic w zdaniu");
string znak2 = Console.ReadLine();
Console.WriteLine("Podaj znak ktory chcesz zamienic w zdaniu");
string znak3 = Console.ReadLine();
sentence = sentence.Replace(" ", znak);
Console.WriteLine("Zdanie po zmianie spacji: "+sentence);
sentence = sentence.Replace(znak3, znak2);
Console.WriteLine("Zdanie po zamianie znaku: "+sentence);