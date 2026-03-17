using System.Text;

namespace bài_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            Dictionary<string, string> tuDien = new Dictionary<string, string>();
            tuDien.Add("Hello", "Xin chào");
            tuDien.Add("World", "Thế giới");
            tuDien.Add("Student", "Học sinh, sinh viên");
            tuDien.Add("Teacher", "Giáo viên");
            tuDien.Add("Programming", "Lập trình");
            tuDien.Add("Computer", "Máy tính");
            Console.WriteLine("--- TỪ ĐIỂN ANH - VIỆT ĐƠN GIẢN ---");
            Console.WriteLine("Nhập từ cần tra: ");
            while (true)
            {
                string word = Console.ReadLine();
                if (tuDien.ContainsKey(word))
                    Console.WriteLine($"Nghĩa của từ {word}: {tuDien[word]}");
                else
                    Console.WriteLine($"Từ điểm chưa được cập nhật");
            }
        }
    }
}
