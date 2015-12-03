using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace Trial
{
    class Program
    {
        const int _max = 1000; //inital value was 100mil
        const int one = 1;

        static void Main()
        {
            Thread t = new Thread(Go);
            t.Start();
            //t.Join();
            Console.Write("Thread t has ended!");
            Console.Read();
        }

        static void Go()
        {
            for (int i = 0; i < 1000; i++) Console.Write("y");
        }



        //static void compareTimes()
        //{
        //    var s1 = Stopwatch.StartNew();
        //    for (int i = 0; i < _max; i++)
        //    {
        //        Method1();
        //    }
        //    s1.Stop();
        //    var s2 = Stopwatch.StartNew();
        //    for (int i = 0; i < _max; i++)
        //    {
        //        Method2();
        //    }
        //    s2.Stop();
        //    Console.WriteLine(((double)(s1.Elapsed.TotalMilliseconds * 1000 * 1000) /
        //        _max).ToString("0.00 ns"));
        //    Console.WriteLine(((double)(s2.Elapsed.TotalMilliseconds * 1000 * 1000) /
        //        _max).ToString("0.00 ns"));
        //    Console.Read();
        //}

        //static void Method1()
        //{
        //    var numAlpha = new Regex("(?<Alpha>[a-zA-Z]*)(?<Numeric>[0-9]*)");
        //    var match = numAlpha.Match("codename123");

        //    var alpha = match.Groups["Alpha"].Value;
        //    var num = match.Groups["Numeric"].Value;
        //    //Console.WriteLine(num);
        //    //Console.WriteLine(alpha);
            
        //}

        //static void Method2()
        //{
        //    string stringer = "codename123";
        //    var a = stringer.IndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
        //    var numeric = stringer.Substring(a);
        //    var alpha = stringer.Substring(0, a);
        //    //Console.WriteLine(stringer.Substring(a));
        //    //Console.WriteLine(stringer.Substring(0, a));
        //}

        //static void Method3(int size, string name, bool flag)
        //{
        //    if (!flag && size != -1 && name != null)
        //    {
        //        throw new Exception();
        //    }
        //}
    }
}