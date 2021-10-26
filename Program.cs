using System;
using System.Threading.Tasks;

namespace Demo_TPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo For Task Parallel Library");
            var Task0 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("This is the first method to create and start a task using TPL");
            });
            Task0.Wait();
            //Second method to create a Task using TPL  
            var task1 = new Task(() =>
            {
                Console.WriteLine("This is the second method to create a task using TPL");
            });
            // Next, we have to start the Task  
            task1.Start();
            task1.Wait();

            Console.Write("Task in Execution...!!");
            Console.ReadKey();
        }
    }
}
