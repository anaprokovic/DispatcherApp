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
    public partial class Dispatchers : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDriverBusiness _driverBusiness;
        public Dispatchers(IDispatcherBusiness dispatcherBusiness,IDriverBusiness driverBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void Dispatchers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<Dispatcher> dispatchers = _dispatcherBusiness.GetAllDispatchers();

            listBoxDispatchers.Items.Clear();

            foreach (Dispatcher dispatcher in dispatchers)
                listBoxDispatchers.Items.Add(dispatcher.Id+". Name: "+dispatcher.Name+" Surname: "+dispatcher.Surname);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_dispatcher new_Dispatcher = new New_dispatcher(_dispatcherBusiness);
            new_Dispatcher.ShowDialog();
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_dispatcher_s_info update_info = new Update_dispatcher_s_info(_dispatcherBusiness);
            update_info.ShowDialog();

            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_dispatcher delete_Dispatcher = new Delete_dispatcher(_dispatcherBusiness);
            delete_Dispatcher.ShowDialog();
            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispatcher_s_drivings dispatchers_drivings = new Dispatcher_s_drivings(_dispatcherBusiness,_driverBusiness);
            dispatchers_drivings.ShowDialog();
            RefreshData();
        }
    }
}
