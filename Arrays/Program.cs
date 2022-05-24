var numbers = new int[3] {1, 2, 3};

foreach (var value in numbers)
    Console.WriteLine(value);

var flags = new bool[2] {true, false};

foreach (var flag in flags)
    Console.WriteLine(flag);

var names = new string[3] {"Cameron", "Chanray", "Duncan"};

foreach (var name in names)
    Console.WriteLine(name);

// Length
var arrayNumbers = new[] { 3, 7, 9, 2, 14, 6 };

Console.WriteLine($"Length of the Array: {arrayNumbers.Length}");

// IndexOf()
var index = Array.IndexOf(arrayNumbers, 14);
Console.WriteLine($"Index of 14 in the Array: {index}");

// Clear()
Array.Clear(arrayNumbers, 0, 2);

Console.WriteLine("Values in the Array after clearing the first two elements:");

foreach(var number in arrayNumbers)
    Console.WriteLine(number);

// Copy()
var copiedArray = new int[3];
Array.Copy(arrayNumbers, copiedArray, 3);

System.Console.WriteLine("Copied Array values");

foreach(var number in copiedArray)
    Console.WriteLine(number);

// Sort()
Array.Sort(arrayNumbers);

Console.WriteLine("Sorted Array values");

foreach (var number in arrayNumbers)
    Console.WriteLine(number);

// Reverse()
Array.Reverse(arrayNumbers);

Console.WriteLine("Array in reverse order");

foreach (var number in arrayNumbers)
    Console.WriteLine(number);