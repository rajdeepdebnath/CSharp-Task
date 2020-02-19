using System;
using System.Threading.Tasks;

namespace CSharpTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Task(Test);//Action, creationOptions, cancellationtoken
            var t = Task.Factory.StartNew(Test);//Action, creationOptions, cancellationtoken, taskscheduler
            var t = Task.Run(Test);//Action, cancellationtoken

            Console.WriteLine("done..");
        }

        static void Test()
        {
            Console.WriteLine("test method");
        }
    }
}
