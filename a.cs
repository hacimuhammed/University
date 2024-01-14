//class Program
//{
//    static void Main()
//    {
//        string[] birler = { "", "bir", "iki", "üç", "dört", "beþ", "altý", "yedi", "sekiz", "dokuz" };
//        string[] onlar = { "", "on", "yirmi", "otuz", "kýrk", "elli", "altmýþ", "yetmiþ", "seksen", "doksan" };
//        string[] yuzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beþyüz", "altýyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

//        Console.Write("Bir sayý girin: ");
//        int inputValue = Convert.ToInt32(Console.ReadLine());


//        if (inputValue < 0)
//        {
//            Console.Write("eksi ");
//            inputValue = Math.Abs(inputValue);
//        }

//        if (inputValue >= 1000)
//            throw new Exception("Hata, Girilen Deðer En fazla 3 Basamaklý Olabilir");

//        string generatedValue = "";

//        if (inputValue >= 100)
//        {
//            generatedValue += yuzler[inputValue / 100] + " ";
//            inputValue %= 100;
//        }

//        if (inputValue >= 10)
//        {
//            generatedValue += onlar[inputValue / 10] + " ";
//            inputValue %= 10;
//        }

//        if (inputValue > 0)
//        {
//            generatedValue += birler[inputValue];
//        }
//        Console.WriteLine(generatedValue);
//    }
//}
