using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{
    class CNPException:Exception
    {
        public CNPException()
        {

        }

        public CNPException(string message):base(message)
        {

        }
        public CNPException(string message, Exception inner): base(message, inner)
        {

        }
    }
}
