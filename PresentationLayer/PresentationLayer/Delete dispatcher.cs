using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Delete_dispatcher : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        public Delete_dispatcher(IDispatcherBusiness dispatcherBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            InitializeComponent();
        }

        private void Delete_dispatcher_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Dispatcher> dispatchers = _dispatcherBusiness.GetAllDispatchers();

            listBoxDispatchers.Items.Clear();

            foreach (Dispatcher dispatcher in dispatchers)
                listBoxDispatchers.Items.Add(dispatcher.Id + ". Name: " + dispatcher.Name + " Surname: " + dispatcher.Surname);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                
                if (_dispatcherBusiness.GetDispatcherByID(id))
                {
                    this._dispatcherBusiness.DeleteDispatcher(id);
                    MessageBox.Show("Dispatcher successfully deleted!", "Success");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please fill in data in correct id!", "Check id");
                }
            }
            catch
            {
                MessageBox.Show("Please fill in data in correct id!", "Check id");
            }
        }
    }
}
