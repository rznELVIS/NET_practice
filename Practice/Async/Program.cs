using Async.AsyncAwait;
using Async.Tasks;

Console.WriteLine("Practice Async is started...");

/*var immediateThreadRunner = new ImmediateThreadRunner();
immediateThreadRunner.Run(5);

Thread.Sleep(300);

var immediateThreadRunnerWithParamCopy = new ImmediateThreadRunnerWithParamCopy();
immediateThreadRunnerWithParamCopy.Run(20);

Thread.Sleep(300);

var consistentThreadRunner = new ConsistentThreadRunner();
consistentThreadRunner.Run(5);

Thread.Sleep(300);

var consistentThreadRunnerWithParamCopy = new ConsistentThreadRunnerWithParamCopy();
consistentThreadRunnerWithParamCopy.Run(20);

Thread.Sleep(300);

var immediateTaskRunner = new ImmediateTaskRunner();
immediateTaskRunner.Run(10);

Thread.Sleep(300);

var immediateTaskRunnerWithParamCopy = new ImmediateTaskRunnerWithParamCopy();
immediateTaskRunnerWithParamCopy.Run(10);

Thread.Sleep(300);

var consistentTaskRunner = new ConsistentTaskRunner();
consistentTaskRunner.Run(10);

Thread.Sleep(300);

var consistentTaskRunnerWithParamCopy = new ConsistentTaskRunnerWithParamCopy();
consistentTaskRunnerWithParamCopy.Run(10); */

var asyncRunnerWithAsync = new AsyncRunnerWithAwait();
var task = asyncRunnerWithAsync.Run();
Console.WriteLine($"Задача: {task}");
await task;

Thread.Sleep(3000);

var asyncRunnerWithoutAsync = new AsyncRunnerWithoutAwait();
await asyncRunnerWithoutAsync.Run();

Thread.Sleep(3000);

var asyncRunnerWithoutAsyncAndAwait = new AsyncRunnerWithoutAwaitAndAsync();
asyncRunnerWithoutAsyncAndAwait.Run();

Thread.Sleep(3000);

var asyncRunnerWithAwaitAndVoid = new AsyncRunnerWithAwaitAndVoid();
asyncRunnerWithAwaitAndVoid.Run();

Console.ReadLine();

Console.WriteLine("Practice Async is ended...");

