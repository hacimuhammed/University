class Program
{
    static void Main()
    {

        string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
        string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
        string[] yuzler = { "", "yüz", "ikiyüz", "üçyüz", "dörtyüz", "beşyüz", "altıyüz", "yediyüz", "sekizyüz", "dokuzyüz" };

        int girilenSayi = Convert.ToInt32(Console.ReadLine());
        string olusturulanSayi = string.Empty;

        if (girilenSayi < 0)
        {
            olusturulanSayi += "eksi ";
            girilenSayi = Math.Abs(girilenSayi);
        }

        if (girilenSayi >= 1000)
            throw new Exception("Hata, Maksimum 3 basamaklı bir sayı girebilirsiniz...");

        if (girilenSayi >= 100)
        {
            olusturulanSayi += yuzler[girilenSayi / 100] + " ";
            girilenSayi %= 100;
        }

        if (girilenSayi >= 10)
        {
            olusturulanSayi += onlar[girilenSayi / 10] + " ";
            girilenSayi %= 10;

            if (girilenSayi > 0)
                olusturulanSayi += birler[girilenSayi];
            else
                olusturulanSayi = "sıfır";

            Console.Write(olusturulanSayi);

        }
    }
}