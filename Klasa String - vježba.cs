using System;

class Program1
{
    static void Main()
    {
        string s1 = "Hrvatska ima more";
            string s2 = "Italija je prvak svijeta";

                string s3 = s1.Substring(0, 8) + s2.Substring(6);
        
        Console.WriteLine(s3);
    }
}


class Program2
{
    static void Main()
    {
        Console.WriteLine("Unesite niz znakova:");
        string userInput = Console.ReadLine();

            string zamijenjeniRazmaci = userInput.Replace(' ', '_');
            Console.WriteLine("Niz s zamijenjenim razmacima: " + zamijenjeniRazmaci);
    }
}


class Program3
{
    static void Main()
    {
        Console.WriteLine("Unesite niz znakova:");
        string userInput = Console.ReadLine();

            string sVelika = userInput.ToUpper();
                string sMala = userInput.ToLower();
                    string sPrvaTri = userInput.Substring(0, Math.Min(3, userInput.Length));
                        string sZadnjihPet = userInput.Substring(Math.Max(0, userInput.Length - 5));
                            string s8_11 = userInput.Substring(7, Math.Min(4, userInput.Length - 7));

        Console.WriteLine("Niz u velikim slovima: " + sVelika);
            Console.WriteLine("Niz u malim slovima: " + sMala);
                Console.WriteLine("Prva tri znaka: " + sPrvaTri);
                    Console.WriteLine("Zadnjih pet znakova: " + sZadnjihPet);
                    	Console.WriteLine("Od 8. do 11. znaka: " + s8_11);
    }
}


class Program4
{
    static void Main()
    {
        Console.WriteLine("Unesite rečenicu:");

            string rečenica = Console.ReadLine();
                string[] riječi = rečenica.Split(' ');

        if (riječi.Length > 0)
        {
            Console.WriteLine("Prva riječ: " + riječi[0]);
                Console.WriteLine("Zadnja riječ: " + riječi[riječi.Length - 1]);
        }
    }
}


class Program5
{
    static void Main()
    {
        Console.WriteLine("Unesite cijeli i decimalni broj odvojene razmakom:");

        string[] unos = Console.ReadLine().Split(' ');

        if (unos.Length == 2 && int.TryParse(unos[0], out int cijeli) && double.TryParse(unos[1], out double decimalni))
        {
            Console.WriteLine($"Cijeli broj: {cijeli}");
                Console.WriteLine($"Decimalni broj: {decimalni}");
        }
            else
            {
                Console.WriteLine("Pogrešan unos.");
            }
    }
}
