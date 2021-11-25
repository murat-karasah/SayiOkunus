using System;

namespace ConsoleApp5
{
    class Program
    {
        public static string sayi,bir,onsayi,yuzsayi;
        public static string[] dizi;
        public static char sayi1, sayi2, sayi3;


        static void Main(string[] args)
        {
            Console.WriteLine("1-999 arası bir sayı giriniz:");
            sayi = Console.ReadLine();
            char[] dizi = sayi.ToCharArray();
            int uzunluk = dizi.Length;
            if (uzunluk==1)
            {
                 sayi1 = dizi[0];

                Console.WriteLine("Okunuşu : " + birler(bir));
                Main(null);
            }
            if (uzunluk==2)
            {
                sayi1 = dizi[1];
                sayi2 = dizi[0];
                if (sayi1=='0')
                {
                    Console.WriteLine("Okunuşu :" + onlar(onsayi) );
                    Main(null);
                }
                else
                {
                    Console.WriteLine("Okunuşu :" + onlar(onsayi) + birler(bir));
                    Main(null);
                }
            }
            if (uzunluk==3)
            {
                sayi1 = dizi[2];
                sayi2 = dizi[1];
                sayi3 = dizi[0];
                yuzler(yuzsayi);
                if (sayi1 == '0')
                {
                    if (sayi1 == '0' && sayi2 == '0')
                    {
                        Console.WriteLine("Okunuşu :" + yuzler(yuzsayi)); Main(null);
                    }
                    Console.WriteLine("Okunuşu :" + yuzler(yuzsayi) + onlar(onsayi)); Main(null);
                }
                   else
                {
                    Console.WriteLine("Okunuşu :" + yuzler(yuzsayi) + onlar(onsayi) + birler(bir)); Main(null);

                }
            }
        }

        private static string yuzler(string yuzsayi)
        {
            switch (sayi3)
            {
                case '1': yuzsayi = "yüz";      break;
                case '2': yuzsayi = "ikiyüz";   break;
                case '3': yuzsayi = "üçyüz";    break;
                case '4': yuzsayi = "dörtyüz";  break;
                case '5': yuzsayi = "beşyüz";   break;
                case '6': yuzsayi = "altıyüz";  break;
                case '7': yuzsayi = "yediyüz";  break;
                case '8': yuzsayi = "sekizyüz"; break;
                case '9': yuzsayi = "dokuzyüz"; break;
                default:
                    break;
            }
            return yuzsayi;
        }
    

        private static string onlar(string onsayi)
        {
            switch (sayi2)
            {
                case '1':
                    onsayi = "on";
                    break;

                case '2':
                    onsayi = "yrmi";

                    break;

                case '3':
                    onsayi = "otuz";

                    break;

                case '4':
                    onsayi = "kırk";

                    break;

                case '5':
                    onsayi = "elli";

                    break;

                case '6':
                    onsayi = "atmış";

                    break;

                case '7':
                    onsayi = "yetmiş";

                    break;

                case '8':
                    onsayi = "seksen";

                    break;

                case '9':
                    onsayi = "doksan";

                    break;

                case '0':
                    onsayi = "sıfır";

                    break;
                default:
                    break;
            }
            return onsayi;
        }
    

        private static string birler(string bir)
        {
            switch (sayi1)
            {
                case '1':
                    bir="bir";
                         break;

                case '2':
                    bir = "iki";

                    break;

                case '3':
                    bir = "üç";

                    break;

                case '4':
                    bir = "dört";

                    break;

                case '5':
                    bir = "beş";

                    break;

                case '6':
                    bir = "altı";

                    break;

                case '7':
                    bir = "yedi";

                    break;

                case '8':
                    bir = "sekiz";

                    break;

                case '9':
                    bir = "dokuz";

                    break;

                case '0':
                    bir = "sıfır";

                    break;
                default:
                    break;
            }
            return  bir;
        }

    }
}
