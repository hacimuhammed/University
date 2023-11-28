Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Tek mi Çift mi? 'Tek|Çift': "); 
string choice = Console.ReadLine() ?? "";

int total = 0;

if (number % 2 == 1 && choice.ToLower() == "tek")
{
    Console.WriteLine($"1 ile {number} arasındaki tek sayılar:");

    for (int i = 1; i <= number; i += 2) { Console.Write(i + " "); total += i; }

    Console.WriteLine($"\nToplam: {total}");
}
else if (number % 2 == 0 && choice.ToLower() == "çift")
{
    Console.WriteLine($"1 ile {number} arasındaki tüm sayılar:");

    for (int i = 1; i <= number; i++) { Console.Write(i + " "); total += i; }

    Console.WriteLine($"\nToplam: {total}");
}
else { Console.WriteLine("Hatalı giriş ya da seçim!"); }