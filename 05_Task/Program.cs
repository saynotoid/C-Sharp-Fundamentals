using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _05_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Develop interface IFlyable with method Fly()
            // (Output information about bird or plane).
            //
            // Create two classes
            // Bird(with fields: name and canFly) and
            // Plane(with fields: mark and highFly) ,
            // which implement interface IFlyable.
            //
            // Create List of IFlyable objects.Add some Birds and Planes to it.
            // Call Fly() method for every item from the list of it.

            List<IFlyable> listOfIFlyable = new List<IFlyable>();
            listOfIFlyable.Add(new Bird("squirrel", true));
            listOfIFlyable.Add(new Bird("Vova", false));
            listOfIFlyable.Add(new Plane("f-16", true));

            foreach (var item in listOfIFlyable)
            {
                item.Fly();
            }
            Console.WriteLine();

            // Declare collection myColl of 10 integers (read from console).
            //  1) Find and print all positions of element “-10” in this collection;
            //  2) Remove from collection elements, which are greater then 20.Print new collection;
            //  3) Insert elements 1,-3,-4 in positions 2, 8, 5.Print new collection;
            //  4) Sort and print collection
            // Use next collections for this tasks: List or ArrayList

            Console.WriteLine("Enter 10 integers:");
            List<int> myColl = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int.TryParse(Console.ReadLine(), out int val);
                myColl.Add(val);
            }

            Console.WriteLine("Positions of element “-10”");
            for (int i = 0; i < myColl.Count; i++)
            {
                if (myColl[i] == -10)
                {
                    Console.WriteLine($"Index of '-10' - {i}");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Removing from collection elements, which are greater then 20.");
            List<int> myCollTrimmed = new List<int>(myColl);
            for (int i = myCollTrimmed.Count - 1; i > 0; i--)
            {
                //Console.WriteLine("Print old collection [DEBUG]");
                //foreach (var item in myCollTrimmed)
                //{
                //    Console.Write(item + " ");
                //}
                //Console.WriteLine();

                if (20 < myCollTrimmed[i])
                {
                    myCollTrimmed.RemoveAt(i);
                }
            }
            Console.WriteLine("Print new collection");
            foreach (var item in myCollTrimmed)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Insert elements 1,-3,-4 in positions 2, 8, 5.Print new collection");
            myColl.Insert(2, -1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);

            Console.WriteLine("Print new collection");
            foreach (var item in myColl)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Sort and print collection");
            myColl.Sort();

            Console.WriteLine("Print new collection");
            foreach (var item in myColl)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}
