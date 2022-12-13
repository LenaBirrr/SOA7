using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOA7
{
    public class StackException:Exception
    {
        public StackException(string message) : base(message) { }
    }
}
