using Film;

static void Registrering(Filmen f)
{
    Console.WriteLine("Filmtitel: ");
    f.GetSetTitel = Console.ReadLine();
    Console.WriteLine("Filmkostnad: ");
    f.GetSetKostnader = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Huvudskådespelarens namn: ");
    f.GetSetSkådespelare = Console.ReadLine();
    Console.WriteLine("Sponsorskap: ");
    f.GetSetSponsring = Convert.ToDouble(Console.ReadLine());
}

int n, i, antTittare;
double biljettpris;
Console.WriteLine("Ange antalet filmer");
n = Convert.ToInt32(Console.ReadLine());
Filmen[] f = new Filmen[n];
double[] feeS = new double[n];
double[] feeFilm = new double[n];
for (i = 0; i < n; i++)
{
    f[i] = new Filmen();
    Console.WriteLine("Ange information om {0}.filmen", i);
    Registrering(f[i]);
    Console.WriteLine("Ange antalet tittare");
    antTittare = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ange biljettpriset");
    biljettpris = Convert.ToDouble(Console.ReadLine());
    feeFilm[i] = f[i].Beräkna(f[i], antTittare, biljettpris);
    feeS[i] = f[i].FeeS(feeFilm[i]);
    Console.WriteLine("*************************************************");
}
Console.WriteLine();
Console.WriteLine("****************************");
for (i = 0; i < n; i++)
    Console.WriteLine("Filmen {0} har uppnått en avgift av  {1} kronor, och huvudskådespelaren {2} intjänade  {3} kronor.", f[i].GetSetTitel, feeFilm[i], f[i].GetSetSkådespelare, feeS[i]);
Console.ReadLine();

