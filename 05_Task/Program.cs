using System.Collections.Generic;
using System.Numerics;
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

        }
}
}
