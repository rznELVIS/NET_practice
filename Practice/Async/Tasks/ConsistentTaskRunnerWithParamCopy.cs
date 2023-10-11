using System;

namespace Async.Tasks
{
    public class ConsistentTaskRunnerWithParamCopy : ThreadsRunner
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
                var param = i;
                var task = new Task(() => Do(param));
                tasks[i] = task;
            }

            foreach(Task task in tasks)
            {
                task.Start();
            }
        }
    }
}