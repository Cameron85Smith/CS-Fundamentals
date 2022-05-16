byte number = 2; // byte
var counter = 10; // int32
var totalPrice = 20.95f; // "f" tells the compiler to treat the value as a float 
var character = 'A'; // Single quote for characters
var firstName = "Cameron"; // Double quote for strings
var isWorking = false; // Boolrsn

Console.WriteLine(number);
Console.WriteLine(counter);
Console.WriteLine(totalPrice);
Console.WriteLine(character);
Console.WriteLine(firstName);
Console.WriteLine(isWorking);

Console.WriteLine();

// This is known as a "Format String". It can be used as a template.
Console.WriteLine("Byte Minimum Value: {0}\nByte Maximum Value: {1}", byte.MinValue, byte.MaxValue);
Console.WriteLine("Float Minimum Value: {0}\nFloat Maximum Value: {1}", float.MinValue, float.MaxValue);

// This const value cannot be changed, it is a readonly value.
const float Pi = 3.14f;
Console.WriteLine(Pi);