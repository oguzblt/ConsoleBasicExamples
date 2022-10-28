using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExamples
{
    internal class Uygulamalar
    {
        public static void CarpımTablosu()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("{0}X{1} = {2}", i, j, i*j);
                }
            }
        }
        public static void AlfabeYazirma()
        {
            char i;
            for (i = 'a'; i <= 'z'; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ToplamaIslemi() // programdan çıkış yapılana kadar toplama işlemi..
        {
            int toplam = 0;
            int exit = 0;
            for (int i = 0; ; i++)
            {
                Console.Write("Toplanacak sayıyı gir (çıkış yapmak için '0' tuşla): ");
                i = Convert.ToInt32(Console.ReadLine());
                if (i == exit)
                {
                    Console.WriteLine("Çıkış Yapıldı.");
                    break;
                }
                else
                {
                    Console.Write("{0}+{1}", toplam, i);
                    toplam = toplam + i;
                    Console.WriteLine(" = "+ toplam);
                }
            }

        }
        public static void YildizYapimi()
        {
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void TekÇiftIslem() // tek sayıları çıkartan, çift sayıları toplayan..
        {
            int toplam = 0;
            int sayi = 0;
            while (true)
            {
                Console.Write("Bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == 0)
                {
                    Console.WriteLine("Çıkış yapıldı..");
                    break;
                }
                else if (sayi %2 == 0)
                {
                    toplam = toplam + sayi;
                    Console.WriteLine("Sonuç: "+ toplam);
                }
                else
                {
                    toplam = toplam- sayi;
                    Console.WriteLine("Sonuç: " + toplam);
                }
            }
        }
        public static void TekCiftBulma() // girilen 2 sayı arasındaki tek çift sayıları bulan..
        {
            Console.Write("Başlangıç sayısını giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş sayısını giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i = sayi1; i < sayi2; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine("Tek sayı. " + i);
                else
                    Console.WriteLine("Çift sayı." + i);
            }
        }
        public static void SayiTahminOyunu()
        {
            Random rnd = new Random();
            int tahmin = rnd.Next(20);
            int sayi = 0;
            int sayac = 0;
            while (true)
            {
                Console.Write("Tahmin sayınızı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi == tahmin)
                {
                    sayac++;
                    Console.WriteLine("Tebrikler doğru tahmin. {0} tekrarda cevaba ulaştınız", sayac);
                    break;
                }
                else if (sayi > tahmin)
                {
                    sayac++;
                    Console.WriteLine("Sayınız yüksek. Tekrar Deneyin!!");
                }
                else
                {
                    sayac++;
                    Console.WriteLine("Sayınız düşük. Tekrar Deneyin!!");
                }

            }
        }
        public static void VizeFinalHesaplama()
        {
            Console.Write("vize notu giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("final notu giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());
            double ort = (vize*0.4) + (final*0.6);

            if (ort > 84)
            {
                Console.WriteLine("Tebrikler Dersten Geçtiniz!!" + "Ders ortalamanız: " + ort + " Ders Notu: A");
            }
            else if (ort >69)
            {
                Console.WriteLine("Tebrikler Dersten Geçtiniz!!" + "Ders ortalamanız: " + ort + " Ders Notu: B");
            }
            else if (ort > 59)
            {
                Console.WriteLine("Tebrikler Dersten Geçtiniz!!" + "Ders ortalamanız: " + ort + " Ders Notu: C");
            }
            else if (ort > 49)
            {
                Console.WriteLine("Tebrikler Dersten Geçtiniz!!" + "Ders ortalamanız: " + ort + " Ders Notu: D");
            }
            else
            {
                Console.WriteLine("Dersten Kaldınız!!" + "Ders ortalamanız: " + ort);
            }
        }
        public static void GirilenKarakteriBulan()
        {
            Console.WriteLine("Bir tuşa basınız: ");
            System.ConsoleKeyInfo KeyInfo = Console.ReadKey();
            Console.WriteLine("Basılan Tuş= " + KeyInfo.Key.ToString());
        }
        public static void CemberAlanCevre()
        {
            const double pi = Math.PI;
            Console.Write("Yarıçap Giriniz: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            double alan = (pi * (yaricap * yaricap));
            double cevre = (2 * pi * yaricap);
            Console.WriteLine("Çemberin Alanı: " + alan);
            Console.WriteLine("Çemberin çevresi: " + cevre);
            Console.ReadKey();
        }
        public static void HesapMakinesi()
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir işlem seçin (topla, cikar, carp, bol): ");
            string islem = Console.ReadLine();
            if (islem == "topla")
            {
                Console.WriteLine("İşlemin sonucu: " + (sayi1 + sayi2));
            }
            else if (islem == "cikar")
            {
                Console.WriteLine("İşlemin sonucu: " + (sayi1 - sayi2));
            }
            else if (islem == "carp")
            {
                Console.WriteLine("İşlemin sonucu: " + (sayi1 * sayi2));
            }
            else if (islem == "bol")
            {
                Console.WriteLine("İşlemin sonucu: " + (sayi1/sayi2));
            }
            else
            {
                Console.WriteLine("Hatalı işlem seçtiniz.");
            }
        } // if else yapısı kullanılarak yapılan hesap makinesi..
       
    }
}
