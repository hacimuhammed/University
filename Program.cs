Console.Write("Kaç Adet Sayı Girilecek: ");
int l = Convert.ToInt32(Console.ReadLine());

List<int> notlar = new List<int>();
for (int i = 1; i <= l; i++)
{
    Console.Write($"{i}. Sayıyı Giriniz: ");
    int sayi = Convert.ToInt32(Console.ReadLine());
    notlar.Add(sayi);
}
int sum = notlar.Sum();
int avg = notlar.Sum() / notlar.Count;
Console.WriteLine($"Toplam: {sum} Ortalama: {avg}");