using System.Text.Json;
using System.Text.Json.Serialization;

namespace _12_HomeWork
{
    internal class Student
    {
        //  Create Student class with
        //          public int property Id, string Name, fload Rating, and Group Group.
        //      Create a constructor with string, decimal, and Group parameters
        //      to initialize the properties.

        public int Id { get; set; }

        [JsonPropertyName("Full name")]
        public string Name { get; set; }

        public double Rating { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Group Group { get; set; }

        public Student(string name, double rating, Group group)
        {
            Name = name;
            Rating = rating;
            Group = group;
        }

        public string Serialize()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        public static Student Deserialize(string s)
        {
            return JsonSerializer.Deserialize<Student>(s);
        }
    }
}
