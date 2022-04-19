Console.WriteLine("zadejte  první číslo");
string cislo1 = Console.ReadLine();
int cislo11 = Convert.ToInt32(cislo1);
Console.Clear();
Console.WriteLine("zadejte  druhé číslo");
string cislo2 = Console.ReadLine();
int cislo22 = Convert.ToInt32(cislo2);
Console.Clear();

if (cislo11 < cislo22)
    Console.WriteLine($"{cislo11} je menší než {cislo22}");

if (cislo11 > cislo22)
    Console.WriteLine($"{cislo22} je menší než  {cislo11}");

if (cislo11 == cislo22)
    Console.WriteLine("Čísla jsou rovna");