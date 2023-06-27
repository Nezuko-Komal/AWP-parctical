using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "Komal Negi";
            string m = "Heyyyyyyyyyyy";
            //string r = n.Insert(2, "kom");
            //Console.WriteLine(r);

            //string u = n.Remove(2);
            //Console.WriteLine(u);

            //int k = n.IndexOf("K");
            //Console.WriteLine(k);

            //int k = n.LastIndexOf("n");
            //Console.WriteLine(k);

            //string c = string.Concat(n,m);
            //Console.WriteLine(c);

            //string n1 = "Neha", p1="Priya";
            //bool b = string.Equals(n1, p1);
            //Console.WriteLine(b);

            //string b = "HELLO WORLD";
            //bool t = b.Contains("RL");
            //Console.WriteLine(t);

            //string t = "How are you";
            //bool c = t.StartsWith("Ho");
            //Console.WriteLine(c);

            //bool c1 = t.EndsWith("are");
            //Console.Write(c1);

            //int a = 10, b = 20;
            //int c = Math.Min(a, b);
            //Console.WriteLine(c);

            //int a = 10, b = 20;
            //int c = Math.Max(a, b);
            //Console.WriteLine(c);

            //int a = 10, b = 10;
            //if(a<b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Both the value are same");
            //}

            //int a = 20, b = 10;
            //if (a > b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("Both the value are same");
            //}

            //Console.WriteLine(Math.Abs(-98));

            //Console.WriteLine(Math.Pow(2, 3));

            //Console.WriteLine(Math.Round(-43.12));
            //Console.WriteLine(Math.Round(-43.54));

            //Console.WriteLine(Math.Ceiling(12.54));

            //Console.WriteLine(Math.Floor(65.98));

            //ARRAY FUNCTION
            int[] p = new int[4] { 12, 32, 44, 55 };
            int[] c1 = new int[p.Length];

            Array.Copy(p, c1, 3);

            foreach(int i in c1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
