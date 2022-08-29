using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_WAP_VARIANTA2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WelcomeForm());
            var ClientValidation = new ClientValidation();
            var Client = new Client();
            ClientValidation.ClientValidated += Client.onClientValidation;
            ClientValidation.Validation(Client);
            var ClientService = new ClientService();
            ClientValidation.ClientValidated += ClientService.OnClientValidation;

        }
    }
}
