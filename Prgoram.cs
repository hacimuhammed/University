int toplam = 0;
for (; ; )
{
    Console.Write("Bir sayı girin: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 83) { Console.WriteLine($"İşlem durduruldu. Toplam: {toplam}"); break; }
    toplam += sayi;
}
