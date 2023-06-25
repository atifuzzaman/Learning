using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StateMachineSumSample
{
    public sealed class ReadingNumber : CodeActivity<int>
    {

        // If your activity returns a value, derive from CodeActivity<TResult>
        // and return the value from the Execute method.
        protected override int Execute(CodeActivityContext context)
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
