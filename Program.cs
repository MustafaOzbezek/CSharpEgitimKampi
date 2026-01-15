using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Mod İşlemler


            //int number;
            //number = 26;
            //Int result = number % 5;
            //Console.WriteLine(result);

            Console.Write("Lütfen 1.sayıyı giriniz: ");
            int number1=int.Parse(Console.ReadLine());


            Console.Write("Lütfen 2.sayıyı giriniz: ");
            int number2=int.Parse(Console.ReadLine());

            int result = number1 % number2;
            Console.Write("1. Sayının 2. sayıya bölüünden kalan :" + result);



            #endregion


            Console.Read();
        }
    }
}
