// Introduction to List.

var numbers = new List<int>() {1, 2, 3, 4};

// Add()
numbers.Add(1);

// AddRange()
numbers.AddRange(new int[3] {7, 8, 9});

foreach (var number in numbers)
    Console.WriteLine(number);

Console.WriteLine();

// IndexOf()
Console.WriteLine($"The index of 1 is {numbers.IndexOf(1)}");

// LastIndexOf()
Console.WriteLine($"The last index of 1 is {numbers.LastIndexOf(1)}");

// Count()
Console.WriteLine($"We have {numbers.Count()} records in our list");

// Remove
Console.WriteLine("We remove all 1's from the list");

// In C#, we are not allowed to modify our collection in a foreach loop.
// We can modify it in a for loop.
for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] == 1)
        numbers.Remove(numbers[i]);
    
    Console.WriteLine(numbers[i]);
}

// Clear()
numbers.Clear();
Console.WriteLine($"The list has been cleared and it contains {numbers.Count} elements");