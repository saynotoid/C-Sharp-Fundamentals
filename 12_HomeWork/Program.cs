namespace _12_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Please, create Group class with public string property Name, int Id, and Student Leader.
            //      Create a constructor with string, int, and Student parameters
            //      for initializing the properties.
            // 
            //  Create Student class with
            //          public int property Id, string Name, fload Rating, and Group Group.
            //      Create a constructor with string, decimal, and Group parameters
            //      to initialize the properties.
            // 
            //  Implement a public Serialize method that returns a string
            //      that contains a serialized Student object in JSON format.
            // 
            //  Student that is created like this
            // Student s =
            // new Student("Anna", 70.1, new Group("Mechanics", 1, new Student("Tom", 60.25, null)));
            // 
            //  should be serialized into the next string:     
            // 
            // {
            //    "Full name": "Anna",
            //        "Rating": 70.1,
            //        "Group": {
            //            "Name": "Mechanics",
            //            "Id": 1,
            //            "Leader": {
            //                "Full name": "Tom",
            //                "Rating": 60.25
            //            }
            //        }
            //    }
            // }
            // 
            //  Note, that Id property should not be serialized
            //      and the Name property should be represented as "Full name"
            //
            //  Also, implement public static method Deserialize
            //      which takes a string as a parameter
            //      and returns a deserialized Worker object from it.

            //Student s = new Student("Anna", 70.1, new Group("Mechanics", 1, new Student("Tom", 60.25, null)));
            //Console.WriteLine(s.Serialize());

            Student s = new Student("Jack", 89.08f, new Group("Math", 1, new Student("Jim", 83, null)));
            Console.WriteLine(s.Serialize());

            Student sa = new Student("Anna", 73.54, null);
            sa.Group = new Group("Mechanics", 1, new Student("Tom", 83.09, null));
            string serialized = sa.Serialize();
            Console.WriteLine(serialized);
            var deserializedStudent = Student.Deserialize(serialized);
            Console.WriteLine(deserializedStudent.Id);
            Console.WriteLine(deserializedStudent.Name);
            Console.WriteLine(deserializedStudent.Rating);
            Console.WriteLine(deserializedStudent.Group.Id);
            Console.WriteLine(deserializedStudent.Group.Leader.Id);
            Console.WriteLine(deserializedStudent.Group.Leader.Name);
            Console.WriteLine(deserializedStudent.Group.Leader.Rating);
        }
    }
}
