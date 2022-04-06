using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml2finished
{
    public class Customexception: Exception
    {
        public Customexception(string message) : base (message)
        {

        }
    }
}
