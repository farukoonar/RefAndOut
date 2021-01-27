using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;

            //metotun içinde sayıyı 20'e eşitlediğimiz için 20 değerini döndürür
            Console.WriteLine("Metotdan gelen sayı: {0} ",DegerDondur1(sayi1)); 
            //integer değişkenler değer tip olduğu için metota sadece o değişkenin içindeki 10 değeri gider
            //sayi değişkeni hala 10 kalmaya devam eder
            Console.WriteLine("Değişkenin içindeki sayı: {0} ", sayi1);

            
            Console.WriteLine("Metotdan gelen sayı: {0} ", DegerDondur2(ref sayi1));
            //burada ise ref keywordü ile metotun içine sayının referansını göndererek sayi'nin değerini 20 olarak değiştirmiş olduk
            Console.WriteLine("Değişkenin içindeki sayı: {0} ", sayi1);

            int sayi2;
            Console.WriteLine("Metotdan gelen sayı: {0} ", DegerDondur3(out sayi2));
            //out ise ref ile aynı görevi yapmaktadır ama refde sayıya değer atamak zorundaydık ama outda değer atamak zorunda değiliz
            //aynı şekilde refde metotun içinde sayıya değer atamak zorunda değildik ama outda metotun içinde sayıya değer atamak zorundayız
            Console.WriteLine("Değişkenin içindeki sayı: {0} ", sayi2);

        }
        
        static int DegerDondur1(int sayi)
        {
            sayi = 20;
            return sayi;
        }
        static int DegerDondur2(ref int sayi)
        {
            sayi = 20;
            return sayi;
        }
        static int DegerDondur3(out int sayi)
        {
            sayi = 20;
            return sayi;
        }
    }
}
