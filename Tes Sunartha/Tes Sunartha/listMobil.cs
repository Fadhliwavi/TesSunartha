using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesSunartha
{


    /* Pertanyaan:
        1. Tampilkan data pertama yang memiliki merk "Honda"
        2. Tampilkan data terakhir yang memiliki merk "Honda" dan bertipe "Sedan"
        3. Tampilkan data pertama yang memiliki merk "Honda" dan punya varian "City"
        4. Tampilkan data default yang memiliki merk "Toyota"
        5. Tampilkan 3 data apa saja
        Format tampilan : IDRegistrasi, Merk, Varian*/
    public class listMobil
    {
        public int IdRegistrasi { get; set; }
        public string Tipe { get; set; }
        public string Merk { get; set; }
        public string Varian { get; set; }

        public listMobil(int idRegistrasi, string tipe, string merk, string varian)
        {
            this.IdRegistrasi = idRegistrasi;
            this.Tipe = tipe;
            this.Merk = merk;
            this.Varian = varian;
        }

        public listMobil()
        {
        }

        public void PrintListMobil()
        {
            Console.WriteLine("\n\n\n---------------------------\n" + "Tipe\t\t\t: {0}", Tipe);
            Console.WriteLine("Merk\t\t\t: {0}", Merk);
            Console.WriteLine("Varian\t\t\t: {0}", Varian);
        }






        /*Ada 2 anak sedang bermain angka bersahutan, sebut saja anak A dan anak B, mereka 
        saling bersahutan angka mulai dari 1 hingga 500. dimulai dari anak A berteriak "1", 
        dilanjutkan anak B berteriak "2", kembali ke anak A melanjutkan teriak "3" dan 
        seterusnya. untuk membuat permainan lebih menarik salah satu dari mereka 
        mengusulkan untuk meneriakkan kata tertentu ketika mendapat giliran angka dengan 
        kategori yang mereka tentukan.
        1. "tik" jika angka merupakan kelipatan 3
        2. "tek" jika angka merupakan kelipatan 5*/

        public void No1()
        {
            int i, n, y;
            Console.WriteLine("Masukan Angka : ");
            n = Convert.ToInt32(Console.ReadLine());
            y = 1;
            i = 1;

            while (i <= n)
            {
                if(y % 3 == 0)
                {
                    Console.Write("tik");
                }
                else if( y % 5 == 0)
                {
                    Console.Write("tek");
                }
                else
                {
                    Console.Write("{0}", y);
                }
                i++;
                 
            }
        }

        public void No2()
        {
            int i, n, y;
            Console.WriteLine("Masukan Angka : ");
            n = Convert.ToInt32(Console.ReadLine());
            y = 1;
            i = 1;

            while (i <= n)
            {
                if (y % 3 == 0)
                {
                    Console.Write("tik");
                }
                else if (y % 5 == 0)
                {
                    Console.Write("tek");
                }
                else if(y % 7 == 0)
                {
                    Console.Write("tok");
                }
                else
                {
                    Console.Write("{0}", y);
                }
                i++;

            }
        }
    }

}
