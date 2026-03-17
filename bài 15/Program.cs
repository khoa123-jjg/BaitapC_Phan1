using System.Text;

namespace bài_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Dictionary<string, string> tuDien = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            tuDien.Add("Hello", "Xin chào");
            tuDien.Add("World", "Thế giới");
            tuDien.Add("Student", "Học sinh, sinh viên");
            tuDien.Add("Teacher", "Giáo viên");
            tuDien.Add("Programming", "Lập trình");
            tuDien.Add("Computer", "Máy tính");
            Console.WriteLine("--- TỪ ĐIỂN ANH - VIỆT ---");
            Console.WriteLine("Nhập từ tra: ");
            while (true) { 
                string word = Console.ReadLine();
                if (tuDien.ContainsKey(word))
                {
                    Console.WriteLine($"Nghĩa của từ {word}: {tuDien[word]}");
                }
                else
                {
                    Console.WriteLine($"Từ chưa được cập nhật");
                }
            }
        }
    }
}
