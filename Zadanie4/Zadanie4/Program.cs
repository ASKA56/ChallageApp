// ASKA Zadanie4

var myMame = "Ewa";
var mySex = "Kobieta";
var myAge = 33;

if (mySex == "Kobieta" && myAge == 33)
{
    Console.WriteLine("Ewa lat 33.");
}
else if (mySex == "Kobieta" && myAge < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (mySex != "Kobieta" && myAge < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}

