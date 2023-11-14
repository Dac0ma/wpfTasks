using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;


namespace _2tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
             int[] q = new int[20];
             for(int i = 0; i < q.Length;i++)
                 q[i] = rnd.Next(10);

             for(int i = 0;i <q.Length;i++)
                 Console.Write(q[i] + " ");

             Console.WriteLine();
             int minindex = 0;
             int maxindex = 0;
             for (int i = 0; i < q.Length; i++)
             {
                 if (q[i] < q[minindex])
                 {
                     minindex = i;
                 }
                 if (q[i] > q[maxindex])
                 {
                     maxindex = i;
                 }
             }

             int res = q[maxindex];
             q[maxindex] = q[minindex];
             q[minindex] = res;

             for (int i = 0; i < q.Length; i++)
                 Console.Write(q[i] + " ");

             Console.WriteLine();

             for (int i = 0; i < q.Length; i++)
                 for (int j = i + 1; j < q.Length; j++)
                     if (q[i] > q[j])
                     {
                         int temp = q[i];
                         q[i] = q[j];
                         q[j] = temp;
                     }
             for (int i = 0; i < q.Length; i++)
                 Console.Write(q[i] + " ");

             Console.WriteLine(); 

            int[] f = new int[40];
            for (int i = 0; i < f.Length; i++)
                f[i] = rnd.Next(-10,10);

            for (int i = 0; i < f.Length; i++)
                for (int j = i + 1; j < f.Length; j++)
                    if (f[j] > f[i])
                    {
                        int temp = f[i];
                        f[i] = f[j];
                        f[j] = temp;
                    }

            for (int i = 0; i < f.Length; i++)
                Console.Write(f[i] + " ");

            
            FileStream fstream = new FileStream("C:\\F1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fstream);

            for (int i = 0; i < f.Length; i++)
                writer.Write(f[i] + " ");

            writer.Close();

            for (int i = 0; i < f.Length; i++)
                for (int j = i + 1; j < f.Length; j++)
                    if (f[i] > f[j])
                    {
                        int temp = f[i];
                        f[i] = f[j];
                        f[j] = temp;
                    }

            FileStream f2stream = new FileStream("C:\\F2.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer2 = new StreamWriter(f2stream);

            for (int i = 0; i < f.Length; i++)
                writer2.Write(f[i] + " ");

            writer2.Close();
        }
    }
}

