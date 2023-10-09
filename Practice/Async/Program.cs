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
consistentThreadRunnerWithParamCopy.Run(20);*/

Thread.Sleep(300);

var immediateTaskRunner = new ImmediateTaskRunner();
immediateTaskRunner.Run(10);

Thread.Sleep(300);

var immediateTaskRunnerWithParamCopy = new ImmediateTaskRunnerWithParamCopy();
immediateTaskRunnerWithParamCopy.Run(10);

Console.ReadLine();

Console.WriteLine("Practice Async is ended...");

