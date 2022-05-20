// (1) When you post a message on Facebook, depending on the number of people who
// like your post, Facebook displays different information. If no one likes your
//  post, it doesn't display anything.
// If only one person likes your post, it displays: [Friend's Name] likes your post.
// If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
// If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
// Write a program and continuously ask the user to enter different names, until
// the user presses Enter (without supplying a name). Depending on the number of
// names provided, display a message based on the above pattern.
var names = new List<string>();
var name = "";

while (true)
{
    Console.WriteLine("Please enter a friend's name.");
    name = Console.ReadLine();
    
    if (!String.IsNullOrWhiteSpace(name))
    {
      names.Add(name);
      continue;
    }

    break;
}

var nameCount = names.Count;

switch(nameCount)
{
    case 0:
    break;
    case 1:
        Console.WriteLine($"{names[0]} likes your post.");
    break;
    case 2:
        Console.WriteLine($"{names[0]} and {names[1]} like your post.");
    break;
    default:
        Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} other/s like your post.");
    break;
}

// (2) Write a program and ask the user to enter their name. Use an array to
// reverse the name and then store the result in a new string. Display the
// reversed name on the console.
var reversedName = "";

Console.WriteLine("Please enter your name.");
var userName = Console.ReadLine();

// First convert to a char array.
var nameChar = userName.ToCharArray();

// Reverse()
Array.Reverse(nameChar);

// Add characters to build the string up.
foreach (var c in nameChar)
    reversedName += c;

Console.WriteLine(reversedName);

// (3) Write a program and ask the user to enter 5 numbers. If a number has been
// previously entered, display an error message and ask the user to re-try. Once
// the user successfully enters 5 unique numbers, sort them and display the result
// on the console.
var numbers = new List<string>();
var userNumber = "";

while(true)
{
    Console.WriteLine("Please enter a unique number");
    userNumber = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(userNumber))
        break;

    if (!numbers.Contains(userNumber))
    {
        numbers.Add(userNumber);
        continue;
    }
    else
    {
        Console.WriteLine("You entered a number that is already in the list, please add a unique number");
        continue;
    } 

    break;
}

numbers.Sort();

foreach (var number in numbers)
    Console.WriteLine(number);

// (4) Write a program and ask the user to continuously enter a number or type
// "Quit" to exit. The list of numbers may include duplicates. Display the
// unique numbers that the user has entered.
var userNumbers = new List<int>();
var userInput = "";

while (true)
{
    Console.WriteLine("Please enter a number");
    userInput = Console.ReadLine();

    if (userInput == "Quit")
        return;
    else if (!String.IsNullOrWhiteSpace(userInput))
    {
        userNumbers.Add(Convert.ToInt32(userInput));
        continue;
    }

    break;
}

 var distinctNumbers = userNumbers.Distinct();

foreach (var distNumbers in distinctNumbers)
    Console.WriteLine(distNumbers);

// (5) Write a program and ask the user to supply a list of comma separated numbers
// (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
// display "Invalid List" and ask the user to re-try; otherwise, display the
// 3 smallest numbers in the list.
var userList = new List<string>();

while (true)
{
    Console.WriteLine("Please enter 5 numbers separated by a comma. Example: 1,2,3,4,5");
    
    userList = Console.ReadLine().Split(",").ToList();

    if (userList.Count == 0 || userList.Count < 5 )
    {
         System.Console.WriteLine("Invalid list, please try again.");
         continue;
    }

    break;
}

userList.Sort();
var smallestNumbers = userList.Take(3);

foreach (var number in smallestNumbers)
    Console.WriteLine(number);