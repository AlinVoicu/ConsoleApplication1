using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EvaluareAritm
    {
        public static int Suma(int a,int b)
        {
            return a + b;
        }
    }
    class Program
    {
        delegate int Evaluare(int x, int y);
        static void Main(string[] args)
        {
            StreamReader sr = null;
            int cnt = 0;
            try
            {
                sr = new StreamReader("E:\\fisier_test.txt");
                while (sr.ReadLine() != null)
                    cnt++;
            }
            catch
            {
                Console.WriteLine("Upsy Dupsy Got A Error there :P");
            }
            finally
            {
                Console.WriteLine("Nr de linii:" + cnt);
            }
            Console.ReadKey();
        }
    }
}
