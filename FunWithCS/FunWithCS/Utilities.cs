using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCS
{
    static class Utilities
    {
        public static string
            ToUpper(this Person p)
        {
            return p.Name.ToUpper();
        }
    }
}
