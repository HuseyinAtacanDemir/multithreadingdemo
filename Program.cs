using System.Threading;
using System;

namespace threads
{
    static class Global
    {
        public static int threadNo = 0;
     
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("MultiThreading Demo App");
            Console.WriteLine("Type the thread number (1-10) to kill a thread");
            Console.WriteLine("Type 11 to kill all threads or exit.");

            //Creating Threads

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
            Thread t4 = new Thread(Method4)
            {
                Name = "Thread4"
            };
            Thread t5 = new Thread(Method5)
            {
                Name = "Thread5"
            };
            Thread t6 = new Thread(Method6)
            {
                Name = "Thread6"
            };
            Thread t7 = new Thread(Method7)
            {
                Name = "Thread7"
            };
            Thread t8 = new Thread(Method8)
            {
                Name = "Thread8"
            };
            Thread t9 = new Thread(Method9)
            {
                Name = "Thread9"
            };
            Thread t10 = new Thread(Method10)
            {
                Name = "Thread10"
            };
            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
            
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
        static void Method1()
        {
            Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method1 :" + i++);

                Thread.Sleep(500);

                if (Global.threadNo == 1 || Global.threadNo == 11)
                    break;
            }
            Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
            
        }
        static void Method2()
        {
            Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method2 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 2 || Global.threadNo == 11)
                    break;
            }
            Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
            
        }
        static void Method3()
        {
            Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method3 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 3 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
            
        }

        static void Method4()
        {
            Console.WriteLine("Method4 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method4 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 4 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method4 Ended using " + Thread.CurrentThread.Name);
            

        }
        static void Method5()
        {
            Console.WriteLine("Method5 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method5 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 5 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method5 Ended using " + Thread.CurrentThread.Name);
            

        }
        static void Method6()
        {
            Console.WriteLine("Method6 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method6 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 6 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method6 Ended using " + Thread.CurrentThread.Name);
            

        }
        static void Method7()
        {
            Console.WriteLine("Method7 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method7 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 7 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method7 Ended using " + Thread.CurrentThread.Name);
            
        }
        static void Method8()
        {
            Console.WriteLine("Method8 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method8 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 8 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method8 Ended using " + Thread.CurrentThread.Name);
            
        }
        static void Method9()
        {
            Console.WriteLine("Method9 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method9 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 9 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method9 Ended using " + Thread.CurrentThread.Name);
            
        }
        static void Method10()
        {
            Console.WriteLine("Method10 Started using " + Thread.CurrentThread.Name);
            int i = 0;
            while (true)
            {
                Console.WriteLine("Method10 :" + i++);
                Thread.Sleep(500);

                if (Global.threadNo == 10 || Global.threadNo == 11)
                {
                    break;
                }

            }
            Console.WriteLine("Method10 Ended using " + Thread.CurrentThread.Name);
            
        }
    }
}