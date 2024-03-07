var name = "Ewa";
var sex = "kobieta";
var age = 31;

if ( sex == "kobieta" && age <= 29)
{
    Console.WriteLine( "Kobieta poniżej 30 lat");

}
if ( name == "Ewa" && age == 30 )
{
    if ( sex == "kobieta")
    {
        Console.WriteLine("Ewa, lat 30");
    }
}
if ( sex == "męszczyzna" && age <=18 )
{
    Console.WriteLine("Niepełnoletni męszczyzna");
}
