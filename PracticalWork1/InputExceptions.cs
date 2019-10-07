using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork1
{
    class InputExceptions : Exception
    {
        public InputExceptions(string message) : base(message)
            {

            }
    }
}
