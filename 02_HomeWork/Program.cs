namespace _02_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 1
            //// Read 3 float numbers and check if they are all in the range [-5.5].

            ////Console.WriteLine("Input 3 float numbers one by one : ");
            //float.TryParse(Console.ReadLine(), out float num1);
            //float.TryParse(Console.ReadLine(), out float num2);
            //float.TryParse(Console.ReadLine(), out float num3);

            //if ((-5 <= num1 && num1 <= 5) && (-5 <= num2 && num2 <= 5) && (-5 <= num3 && num3 <= 5))
            //    //Console.WriteLine("they are all in the range [-5.5]");
            //    Console.WriteLine("True");
            //else
            //    //Console.WriteLine("at least some of them are not in the range [-5.5]");
            //    Console.WriteLine("False");

            //// 2
            //// Read 3 integer numbers and output max and min of them.

            ////Console.WriteLine("Input 3 integer numbers, please, one by one : ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //int.TryParse(Console.ReadLine(), out int num2);
            //int.TryParse(Console.ReadLine(), out int num3);

            //Console.WriteLine($"max: {(num1 < num2 ? num2 < num3 ? num3 : num2 : num1 < num3 ? num3 : num1)}");
            //Console.WriteLine($"min: {(num1 < num2 ? num1 < num3 ? num1 : num3 : num2 < num3 ? num2 : num3)}");

            //// 3
            //// Read number of HTTP Error (400, 401,402, ...) and write the name of this error
            //// (Declare enum HTTPError)

            ////Console.Write("Input HTTP Error code (400, 401,402, ...) -> ");
            //int.TryParse(Console.ReadLine(), out int errorCode);
            //Console.WriteLine((HTTPError)errorCode);

            //// 4
            //// Declare struct Dog with fields name, mark, age.
            //// Declare object myDog of Dog type and read values for it.
            //// Output information on the console. (Override method ToString in struct)

            //Dog myDog;
            //myDog.name = Console.ReadLine();
            //myDog.mark = Console.ReadLine();
            //byte.TryParse(Console.ReadLine(), out myDog.age);

            //Console.WriteLine(myDog);

        }
        enum HTTPError
        {
            BadRequest = 400,
            Unauthorized,
            PaymentRequired,
            Forbidden,
            NotFound,
            MethodNotAllowed,
            NotAcceptable,
            ProxyAuthenticationRequired,
            RequestTimeout,
            Conflict,
            Gone,
            LengthRequired,
            PreconditionFailed,
            PayloadTooLarge,
            URITooLong,
            UnsupportedMediaType,
            RangeNotSatisfiable,
            ExpectationFailed,
            ImaTeapot = 418,
            MisdirectedRequest = 421,
            UnprocessableEntity,
            Locked,
            FailedDependency,
            TooEarly,
            UpgradeRequired = 426,
            PreconditionRequired = 428,
            TooManyRequests = 429,
            RequestHeaderFieldsTooLarge = 431,
            UnavailableForLegalReasons = 451
        }

        struct Dog
        {
            public string name;
            public string mark;
            public byte age;
            public override string ToString()
            {
                return string.Format($"Name: {name}, mark: {mark}, age: {age}");
            }
        }
    }
}
