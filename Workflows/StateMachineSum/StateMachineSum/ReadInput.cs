using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineSum
{
    public sealed class ReadInput : CodeActivity<int>
    {


        protected override int Execute(CodeActivityContext context)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            return number;
        }

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        //protected override int Execute(CodeActivityContext context)
        //{
        //    string numberString = Console.ReadLine();
        //    // Obtain the runtime value of the Text input argument
        //    int text = context.GetValue(this.number);
        //}
    }
}
