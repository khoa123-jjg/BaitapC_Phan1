using System.Text;

namespace bài_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<int> list = new List<int> { 1,2,3,4,5,6};
            Console.WriteLine($"Các phần tử ban đầu trong list là: " + string.Join(",", list));
            list.Reverse();
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"Các phần tử sau khi đảo ngược trong list là: " + string.Join(",", list));
            Console.ReadKey();

        }
    }
}
