// Introduction to Type Conversion.

int i = 1000;
long y = i; // This is an implicit conversion.
byte b = (byte)i; // There will be data loss. This is an Explicit Conversion from int to byte.
Console.WriteLine("Implicit conversion of int to long: {0}", y);
Console.WriteLine("Explicit conversion of int to byte: {0}", b);

// We cannot convert type "string" to an "int", so we have to try the Convert method.
// int convertedToNumber = (int) number;
var number = "12345";
int convertedToInt = Convert.ToInt32(number); // This is an explicit converion from string to int. 
Console.WriteLine("Explicit conversion of string to int: {0}", convertedToInt);