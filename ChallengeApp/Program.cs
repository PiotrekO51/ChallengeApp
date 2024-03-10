//Sprawdzanie występowania liczb w cyfsze.

var numberToCheck = 34556776;
char [] letters = numberToCheck.ToString().ToCharArray();
char[] numberToLetter = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];

Console.WriteLine("Sposób nr 1 ");
Console.WriteLine(" ");
Console.WriteLine("Liczba do sprawdzenia => " + numberToCheck);

foreach (var number in numberToLetter)
{
    var counter = 0;
    foreach (var letter in letters )
        if (number == letter) 
            counter++;
    Console.WriteLine(number + " => " + counter);
}


// sposób nr 2 listy
Console.WriteLine(" ");
Console.WriteLine("Sposób nr 2  <-listy-> ");


List<char> numbers2 = new List<char>();

for (var i = 0; i <= 9; i++)
{
    numbers2.Add(i.ToString()[0]);
    
}

foreach (var number2 in numbers2 )
{
    var counter2 = 0;
    
        foreach (var letter in letters)
            if(number2 == letter)
                counter2++;
        Console.WriteLine(number2 + "<=> " + counter2);
}