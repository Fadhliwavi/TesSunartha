using TesSunartha;

using System;
using System.ComponentModel;

namespace TesSunartha
{
    class Program
    {
         static void Main(string[] args)
        {
            Console.Clear();

            listMobil listMobil = new listMobil();
            listMobil.No1();
            listMobil.No2();
        }


        public static void PrintListMobil()
        {
            listMobil listMobil = new listMobil();
            listMobil.IdRegistrasi = 0001;
            listMobil.Tipe = "Sedan";
            listMobil.Merk = "Toyota";
            listMobil.Varian = "FT86";
            Console.WriteLine(listMobil.IdRegistrasi);
            Console.WriteLine(listMobil.Tipe);
            Console.WriteLine(listMobil.Merk);
            Console.WriteLine(listMobil.Varian);
            listMobil.PrintListMobil();

            listMobil listMobil1 = new listMobil();
            listMobil.IdRegistrasi = 0002;
            listMobil.Tipe = "Suv";
            listMobil.Merk = "Toyota";
            listMobil.Varian = "Rav$";
            Console.WriteLine(listMobil.IdRegistrasi);
            Console.WriteLine(listMobil.Tipe);
            Console.WriteLine(listMobil.Merk);
            Console.WriteLine(listMobil.Varian);
            listMobil.PrintListMobil();

            listMobil listMobil2 = new listMobil();
            listMobil.IdRegistrasi = 0001;
            listMobil.Tipe = "Sedan";
            listMobil.Merk = "Honda";
            listMobil.Varian = "Accord";
            Console.WriteLine(listMobil.IdRegistrasi);
            Console.WriteLine(listMobil.Tipe);
            Console.WriteLine(listMobil.Merk);
            Console.WriteLine(listMobil.Varian);
            listMobil.PrintListMobil();

            listMobil listMobil3 = new listMobil();
            listMobil.IdRegistrasi = 0001;
            listMobil.Tipe = "Suv";
            listMobil.Merk = "Honda";
            listMobil.Varian = "FT86";
            Console.WriteLine(listMobil.IdRegistrasi);
            Console.WriteLine(listMobil.Tipe);
            Console.WriteLine(listMobil.Merk);
            Console.WriteLine(listMobil.Varian);
            listMobil.PrintListMobil();


        }

    }
}