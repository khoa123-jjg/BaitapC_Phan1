using System.Text;

namespace bài_18
{
    class Student
    {
        public string Name;
        public double Core;
        public Student(string name, double core)
        {
            Name = name;
            Core = core;
        }
        public void In()
        {
            Console.WriteLine($"{Core} | {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<Student> list = new List<Student>();
            list.Add(new Student("Nguyen Van A", 8.6));
            list.Add(new Student("Nguyen Van B", 2.4));
            list.Add(new Student("Nguyen Van C", 9.0));
            double core = 0;
            foreach (Student student in list)
            {
                if (student.Core > core)
                {
                    core = student.Core;
                }
            }
            Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
            foreach (Student student in list)
                student.In();
            Console.Write("Sinh viên có điểm số cao nhất: ");
            foreach (Student student in list)
            {
                if (student.Core == core)
                {
                    student.In();
                }
            }
            Console.ReadKey();
        }
    }
}
