
var path = @"C:\Users\camer\Pictures\2022-01-25\003.jpg";

// GetExtension()
Console.WriteLine($"Extension of file: {Path.GetExtension(path)}");

// GetFileName()
Console.WriteLine($"File name: {Path.GetFileName(path)}");

// GetFileNameWithoutExtension()
Console.WriteLine($"File name without extension: {Path.GetFileNameWithoutExtension(path)}");

// GetDirectoryName()
Console.WriteLine($"Directory name: {Path.GetDirectoryName(path)}");