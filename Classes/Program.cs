using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {   // If the class does not have the static keyword, you have to create an instance (object) of the class.
            // if the class is static, we can initialise the properties directly afer adding the using statement for that specific class.
            var person = new Person(); 
            person.FirstName = "Cameron"; 
            person.LastName = "Smith";
            person.Introduce();

            var calculator = new Calculator();
            var result = calculator.Add(1, 3);
            Console.WriteLine(result);
        }
    }
}