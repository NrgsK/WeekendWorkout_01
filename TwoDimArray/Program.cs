internal class Program
{
    private static void Main(string[] args)
    {
        // İki boyutlu bir dizinin tüm elemanlarının değerini iki katına çıkartan ve sonra bu diziyi ekrana yazdıran kodu geliştiriniz.

       

        int[,] dizi = new int[5, 5];        // 5x5 boyutunda bir dizi oluşturulur.
        int[,] diziYeni = new int[5, 5];        // yeni değerleri tutması için dizi boyutunda yeni bir dizi oluşturulur.
        Random random= new Random();        // dizi elemanlarını rastgele oluşturmak için random değişkeni oluşturulur.    

        for (int i = 0; i < dizi.GetLength(0); i++)     // dizinin içerisindeki elemanlar rastgele sayılarla doldurulur.
        {
            for (int j = 0; j < dizi.GetLength(0); j++)
            {
                dizi[i, j] = random.Next(1, 100); 
            }
        }
        

        for (int i = 0;i < dizi.GetLength(0);i++)       // "dizi" değişkeninde bulunan her eleman 2 ile çarpılarak "diziYeni" dizisine atanır.
        {
            for (int j = 0; j < dizi.GetLength(0); j++)
            {
                diziYeni[i, j] = dizi[i,j]*2;
            }
                    
        }
        
        Console.WriteLine("Dizi Elemanları: \n");
        for (int i = 0; i < dizi.GetLength(0); i++)     // Kıyaslama için oluştururan dizinin elemanları ekrana yazdırılır.
        {
            for (int j = 0; j < dizi.GetLength(0); j++)
            {
                Console.Write(dizi[i, j] + " ");
            }
            Console.Write("\n");
        }
       
        Console.WriteLine("\nYeni Dizi Elemanları: \n");        // Oluşturulan yeni dizi ekrana yazdırılır.
        for (int i = 0; i < diziYeni.GetLength(0); i++)
        {
            for (int j = 0; j < diziYeni.GetLength(0); j++)
            {
                Console.Write(diziYeni[i, j] + " ");
            }
            Console.Write("\n");
        }





        Console.ReadKey();
    }
}