
const int passwordLength = 10;

var random = new Random();
var buffer = new char[passwordLength];

for (var i = 0; i < passwordLength; i++)
{
    // Represents the english alphabet. If we add the number to a character, the result is going to be a number,
    // then we cast it to a character. The result will be a character.
    buffer[i] = ((char)('a' + random.Next(0, 26)));
}

var password = new string(buffer);
Console.WriteLine(password);