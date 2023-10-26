using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMComponentLibrary.Exceptions
{
    public class PropertyChangeException : Exception
    {
        public PropertyChangeException(string message) : base(message)
        {
        }
    }
}
