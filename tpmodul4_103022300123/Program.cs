using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Masukkan nama kelurahan:");
//        string kelurahan = Console.ReadLine();

//        string kodePos = KodePos.GetKodePos(kelurahan);
//        Console.WriteLine($"Kode pos {kelurahan}: {kodePos}");

//        Console.ReadLine();
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        DoorMachine door = new DoorMachine();

        Console.WriteLine("\nTes membuka pintu:");
        door.BukaPintu();

        Console.WriteLine("\nTes mengunci pintu:");
        door.KunciPintu();

        Console.WriteLine("\nTes mengunci lagi:");
        door.KunciPintu();

        Console.ReadLine();
    }
}

