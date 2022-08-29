using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{
    public class ClientValidation
    {
        public delegate void ClientEventHandler(object source, ClientValidationArgs e);
        public event ClientEventHandler ClientValidated;
        public void Validation(Client c)
        {
            Console.WriteLine("Validate client");
            Thread.Sleep(1000);

        }

        protected virtual void onClientValidated(Client client)
        {
            if (ClientValidated != null)
            {
                ClientValidated(this, new ClientValidationArgs() { Client=client});
            }
        }
    }
}
