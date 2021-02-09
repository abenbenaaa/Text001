using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            foo.F1();
            Console.ReadKey();
        }
    }

    public sealed class Foo
    {
        public void F1()
        {
            F2();
        }

        void F2()
        {
            var stackTrace = new StackTrace();
            var n = stackTrace.FrameCount;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(stackTrace.GetFrame(i).GetMethod().Name);
            }
        }
    }
}