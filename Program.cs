using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alıştırma_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kullaniciSecimStr;
            ArrayList degerListesi = new ArrayList();

            do
            {
                string onaylama;
                Console.WriteLine("Menü:");
                Console.WriteLine("1 - Değer Girişi Yapınız");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle ");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama Çıkış");
                Console.Write("Seçiniz:     ");
                kullaniciSecimStr = Console.ReadLine();
                Console.Clear();

                switch (kullaniciSecimStr)
                {

                    case "1":
                        do
                        {
                            Console.Write("Değer Girişi Yapın:  ");
                            string yeniDeger = Console.ReadLine();
                            degerListesi.Add(yeniDeger);
                            Console.Clear();
                            Console.WriteLine("Değeriniz eklendi.");

                            Console.WriteLine("Yeni değer ekleyecek misiniz?");
                            Console.WriteLine("1 - Evet     2 - Hayır");
                            onaylama = Console.ReadLine();
                            Console.Clear();

                        } while (onaylama == "1");
                        break;

                    case "2":
                       
                        object[] siralamaListesi = degerListesi.ToArray();
                        foreach (object deger in siralamaListesi)
                        {
                            Console.WriteLine(deger);
                            
                        }
                        System.Threading.Thread.Sleep(3000); // bu komut sistemin 3 saniye beklemesini sağlar. (2000 olsaydı 2 saniye olurdu
                        Console.WriteLine("Çıkmak için herhangi bir tuşa basın");
                        Console.Read();
                        break;

                    case "3":
                        Console.Write("Aramak İstediğiniz Değeri Giriniz:   ");
                        string arananDeger = Console.ReadLine();
                        Console.Clear();
                        bool Kontrol1 = degerListesi.Contains(arananDeger);
                        if (Kontrol1) 
                        {
                            Console.WriteLine("Aradığınız değer bulunmuştur");
                            System.Threading.Thread.Sleep(3000);

                        }
                        else
                        {
                            Console.WriteLine("Aradığınız Değer Bulunmamaktadır.");
                            System.Threading.Thread.Sleep(3000);
                        }
                        break;

                    case "4":
                        Console.WriteLine("Düzenlemek istediğiniz değeri giriniz:   ");
                        
                        string duzenlenenDeger = Console.ReadLine();
                        Console.Clear();
                        bool Kontrol2 = degerListesi.Contains(duzenlenenDeger);
                        if (Kontrol2)
                        {
                            Console.Write("Değerinizi Giriniz:  ");
                            string yeniDeger = Console.ReadLine();
                            int index = degerListesi.IndexOf(duzenlenenDeger);
                            degerListesi[index] = yeniDeger;
                            Console.Clear();
                            Console.WriteLine("Değer değiştirildi");
                            System.Threading.Thread.Sleep(5000);
                        }
                        else
                        {
                            Console.WriteLine("Değiştirmek istediğiniz değer bulunamadı.");
                            System.Threading.Thread.Sleep(5000);
                        }
                        break;
                    case "5":
                        Console.Write("Silmek istediğiniz değeri giriniz:   ");
                        string silinenDeger = Console.ReadLine();
                        degerListesi.Remove(silinenDeger);
                        Console.Clear();
                        Console.WriteLine("İstediğiniz değer başarıyla silinmiştir");
                        System.Threading.Thread.Sleep(5000);
                        break;
                    default:
                        break;
                }
            } while (kullaniciSecimStr != "6"  );

            Console.Clear() ;
            Console.WriteLine("Uygulamadan çıkılıyor...");
            System.Threading.Thread.Sleep(3000);


        }
    }
}
