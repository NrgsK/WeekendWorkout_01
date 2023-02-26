internal class Program
{
    private static void Main(string[] args)
    {
        // Bilgisayar tarafından belirlenen 1 ile 200 arasında rastgele bir sayıyı tahmin edeceğiniz şekilde sizi yönlendiren bir oyun programı yazınız. Yani girdiğiniz değer tutulan değerden büyükse/küçükse uygun bir mesaj vererek yeni sayı girmesini isteyebilirsiniz. Maximum sayıyı tahmin etme sınırı 10 olsun. Eğer bu sınır geçilirse ekranın geriplan rengi kırmızı olsun ve bir mesaj vererek programdan çıksın. (Not: Şimdiye kadar incelemediğimiz “otomatik sayı üretme” C# fonksiyonu “Random” bu konuda size yardımcı olacaktır. Gerekli araştırmalarınızı yapabilirsiniz..Diğer taraftan geriplan rengi değiştirme işi için de araştırmalarınızı yapabilirsiniz...)

        Random rnd= new Random();       // Random değerler için rnd değişkeni tanımlanır.
        int uret=rnd.Next(1,200);     // 1 ile 200 arasında rastgele sayı atanır.
        int tahmin = 0;             // tahmin edilecek sayılar için değer atanır.

        // tahmin hakkı sınırlı olduğu için for döngüsü kullanılır.
        for (int i = 1; i < 11; i++)
        {
            Console.Write("\n{0}. tahmini giriniz: ",i);
            tahmin=Convert.ToInt32(Console.ReadLine());     // tahmin değeri ekrandan alınır.


            if (tahmin < uret)  // tahmin sayısı üretilen sayıdan küçükse ekrana "küçüktür" mesajı verilir.
            {
                Console.WriteLine("\nTahmin ettiğiniz sayı küçüktür.");

            }
            else if (tahmin > uret)     // tahmin sayısı üretilen sayıdan küçükse ekrana "büyüktür" mesajı verilir.
            {
                Console.WriteLine("\nTahmin ettiğiniz sayı büyüktür..");

            }
            else if (tahmin == uret)    // eğer tahmin edilen sayı üretilen sayıya eşitse "DOĞRU BİLDİNİZ" mesajı ekrana verilir ve döngüden çıkılır.
            {
                Console.WriteLine("\nDOĞRU BİLDİNİZ.");
                Console.WriteLine("\n{0}. tahmin", i);
                break;

            }
            if (i == 10) {      // 10. tahminde uyarı verileceği için ayrı bir if koşulu oluşturulur.
                Console.BackgroundColor= ConsoleColor.Red;  // ekran arka planı kırmızı renge dönüştürülür.
                Console.Clear();    // ekrandaki bilgileri silmek için kullanılan metot.
                Console.WriteLine("TAHMİN LİMİTİNİ AŞTINIZ!!!");
            
            
            }
        }



        Console.ReadKey();
    }
}