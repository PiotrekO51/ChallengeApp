using System;

var name = "Ewa";
var sex = "męszczyzna";
var age = 17;

if ( sex == "kobieta" && age <= 29)
{
    Console.WriteLine( "Kobieta poniżej 30 lat");

}
else  if ( name == "Ewa" && age == 30 )

    {
        Console.WriteLine("Ewa, lat 30");
    }
else if ( sex == "męszczyzna" && age <=18 )

    {
        Console.WriteLine("Niepełnoletni męszczyzna");
    }
