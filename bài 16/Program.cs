using System.Text;

namespace bài_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào một chuỗi: ");
            string word = Console.ReadLine();
            Dictionary<char,int> tuDien = new Dictionary<char,int>();
            foreach (string k in word.Split(' '))
            {
                foreach (char y in k)
                {
                    if (tuDien.ContainsKey(y))
                    {
                        tuDien[y]++;
                    }
                    else
                    {
                        tuDien.Add(y, 1);
                    }
                }
            }
            foreach (var z in tuDien )
            {
                Console.Write($"{z.Key}:{z.Value} ");
            }
        }
    }
}
