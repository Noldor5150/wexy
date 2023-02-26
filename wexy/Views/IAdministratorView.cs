using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wexy.Views
{
   public interface IAdministratorView
    {
        //Props-Fields
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string SearValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessfull { get; set; }
        string Message { get; set; }

        //Events

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler UpdateEvent;
        event EventHandler SaveEvent;
        event EventHandler DeleteEvent;

        //Methods

        void SetAdministratorListBindingSource(BindingSource adminList);
        void Show();

    }
}
