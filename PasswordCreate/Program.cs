internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan alınan sayısal değere göre uygun olan uzunlukta şifre üreten bir kod geliştiriniz (Örneğin kullanıcı 5 girecek buna uygun olarak rastgele olacak şekilde 5 karakterlik şifre oluşturulacak. Maksimum karakter sayısı 10 olacak ve kullanıcı 10 üzerinde bir değer verirse uyarı verilerek uygun değer girilene kadar kullanıcıdan değer alınacak.)

        Random rnd= new Random();

        Console.Write("Lütfen bir sayı giriniz: ");
        int sayi=Convert.ToInt32(Console.ReadLine());

        char[] sifre=new char[sayi];

        int rastgele = 0;       // random karakterler üretebilmek için rastgele adında bir değişken tanımlanır. böylelikle ASCII oluşturulan random değerlerin ASCII tablosundaki karşılıları bulunur.      


        if (sayi > 0 && sayi <= 10)
        {
            for (int i = 0; i < sifre.Length; i++)
            {
                // ASCII karakter tablosuna göre tek karakterler 10'luk sayı sistemine göre 33 ile 126 arasındadır.
                // Her seferinde farklı bir karakter oluşturması için rastgele değişkenine for döngüsü içerisinde atama yapılır.
                rastgele = rnd.Next(33, 126);
                sifre[i] = Convert.ToChar(rastgele);

            }

            Console.Write("Oluşturulan şifre: ");
            for (int i = 0; i < sifre.Length; i++)
            {
                Console.Write(sifre[i]);
            }
        }
        else
            Console.WriteLine("Şifre uzunlığı 1 ile 10 karakter arasında olabilir.");




        Console.ReadKey();
    }
}