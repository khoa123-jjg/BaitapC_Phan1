using System.Text;

namespace bài_5
{

    internal class Program
    {
        static void In(List<string> list)
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (string k in list)
            {
                Console.Write(k + "|");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<string> list = new List<string> { "Nguyễn Văn An", "Lê Thị Bình", "Trần Hoàng Chi", "Phạm Quốc Dũng" };
            Console.WriteLine("--- Danh sách sinh viên hiện tại ---");
            In(list);
            string name = null;
            do
            {
                Console.Write($"Không tìm thấy sinh viên có tên {name} trong danh sách");
                Console.Write("\nNhập tên sinh viên cần xóa:");
                name = Console.ReadLine();
            } while (list.Remove(name) == false);
            Console.WriteLine($"Đã xóa sinh viên có tên {name} khỏi danh sách.");
            Console.WriteLine("\n--- Danh sách sinh viên sau khi cập nhật ---");
            In(list);
            Console.ReadKey();


        }
    }
}
