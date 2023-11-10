using System.Numerics;

Console.WriteLine("*** youtube.com/@msavarian (C# Learning Videos In Persian) ***");
Console.WriteLine("**** C# - S08.ConsoleApp.DataTypes.Part3.Numeric.Integral ****");
Console.WriteLine("\n\n");


// *** C# Data Types -> Numeric - Integer
Console.WriteLine("");
Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue} and size in memory is {sizeof(sbyte)}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue} and size in memory is {sizeof(short)}");
Console.WriteLine($"int    : {int.MinValue}   to {int.MaxValue}   and size in memory is {sizeof(int)}");
Console.WriteLine($"long   : {long.MinValue}  to {long.MaxValue}  and size in memory is {sizeof(long)}");


Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue} and size in memory is {sizeof(byte)}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue} and size in memory is {sizeof(ushort)}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue} and size in memory is {sizeof(uint)}");
Console.WriteLine($"ulong (System.Int64)  : {ulong.MinValue} to {ulong.MaxValue} and size in memory is {sizeof(ulong)}");

//sbyte num1 = 200; // Has Error
//byte num1 = 200; 

//var num1=10;
//sbyte num1=10;


// Data Type Operators
Console.Write(sizeof(int));
Console.Write(typeof(int));
//Console.WriteLine($"size of int     in memory is {sizeof(int)}");        //returns 4
//Console.WriteLine($"size of char    in memory is {sizeof(char)}");       // returns 2
//Console.WriteLine($"size of bool    in memory is {sizeof(bool)}");       //returns 1
//Console.WriteLine($"size of long    in memory is {sizeof(long)}");       //returns 8
//Console.WriteLine($"size of float   in memory is {sizeof(float)}");      //returns 4
//Console.WriteLine($"size of double  in memory is {sizeof(double)}");     //returns 8 
//Console.WriteLine($"size of decimal in memory is {sizeof(decimal)}");    //returns 16



// Integral Literal (Type Inference Suffixes)
var num1 = 20;
var num2 = 20u;
var num3 = 20l; // 20L
var num4 = 20ul;


// Integral Literal (Base Number Prefix)
// base 2,10,16
var b10 = 101;
var b2 = 0b101; // 5
var b16 = 0x101Face;



// *** C# Data Types -> Numeric - Integer -> Platform Dependent Data Types
// Native-sized integers (ranges)
Console.WriteLine("");
Console.WriteLine($"nint {nint.MinValue} to {nint.MaxValue}");
Console.WriteLine($"nuint {nuint.MinValue} to {nuint.MaxValue}");


// Native-sized integers (size)
//Console.WriteLine($"size of nint = {nint.Size}");
//Console.WriteLine($"size of nuint = {sizeof(nuint)}");

// * output when run in a 64-bit process
// *  size of nint = 8
// *  size of nuint = 8
// * output when run in a 32-bit process
// *  size of nint = 4
// *  size of nuint = 4



// Big Integer
BigInteger bi1 = 2147483647;
Console.WriteLine("BigInteger: {0}", bi1);

BigInteger bi2 = new BigInteger(2147483647);
Console.WriteLine("BigInteger from double value: {0}", bi2);

BigInteger bi3 = new BigInteger(9223372036854775807);
Console.WriteLine("BigInteger from Int64 value: {0}", bi3);

BigInteger bi4 = new BigInteger(18446744073709551615);
Console.WriteLine("BigInteger from UInt64 value: {0}", bi4);



// Digital Separator
int sep = 516_516_561;