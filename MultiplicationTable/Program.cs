internal class Program
{
    private static void Main(string[] args)
    {
        // Ekrana 10’a kadar olan sayıların çarpım tablosunu satır satır yazdıran programı geliştiriniz. (örneğin 6x2=12,6x3=18.. gibi)

        Console.Write("1 ile 10 arasında bir sayı giriniz: ");      // sayı bilgisi alınır.
        int sayi=Convert.ToInt32(Console.ReadLine());

        // IF koşulu ile girilen sayının 1 ile 10 arasında olup olmadığı kontrol edilir.
        // SWITCH-CASE yapısı ile kullanıcıdan alınan değer için çarpma işlemleri yapılarak yazdırılır.
        if (sayi > 0 || sayi <= 10) { 
            switch (sayi)
            {
                case 1:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 2:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 3:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 4:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 5:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 6:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 7:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 8:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 9:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;
                case 10:
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write("\n\t{0} x {1} = {2} ", sayi, i, sayi * i);
                    }
                    break;

            }
        
        }
        else
        {

            Console.WriteLine("\nGeçerli bir sayı giriniz.");
        }


        Console.ReadKey();
    }
}