using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Collection
{
    class Program
    {
        static void Main()
        {
            RegionInfo region = RegionInfo.CurrentRegion;

            Console.WriteLine($"Region Name : {region.CurrencyEnglishName}");
            Console.WriteLine($"Native Name : {region.CurrencyNativeName}");
            Console.WriteLine($"Symbol : {region.CurrencySymbol}");

            string[] week = CultureInfo.CurrentCulture.DateTimeFormat.DayNames;

            foreach(string days in week)
            {
                Console.WriteLine(days);
            }

            Console.WriteLine(new string('-', 35));

            week = CultureInfo.GetCultureInfo("en-US").DateTimeFormat.DayNames;

            Console.WriteLine("Дни недели на английском:");
            foreach(string days in week)
            {
                Console.WriteLine(days);
            }

            Console.WriteLine(new string('-', 35));

            week = CultureInfo.GetCultureInfo("de-De").DateTimeFormat.DayNames;

            Console.WriteLine("Дни недели на немецком:");
            foreach (string days in week)
            {
                Console.WriteLine(days);
            }

            Console.WriteLine(new string('-', 35));

            week = CultureInfo.GetCultureInfo("kk-KZ").DateTimeFormat.DayNames;

            Console.WriteLine("Дни недели на казахском:");
            foreach (string days in week)
            {
                Console.WriteLine(days);
            }

            double money = 144.48;

            var america = new CultureInfo("en-US");
            var germany = new CultureInfo("de-DE");
            var kazahstan = new CultureInfo("kk-KZ");

            string localMoney = money.ToString("C", america);
            Console.WriteLine($"Деньги США : {localMoney}");

            localMoney = money.ToString("C", germany);
            Console.WriteLine($"Деньги Германии : {localMoney}");

            localMoney = money.ToString("C", kazahstan);
            Console.WriteLine($"Деньги Казахстана : {localMoney}");

            //d Определяет символы цифр.
            //D Определяет любой символ, который не является цифрой.
            //w Определяет любой символ цифры, буквы или подчеркивания.
            //W Определяет любой символ, который не является цифрой, буквой или подчеркиванием.
            //s Определяет любой непечатный символ, включая пробел. 
            //S Определяет любой символ, кроме символов табуляции, новой строки и возврата каретки.
            //. Определяет любой символ кроме символа новой строки.
            //\. Определяет символ точки.

            string dog = @"\d";

            var regex = new Regex(dog);

            while (true)
            {
                string str = Console.ReadKey().KeyChar.ToString();

                if (str == " ")
                    break;

                if (regex.IsMatch(str))
                {
                    Console.WriteLine(" Собака нашла");
                }
                else
                {
                    Console.WriteLine(" Собака не нашла");
                }
            }


            Console.ReadKey();
        }
    }
}
