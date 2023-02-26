﻿using System;
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
            // Set admin list binding source
            this.view.SetAdministratorListBindingSource(adminBindingSource);
            //load admin list view
            LoadAllAdministrators();
            //show view
            this.view.Show();
        }

        private void LoadAllAdministrators()
        {
            throw new NotImplementedException();
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