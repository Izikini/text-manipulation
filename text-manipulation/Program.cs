//Zadanie 3

Console.WriteLine("Podaj tekst :");
string tekst = Console.ReadLine();
Console.WriteLine("Podaj znak do wyszukiwania");
char znak = Console.ReadLine()[0];

int wystapienia = 0;
for(int i = 0; i < tekst.Length; i++)
{
    if (tekst[i] == znak)
    {
        wystapienia++;
    }
}
Console.WriteLine($"Znak {znak} wystepuje w tekscie {wystapienia} razy.");