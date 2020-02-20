using System;
using System.Threading.Tasks;

namespace CSharpTask
{
    class Program
    {
        static async Task Main(string[] args)
        {


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
