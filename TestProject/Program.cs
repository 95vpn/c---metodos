﻿/*
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello()
{
    Console.WriteLine("wert dfg dfg");
}

int[] a = { 1, 2, 3, 4, 5 };
Console.WriteLine("Constets of array");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.WriteLine($"{x} ");
    }
    Console.WriteLine();
}
*/
//void ShowData(string a, int b, int c);
//void  DisplayData(string month, int day, int year);

/*
Console.WriteLine("Generating random numbers");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1, 100)}");
    }

    Console.WriteLine();
}
*/

/*
using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMI");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule");

//Format and display medicine times
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    //Adjust the times by adding the difference, keeping the value within 24 hours 
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    //Adjust the times by adding the difference, keeping the value within 24 hours 
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");

//Format and display medicine times 
DisplayTimes();

Console.WriteLine();

void DisplayTimes()
{
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

void AdjustTimes()
{
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

*/

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and each ipAddres number is int range 0 -255

then ipAddress is ValidationAttribute
else ipAddress is invalid
*/

/*
string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.255", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;


foreach (string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid Ipv4 addres");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
};

void ValidateZeroes()
{

    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }
    validZeroes = true;

}

void ValidateRange()
{
    
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
*/

/*
Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

Console.WriteLine("A fortune teller whispers the following words:");

fortune();

void fortune()
{
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
*/

//Parametros en metodos
/*
CountTo(5);

void CountTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.WriteLine($"{i}, ");
    }
}
*/

/*
int[] schedule = {800, 1200, 1600, 2000};

DisplayAdjustTimes(schedule, 6, -6);

void DisplayAdjustTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 *  (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/

/*
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert", "Vanya"});

void DisplayStudents(string[] students)
{
    foreach (string student in students)
    {
        Console.WriteLine($"{student}, ");
    }
    Console.WriteLine();
}
*/


/*
void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    double circunference = 2 * pi * radius;
    Console.WriteLine($"Area = {area}");
    Console.WriteLine($"Circunference = {circunference}");
}
*/

/*
double pi = 3.14159;
PrintCircleArea(12);
PrintCircleCiecunference(12);
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCiecunference(radius);
}

void PrintCircleArea (int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCiecunference (int radius)
{
    double circunference = 2 * pi * radius;
    Console.WriteLine($"Circunference = {circunference}");
}
*/

/*

int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} * {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} * {b} = {c}");
}

int[] array = {1, 2, 3, 4, 5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray (int[] array)
{
    foreach (int a in array)
    {
        Console.Write($"{a}");
    }
    Console.WriteLine();
}

void Clear (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}
*/

/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth (string status, bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
*/

/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth (bool isHealthy)
{
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
*/

/*
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP (string name, int partySize, string allergies, bool inviteOnly)
{
    if (inviteOnly)
    {
        //search guestList before adding rsvp
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}


void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
*/

/*
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

CorreoElectronico(corporate, external, externalDomain);

void CorreoElectronico(string[,] corporate, string[,] external, string externalDomain)
{
    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        // display internal email addresses
        string name = corporate[i, 0];
        string lastName = corporate[i, 1];        
        Console.WriteLine($"{name.ToLower().Substring(0, 2)}{lastName.ToLower()}@contoso.com");
    }


    for (int i = 0; i < external.GetLength(0); i++)
    {
        // display external email addresses
        string name = external[i, 0];
        string lastName = external[i, 1];
        Console.WriteLine($"{name.ToLower().Substring(0, 2)}{lastName.ToLower()}@{externalDomain}");
    }
}
*/

/*
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";



for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
    MostrarEmail(firstName: corporate[i, 0], lastName: corporate[i, 1]);
}


for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
    MostrarEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
}

void MostrarEmail(string firstName, string lastName, string domain = "@contoso")
{
    string email = firstName.Substring(0, 2) + lastName;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}
*/

//Crear métodos que devuelven valores
/*
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
    Console.WriteLine("asdfs:" + total);
}

if (TotalMeetsMinimum())
{
    total -= 5;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
*/

/*
double usd = 23.71;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

Console.WriteLine(100 * 0.5);
*/

//Devolver string

/*
string input = "there are the snake at the zoo";
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));


string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
        // Console.WriteLine(result);
    }
    return result;
}

string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
*/

//Devuelve booleanos

/*
string[] words = {"racercar", "talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindromo?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");

}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
*/
//Devolver matrices desde metodos

/*
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }
        }
    }
    return new int[0];
}
*/

/*

int target = 80;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
    Console.WriteLine("No two coins make change");
}
else
{
    Console.WriteLine($"Change found at positions ");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        if (result[i,0] == -1)
        {
            break;
        }
        Console.WriteLine($"{result [i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target)
{
    int[,] result = {{-1,-1}, {-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0))
            {
                return result;
            }
        }
    }
    if (count == 0)
    {
        return new int [0, 0];
    }
    return result;
}
*/
/*
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay()
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget()
{
    return random.Next(1, 6);
}

int RollDice()
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target)
{
    if (roll > target)
    {
        return "You win";
    }
    return "You Lose";
}

*/

using System;
using System.Reflection;
string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macanas",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises", 
};

void RandomizeAnimals()
{
    
    
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(pettingZoo.Length);
        string temp = pettingZoo[i]; 
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;  
        
    }

   
   
   
   

}

 foreach (string animal in pettingZoo)
 {
     Console.WriteLine(animal);
 }

//AssingGroup();

Console.WriteLine("School A");

//PrintGroup(group);


//string[,] group = AssignGroup();

//Actualmente hat tres ecuelas visitantes
//La escuela A tienes seis grupos de visitantes (el numero predeternminado)
//L a escuela B tiene tres grupos de visita
//La escuela C tiene dos grupos de visita

//Para cada escuela visitada, realice las siguientes tareas
//Aleatorizar los animales
//Asigna los animales al número correcto de grupos 
//Imprima el nombre de la escuela








