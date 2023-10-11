using System;

namespace Async.Tasks
{
    public class ConsistentTaskRunner : ThreadsRunner
    {
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме таски сразу одновременно после инициализации.");
        }

        protected override void RunThreads(int count)
        {
            Task[] tasks = new Task[count];

            for (int i = 0; i < count; i++)
            {
                var task = new Task(() => Do(i));
                tasks[i] = task;
            }

            foreach(Task task in tasks)
            {
                task.Start();
            }
        }
    }
}