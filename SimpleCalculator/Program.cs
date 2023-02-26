internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan alınan 2 sayıya yine kullanıcıdan alınacak işlem seçimine göre dört işlem uygulayan program kodunu yazınız. (Toplama için T veya t, Çıkartma için E/e, Çarpma için Ç/ç, Bölme için B/b kodlarını kullanınız. Eğer bu işlem kodları dışındaki girişler için hatalı giriş yapıldığına dair bir mesaj verdirebilirsiniz)

        // İşlem yapılacak değerler kullanıcıdan alınır.
        Console.Write("1. sayıyı giriniz: ");       
        int sayi1=Convert.ToInt32(Console.ReadLine());

        Console.Write("\n\n2. sayıyı giriniz: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());


        // işlem kısa yolları için bilgilendirme 
        Console.WriteLine("\nToplama = T/t");
        Console.WriteLine("\nÇıkartma = E/e");
        Console.WriteLine("\nÇarpma = Ç/ç");
        Console.WriteLine("\nBölme = B/b");

        // yapılacak işlem kullanıcıdan istenir
        Console.Write("\n\nYapılacak işlemi giriniz: ");
        char islem=Convert.ToChar(Console.ReadLine());

        // İşlemler 
        if(islem=='E' || islem == 'e')
        {
            Console.Write("\n{0} - {1} = {2}",sayi1,sayi2,sayi1-sayi2);

        }
        else if (islem == 'T' || islem == 't')
        {
            Console.Write("\n{0} - {1} = {2}", sayi1, sayi2, sayi1 + sayi2);

        }
        else if (islem == 'Ç' || islem == 'ç')
        {
            Console.Write("\n{0} - {1} = {2}", sayi1, sayi2, sayi1 * sayi2);

        }
        else if (islem == 'B' || islem == 'b')
        {
            Console.Write("\n{0} - {1} = {2}", sayi1, sayi2, sayi1 / sayi2);

        }
        else
        {
            Console.WriteLine("\nListedeki işlemlerden birini seçiniz.");

        } // işlem tablosunda verilen karakterlerden başka bir karakter girilirse işlem yapmaz.

        Console.WriteLine();
        Console.ReadKey();
    }
}