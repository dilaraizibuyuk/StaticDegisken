using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegisken
{
    class Personel
    {
        /////////1.yöntem:değişken tanımlama//////////
        //public int personelID;
        //public string Ad;
        //public string Soyad;
        //public static int maas; //static değişken


        ////////2.yöntem:prop ile///////////
        public int personelID { get; set; }
        public string Ad { get; set; }

        public string Soyad { get; set; }

        public static int Maas { get; set; } //static değişken


    }
}
