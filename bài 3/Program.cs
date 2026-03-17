using System.Text;

namespace bài_3
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
            float max = list[0];
            foreach (float k in list)
            {
                if( k > max ) 
                    max = k;
            }
            Console.WriteLine("\n---------------------------------\n");
            Console.WriteLine($"Giá trị lớn nhất trong list là: {max}");
            Console.ReadKey();

        }
    }
 }
