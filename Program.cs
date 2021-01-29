using System.Threading;
using System;

namespace threads
{
    static class Global
    {
        public static int threadNo = 0;
    }

    static class Foo
    {
        public static void bar(int input)
        {
            Console.WriteLine("foo" + input + " Started using " + Thread.CurrentThread.Name);

            int i = 0;

            while (true)
            {
                Console.WriteLine("foo" + input + " :" + i++);

                Thread.Sleep(500);

                if (Global.threadNo == input || Global.threadNo == 11)
                    break;
            }

            Console.WriteLine("foo" + input + " Ended using " + Thread.CurrentThread.Name);

        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("MultiThreading Demo App");
            Console.WriteLine("Type the thread number (1-10) to kill a thread");
            Console.WriteLine("Type 11 to kill all threads or exit.");


            Thread[] threads = new Thread[10];

            for(int i = 0; i < 10; i++)
            {
                int capture = i;
                threads[i] = new Thread(() => Foo.bar(capture+1))
                {
                    Name = "Thread" + (capture+1) + ""
                };
                threads[i].Start();
            }

            while (true)
            {

                Global.threadNo = Convert.ToInt32(Console.ReadLine());

                if (Global.threadNo == 11)
                {
                    break;
                }
            }
            Console.WriteLine("Main Thread Ended, all Child Threads Ended");
            
        }
    }
}