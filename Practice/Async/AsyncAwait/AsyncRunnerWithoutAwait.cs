namespace Async.AsyncAwait
{
    public class AsyncRunnerWithoutAwait: AsyncRunnerWithAwait
	{
        public async Task Run()
        {
            Console.WriteLine("Начало метода Async");

            Task.Run(() => Do("Task #1"));

            Console.WriteLine("Окончание метода Async");
        }
	}
}

