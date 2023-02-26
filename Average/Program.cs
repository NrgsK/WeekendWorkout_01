internal class Program
{
    private static void Main(string[] args)
    {
        // Klavyeden 0 (sıfır) değeri girilinceye kadar klavyeden okutulan değerlerin ortalamasını hesaplayıp ekrana yazan programı yazınız.

        Console.WriteLine("Ortalaması alınacak sayıları giriniz:");

        int sayilar = 0;      // girilecek sayıların değerini tutacak bir dizi tanımlandı.
        int toplam = 0, ortalama=0, i=0;

        // sayılar 0 dan büyük ve eşitse döngü çalışır.
        while (sayilar>=0)
        {
            ++i;
            Console.Write("\n"+i+". Sayı : ");
            sayilar = Convert.ToInt32(Console.ReadLine());
            toplam += sayilar;
            
            if (sayilar == 0)
            {
                ortalama = toplam / i;
                Console.WriteLine("\n\nGirilen {0} adet sayının ortalama değeri : {1} ",i,ortalama);
                break;  // 0 girildiğinde devam etmemesi için break komutu kullanıldı.
            }
            


        }

        if(sayilar<0) {

            Console.WriteLine("\nGirmiş olduğunuz sayı 0'dn küçüktür.");
        
        }

        
        
        
        
        



        Console.ReadKey();
    }
}