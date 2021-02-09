using System;
using System.Threading;
using System.ComponentModel;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        //定义一个ManualResetEvent
        var signal = new ManualResetEvent(false);
        new Thread(() =>
        {
            Console.WriteLine("Waiting for signal...");
            signal.WaitOne();
            signal.Dispose();
            Console.WriteLine("Get Signal!");
        }).Start();
        Thread.Sleep(3000);
        //设置有信号
        signal.Set();
        //线程池 后台线程
        Task task = Task.Factory.StartNew(() => { Console.WriteLine("Foor");Thread.Sleep(200); },TaskCreationOptions.LongRunning);
        Console.WriteLine(task.Status);

        task.Wait();
        Console.ReadKey();
    }
}