using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wexy.Models;
using wexy.Views;

namespace wexy.Presenters
{
    public class AdministratorPresenter
    {
        //Fields
        private IAdministratorView view;
        private IAdministratorRepository repository;
        private BindingSource adminBindingSource;
        private IEnumerable<AdministratorModel> adminList;

        
        

        public AdministratorPresenter(IAdministratorView view, IAdministratorRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.adminBindingSource = new BindingSource();
            // Subscribe event handler methods to view events
            this.view.AddNewEvent += AddNewAdministrator;
            this.view.SaveEvent += SaveAdministarorParams;
            this.view.UpdateEvent += UpdateAdministrator;
            this.view.CancelEvent += CancelAction;
            this.view.EditEvent += LoadSelectedAdminForEdit;
            this.view.SaveEvent += SearchAdministrator;
            this.view.DeleteEvent += DeleteAdministrator;

            // Set admin list binding source
            this.view.SetAdministratorListBindingSource(adminBindingSource);
            //load admin list view
            LoadAllAdministrators();
            //show view
            this.view.Show();
        }

        private void DeleteAdministrator(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchAdministrator(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectedAdminForEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UpdateAdministrator(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        List<AdministratorModel> adminlisttest = new List<AdministratorModel>()
        {
            new AdministratorModel() {Id = 1, FirstName = "Billy", LastName = "Gibbons", Email = "billgib@zztop.com", UserName = "KillBill", Password = "somepassword"},
            new AdministratorModel() {Id = 2, FirstName = "Paul", LastName = "Sanders", Email = "pollyS@frieds.com", UserName = "Polly S", Password = "somepassword"},
            new AdministratorModel() {Id = 3, FirstName = "Donny", LastName = "Trump", Email = "donnytb@president.com", UserName = "Donny", Password = "somepassword"}
        };
        private void LoadAllAdministrators()
        {
            //adminList = repository.GetAll();
            //adminBindingSource.DataSource = adminList;
            adminBindingSource.DataSource = adminlisttest;
        }

        private void SaveAdministarorParams(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewAdministrator(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
