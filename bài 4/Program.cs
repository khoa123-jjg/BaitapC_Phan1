using System.Text;

namespace bài_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            List<float> list = new List<float>();
            Console.Write("Nhập số lượng phần tử của list:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n---------------------------------\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ [" + (i + 1) + "]: ");
                float k = float.Parse(Console.ReadLine());
                list.Add(k);
            }
            float count = 0;
            foreach (float k in list)
            {
                if (k % 2 == 0)
                    count++; 
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"\nSố lượng phần tử chẵn trong list là: {count}");
            Console.ReadKey();

        }
    }
}
