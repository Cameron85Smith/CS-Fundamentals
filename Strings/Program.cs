// Introduction to String.

var firstName = "John";
var lastName = "Smith";

var fullName = string.Format("My full name is {0} {1} ", firstName, lastName);
Console.WriteLine(fullName);

var listOfNames = new string[3] { "John", "Jack", "Sally" };

var names = string.Join(", ", listOfNames);
Console.WriteLine(names);

var name = "Cameron Smith   "; // <-- White space after my name.

// With the following method calls, we return new strings, so the original string is not affected.

// Trim() - Removes leading and trailing white space charactersfrom the current string.
Console.WriteLine($"Trimmed Name: '{name.Trim()}'");

// ToUpper() - Converts all letters to upper case.
Console.WriteLine($"ToUpper: '{name.Trim().ToUpper()}'");

// Split() - Splits the current string on the specifier and returns an array.
var nameLastName = name.Split(' ');
Console.WriteLine($"First name: {nameLastName[0]}, Last name: {nameLastName[1]}");

// Replace()
Console.WriteLine($"Replaced Name: {name.Replace(name, "Chanray Smith")}");

// Validation checks.
if (String.IsNullOrWhiteSpace(null) || String.IsNullOrWhiteSpace(" "))
    Console.WriteLine("Invalid");

// Conversion from string.
var str = "36";
var age = Convert.ToByte(str);
Console.WriteLine(age);

// Conversion from a number to a ZA currency.
float num = 29.93f;
Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-ZA");
Console.WriteLine($"Price: {num.ToString("C0")}");

// Summarizing text
var sentence = "This is going to be a really really really really really really really long text";

var summarizedText = StringUtility.SummarizeText(sentence, 25);
Console.WriteLine(summarizedText);