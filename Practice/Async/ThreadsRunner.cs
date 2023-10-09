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

        protected abstract void PrintInfo();

        protected virtual void RunThreads(int count) { }

        protected void Do(int number)
        {
            Console.WriteLine($"Поток номер {number}. Id потока {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}

