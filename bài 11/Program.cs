using System.Text;

namespace bài_11
{
    class Student
    {
        public string Name;
        public int Id;
        public Student(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public void In()
        {
            Console.WriteLine($"{Id} | {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<Student> list = new List<Student>();
            list.Add(new Student("Nguyen Van A", 1));
            list.Add(new Student("Nguyen Van B", 2));
            list.Add(new Student("Nguyen Van C", 3));
            Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
            foreach (Student student in list)
                student.In();

        }
    }
}
