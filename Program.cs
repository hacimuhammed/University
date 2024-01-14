string[] iller = { "Muş", "Ağrı", "Bolu", "Mersin", "Ankara", "Sivas", "Kayseri" };
string[] isimler = { "Asuman", "İclal", "Emin", "Bekir", "Ahmet", "Can", "Esma" };

Random random = new Random();
random.Shuffle(iller);
random.Shuffle(isimler);

for (int i = 0; i < 7; i++)
    Console.WriteLine(iller[i] + " " + isimler[i]);
