namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            // Define class Car with fields
            // name, color, price and const field CompanyName
            // Create two constructors - default and with parameters.
            // Create a property to access the color field.
            // Define methods:
            // Input () - to enter data about cars from the console,
            // Print () - to output data about cars on the console
            // ChangePrice (double x) - to change the price by x%

            // 2
            // Enter data about 3 cars.

            // 3
            // Decrease car price by 10%, display info about the car on the console

            // 4
            // Enter a new color and “repaint” the car from the color white in the defined color

            // 5
            // Overload operator == for the class Car (cars - equal if the name and price are equal)

            // 6
            // Override method ToString()  in the class Car, which returns a line with data about cars

            Console.WriteLine("Hello, enter info about 3 cars down below -> ");

            Car[] cars = new Car[3];
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = new Car();
                cars[i].Input();
            }

            cars[2].ChangePrice(10);

            cars[2].Print();

            Console.Write("Enter a new colour -> ");
            cars[2].Color = Console.ReadLine();

            Console.WriteLine("Extra stuff below:");
            Console.WriteLine(cars[2]);

            Console.WriteLine($"Are cars equal? -> {cars[0] == cars[1]}");

        }
    }
}
