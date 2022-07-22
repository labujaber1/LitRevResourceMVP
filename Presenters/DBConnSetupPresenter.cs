using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LitRevResourceMVP.Models;
using LitRevResourceMVP.Views;

namespace LitRevResourceMVP.Presenters
{
    public class DBConnSetupPresenter
    {
        private IDBConnSetupView view;
        private IDBConnSetupRepository repository;
        private BindingSource connectionFileBindingSource;
        private IEnumerable<string> connStringFromFile;

        public DBConnSetupPresenter(IDBConnSetupView view, IDBConnSetupRepository repository)
        {
            this.connectionFileBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;
            this.view.DeleteEvent += DeleteConn;
            this.view.EditEvent += EditConn;
            this.view.SaveEvent += SaveConn;
            this.view.TestConnEvent += TestConn;
            this.view.SetConnectionFileBindingSource(connectionFileBindingSource);
            LoadConnectionFile();

            this.view.Show();
        }

        private void LoadConnectionFile()
        {
            connStringFromFile = repository.GetConnString();
            connectionFileBindingSource.DataSource = connStringFromFile;
            
        }

        private void DeleteConn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditConn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveConn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TestConn(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
