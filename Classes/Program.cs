using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(); // If the class does not have the static keyword, you have to create an instance (object) of the class.
            person.FirstName = "Cameron"; // if the class is static, we can initialise the properties directly afer adding the using statement for that specific class.
            person.LastName = "Smith";
            person.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine(result); // All methods of the Console class is static because we only have one console when running the application.
        }
    }
}