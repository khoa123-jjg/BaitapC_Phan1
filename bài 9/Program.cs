using System.Text;

namespace bài_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<int> list = new List<int>();
            Console.Write("Nhập số lượng phần tử của list:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ [" + (i + 1) + "]: ");
                int l = int.Parse(Console.ReadLine());
                list.Add(l);
            }
            List<int> listnew = new List<int>();
            foreach (int k in list)
            {
                if (!listnew.Contains(k))
                {
                    listnew.Add(k);                  
                }
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"\nCác phần tử còn lại trong list là: " + string.Join(",", listnew));
            Console.ReadKey();
        }
    }
}
