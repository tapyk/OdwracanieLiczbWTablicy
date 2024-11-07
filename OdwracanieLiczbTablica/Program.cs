int[] tab1;
int[] tab2;

Console.Write("Podaj rozmiar tablicy: ");
string rozmiar_str = Console.ReadLine();
if(int.TryParse(rozmiar_str, out int rozmiar))
{
    tab1 = new int[rozmiar];
    for (int i = 0; i < rozmiar; i++)
    {
        Console.Write("Podaj liczbę " + (i + 1) + ": ");
        string liczba_str = Console.ReadLine();
        if (int.TryParse(liczba_str, out int liczba))
        {
            tab1[i] = liczba;
        }
    }
    tab2 = new int[rozmiar];
    int j = 0;
    for (int i = rozmiar - 1; i >= 0; i--)
    {
        tab2 [j] = tab1[i];
        j++;
    }
    Console.Write("Tablica: [ ");
    foreach (var i in tab1)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");

    Console.Write("Tablica odwrócona: [ ");
    foreach (var i in tab2)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("]");

}