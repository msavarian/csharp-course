
Console.WriteLine("*** youtube.com/@msavarian (C# Learning Videos In Persian) ***");

/*
int number1 = 5;
int number2 = 5;
Console.WriteLine(number1 + number2);

number1 = 6;
number2 = 6;
Console.WriteLine(number1 + number2);
*/

/***** Variables ********************************/
/*
Console.Write("Please Enter Your Name: ");
string name = Console.ReadLine();
Console.WriteLine("Hi " + name);
Console.Write(name + " Enter Your Age: ");
Console.ReadLine();
*/

// Strongly Type
// string name = 5; // Error
string name = "5";

// int age = "32"; // Error
int age = 32;

Console.WriteLine("\n\n\n");


//int a;
//int b;
//int c;

//int a=1;
//int b=1;
//int c=1;

// int a, b, c;

//int a=1, b=1, c=2;

//int a, b, c;
//a = b = c = 1;


/***** Constants ********************************/

// int StartWorkHour = 8; // a variable and it's not good 
const int StartWorkHour = 8;
Console.WriteLine("All Employee Should Start Working At " + StartWorkHour);

const string Day1 = "Saturday";
const string Day2 = "Sunday";
const string Day3 = "Monday";
const string Day4 = "Tuesday";
const string Day5 = "Wednesday";
const string Day6 = "Thursday";
const string Day7 = "Friday";

/***** Enum ********************************/

namespace S06.ConsoleApp.Variables
{
    enum WeekDays
    {
        Saturday=1,
        Sunday=2,
        Monday=3,
        Tuesday=4,
        Wednesday=5,
        Thursday=6,
        Friday=7
    }
}