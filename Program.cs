using System;

//using System.Collections.Generic;

//class KodePos
//{
//    private Dictionary<string, string> kodePosTable = new Dictionary<string, string>
//    {
//        { "Batununggal", "40266" },
//        { "Kujangsari", "40287" },
//        { "Mengger", "40267" },
//        { "Wates", "40256" },
//        { "Cijaura", "40287" },
//        { "Jatisari", "40286" },
//        { "Margasari", "40286" },
//        { "Sekejati", "40286" },
//        { "Kebonwaru", "40272" },
//        { "Maleer", "40274" },
//        { "Samoja", "40273" }
//    };

//    public string GetKodePos(string kelurahan)
//    {
//        if (kodePosTable.ContainsKey(kelurahan))
//        {
//            return kodePosTable[kelurahan];
//        }
//        else
//        {
//            return "Kode pos tidak ditemukan";
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        KodePos kodePos = new KodePos();

//        Console.Write("Masukkan nama kelurahan: ");
//        string kelurahan = Console.ReadLine();

//        string kode = kodePos.GetKodePos(kelurahan);
//        Console.WriteLine($"Kode Pos untuk {kelurahan} adalah {kode}");
//    }
//}


public enum DoorState
{
    Terkunci,
    Terbuka
}

public class DoorMachine
{
    private DoorState state;

    public DoorMachine()
    {
        // State awal adalah terkunci
        state = DoorState.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void BukaPintu()
    {
        if (state == DoorState.Terkunci)
        {
            state = DoorState.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terbuka");
        }
    }

    public void KunciPintu()
    {
        if (state == DoorState.Terbuka)
        {
            state = DoorState.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu sudah terkunci");
        }
    }
}

class Program
{
    static void Main()
    {
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();  
        pintu.KunciPintu(); 
        pintu.KunciPintu(); 
        pintu.BukaPintu();  
    }
}


