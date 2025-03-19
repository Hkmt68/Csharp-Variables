using System;

class Program
{
    public static void Main(string[] args)
    {
        // 1. Değişken Tanımlamaları
        int tamSayi = 5; // Tam sayılar için int türü
        double ondalikliSayi = 3.14; // Ondalıklı sayılar için double türü
        char karakter = 'A'; // Tek bir karakter için char türü
        bool dogruMu = true; // Boolean (doğru/yanlış) değeri için bool türü
        string metin = "Merhaba, dünya!"; // Metinler için string türü
        decimal para = 199.99m; // Finansal hesaplamalar için decimal türü

        // 2. Değişken Değerlerini Yazdırma
        Console.WriteLine("Tam Sayı: " + tamSayi);
        Console.WriteLine("Ondalıklı Sayı: " + ondalikliSayi);
        Console.WriteLine("Karakter: " + karakter);
        Console.WriteLine("Doğru mu: " + dogruMu);
        Console.WriteLine("Metin: " + metin);
        Console.WriteLine("Para: " + para);

        // 3. Değişken Dönüşümü (Casting)
        int sayi1 = 10;
        double sayi2 = 3.14;
        double sonuc = sayi1 + sayi2; // Farklı türdeki sayıları toplama
        Console.WriteLine("Sayıların toplamı (int + double): " + sonuc);

        // 4. Kullanıcıdan Girdi Alma
        Console.WriteLine("Lütfen isminizi giriniz:");
        string? kullaniciIsmi = Console.ReadLine();
        Console.WriteLine("Merhaba, " + kullaniciIsmi + "!");

        // 5. Tip Kontrolü (Type Checking)
        Console.WriteLine("Metnin türü: " + metin.GetType());
        Console.WriteLine("Ondalık sayının türü: " + ondalikliSayi.GetType());
        
        // 6. String ve Int Dönüşümü
        string sayiString = "123";
        int sayiInt = int.Parse(sayiString); // String'den int'e dönüşüm
        Console.WriteLine("String'den int'e dönüşüm sonucu: " + sayiInt);

        // 7. Nullable Türler
        int? nullableInt = null; // Nullable int
        Console.WriteLine("Nullable int: " + nullableInt.HasValue); // Null olup olmadığını kontrol etme

        // 8. Array Kullanımı
        int[] sayilar = { 1, 2, 3, 4, 5 }; // Array tanımlaması
        Console.WriteLine("Dizi elemanları:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}
