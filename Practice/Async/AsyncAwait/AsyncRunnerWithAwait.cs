namespace Async.AsyncAwait
{
    public class AsyncRunnerWithAwait
	{
        public async Task Run()
        {
            Console.WriteLine("Начало метода Async");

            await Task.Run(() => Do("Task #1"));

            Console.WriteLine("Окончание метода Async");
        }

        protected virtual void Do(string name)
		{
            Thread.Sleep(1500);
            Console.WriteLine($"Имя задача: {name}, Id потока {Thread.CurrentThread.ManagedThreadId}");
        }  
    }
}

