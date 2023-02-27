internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan ekrandan 1 ile 10 arasında bir değer girmesini isteyiniz ve bu girilen değere göre kenarları "*" karakterlerinden oluşan bir kare şeklini ekrana çizdiriniz.

        Console.Write("Lütfen 1 ile 10 arasında bir değer giriniz: ");
        int deger=Convert.ToInt32(Console.ReadLine());      // Klavyeden alınan değer
        // int deger=int.Parse(Console.Readline()); 

        Console.WriteLine();

        // IF-ELSE koşulu ile girilen sayının 1 ile 10 arasında olup olmadığı kontrol edilir.
        // Klavyeden alınan sayı istenilen sınırlar içerisinde değilse "İşlem yapılamadı" mesajı verilir.
        if (deger >= 0 && deger <= 10)
        {
            for (int i = 0; i < deger; i++)     // Üst kenar için FOR DÖNGÜSÜ
            {
                Console.Write("* ");       // boşluk görsel açıdan kareye benzemesi için eklendi.
            }
            Console.WriteLine();       // Alt satıra geçmesi için

            for (int i = 0; i < deger; i++)     // Sol kenar için FOR DÖNGÜSÜ. 
            {
                Console.Write("*");
                for (int j = 0; j < deger-2; j++)       // iç kısımdaki boşluklar için bu döngü oluşturuldu. kenarlar for sınırına katılmadı o yüzden deger-2 
                {   

                    Console.Write("  ");

                }
                 
                Console.Write(" *");   // sağ kenar için
                Console.WriteLine();    // bir sonraki satıra geçmesi için
            }
            for (int i = 0; i < deger; i++)
            {
                Console.Write("* ");   // alt kenar için

            }
        }



        else
        {

            Console.WriteLine("Girmiş olduğunuz değer 1 ile 10 arasında değildir.\n İŞLEM YAPILAMADI.");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}
