using System;
using System.Threading.Tasks;

namespace CSharpTask
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Task.ContinueWith
            //var t1 = Task.Run(() => throw new Exception("task 1 exception"));

            //await t1.ContinueWith((antecedent) => Console.WriteLine($"{antecedent.Exception.Message},{antecedent.IsFaulted}, {antecedent.IsCompletedSuccessfully}"))
            //    .ContinueWith((antecedent) => Console.WriteLine($"{antecedent.IsFaulted},{antecedent.IsCompletedSuccessfully}"));

            //var t2 = Task.Run(() => Console.WriteLine("task 2"));

            //t2.ContinueWith((antecedent) => Console.WriteLine("task 2 chain 1")).
            //    ContinueWith((antecedent) => Console.WriteLine("task 2 chain 2"));


            //Task.Delay(2000).Wait();


            //Task.Delay
            //Console.WriteLine("step 1");

            //var t1 = Task.Delay(2000);

            //await t1;

            //Console.WriteLine(t1.IsCompleted);

            //Console.WriteLine("step 2");


            //var t = new Task(Test);//Action, creationOptions, cancellationtoken
            //var t = Task.Factory.StartNew(Test);//Action, creationOptions, cancellationtoken, taskscheduler
            //var t = Task.Run(Test);//Action, cancellationtoken

            Console.WriteLine("done..");
        }


        static void Test()
        {
            Console.WriteLine("test method");
        }
    }
}
