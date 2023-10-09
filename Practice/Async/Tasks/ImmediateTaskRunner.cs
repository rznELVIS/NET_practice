using System;

namespace Async.Tasks
{
    public class ImmediateTaskRunner : ThreadsRunner
    {
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме таски сразу после создания.");
        }

        protected override void RunThreads(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var task = new Task(() => Do(i));
                task.Start();
            }
        }
    }
}