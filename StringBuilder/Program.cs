using System.Text;
var builder = new StringBuilder("Hello World");
var chainedBuilder = new StringBuilder("Hello World");

builder.Append('-', 10);
builder.AppendLine();
builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);
builder.Replace('-', '+');
builder.Remove(0, 10);
builder.Insert(0, new string('-', 10));
Console.WriteLine(builder);
Console.WriteLine($"First character: {builder[0]}");

// We can chain our StringBuilder methods because every method below returns a StringBuilder.
Console.WriteLine();
Console.WriteLine("Our Chained Methods:");

chainedBuilder
    .Append('-', 10)
    .AppendLine()
    .Append("Header")
    .AppendLine()
    .Append('-', 10)
    .Replace('-', '+')
    .Remove(0, 10)
    .Insert(0, new string('-', 10));

Console.WriteLine(chainedBuilder);