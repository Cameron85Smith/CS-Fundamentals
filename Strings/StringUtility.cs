public class StringUtility
{
    // Our main method is static, this method needs to be static as well so that main can call it.
    public static string SummarizeText(string text, int maxLength = 20)
    {
        if (text.Length < maxLength)
            return text;

        var words = text.Split(); // Split words into an array.
        var totalCharacters = 0;
        var summaryWords = new List<string>();

        foreach (var word in words)
        {
            summaryWords.Add(word); // Store each word into its own index in a list.
            totalCharacters += word.Length + 1; // +1 accounts for the space after the word.

            if (totalCharacters > maxLength) // If the word length is more than 20, break out and stop adding.
                break;
        }

        return String.Join(" ", summaryWords) + "..."; // We format and return the string.
    }
}