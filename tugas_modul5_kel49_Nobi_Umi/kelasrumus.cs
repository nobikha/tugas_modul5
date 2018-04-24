using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_modul5_kel49_Nobi_Umi
{
    class kelasrumus
    {
        public double persen10(int uang, int bulan)
        {
            return uang + (uang * bulan * 0.1);
        }
        public double persen20(int uang, int bulan)
        {
            return uang + (uang * bulan * 0.2);
        }
    }
}
