using System.Text;

namespace bài_13
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
        static void xoa(List<Student> list, int ID)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == ID)
                {
                    list.Remove(list[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<Student> list = new List<Student>();
            list.Add(new Student("Nguyen Van A", 1));
            list.Add(new Student("Nguyen Van B", 2));
            list.Add(new Student("Nguyen Van C", 3));
            Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
            foreach (Student student in list)
                student.In();
            Console.WriteLine("Nhập ID sinh viên cần xóa:");
            int id = int.Parse(Console.ReadLine());
            xoa(list, id);
            Console.WriteLine("--- DANH SÁCH SINH VIÊN ---");
            foreach (Student student in list)
                student.In();
            Console.ReadKey();
        }
    }
}
