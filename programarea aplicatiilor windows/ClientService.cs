using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_WAP_VARIANTA2
{
    class ClientService
    {
        public void OnClientValidation(object source, ClientValidationArgs e)
        {
            Console.WriteLine("Loading the data..."+e.Client.name);
        }
    }
}
