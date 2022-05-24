namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // (1) if/else - Check if input is valid.
            Console.WriteLine("Please enter a value between 0 and 10");
            var userInput = Console.ReadLine();

            var input = Convert.ToInt32(userInput);
            var validation = input > 1 && input < 10 ? "Valid" : "Invalid";

            Console.WriteLine(validation);

            // (2) Ternary - Find the maximum value.
            Console.WriteLine("Please enter your first number");
            var firstUserInput = Console.ReadLine();
            Console.WriteLine("Please enter your last number");
            var secondUserInput = Console.ReadLine();

            var firstInput = Convert.ToInt32(firstUserInput);
            var secondInput = Convert.ToInt32(secondUserInput);
            var maxValue = firstInput > secondInput ? firstInput : secondInput;

            Console.WriteLine(maxValue);

            // (3) if/else - Image Orientation.
            Console.WriteLine("Please enter the width of the image");
            var widthUserInput = Console.ReadLine();
            Console.WriteLine("Please enter the height of the image");
            var heightUserInput = Console.ReadLine();

            var width = Convert.ToInt32(widthUserInput);
            var height = Convert.ToInt32(heightUserInput);

            if (width > height)
            {
                Console.WriteLine("Landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("The ratio of the image is 1:1");
            }

            // (4) if/else - Speed Camera
            Console.WriteLine("Please enter the speed limit");
            var speedLimitUserInput = Console.ReadLine();
            Console.WriteLine("What was the speed of the car?");
            var vehicleSpeedUserInput = Console.ReadLine();

            var speedLimit = Convert.ToInt32(speedLimitUserInput);
            var vehicleSpeed = Convert.ToInt32(vehicleSpeedUserInput);
            var demeritPoints = (vehicleSpeed - speedLimit) / 5;
            
            if (speedLimit > vehicleSpeed)
            {
                Console.WriteLine("OK");
            }
            else if (demeritPoints > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                demeritPoints = (vehicleSpeed - speedLimit) / 5;
                Console.WriteLine($"Demerit Points: {demeritPoints}");
            }
        }
    }
}