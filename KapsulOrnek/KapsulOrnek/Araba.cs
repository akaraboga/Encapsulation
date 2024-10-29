using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsulOrnek
{
    internal class Araba
    {

        public string Marka { get; set; }//Public propertylerimizi tanımlıyoruz
        public string Model { get; set; }
        public string Renk { get; set; }

        private int KapıSayısı { get; set; }//Kapsulleme yapacagımız propertymizi private olarak alıyoruz


        public int kapı//Public bir property acıp içinde KapıSayısı Propertysini atayacağız
        {

            get { return KapıSayısı; }//set içinde ki işlemler bittikten sonra KapıSayısı olan private propertynın değerini return ediyoruz

            set
            {
                if (value == 2 || value == 4)//set içine kapı propertysınden gelen değer : eğer 2 veya 4 e eşitse private olan KapıSayısı propertysine gelen değeri alsın diyoruz.
                {
                    KapıSayısı = value;
                }
                else//Eğer kapı propertysine gelen değer 2 veya 4 değilse KapıSayısı Propertysi -1 olsun ve hata mesajı versin diyoruz.
                {
                    KapıSayısı = -1;
                    Console.WriteLine("Kapı sayısı sadece 2 ve 4 olabilir\n");
                }

            }

        }


        public Araba(string _Marka, string _Model, string _renk, int _Kapı)//Parametre alan Constructorumuz ile propertylerimize değer atıyoruz.
        {
            Marka = _Marka;
            Model = _Model;
            Renk = _renk;
            kapı = _Kapı;//_Kapı değişkeni ile Constructora gelen değeri al ve kapı propertysine ata diyoruz ve kapı propert 
        }


        public void bilgi()//Arabanın ozelliklerini yazdırıyoruz.
        {
            Console.WriteLine(" Arabanın markası : {0} \n modeli : {1} \n rengi : {2} \n Kapı sayısı : {3}", Marka, Model, Renk, KapıSayısı);
        }


    }




}

