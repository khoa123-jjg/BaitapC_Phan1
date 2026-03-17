using System.Text;

namespace bài_7
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
            for (int i = 0; i < n; i++)
            {
                for (int j = n-1; j >= 1; j--) {
                    if (list[j] > list[j - 1])
                    {
                        int k;
                        k = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = k;
                    }
                }
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"\nCác phần tử sau khi xắp xếp trong list là: "+string.Join(",",list));
            Console.ReadKey();

        }
    }
}
