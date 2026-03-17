using System.Text;

namespace bài_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<int> list = new List<int>();
            Dictionary<int, int> solan = new Dictionary<int, int>();
            Console.Write("Nhập số lượng phần tử của list:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ [" + (i + 1) + "]: ");
                int k = int.Parse(Console.ReadLine());
                list.Add(k);
            }
            foreach (int k in list)
            {
                if (solan.ContainsKey(k))
                {
                    solan[k]++;
                }
                else
                {
                    solan[k] = 1;
                }
            }
            int count = 0;
            foreach (var k in solan)
            {
                if (k.Value > count)
                {
                    count = k.Value;
                }
            }

            Console.Write("Số xuất hiện nhiều lần nhất: ");
            foreach (var k in solan)
            {
                if (k.Value == count)
                {
                    Console.Write($"{k.Key}:{k.Value} ");
                }
            }
        }
    }
}
