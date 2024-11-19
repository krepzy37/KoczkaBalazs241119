using KoczkaBalazs241119;
using System.Text;
var dolgozok = new List<Dolgozo>();
using StreamReader sr = new(@"..\..\..\src\berek2020.txt", Encoding.UTF8);
_=sr.ReadLine();
while (!sr.EndOfStream) dolgozok.Add(new(sr.ReadLine()));

int f3 = dolgozok.Count;
Console.WriteLine($"3. feladat: Dolgozok szama: {f3}");

double f4 = dolgozok.Average(x => x.Ber)/1000;
Console.WriteLine($"4. feladat: 2020 átlagbér: {f4:F2} ezer Ft");

Console.Write("5. feladat: Adja meg egy részleg nevét: ");
string f5 = Console.ReadLine();

var f6 = dolgozok
    .Where(d => d.Reszleg.Equals(f5, StringComparison.OrdinalIgnoreCase))
    .ToList();
Console.WriteLine("6.feladat:");
if (f6.Count > 0)
{
    var f6b = f6.OrderByDescending(d => d.Ber).First();
    Console.WriteLine($"\t{f6b.ToString()}");
}
else
{
    Console.WriteLine("\tA megadott részleg nem létezik a cégnél!");
}

var f7 = dolgozok
    .GroupBy(d => d.Reszleg) 
    .Select(g => new { Reszleg = g.Key, DolgozokSzama = g.Count() }) 
    .ToList();

Console.WriteLine("7. feladat:");
foreach (var s in f7)
{
    Console.WriteLine($"\t{s.Reszleg.ToUpper()}: {s.DolgozokSzama} dolgozó");
}