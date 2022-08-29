using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{    [Serializable]
    public class Credit : Client
    {  
        public long Id { get; set; }
        public  string employeeName { get; set; }
       public  int noCredits { get; set; }
       public int idCredit { get; set; }

       public Credit(long mainId, string namec, string nameE, int cNp, int idcredit)
        {
            this.Id = mainId;
            this.employeeName = nameE;
            this.name = namec;
            this.CNP = cNp;
            this.idCredit = idcredit;

        }

        public Credit(string name, int accountNumber,  maritalStatus status, int noKids,int cNP,int phone,int noCredit, string Employee,int id): base(name, accountNumber,  status, noKids,cNP,phone)
        {
            employeeName = Employee;
            noCredits = noCredit;
            idCredit = id;
        }
        public Credit(string nameC, string nameE,int CnP, int noAccount, int id)
        {
            this.name = nameC;
            this.employeeName = nameE;
            this.CNP = CnP;
            this.accountNumber = noAccount;
            this.idCredit = id;
        }

    }
}
