using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
    
{   public enum maritalStatus { married,single,serious_relationship}
    [Serializable]
    public class Client  
    {
       public long Id { get; set; }
       public string name { get; set; }
       public  int accountNumber { get; set; }
        ///float interestRate { get; set; }
       public maritalStatus Status { get; set; }
       public int noKids { get; set; }
       public  int CNP { get; set; }
       public  double phoneNumber { get; set; }
        public Client()
        {

        }
        public Client(string name, maritalStatus s, int noKids, int cNP, double phoneNumber)
        {
            this.name = name;
            this.Status = s;
            this.noKids = noKids;
            this.CNP = cNP;
            this.phoneNumber = phoneNumber;
        }

        public Client(string name, int accountNumber, maritalStatus s, int noKids, int cNP, double phone)
        {
            this.name = name;
            this.accountNumber = accountNumber; 
            this.Status = s;
            this.noKids = noKids;
            this.CNP = cNP;
            this.phoneNumber = phone;
        }
        public void onClientValidation(object source, EventArgs e)
        {
            Console.WriteLine("Waiting for validation...");
        }
        public Client(long id, string name, int cNP, double phoneNumber)
        {
            this.Id = id;
            this.name = name;
            CNP = cNP;
            this.phoneNumber = phoneNumber;
        }
        public Client(string name, int cNP, double phoneNumber)
        {   
            this.name = name;
            CNP = cNP;
            this.phoneNumber = phoneNumber;
        }
        public Client(long id, string name)
        {
            this.Id = id;
            this.name = name;
        }
    }

}
