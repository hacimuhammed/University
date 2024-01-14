string[] iller = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
string[] isimler = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };

Random random = new Random();
random.Shuffle(isimler);

int length = iller.Length;

for (int i = 0; i < length - 1; i++)
{
    int j = random.Next(i, length);

    if (j != i)
    {
        var temp = iller[i];
        iller[i] = iller[j];
        iller[j] = temp;
    }
}

for (int i = 0; i < 7; i++)
    Console.WriteLine(iller[i] + " " + isimler[i]);