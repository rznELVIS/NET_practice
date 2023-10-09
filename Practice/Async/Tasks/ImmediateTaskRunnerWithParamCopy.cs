using System;

namespace Async.Tasks
{
    public class ImmediateTaskRunnerWithParamCopy : ThreadsRunner
    {
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме таски сразу после создания, но копируем параметр.");
        }

        protected override void RunThreads(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var param = i;
                var task = new Task(() => Do(param));
                task.Start();
            }
        }
    }
}