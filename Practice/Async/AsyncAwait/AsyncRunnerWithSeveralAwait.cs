namespace Async.AsyncAwait
{
    public class AsyncRunnerWithSeveralAwait
	{
        public async Task Run()
        {
            Console.WriteLine("Начало метода Async");

            Task[] tasks = new Task[5];
            for (int i = 0; i < tasks.Length; i++)
            {
                var param = i;
                tasks[i] = new Task(() => Do($"Task #{param}"));
            }

            foreach(Task task in tasks)
            {
                task.Start();
            }

            Task.WaitAll(tasks);

            Console.WriteLine("Окончание метода Async");
        }

        protected virtual void Do(string name)
		{
            Thread.Sleep(1500);
            Console.WriteLine($"Имя задача: {name}, Task Id: {Task.CurrentId}, Id потока {Thread.CurrentThread.ManagedThreadId}");
        }  
    }
}

