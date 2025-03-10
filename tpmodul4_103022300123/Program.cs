using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nama kelurahan:");
        string kelurahan = Console.ReadLine();

        string kodePos = KodePos.GetKodePos(kelurahan);
        Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");
    }
}

