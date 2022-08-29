using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{
    public class InvalidReimburmsentDate:Exception
    {
        public DateTime reimbursmentDate { get; set; }
        public InvalidReimburmsentDate(DateTime rDate)
        {
            this.reimbursmentDate = rDate;
        }

        public override string Message
        {
            get
            {
                return "The birthday " + reimbursmentDate + "is invalid!";
            }
        }
    }
}
