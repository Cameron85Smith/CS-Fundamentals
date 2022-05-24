using System.Text;
// (1) - Write a program and ask the user to enter a few numbers separated by a hyphen.
// Work out if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
// or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

Console.WriteLine("Enter a few numbers separated by a hyphen. Example : 1-2-3-4-5");
var userInput = Console.ReadLine().Split('-');
var indexValuesAsc = 0;
var indexValuesDesc = 0;

if (userInput.Count() < 2 )
    return;
else    
{
    indexValuesAsc = Convert.ToInt32(userInput[0]);
    indexValuesDesc = Convert.ToInt32(userInput[0]);
}

for (int i = 0; i < userInput.Count(); i++)
{
    if (Convert.ToInt32(userInput[i]) == indexValuesAsc || Convert.ToInt32(userInput[i]) == indexValuesDesc)
    {
        indexValuesAsc++;
        indexValuesDesc--;
    }
    else
    {
        Console.WriteLine("Not Consecutive");
        break;
    }

    if (i == userInput.Count() - 1)
        Console.WriteLine("Consecutive");
}

// (2) - Write a program and ask the user to enter a few numbers separated by a hyphen.
// If the user simply presses Enter, without supplying an input, exit immediately;
// otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.

Console.WriteLine("Enter a few numbers separated by a hyphen. Example : 1-2-3-4-5");
userInput = Console.ReadLine().Split('-');

if (userInput.Count() < 2 )
    return;

var distinct = userInput.Distinct();

var duplicateCheck = distinct.Count() != userInput.Count() ? "Duplicates" : "No Duplicates";
Console.WriteLine(duplicateCheck);

// (3) - Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
// A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display
// "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

TimeSpan time;

Console.WriteLine("Please enter a time value. e.g. 19:00");
var userValue = Console.ReadLine();
TimeSpan.TryParse(userValue, out time);
var minTime = TimeSpan.Parse("00:00");
var maxTime = TimeSpan.Parse("23:59");

var validity = time > minTime && time < maxTime ? "OK" : "Invalid Time";

Console.WriteLine(validity);

// (4)- Write a program and ask the user to enter a few words separated by a space. Use the words to create
// a variable name with PascalCase. For example, if the user types: "number of students", display
// "NumberOfStudents". Make sure that the program is not dependent on the input. So, if the user types
// "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".

Console.WriteLine("Please enter a few words separated by a space.");
var words = Console.ReadLine().ToLower().Split(' ');
var pascalCase = new StringBuilder();

foreach(var word in words)
    pascalCase.Append(char.ToUpper(word[0]) + word.Substring(1));

Console.WriteLine(pascalCase);

// (5)- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i)
// in the word. So, if the user enters "inadequate", the program should display 6 on the console.

Console.WriteLine("Please enter a word");
var userWord = Console.ReadLine().ToCharArray();

if (userWord.Count() < 1)
    return;

var count = 0;

foreach (var letter in userWord)
{
    switch (letter)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            count++;
            break;
        default:
            break;
    }
}

Console.WriteLine(count);