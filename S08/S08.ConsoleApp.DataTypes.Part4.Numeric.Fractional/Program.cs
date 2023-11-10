Console.WriteLine("*** youtube.com/@msavarian (C# Learning Videos In Persian) ***");
Console.WriteLine("**** C# - S08.ConsoleApp.DataTypes.Part4.Numeric.Fractional ****");



// *** Data Types -> Numeric - Floating Point Numbers

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue}   to {float.MaxValue}   (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue}  to {double.MaxValue}  (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// *** .Net Data Types -> Numeric -> No alias in C# 
Console.WriteLine($"Half : {Half.MinValue} to {Half.MaxValue}");

//var num1 = 3.5d;
//var num2 = 3.5F;
//var num3 = 3.5M;

Console.WriteLine("");
Console.WriteLine("");

float num1f = 1.0F;
float num2f = 3.0F;
float num3f = num1f / num2f;
Console.WriteLine($"1.0F / 3.0F = {num3f}");

double num1d = 1.0d;
double num2d = 3.0d;
double num3d = num1d / num2d;
Console.WriteLine($"1.0D / 3.0D = {num3d}");

decimal num1m = 1.0m;
decimal num2m = 3.0m;
decimal num3m = num1m / num2m;
Console.WriteLine($"1.0M / 3.0M = {num3m}");


Console.WriteLine("");
Console.WriteLine("");

int a = 5;
int b = 5;
int c = 3;
Console.WriteLine("(a + b) / c = " + (a + b) / c); // 3
Console.WriteLine("(a + b) % c = " + (a + b) % c);
Console.WriteLine("");


double a1 = 5;
double b1 = 5;
double c1 = 3;
Console.WriteLine("(a1 + b1) / c1 = " + (a1 + b1) / c1); // 3.3333334
Console.WriteLine("");

Console.WriteLine("\n\n\n\n\n\n\n");