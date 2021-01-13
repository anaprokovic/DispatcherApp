using Shared.Interfaces.Business;
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
    public partial class MainMenu : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDrivingBusiness _drivingBusiness;
        public MainMenu(IDrivingBusiness drivingBusiness, IDriverBusiness driverBusiness, IDispatcherBusiness dispatcherBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            this._drivingBusiness = drivingBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispatchers dispatchers = new Dispatchers(_dispatcherBusiness,_driverBusiness);
            dispatchers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drivers drivers = new Drivers(_driverBusiness,_dispatcherBusiness,_drivingBusiness);
            drivers.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivings drivings = new Drivings(_drivingBusiness,_dispatcherBusiness,_driverBusiness);
            drivings.ShowDialog();
            
        }
    }
}
