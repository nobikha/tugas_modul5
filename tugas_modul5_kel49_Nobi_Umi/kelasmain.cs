using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tugas_modul5_kel49_Nobi_Umi
{
    class kelasmain
    {
        static void Main(string[] args)
        {
            kelasoutput baca = new kelasoutput();
            baca.awal();
            kelasinput masuk = new kelasinput();
            float uang, lama;
            string input;
            Console.Write("|Jumlah uang yang ditabung    : Rp. ");
            input = Console.ReadLine();
            float.TryParse(input, out uang);
            Console.Write("|===============================================\n");
            Console.Write("|Lama Anda menabung (bulan)   : ");
            input = Console.ReadLine();
            float.TryParse(input, out lama);
            Console.Write("|===============================================\n\n");
            if (uang <= 1000000)
            {
                int bulan;

                for (bulan = 1; bulan <= lama; bulan++)
                {
                    kelasrumus rumus = new kelasrumus();
                    double total = rumus.persen10(uang, bulan);
                    kelasoutput perulangan = new kelasoutput();
                    Console.WriteLine(perulangan.ulang(bulan, total));
                }

                kelasoutput output = new kelasoutput();
                output.persen10(uang, lama);
                output.akhir();
            }
            else
            {
                int bulan;
                for (bulan = 1; bulan <= lama; bulan++)
                {
                    kelasrumus rumus = new kelasrumus();
                    double total = rumus.persen20(uang, bulan);
                    kelasoutput perulangan = new kelasoutput();
                    Console.WriteLine(perulangan.ulang(bulan, total));
                }

                kelasoutput output = new kelasoutput();
                output.persen20(uang, lama);
                output.akhir();
            }
            Console.ReadLine();
        }
    }
}

