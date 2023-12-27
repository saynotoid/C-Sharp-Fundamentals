namespace _02_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //// Enter two integers numbers and check if they can represent the day and month.
            //// Output result on the console.

            //Console.Write("Enter day -> ");
            //int.TryParse(Console.ReadLine(), out int day);

            //Console.Write("Enter month -> ");
            //int.TryParse(Console.ReadLine(), out int month);

            //// Magic numbers  ahead!!!
            //Console.WriteLine((0 < day && day < 32) && (0 < month && month < 13)
            //    ? "They can" : "They cannot");

            //// 2
            //// Enter double  number  and get the first 2 digits after the point of this number
            //// and output the sum of these numbers. For example: 3.456 -> 4+5=9

            //Console.Write("Enter the number with floating point -> ");
            //double.TryParse(Console.ReadLine(), out double number);
            //// removing digits before dot: 3.456 - 3 = 0.456;
            //number -= (int)number;
            //// taking out first digit 0.456 * 10 = 4.56 -> 4; //can be put in a method
            //int firstDigit = (int)(number *= 10);
            //// removing first digit after the dot: 4.56 - 4 = 0.56;
            //number -= firstDigit;
            //// taking out second digit 0.56 * 10 = 5.6 -> 5;  //can be put in a method
            //int secondDigit = (int)(number *= 10);
            //Console.WriteLine(firstDigit + secondDigit);

            //// 3
            //// Enter integer number  h, representing the time of day (hour).
            //// Depending on the time of day, output greetings
            //// ("Good morning!", "Good afternoon!", "Good evening!“ or "Good night!")

            //Console.Write("Enter time of the day (hour) -> ");
            //int.TryParse(Console.ReadLine(), out int hour);

            //if ( 0 <= hour && hour <= 24 )
            //{
            //    if (hour < 6 || hour == 24) hour = 0;
            //    else if (hour < 12) hour = 6;
            //    else if (hour < 18) hour = 12;
            //    else hour = 18;

            //    Console.WriteLine($"Good {(TimeOfDay)hour}!");
            //}
            //else
            //    Console.WriteLine("Input time of the day (hour) between 0 and 24 hours");

            //// 4
            //// Identify enum TestCaseStatus {Pass, Fail, Blocked, WP, Unexecuted}.
            //// Assign status “Pass” for variable test1Status and output result on the console.

            //int test1Status = 0;
            //Console.WriteLine((TestCaseStatus)test1Status);

            //// 5
            //// Determine struct RGB that represents the color with fields red, green, blue (type byte).
            //// Identify two variables of this type and enter their fields for white and black colors.

            //RGB colorWhite, colorBlack;

            //colorWhite.red = 255;
            //colorWhite.green = 255;
            //colorWhite.blue = 255;

            //colorBlack.red = 0;
            //colorBlack.green = 0;
            //colorBlack.blue = 0;

            // ADDITIONAL TASKS

            //// 1
            //// Create class Cat.
            //// The cat should have a property "fullness level" and method "eat something".
            //// Create enum Food (fish, mouse, ...).
            //// Each type of food should change the level of satiety differently.

            //Cat cat = new Cat();
            //Console.WriteLine($"Cat fullness level is {cat.FullnessLevel}");
            //cat.EatSomething(Food.snacks);
            //Console.WriteLine($"Cat fullness level is {cat.FullnessLevel}");
            //cat.EatSomething(Food.cheese);
            //Console.WriteLine($"Cat fullness level is {cat.FullnessLevel}");
            //cat.EatSomething(Food.mouse);
            //Console.WriteLine($"Cat fullness level is {cat.FullnessLevel}");
            //cat.EatSomething(Food.mouse);
            //Console.WriteLine($"Cat fullness level is {cat.FullnessLevel}");

            //// 2
            //// Create struct Student with fields last name and group number.
            //// Create array of students and output student names of a given group
            ////      that begin with a given letter.
            //// The last name and group number are entered from the console.

            //Student[] students = new Student[4];
            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i] = new Student();
            //    Console.Write($"Enter student's numer {i} last name -> ");
            //    students[i].lastName = Console.ReadLine();
            //    Console.Write($"Enter student's numer {i} group number -> ");
            //    byte.TryParse(Console.ReadLine(), out students[i].groupNumber);
            //}

            //Console.WriteLine();
            //Console.Write("What group number r u interested in? -> ");
            //byte.TryParse(Console.ReadLine(), out byte groupNumber);
            //Console.Write("Gimme a letter to work with -> ");
            //char startingLetter = Convert.ToChar(Console.ReadLine());

            //foreach (Student student in students)
            //{
            //    if (student.groupNumber == groupNumber && student.lastName.StartsWith(startingLetter))
            //        Console.WriteLine(student);
            //}
        }
        enum TimeOfDay
        {
            night = 0,
            morning = 6,
            afternoon = 12,
            evening = 18
        }
        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }
        struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }

        class Cat()
        {
            private int fullnessLevel = 0;
            public int FullnessLevel
            {
                get { return fullnessLevel; }
                set { fullnessLevel = value; }
            }
            public void EatSomething(Food food)
            {
                //new Random().Next(1, 4)
                FullnessLevel += (int)food;
            }
        }
        enum Food { fish = -4, mouse = 2, cheese = 1, snacks = 13 }
        //enum Food { fish = 1, mouse, cheese, snacks }

        struct Student
        {
            public string lastName;
            public byte groupNumber;

            public override string ToString()
            {
                return String.Format($"L.Name -> {lastName} from group number -> {groupNumber}");
            }
        }
    }
}
