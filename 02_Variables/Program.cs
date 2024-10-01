using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //////double number;
            //////number = 2.45;
            //////Console.WriteLine(number);
            //////Console.Read();

            //////gramajları olan meyve sebze ekranı 

            //////Console.WriteLine("***** Fiyat Listesi *****");
            //////Console.WriteLine();

            //////double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //////applePrice = 14.85;
            //////orangePrice = 20.95;
            //////strawberryPrice = 45;
            //////potatoPrice = 50.16;
            //////tomatoPrice = 19.90;
            //////Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //////Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //////Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //////Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //////Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");
            //////double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //////appleGram = 1.245;
            //////orangeGram = 2.452   ;
            //////strawberryGram = 3.694  ;
            //////potatoGram = 0.750 ;
            //////tomatoGram =3.555 ;
            //////double appleTotalPrice = appleGram * applePrice;
            //////double orangeTotalPrice = orangeGram * orangePrice; 
            //////double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //////double potatoTotalPrice = potatoGram * potatoPrice;
            //////double tomatoTotalPrice = tomatoGram * tomatoPrice; 

            //////Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            //////Console.WriteLine("Alınan Ürün : Elma -  " + "Birim Fiyatı : " + applePrice + " - Gramaj : "  + appleGram + "- Toplam Tutar : " + appleTotalPrice + " TL");
            //////Console.WriteLine("Alınan Ürün : Portakal -  " + "Birim Fiyatı : " + orangePrice + " - Gramaj : "  + orangeGram + "- Toplam Tutar : " + orangeTotalPrice + " TL");
            //////Console.WriteLine("Alınan Ürün : Çilek -  " + "Birim Fiyatı : " + strawberryPrice + " - Gramaj : "  + strawberryGram + "- Toplam Tutar : " + strawberryTotalPrice + " TL");
            //////Console.WriteLine("Alınan Ürün : Patates -  " + "Birim Fiyatı : " + potatoPrice  + " - Gramaj : "  + potatoGram + "- Toplam Tutar : " + potatoTotalPrice + " TL");
            //////Console.WriteLine("Alınan Ürün : Domates -  " + "Birim Fiyatı : " + tomatoPrice + " - Gramaj : "  + tomatoGram + "- Toplam Tutar : " + tomatoTotalPrice + " TL");

            //////double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice ;
            //////Console.WriteLine("");
            //////Console.WriteLine ("Toplam Alışveriş Fiyatı : " + shoppingTotalPrice  + " TL");
            //////Console.Read();



            #endregion
            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler


            //Console.WriteLine("***** C# Hava Yolları Yolcu Bİlgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName= Console.ReadLine();
            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname= Console.ReadLine();   
            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaşı : ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC : ");
            //passengerIdentityNumber = Console.ReadLine();









            //Console.WriteLine();
            //Console.WriteLine("--------------");
            //Console.WriteLine("Yolcu Ad : " + passengerName + " / " + "Yolcu Soyad : " + passengerSurname +  " / " +  "Yolcu İlçe :  " + passengerDistrict + " / "  +  " Yolcu İl :  " + passengerCity + "/ " + " Yolcu Yaşı : " + passengerAge + " / " + "Yolcu TC No : " + passengerIdentityNumber);




            #endregion
            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler


            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödeme Tutarı : " + totalPrice);












            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen 1. Sınav Notunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav Notunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ders Ortalaması :" + result);






            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz :");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            //#endregion
            //Console.Read();
            #endregion
        }

    }
}
