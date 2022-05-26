// (1) Write a program that reads a text file and displays the number of words.
var words = File.ReadAllText(@"FileToRead.txt").Split();
Console.WriteLine($"There are {words.Count()} words in the file.");

// (2) Write a program that reads a text file and displays the longest word in the file.
var longestWord = "";

 for (int i = 0; i < words.Count(); i++)
{
    if (longestWord.Length < words[i].Length)
    {
        longestWord = words[i];
    }
}

Console.WriteLine($"The longest word in the file is: {longestWord}" );