partial class Program
{
    static int[] ReadNumbers(uint numarElemente)
    {
        Console.WriteLine($"Introduceti cele {numarElemente} numere");
        var numereRaw=Console.ReadLine()?.Split(" ");
        if (numereRaw?.Length != numarElemente)
        {
            Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
            return ReadNumbers(numarElemente);
        }
        var numere= new int[numarElemente];
        for(int i = 0; i < numarElemente; i++)
        {
            if (!int.TryParse(numereRaw?[i],out numere[i]))
            {
                Console.WriteLine("Nu ati introdus datele in format valid, mai incercati");
                return ReadNumbers(numarElemente);
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