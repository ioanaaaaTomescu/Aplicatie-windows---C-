using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{      [Serializable]
    public class Reimbursement 
        
    {   public long Id { get; set; }
        
        public DateTime dateOfReimbursment { get; set; }

        public DateTime reimbursmentDATE
        {
            get
            {
                return dateOfReimbursment;
            }
            set
            {
                if (value < DateTime.Today)
                
                    throw new InvalidReimburmsentDate(value);
               dateOfReimbursment = value;
                
            }

        }
        public float interestRate { get; set; }
        public float i
        {
            get
            {
                return interestRate;
            }
            set
            {
                if (value < 0)
                    throw new InvalidInterestDate(value);
                interestRate = value;
                
            }
        }


       /* public int idClient { get; set; }*/
        public string nameClient { get; set; }
        public Reimbursement(string name, DateTime date)
        {
            this.nameClient = name;
            this.dateOfReimbursment = date;
        }
        //public  Reimbursement(string name, float i, DateTime d/*, int id*/)
        //{
        //    this.nameClient = name;
        //    this.interestRate = i;
        //    this.dateOfReimbursment = d;
        //}
        //Reimbursement(string name, int accountNumber, maritalStatus status, int noKids, int cNP, int phone, float rate, DateTime date) : base(name, accountNumber, status, noKids, cNP, phone)
        //{
        //    this.interestRate = rate;
        //    this.dateOfReimbursment = date;
        //}
    }
}
