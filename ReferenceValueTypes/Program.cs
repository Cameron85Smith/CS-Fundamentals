public class Person
{
    public int Age;
}

class Program
{
    
    public static void Increment(int number)
    {
        number += 10;        
    }

    public static void MakeOld(Person person)
    {
        person.Age += 10;
    }

    public static void Main(string[] args)
    {
        // (1) Value Type Example
        int a = 10; // int is a value type because it is a primitive.

        // We copy a value to b. Meaning that the copy is in a different target location,
        // denoted by b. These two variables are completely independent of one another.
        int b = a;

        b++; // Making a change to one variable does not affect the other variable.

        Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

        // (2) Reference Type Example
        var array1 = new int[3] {1, 2, 3}; // array is a reference type because it is a class.

        // Array1 and Array2 is stored in a Heap. The address of array1 is copied to array 2.
        // This means that both arrays are pointing to the same address. If we make a change
        // to a value, it is reflected in both array1 and array2 because the change is done
        // on an address that both arrays read from.
        var array2 = array1;
        array2[0] = 0;

        Console.WriteLine(string.Format("First element of array1: {0}\nFirst element of array2: {1}",
                                        array1[0], array2[0]));

        // (3) Value Type Example
        var number = 1;
        // A copy of number is sent to the increment method. As a value type, number remains
        // 1. number is only scoped in the main method and belongs to a specific memory location.
        // The increment method has a parameter called number as well, but that parameter is in
        // a different memory location. Increments number is scoped to the increment method only.
        Increment(number);

        Console.WriteLine("The value of number, scoped to Main: {0}", number);

        // (4) Reference Type Example
        // Person is a reference type because it is a class. We set the age to 1.
        var person = new Person() {Age = 1};
        // We now pass an address of the person object to the MakeOld method.
        // The MakeOld method goes to the value in the address provided and makes a change
        // to the Age.
        MakeOld(person);

        // This change is visible to the person.Age property because it references the same
        // memory address.
        Console.WriteLine("The value of person.Age, scoped to Main: {0}", person.Age);
    }
}