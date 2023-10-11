using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Async.AsyncAwait
{
	public class AsyncRunner
	{
        public async void Run()
        {
            Console.WriteLine("Начало метода Async");

            await Task.Run(() => Do());

            Console.WriteLine("Окончание метода Async");
        }

        private void Do()
		{
            Thread.Sleep(1500);
            Console.WriteLine($"Id потока {Thread.CurrentThread.ManagedThreadId}");
        }
	}
}

