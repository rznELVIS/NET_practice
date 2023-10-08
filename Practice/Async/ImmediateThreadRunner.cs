using System;
namespace Async
{
	public class ImmediateThreadRunner : ThreadsRunner
	{
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме потоки сразу после создания.");
        }

        protected override void RunThreads(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var thread = new Thread(() => Do(i));
                thread.Start();
            }
        }
    }
}

