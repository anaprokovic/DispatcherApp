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
    public partial class Update_dispatcher_s_info : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        public Update_dispatcher_s_info(IDispatcherBusiness dispatcherBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxId.Text != "")
            {
                try 
                { 
                    int id = Convert.ToInt32(textBoxId.Text);

                    Dispatcher dispatcher = new Dispatcher();

                    dispatcher.Id = Convert.ToInt32(textBoxId.Text);
                    dispatcher.Name = textBoxName.Text;
                    dispatcher.Surname = textBoxSurname.Text;

                    if(_dispatcherBusiness.GetDispatcherByID(id))
                    { 
                        this._dispatcherBusiness.UpdateDispatcher(dispatcher);
                        MessageBox.Show("Data successfully updated!", "Success");
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
            else
            {
                MessageBox.Show("Please fill in data in correct format!", "Check data");
            }
        }

        private void Update_dispatcher_s_info_Load(object sender, EventArgs e)
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
    }
}
