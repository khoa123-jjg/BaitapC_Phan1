using System.Text;

namespace bài_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Phạm Nhật Khoa");
            Console.WriteLine("2415053122221");
            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử của list:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ [" + (i + 1) + "]: ");
                int k = int.Parse(Console.ReadLine());
                list.Add(k);
            }
            float min = list[0];
            foreach (float k in list)
            {
                if (k < min)
                    min = k;
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"Giá trị nhỏ nhất trong list là: {min}");
            Console.ReadKey();

        }
    }
}
