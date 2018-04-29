using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul5_kel49_Nobi_Umi
{
    class kelasoutput
    {
        public void awal()
        {
            Console.Write("|===============================================|\n");
            Console.Write("|                  KELOMPOK 49                  |\n");
            Console.Write("|        Nobi Kharisma  (21120117130048)        |\n");
            Console.Write("|        Umi Khoiryatin (21120117120005)        |\n");
            Console.Write("|===============================================|\n\n");
            Console.Write("|===============================================|\n");
            Console.Write("|           Selamat Datang  di Bank49           |\n");
            Console.Write("|===============================================|\n\n");
            Console.Write("|===============================================\n");
        }
        public void akhir()
        {
            Console.Write("\n|================================================\n\n");
            Console.Write("|===============================================|\n");
            Console.Write("|     Terima kasih telah menabung di Bank49     |\n");
            Console.Write("|===============================================|\n");
        }
        public void persen10(float uang, float lama)
        {
            Console.Write("\n|================================================\n");
            Console.Write("|Jumlah uang tabungan Anda selama " + lama + " bulan adalah\n");
            Console.Write("|Rp. " + (uang + (uang * lama * 0.1)));
        }
        public void persen20(float uang, float lama)
        {
            Console.Write("\n|================================================\n");
            Console.Write("|Jumlah uang tabungan Anda selama " + lama + " bulan adalah\n");
            Console.Write("|Rp. " + (uang + (uang * lama * 0.2)));
        }
        public String ulang(float bulan, double total)
        {
            return "|Jumlah uang Anda setelah " + bulan + " bulan adalah Rp. " + total;
        }
    }
}