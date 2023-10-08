using System;
using System.Threading;

namespace Async
{
	public class ConsistentThreadRunnerWithParamCopy : ThreadsRunner
	{
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме потоки последовательно, после создания, но с копировнаием параметров.");
        }

        protected override void RunThreads(int count)
        {
            Thread[] threads = new Thread[count];   

            for (int i = 0; i < count; i++)
            {
                var param = i;
                threads[i] = new Thread(() => Do(param));
            }

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
        }
    }
}

