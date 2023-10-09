namespace Async.Threads
{
    public class ImmediateThreadRunnerWithParamCopy : ThreadsRunner
    {
        protected override void PrintInfo()
        {
            Console.WriteLine("Запускаме потоки сразу после создания, но копируем параметр.");
        }

        protected override void RunThreads(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var param = i;
                var thread = new Thread(() => Do(param));
                thread.Start();
            }
        }
    }
}

