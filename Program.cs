/* arguments: start program.exe numberOfThreads command commandParameters...
 */
using System;
using System.Threading;
using System.Diagnostics;

namespace threads
{
    static class Global
    {
        public static int threadNo = 0;
    }
    public static class Bash
    {
        public static string run(string cmd)
        {
            var escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();

            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return result;
        }
    }
    static class Threadify
    {
        public static void threadProcess(string[] command, int input)
        {
            Console.WriteLine("Thread" + input + " Started using " + Thread.CurrentThread.Name);

            string commandString = "";

            foreach(string s in command)
                commandString += s + " ";
            
            Console.WriteLine(Thread.CurrentThread.Name + " started command: " + commandString);

            while (true){
                
                Console.WriteLine(Thread.CurrentThread.Name + ": " + Bash.run(commandString));
                Thread.Sleep(1000);

                if (Global.threadNo == input || Global.threadNo == -1)
                    break;
            }

            Console.WriteLine(Thread.CurrentThread.Name + " ended processing command: " + commandString);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Type the thread number (1-10) to kill a thread");
                Console.WriteLine("Type -1 to kill all threads or exit.");

                int threadCount = Convert.ToInt32(args[0]);
                int paramCount = args.Length;

                string[] command = new string[paramCount - 1];
                Array.Copy(args, 1, command, 0, paramCount - 1);

                Thread[] threads = new Thread[threadCount];

                for (int i = 0; i < threadCount; i++)
                {
                    int capture = i;
                    threads[i] = new Thread(() => Threadify.threadProcess(command, capture + 1)) { Name = "Thread" + (capture + 1) + "" };
                    threads[i].Start();
                }

                while (true)
                {
                    Global.threadNo = Convert.ToInt32(Console.ReadLine());

                    if (Global.threadNo == -1)
                        break;
                }

                Console.WriteLine("Main Thread Ended, all Child Threads Ended");
            }
            else
            {
                Console.WriteLine("Please specify arguments");
            }   
        }
    }
}