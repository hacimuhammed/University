//class Program
//{
//    static void Main()
//    {
//        string[] birler = { "", "bir", "iki", "��", "d�rt", "be�", "alt�", "yedi", "sekiz", "dokuz" };
//        string[] onlar = { "", "on", "yirmi", "otuz", "k�rk", "elli", "altm��", "yetmi�", "seksen", "doksan" };
//        string[] yuzler = { "", "y�z", "ikiy�z", "��y�z", "d�rty�z", "be�y�z", "alt�y�z", "yediy�z", "sekizy�z", "dokuzy�z" };

//        Console.Write("Bir say� girin: ");
//        int inputValue = Convert.ToInt32(Console.ReadLine());


//        if (inputValue < 0)
//        {
//            Console.Write("eksi ");
//            inputValue = Math.Abs(inputValue);
//        }

//        if (inputValue >= 1000)
//            throw new Exception("Hata, Girilen De�er En fazla 3 Basamakl� Olabilir");

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
