using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wexy.Models;

namespace wexy.Views
{
    public partial class AdministratorView : Form, IAdministratorView
    {
        private bool isEdit;
        private bool isSuccessfull;
        private string message;

        public string FirstName 
        {
            get { return txtBoxFirstName.Text; }
            set { txtBoxFirstName.Text = value; }
        }
        public string LastName
         {
                get { return txtBoxLastName.Text; }
                set { txtBoxLastName.Text = value; }
         }
        public string Email
        {
            get { return txtBoxEmail.Text; }
            set { txtBoxEmail.Text = value; }
        }
        public string UserName
        {
            get { return txtBoxUserName.Text; }
            set { txtBoxUserName.Text = value; }
        }
        public string Password
        {
            get { return txtBoxPassword.Text; }
            set { txtBoxPassword.Text = value; }
        }
        public string SearValue 
        { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessfull
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public AdministratorView()
        {
            InitializeComponent();
            
            //AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            //implement update save addnew events
            throw new NotImplementedException();
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler UpdateEvent;
        public event EventHandler SaveEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler EditEvent;
        public event EventHandler CancelEvent;


        /// <summary>
        /// bind administrators list to DataGridView
        /// </summary>
        /// <param name="adminList"></param>
        public void SetAdministratorListBindingSource(BindingSource adminList)
        {
            dataGridAdminListView.DataSource = adminList;
            SetupAdministratorDataGridView(dataGridAdminListView);
        }

        private void SetupAdministratorDataGridView(DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            var columnFirstName = new DataGridViewTextBoxColumn() { HeaderText = "Name", DataPropertyName = "FirstName" };
            var columnLastName = new DataGridViewTextBoxColumn() { HeaderText = "Last Name", DataPropertyName = "LastName" };
            var columnUserName = new DataGridViewTextBoxColumn() { HeaderText = "User Name", DataPropertyName = "UserName" };
            var columnEmail = new DataGridViewTextBoxColumn() { HeaderText = "Email", DataPropertyName = "Email" };
            grid.Columns.Add(columnFirstName);
            grid.Columns.Add(columnLastName);
            grid.Columns.Add(columnUserName);
            grid.Columns.Add(columnEmail);
            grid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
