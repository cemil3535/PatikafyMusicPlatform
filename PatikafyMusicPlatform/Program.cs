// See https://aka.ms/new-console-template for more information
using PatikafyMusicPlatform;
using System;
using System.Collections.Generic;
using System.Linq;

List<Singer> singers = new List<Singer>()
{
    new Singer{Name = "Ajda Pekkan", Kind = "Pop", DebutYear = 1968, AlbumSales = 20},
    new Singer{Name = "Sezen Aksu", Kind = "Turk Halk Muzigi/Pop", DebutYear = 1971, AlbumSales = 10},
    new Singer{Name = "Funda Arar", Kind = "Pop", DebutYear = 1999, AlbumSales = 3},
    new Singer{Name = "Sertab Erener", Kind = "Pop", DebutYear = 1994, AlbumSales = 5},
    new Singer{Name = "Sila", Kind = "Pop", DebutYear = 2009, AlbumSales = 3},
    new Singer{Name = "Serdar Ortac", Kind = "Pop", DebutYear = 1994, AlbumSales = 10 },
    new Singer{Name = "Tarkan", Kind = "Pop", DebutYear = 1992, AlbumSales = 40},
    new Singer{Name = "Hande Yener", Kind = "Pop", DebutYear = 1999, AlbumSales = 7},
    new Singer{Name = "Hadise", Kind = "Pop", DebutYear = 2005, AlbumSales = 5},
    new Singer{Name = "Gulben Ergen", Kind = "Pop", DebutYear = 1997, AlbumSales = 10},
    new Singer{Name = "Nejet Ertas", Kind = "Turk Halk Muzigi/Turk Sanat Muzigi", DebutYear = 1960, AlbumSales = 2}
};

//Singers whose names start with s
Console.WriteLine("Adi 'S' ile baslayan sarkicilar:");
var sNameSingers = singers.Where(s => s.Name.StartsWith("S"));
foreach (var singer in sNameSingers) 
{
    Console.WriteLine(singer.Name);
}

Console.WriteLine("---------------------------------------------------------------------");

// Singers with album sales over 10 million
Console.WriteLine("Album satislari 10 milyonun uzerinde olan sanatcilar: ");
var topSellers = singers.Where(s => s.AlbumSales > 10);
foreach (var singer in topSellers) 
{  
    Console.WriteLine(singer.Name, " " ,singer.AlbumSales, "milyon");
}

Console.WriteLine("---------------------------------------------------------------------");

// Singers who debuted before 2000 and made pop music
Console.WriteLine("2000 yili oncesi cikis yapmis ve pop muzik yapan sarkicilar:");
var before2000PopSingers = singers
    .Where(s => s.DebutYear < 2000 && s.Kind.Contains("Pop"))
    .OrderBy(s => s.DebutYear)
    .ThenBy(s => s.Name);

foreach (var singer in before2000PopSingers)
{  
    Console.WriteLine(singer.Name, " ", singer.DebutYear); 
}

Console.WriteLine("---------------------------------------------------------------------");

// The singer who sold the most albums
var topSeller = singers.OrderByDescending(s => s.AlbumSales).First();
Console.WriteLine($"En cok album satan sarkici: { topSeller.Name}  {topSeller.AlbumSales} milyon");

Console.WriteLine("---------------------------------------------------------------------");

// Newest and oldest debut singers
var newestSinger = singers.OrderByDescending(s => s.DebutYear).First();
var oldestSinger = singers.OrderBy(s => s.DebutYear).First();
Console.WriteLine($"En yeni cikis yapan sarkici: {newestSinger.Name}");
Console.WriteLine($"En eski cikis yapan sarkici:{ oldestSinger.Name}");