// SNACK 1

// ottengo il primo numero 
/*Console.WriteLine("Inserisci il primo numero");
int firstNumber = Convert.ToInt32(Console.ReadLine());

// ottengo il secondo numero
Console.WriteLine("Inserisci il secondo numero");
int secondNumber = Convert.ToInt32(Console.ReadLine());


if(firstNumber > secondNumber)
{
    Console.WriteLine("Il numero più alto è: "+firstNumber);
}

else if(firstNumber < secondNumber)
{
    Console.WriteLine("Il numero più alto è: " +secondNumber);
} else

{
    Console.WriteLine("i numeri inseriti sono uguali");
}


// SNACK 2 


// ottengo prima parola
Console.WriteLine("inserisci la prima parola");
string firstWord = Console.ReadLine();

// ottengo seconda parola
Console.WriteLine("inserisci la seconda parola");
string secondWord = Console.ReadLine();

if (firstWord.Length > secondWord.Length)
{
    Console.WriteLine(secondWord + " " + firstWord);
}
else
{
    Console.WriteLine(firstWord + " " + secondWord);
}
*/

// SNACK 3
int somma = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("inserisci un numero");
    somma = somma + Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("La somma è: "+somma);
