// Introduction to Iterations.

// For loop - Get all even numbers.
Console.WriteLine("For Loop - Get all even numbers.");

for (var i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// For loop - Get all even numbers in reverse.
Console.WriteLine("\nFor Loop - Get all even numbers in reverse.");

for (var i = 10; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

// For loop - Over a string.
var name = "Cameron Smith";
Console.WriteLine("\nFor loop over a string.");

for (var i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}

// For Each loop - Over a string.
Console.WriteLine("\nFor Each loop over a string.");

foreach (var i in name)
{
    Console.WriteLine(i);
}

// For Each loop - Over an Array.
Console.WriteLine("\nFor Each loop over an Array.");

var numbers = new int[] {1, 2, 3, 4};

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

// While loop - Get all even numbers.
Console.WriteLine("\nWhile Loop - Get all even numbers.");

var j = 0;
while (j <= 10)
{
     if (j % 2 == 0)
     {
         Console.WriteLine(j);
     }
    j++;
}

// While loop with continue - Get user name.
Console.WriteLine("\nWhile loop with continue - Get user name.");

while (true)
{
    Console.WriteLine("Type your name");
    var userName = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(userName))
    {
        Console.WriteLine($"Your name is {userName}");
        continue;
    }

    break;
}