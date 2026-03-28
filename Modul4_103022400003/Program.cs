using Modul4_103022400003;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Kode Paket: ");
        Console.WriteLine("Basic -> " + KodePaket.getKodePaket("Basic"));
        Console.WriteLine("Standard -> " + KodePaket.getKodePaket("Standard"));
        Console.WriteLine("Premium -> " + KodePaket.getKodePaket("Premium"));
        Console.WriteLine("Unlimited -> " + KodePaket.getKodePaket("Unlimited"));
        Console.WriteLine("Gaming -> " + KodePaket.getKodePaket("Gaming"));
        Console.WriteLine("Streaming -> " + KodePaket.getKodePaket("Streaming"));
        Console.WriteLine("Family -> " + KodePaket.getKodePaket("Family"));
        Console.WriteLine("Business -> " + KodePaket.getKodePaket("Business"));
        Console.WriteLine("Student -> " + KodePaket.getKodePaket("Student"));
        Console.WriteLine("Traveler -> " + KodePaket.getKodePaket("Traveler"));

        Console.WriteLine();
        MesinKopi.Run();
    }
}