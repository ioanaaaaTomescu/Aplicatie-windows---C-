using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{
    public   class InvalidInterestDate:Exception
    {
         public float interest { get; set; }

        public InvalidInterestDate(float i)
        {
            interest = i;

        }

        public override string Message
        {
            get
            {
                return "The interest " + interest + "is invalid";
            }
        }


    }
}
