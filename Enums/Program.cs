// Introduction to Enums.

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}

class Program
{
    static void Main(string[] args)
    {
        var shippingMethod = ShippingMethod.RegisteredAirMail; // We use dot notation on the enum.
        Console.WriteLine((int)shippingMethod); // We can cast it to display the numeric value of the enum.
        var stringValueOfEnum = shippingMethod.ToString(); // Here, we convert the enum to a string. This is useful when we are not using WriteLine.
        Console.WriteLine(stringValueOfEnum); 

        var shippingMethodId = 3; // We receive a numeric value from another system.
        Console.WriteLine((ShippingMethod)shippingMethodId); // We cast this numeric value to the ShippingMethod Enum and display its string value.

        var methodName = "RegularAirMail"; // We receive a string value from another system.
        var shippingMethodName = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName); // We parse it to a ShippingMethod type, and cast it as a ShippingMethod.
        Console.WriteLine(shippingMethodName);
    }
}