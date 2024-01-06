using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bilgileri al
        Console.Write("Lütfen boyunuzu (cm cinsinden) girin: ");
        double boy = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lütfen kilonuzu (kg cinsinden) girin: ");
        double kilo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Lütfen cinsiyetinizi girin (Kadın için K, Erkek için E): ");
        string cinsiyet = Console.ReadLine();

        // İdeal kilo hesaplama
        double idealKilo;
        if (cinsiyet.ToLower() == "k")
        {
            idealKilo = 45.5 + 2.3 * ((boy / 2.54) - 60);
        }
        else if (cinsiyet.ToLower() == "e")
        {
            idealKilo = 50 + 2.3 * ((boy / 2.54) - 60);
        }
        else
        {
            Console.WriteLine("Geçersiz cinsiyet girişi!");
            return;
        }

        // İdeal kilo kontrolü ve sonuç yazdırma
        if (kilo == idealKilo)
        {
            Console.WriteLine("İdeal kilodasınız.");
        }
        else if (kilo < idealKilo)
        {
            Console.WriteLine("İdeal kilonuzun altındasınız.");
        }
        else
        {
            Console.WriteLine("İdeal kilonuzun üzerindesiniz.");
        }
    }
}
