using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsulOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Araba obje = new Araba("Audi","a3","Kırmızı",1);//obje ile Araba sınıfından verilere erişerek değer atıyoruz.

            obje.bilgi();//bilgi metodu ile arabanın ozelliklerini cağırıyoruz.

            Console.ReadLine();
        }
    }
}
