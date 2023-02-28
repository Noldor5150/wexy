using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wexy.Models;
using wexy.Presenters;
using wexy.Repositories;
using wexy.Views;

namespace wexy
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IAdministratorView adminview = new AdministratorView();
            IAdministratorRepository repository = new AdministratorRepository();
            new AdministratorPresenter(adminview, repository);
            Application.Run((Form)adminview );
        }
    }
}
