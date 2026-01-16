using Opgave2;
using Opgave2.Factories;
using Opgave2.Kort;


// Opret dealer
Dealer<StructKort> dealer = new Dealer<StructKort>(new StructKortFactory());


// Brug filtrene
Console.WriteLine("----- Alle klør -----");
var klørKort = dealer.FilterDeck(FilterByKlør);
foreach (var kort in klørKort)
{
    Console.WriteLine(kort);
}

Console.WriteLine("----- Billedkort -----");
var billedKort = dealer.FilterDeck(FilterByBilledkort);
foreach (var kort in billedKort)
{
    Console.WriteLine(kort);
}



//Lambdaer expressions
Console.WriteLine("----- Hjerter (lambda) -----");
var hjerter = dealer.FilterDeck(kort => kort.Kulør == EKulør.HJERTER);
foreach (var kort in hjerter)
{
    Console.WriteLine(kort);
}


//Filter metoder
static bool FilterByKlør(StructKort kort)
{
    return kort.Kulør == EKulør.KLØR;
}

static bool FilterByBilledkort(StructKort kort)
{
    return kort.Rang == ERang.KNÆGT ||
           kort.Rang == ERang.DAME ||
           kort.Rang == ERang.KONGE;
}
