internal class Program
{
    private static void Main(string[] args)
    {
        // Bir mağaza müşterilerine yaptıkları alışveriş tutarına göre indirim yapmaktadır. 200 TL ye kadar olan alışverişler için %10, 200-400 TL arası olan alışverişler için %15, 400 TL den fazla olan alışverişler için %20 indirim uygulamaktadır. Buna göre bir kişinin ödeyeceği net miktarı hesaplayan programın kodunu yazınız.

        Console.WriteLine("Alışveriş tutarı: ");
        float tutar=(float)Convert.ToDecimal(Console.ReadLine());

        float sonTutar = 0f;        // küsüratlı çıkması durumu için değer float türünde saklanır.
        float indirimOrani = 0f;

        // Negatif bir sayı girilmesi durumu IF koşulu ile kontrol edilir.
        if (tutar > 0) 
        {
            if (tutar<200)
            {
                indirimOrani = 0.10f;
                sonTutar = sonTutar + tutar * indirimOrani;
                Console.WriteLine("\nUygulanan indirim oranı: %10");
                Console.WriteLine("\nİndirimli tutar: {0} ", sonTutar);
                

            }
            else if (tutar >= 200 && tutar<400)
            {
                indirimOrani = 0.15f;
                sonTutar = sonTutar + tutar * indirimOrani;
                Console.WriteLine("\nUygulanan indirim oranı: %15");
                Console.WriteLine("\nİndirimli tutar: {0} ", sonTutar);

            }
            else if (tutar >= 400)
            {
                indirimOrani = 0.20f;
                sonTutar = sonTutar + tutar * indirimOrani;
                Console.WriteLine("\nUygulanan indirim oranı: %20");
                Console.WriteLine("\nİndirimli tutar: {0} ", sonTutar);

            }


        }
        else
        {
            Console.WriteLine("Geçerli bir tutar bilgisi giriniz.");

        }


        Console.ReadKey();
    }
}