using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachineSumSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new SumOfNumbers());
            Console.Read();
        }
    }
}
