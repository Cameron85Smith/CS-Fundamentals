
// (1) For loop - Count the amount of numbers that are divisible by 3.
var count = 0;

for (var i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
        count++;
}

Console.WriteLine($"There are {count} numbers that are divisible by 3");

// (2) While loop - Add numbers until user presses ok.
var sum = 0;
var userInput = "";

while (true)
{
    Console.WriteLine("Please enter a number to add to the end result, or press ok to exit.");
    userInput = Console.ReadLine();
    
    
    if (!String.IsNullOrWhiteSpace(userInput))
    {
        sum += Convert.ToInt32(userInput);
        
        continue;
    }

    break;
}

Console.WriteLine(sum);

// (3) While loop - Calculate the factorial number from a user's input.
Console.WriteLine("Please enter a number and we will calculate the factorial of that number.");
var userInputFactorial = Console.ReadLine();
var input = Convert.ToInt32(userInputFactorial);
var factorial = 1;

while (input > 0)
{
    factorial *= input;
    input--;
}

Console.WriteLine(factorial);

// (4) While loop, If - Guess the correct number
var random = new Random();
var randomNumber = random.Next(1, 10);
int chances = 4;
var userGuess = "";
var guess = 0;

while (chances > 0)
{
    Console.WriteLine($"You have {chances} chances to guess the random number. Please enter a number");
    userGuess = Console.ReadLine();
    guess = Convert.ToInt32(userGuess);

    if (guess == randomNumber)
    {
        Console.WriteLine($"Congratulations, you guessed the correct number, that being {randomNumber}");
        break;
    }
    
    chances--;
    continue;
}

if (chances == 0)
    Console.WriteLine($"You Lost. The random number was {randomNumber}. Game Over!!!");


// (5) For each - Get the maximum number from user input.
Console.WriteLine("Please enter a series of numbers separated by commas. Example: \"1,2,3,4,\" ");
var numbersInput = Console.ReadLine().Split(",");
var numbers = new int[numbersInput.Length];
var index = 0;

foreach (var number in numbersInput)
    numbers[index++] = Convert.ToInt32(number);

var maximumNumber = numbers.Max();
Console.WriteLine($"The maximum number in the unser input is {maximumNumber}");