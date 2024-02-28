using System;

class Program
{
    static void Main(string[] args)
    {
        int tal = 17; 

        if (ÄrPrimtal(tal))
        {
            Console.WriteLine(tal + " är ett primtal.");
        }
        else
        {
            Console.WriteLine(tal + " är inte ett primtal.");
        }
    }

    static bool ÄrPrimtal(int tal)
    {
        if (tal <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(tal); i++)
        {
            if (tal % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
