using System.IO;

// The Directory class provides static methods.

var path = @"c:\temp\folder1";

// CreateDirectory()
Directory.CreateDirectory(path);

// DeleteDirectory()
Directory.Delete(path);

// GetFiles()
Console.WriteLine("Directory Class - Static Method for files");

var files = Directory.GetFiles(@"C:\Program Files (x86)", "*.jpg", SearchOption.AllDirectories);

foreach(var file in files)
    Console.WriteLine(file);

Console.WriteLine("Directory Class - Static Method for directories");

var directories = Directory.GetDirectories(@"C:\Program Files (x86)", "*.*", SearchOption.AllDirectories);

foreach(var directory in directories)
    Console.WriteLine(directory);

if (Directory.Exists(@"C:\Program Files (x86)"))
{
    //
}

// The DirectoryInfo class provides instance methods.

var directoryInfo = new DirectoryInfo(path);

directoryInfo.Create();

directoryInfo.Delete();

Console.WriteLine("DirectoryInfo Class - Instance Method for directories");

var directoryInfoObject = new DirectoryInfo(@"C:\Program Files (x86)\");

var di = directoryInfoObject.GetDirectories();

foreach (var directory in di)
    Console.WriteLine(directory);