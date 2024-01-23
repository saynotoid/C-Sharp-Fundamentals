
namespace _12_HomeWork
{
    internal class Group
    {
        //  Please, create Group class with public string property Name, int Id, and Student Leader.
        //      Create a constructor with string, int, and Student parameters
        //      for initializing the properties.

        public string Name { get; set; }

        public int Id { get; set; }

        public Student Leader { get; set; }

        public Group(string name, int id, Student leader)
        {
            Name = name;
            Id = id;
            Leader = leader;
        }
    }
}
