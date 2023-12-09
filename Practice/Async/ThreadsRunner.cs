namespace Async
{
    public abstract class ThreadsRunner
    {
        public void Run(int count)
        {
            PrintInfo();

            Console.WriteLine($"Главный поток Id: {Thread.CurrentThread.ManagedThreadId}");

            RunThreads(count);
        }

        protected void Do(int number)
        {
            //Thread.Sleep(100);
            Console.WriteLine($"Поток номер {number}. Id потока {Thread.CurrentThread.ManagedThreadId}");
        }

        protected abstract void PrintInfo();

        protected abstract void RunThreads(int count);
    }
}

