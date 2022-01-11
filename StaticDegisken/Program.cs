using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegisken
{
    class Program
    {
        static void Main(string[] args)
        {
            /////1.yöntem/////
            //Personel P2 = new Personel();
            //P2.personelID = 1;
            //P2.Ad = "Dilara";
            //P2.Soyad = "İzibüyük";
            //Personel.maas = 50000;
            //Console.WriteLine("Personel ID'si:"+P2.personelID);
            //Console.WriteLine("Personel Adı:" + P2.Ad);
            //Console.WriteLine("Personel Soyad:" + P2.Soyad);
            //Console.WriteLine("Personel Maaş:" + Personel.maas);


            ////////2.yöntem:prop ile///////////
            Personel P2 = new Personel();
            P2.personelID = 1;
            P2.Ad = "Dilara";
            P2.Soyad = "İzibüyük";
            Personel.Maas = 50000;
            Console.WriteLine("Personel ID'si:" + P2.personelID);
            Console.WriteLine("Personel Adı:" + P2.Ad);
            Console.WriteLine("Personel Soyad:" + P2.Soyad);
            Console.WriteLine("Personel Maaş:" + Personel.Maas);




            Console.ReadLine();


        }
    }
}
