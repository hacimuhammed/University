double[] burslar = { 150, 600, 700, 450, 850, 275, 950, 1500, 210, 368 };

int _i = 0;
foreach (double burs in burslar)
{
    if (burs <= 500)
        burslar[_i] += 0.1 + 50;
    Console.WriteLine(burslar[_i++]);

}