// Introduction to the Path class.

var path = @"FileToRead.txt";

// GetExtension()
Console.WriteLine($"Extension of file: {Path.GetExtension(path)}");

// GetFileName()
Console.WriteLine($"File name: {Path.GetFileName(path)}");

// GetFileNameWithoutExtension()
Console.WriteLine($"File name without extension: {Path.GetFileNameWithoutExtension(path)}");

// GetDirectoryName() - Returns Empty if path does not contain directory information.
Console.WriteLine($"Directory name: {Path.GetDirectoryName(path)}");