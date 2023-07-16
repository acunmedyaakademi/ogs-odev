using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogs_ödev
{

    class Gelir
    {
        public string gelirAdi { get; set; }

        public double kdvTutarı { get; set; }

        public double gelirTutarı { get; set; }


        public Gelir(string gelirAdi, double kdvTutarı, double gelirTutarı)
        {
            gelirAdi = gelirAdi;

            kdvTutarı = kdvTutarı;

            gelirTutarı = gelirTutarı;
        }


        internal class versıon_2
        {
            static List<Gelir> giderListesi = new List<Gelir>();
        }


    }

}