namespace Async.AsyncAwait
{
    public class AsyncRunnerWithoutAwaitAndAsync: AsyncRunnerWithAwait
	{
        public void Run()
        {
            Console.WriteLine("Начало метода Async");

            Task.Run(() => Do("Task #1"));

            Console.WriteLine("Окончание метода Async");
        }
	}
}

