internal class Program
{
    private static void Main(string[] args)
    {
        // Klavyeden girilen sayıdan başlayıp 1'e kadar sayıları 5'er 5'er azaltarak ekrana yazdıran programı hazırlayınız. (Gerekli kontroller yapılarak.)

        Console.WriteLine("Lütfen POZİTİF ve 1 den büyük bir sayı giriniz.\n");
        int value=Convert.ToInt32(Console.ReadLine());      // Klavyeden değer alınıp int e çevrilir.


        if (value <= 0)     // Girilen sayının negatiflik kontrolü yapılır.
        {
            Console.WriteLine("\n\n0 ya da Negatif bir sayı girdiniz. İşlem yapılamamaktadır.");

        }
        else if (value == 1)        // Girilen sayı 1 e eşitse hata verebilir. O yüzden 1 yazılma durumu da kontol edilir.
        {
            Console.WriteLine("\n\n1 sayısını girdiniz. Girdiğiniz sayı ile işlem yapılamamaktadır.");
        }
        else if (value>1) {         // Sayı pozitif ve 1 den büyükse işlem yapılır.
            Console.WriteLine("\n{0} 'den başlayıp 1 e kadar 5'er olarak azalan sayılar: \n",value); 
            while (value>1)     
            {
                value -= 5;
                Console.Write(value+" ");
            }
        
        
        }

        Console.ReadKey();
    }
}