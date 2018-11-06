using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqIDGenerator
{
    public class SeqIDGeneratorException : Exception
    {
        internal SeqIDGeneratorException(string message) : base(message)
        {

        }
    }
}
