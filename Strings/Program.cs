var firstName = "Cameron";
var lastName = "Smith";

var fullName = string.Format("My full name is {0} {1} ", firstName, lastName);
Console.WriteLine(fullName);

var listOfNames = new string[3] {"Cameron", "Chanray", "Duncan"};

var names = string.Join(", ", listOfNames);
Console.WriteLine(names);