using System;
using System.Threading;

namespace Async
{
	public class ConsistentThreadRunner : ThreadsRunner
	{
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме потоки последовательно, после создания.");
        }

        protected override void RunThreads(int count)
        {
            Thread[] threads = new Thread[count];   

            for (int i = 0; i < count; i++)
            {
                threads[i] = new Thread(() => Do(i));
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
        }
    }
}

