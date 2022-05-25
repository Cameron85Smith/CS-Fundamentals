using System.IO;

// If you make use of a small number of operations, it is better to use the
// File class as it provides static methods. However, every time you call a
// static method, the operating system does security checking.This can affect
// performance if you are running a large number of operations.

var path = @"c:\somefile.jpg";

// Copy()
File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

// Delete()
File.Delete(path);

// Exists()
if (File.Exists(path))
{
    //
}

// ReadAllText() - Returns a string.
var stringContent = File.ReadAllText(path);

// ReadAllBytes() - Returns a byte array.
var byteContent = File.ReadAllBytes(path);

// If you make use of a large number of operations, it is better to use the
// FinleInfo class as it provides instance methods. It is more efficient to
// call the instance methods as the operating system does only one security
// check on the object.

var fileInfo = new FileInfo(path);
var destination = @"c:\temp\";

// CopyTo()
fileInfo.CopyTo(destination, true);

// Delete()
fileInfo.Delete();

// Exists - It is a property
if (fileInfo.Exists)
{
    //
}