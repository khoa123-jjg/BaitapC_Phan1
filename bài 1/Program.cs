using System.Text;

namespace bài_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            Console.WriteLine("Các phần tử trong list:");
            foreach (int k in list)
            {
                Console.WriteLine(""+k);
            }
            Console.ReadKey();
        }
    }
}
