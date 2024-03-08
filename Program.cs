var liczba = 54545456;
string liczbaJakoString = liczba.ToString();
char[] litery = liczbaJakoString.ToArray();
char[] numeryLiter = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

Console.WriteLine(liczbaJakoString);

Console.WriteLine("Liczba do sprawdzenia -> " + liczba);
Console.WriteLine("Zestawienie powtażalności cyfr");

foreach (var cyfra in numeryLiter)

{
    var licznik = 0;
    
    foreach (var litera in litery)
        {
            if (cyfra == litera)
                licznik++;
        
        }
    Console.WriteLine(cyfra + "->" + licznik);
}
