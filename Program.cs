// SNACK 1

// ottengo il primo numero 
Console.WriteLine("Inserisci il primo numero");
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
} 

else

{
    Console.WriteLine("i numeri inseriti sono uguali");
}



// SNACK 2 _________________________________________________________________________________________

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



// SNACK 3 ________________________________________________________________________________________

int somma = 0;

for (int i = 0; i < 10; i++)
{
    // aggiungo il numero inserito alla somma totale
    Console.WriteLine("inserisci un numero");
    somma = somma + Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("La somma è: "+somma);



// SNACK 4 _________________________________________________________________________________________

int somma = 0;

// inizializzo il contatore
int cont = 0;

// ciclo da 2 a 10 compresi
for (int i = 2; i <= 10; i++)
{
    somma = somma + i;

    // incremento il contatore
    cont++;
}

// calcolo e stampo la media
Console.WriteLine("La media è: "+ somma/cont);



// SNACK 5 _________________________________________________________________________________________

// ottengo il numero
Console.WriteLine("inserisci un numero");
int number = Convert.ToInt32(Console.ReadLine);

// se il numero è pari
if (number % 2 == 0)
{
    Console.WriteLine(number);
} 

else
{
    Console.WriteLine(number + 1);
}



// SNACK 6  _________________________________________________________________________________________

// found diventerà true quando troverò una corrispondenza di nomi
bool found = false;

// array di nomi ammessi alla festa
string[] names = { "franco", "pippo", "alberto" };

Console.WriteLine("come ti chiami?");
string yourName = Console.ReadLine();

for (int i = 0; i < names.Length; i++)
{
    if (names[i].Equals(yourName))
    {
        // se trovo una corrispondenza aggiorno la variabile
        found = true;
    }
}

if(found)
{
    Console.WriteLine("Sei in lista, puoi partecipare!");
} 

else
{
    Console.WriteLine("Non sei in lista, vattene");
}



// SNACK 7  _________________________________________________________________________________________

int[] array;

// istanzio nuovo array di dimensione 6
array = new int[6];

int number;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine("inserisci un numero");
    number = Convert.ToInt32(Console.ReadLine());

    // se il numero è dispari lo inserisco nell'array
    if(number %2 != 0)
    {
        array[i] = number;
    }
}



// SNACK 8  _________________________________________________________________________________________

int[] array = { 1, 3, 56, 33 };
int somma = 0;

for (int i = 0; i < array.Length; i++)
{
    // sommo gli elementi in posizione dispari
    if(i%2 != 0)
    {
        somma = somma + array[i];
    }
}

Console.WriteLine("La somma è: "+somma);



// SNACK 9  _________________________________________________________________________________________

int[] array;

// istanzio array di 100 elementi
array = new int[100];

int number;

//inizializzo indice
int i = 0;

int somma = 0;

do 
{
    Console.WriteLine("inserisci un numero");
    number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    somma = somma + number;
    i++;

} while (somma < 50);



// SNACK 10  _________________________________________________________________________________________

int[] array;

Console.WriteLine("quanti array vuoi creare?");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < number; i++)
{
    array = new int[10];
    for (int j = 0; j < 10; j++)
    {
        array[j] = new Random().Next(100);
    }

    Console.WriteLine("Stampo l'array");

    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(array[j]);
    }
}








