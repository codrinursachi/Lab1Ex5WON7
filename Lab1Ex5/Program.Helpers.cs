partial class Program
{
    static int[] ReadNumbers(in uint NUMAR_ELEMENTE)
    {
        Console.WriteLine($"Introduceti cele {NUMAR_ELEMENTE} numere");
        var numereRaw=Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length != NUMAR_ELEMENTE)
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumbers(NUMAR_ELEMENTE);
        }
        var numere= new int[NUMAR_ELEMENTE];
        for(int i = 0; i < NUMAR_ELEMENTE; i++)
        {
            if (!int.TryParse(numereRaw?[i],out numere[i]))
            {
                Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                return ReadNumbers(NUMAR_ELEMENTE);
            }
        }
        return numere;
    }
    static int[] SortNumbers(int[] numere)
    {
        Array.Sort(numere);
        return numere;
    }
    static void ShowNumbers(int[] numere)
    {
        foreach(var numar in numere)
            Console.Write(numar+" ");
    }
}