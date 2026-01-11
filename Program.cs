using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");
            //Console.WriteLine("***** Yemek Katogoriler *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Katogoriler *****");

            #endregion


            #region String_Değişkenler 

            //string
            //Değişken_türü Değişken_adı;

            //string name;
            //name = "Mustafa";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail,district,city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri :" + customerName + " " + customerSurname );
            //Console.WriteLine("İletişim :" + customerPhone );
            //Console.WriteLine("Email Adresi :" + customerEmail);
            //Console.WriteLine("Adres :" + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");



            #endregion

            #region Int Değişkenler 

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fİyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----:Pizza " + pizzaPrice + "TL");
            Console.WriteLine("----Kola: " + cokePrice + "Tl" );
            Console.WriteLine("----Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----Kızartma : " + friesPrice + "TL" );
            Console.WriteLine("----Su: " +  waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fİyatı ****");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount*hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount*waterPrice;
            totalPizzaPrice= pizzaCount*pizzaPrice;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalFriesPrice = friesCount * friesPrice;
                




            Console.WriteLine("------------------------------");
            Console.WriteLine("Hamburger Tutarı :" + totalHamburgerPrice + "Tl");
            Console.WriteLine("Pizza Tutarı :" + totalPizzaPrice + "Tl");
            Console.WriteLine("Kızartma  Tutarı :" + totalFriesPrice + "Tl");
            Console.WriteLine("Kola Tutarı :" + totalCokePrice + "Tl");
            Console.WriteLine("Limonata Tutarı :" + totalLemonadePrice + "Tl");
            Console.WriteLine("Su Tutarı :" + totalWaterPrice + "Tl");
            Console.WriteLine();
            int totalPrice = totalCokePrice + totalFriesPrice + totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice; ;
            Console.WriteLine("Toplam Ödenecek Tutar :" + totalPrice + "TL");








            #endregion





            Console.Read();

        }
    }
}
