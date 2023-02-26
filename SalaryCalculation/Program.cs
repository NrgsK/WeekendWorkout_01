internal class Program
{
    private static void Main(string[] args)
    {
        //Bir çalışanın aylık maaşı 8.500 TL'dir. Anlaşması dahilinde çalıştığı her yıl için maaşına %15 zam alacaktır. Bu kişinin 5 yıl sonraki maaşını hesaplayan programı yazınız.

        float maas = 8500f;      // Aylık maaş bilgisi küsürat durumu oluşabileceğinden float türünde bir değişkene tanımlandı.
        Console.WriteLine("Çalışanın ilk aylık maaşı: "+maas);

        for (int i = 0; i < 5; i++)     // 5 yıllık sürecin hesaplanması for döngüsü ile yapıldı.
        {

            maas = maas + maas * 15/100;    // Her yılın zamlı maaşı bir önceki yılın maaş bilgisine göre hesaplandı.
            
        }

        Console.WriteLine("\nÇalışanın 5 yıl sonraki aylık maaşı : "+maas);

        Console.ReadKey();
    }
}