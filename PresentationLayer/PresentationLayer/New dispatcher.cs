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
    public partial class New_dispatcher : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        public New_dispatcher(IDispatcherBusiness dispatcherBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispatcher dispatcher = new Dispatcher();
            if(textBoxName.Text != "" && textBoxSurname.Text != "") 
            { 
                dispatcher.Name = textBoxName.Text;
                dispatcher.Surname = textBoxSurname.Text;

                if (!_dispatcherBusiness.DispatcherByNameSurname(dispatcher))
                {
                    _dispatcherBusiness.InsertDispatcher(dispatcher);
                    MessageBox.Show("Data successfully inserted!", "Success");
                    this.Dispose(); 
                }
                else
                    MessageBox.Show("Dispatcher already exist!", "Check data");
            }
            else
            {
                MessageBox.Show("Please fill in data in correct format!","Check data");
            }
        }
    }
}
