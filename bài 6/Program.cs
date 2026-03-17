using System.Text;

namespace bài_6
{
    internal class Program
    {
        static void In(List<string> list)
        {
            Console.WriteLine("Danh sách hiện có ("+string.Join(",",list)+")");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<string> list = new List<string> { "Táo", "Cam", "xoài", "bưởi" };
            Console.WriteLine("--- Danh sách chuỗi ---");
            In(list);
            string name = null;
            Console.Write("Nhập chuỗi cần tìm: ");
            name = Console.ReadLine();
            if (list.Contains(name))
                Console.WriteLine("Chuỗi " + name + " có tồn tại trong danh sách.");
            else 
                {
                Console.WriteLine("Chuỗi " + name + " không tồn tại trong danh sách.");
            }
            Console.ReadKey();

        }
    }
}
