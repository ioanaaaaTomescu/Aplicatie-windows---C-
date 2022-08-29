using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2.ViewModel
{
    public class MainFormNewModelcs: INotifyPropertyChanged
    {    
        //two elements for which we would want to bind
        public string Namereimbursment { get; set; }
        public string _name {
            get { return Namereimbursment; }
            set
            {
                if (Namereimbursment == value)
                
                    return;
                    Namereimbursment = value;
                OnPropertyChanged();
                
            }
        }

        public DateTime _rdate;
        public DateTime rDate {
            get
            {
                return _rdate;
            }

            set
            {
                if (_rdate == value)
                    return;
                _rdate = value;
                OnPropertyChanged();
            }
        }
         
        public BindingList<Reimbursement> Reimbursement { get;  set; }

        public MainFormNewModelcs()
        {
            Reimbursement = new BindingList<Reimbursement>();
            rDate = DateTime.Now;
            
        }

        
        public void   AddReimbursment()
        {
            Reimbursement r = new Reimbursement(Namereimbursment, rDate);
            //Reimbursement.Add(new Reimbursement(_name, rDate));
            //AddReimbursmentDatabase(r);
             _name = string.Empty;
            rDate = DateTime.Now;
        }

        

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public void DeleteReimbursment(Reimbursement r)
        {
            Reimbursement.Remove(r);
        }
    }
}
//27:00
