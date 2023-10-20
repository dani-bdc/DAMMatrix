using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace DAMComponentLibrary.Exceptions
{
    public class InvalidPositionException : Exception
    {

        public int MinRow { get; set; } = 0;
        public int MaxRow { get; set; } = 0;

        public InvalidPositionException(string message) : base(message)
        {
        }
    }
}
