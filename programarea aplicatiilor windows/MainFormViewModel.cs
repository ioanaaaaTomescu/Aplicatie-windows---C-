using PROIECT_WAP_VARIANTA2.ViewModel;
using System;
using System.ComponentModel;

namespace PROIECT_WAP_VARIANTA2
{
     class MainFormViewModel
    {
        public string name { get; set; }
       
        public int CNP { get; set; }
        public double phone { get; set; }

        public BindingList<Client> Clients { get; private set; }
        public MainFormViewModel()
        {
            Clients = new BindingList<Client>();
        }

        public void addClient()
        {
            Client client = new Client(name, CNP, phone);
            Clients.Add(client);
        }
    }
}