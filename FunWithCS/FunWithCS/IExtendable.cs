using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    interface IExtendable
    {
        void Extend(string msg);
    }

    public class MyLalaClass : IExtendable
    {

        public void Extend(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
