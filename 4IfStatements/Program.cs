internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = new int[10];
        for(int i = 0; i<10; i++)
        {
            Console.Write("{0}. sayiyi giriniz: ", i+1);
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

            Array.Sort(sayilar);
            int enKucuk = sayilar[0];
            int enBuyuk = sayilar[9];

            Console.WriteLine( "Girilen en kucuk sayi= {0}", enKucuk);
            Console.WriteLine("Girilen en buyuk sayi= {0}", enBuyuk);
            Console.ReadLine();


    }
}