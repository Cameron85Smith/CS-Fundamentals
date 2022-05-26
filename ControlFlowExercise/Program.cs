// (1) Write a program to count how many numbers between 1 and 100 are divisible
// by 3 with no remainder. Display the count on the console.
var count = 0;

for (var i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
        count++;
}

Console.WriteLine($"There are {count} numbers that are divisible by 3");

// (2) Write a program and continuously ask the user to enter a number or "ok" to exit.
// Calculate the sum of all the previously entered numbers and display it on the console.
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

// (3) Write a program and ask the user to enter a number. Compute the factorial of the
// number and print it on the console. For example, if the user enters 5, the program
// should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
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

// (4) Write a program that picks a random number between 1 and 10. Give the user 4 chances
// to guess the number. If the user guesses the number, display “You won"; otherwise, display
// "You lost". (To make sure the program is behaving correctly, you can display the secret
// number on the console first.)
var random = new Random();
var randomNumber = random.Next(1, 10);
int chances = 4;
var userGuess = "";
var guess = 0;

while (chances > 0)
{
    Console.WriteLine($"You have {chances} chances to guess the random number. Please enter a number");
    userGuess = Console.ReadLine();

    if (!String.IsNullOrWhiteSpace(userGuess))
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


// (5) Write a program and ask the user to enter a series of numbers separated by comma.
// Find the maximum of the numbers and display it on the console. For example,
// if the user enters "5, 3, 8, 1, 4", the program should display 8.
Console.WriteLine("Please enter a series of numbers separated by commas. Example: \"1,2,3,4,\" ");
var numInput = Console.ReadLine();

if (String.IsNullOrWhiteSpace(numInput))
    return;  

var numbersInput = numInput.Split(",");
var numbers = new int[numbersInput.Length];
var index = 0;

foreach (var number in numbersInput)
    numbers[index++] = Convert.ToInt32(number);

Console.WriteLine($"The maximum number in the user input is {numbers.Max()}");