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
    public partial class Drivers : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDrivingBusiness _drivingBusiness;
        public Drivers(IDriverBusiness driverBusiness, IDispatcherBusiness dispatcherBusiness, IDrivingBusiness drivingBusiness)
        {
            this._drivingBusiness = drivingBusiness;
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }
        private void RefreshData()
        {
            List<Driver> drivers = _driverBusiness.GetDrivers();

            listBoxDrivers.Items.Clear();
            if (drivers.Count > 0)
                foreach (Driver driver in drivers)
                    listBoxDrivers.Items.Add(driver.Id + ". Name: " + driver.Name + " Surname: " + driver.Surname + " Phone number: " + driver.PhoneNumber);
            else
                listBoxDrivers.Items.Add("No drivers yet");
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonNewDriver_Click(object sender, EventArgs e)
        {
            New_driver new_Driver = new New_driver(_driverBusiness,_dispatcherBusiness);
            new_Driver.ShowDialog();
            RefreshData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update_driver update_Driver = new Update_driver(_dispatcherBusiness,_driverBusiness);
            update_Driver.ShowDialog();
            RefreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete_driver delete_Driver = new Delete_driver(_driverBusiness);
            delete_Driver.ShowDialog();
            RefreshData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivers_drivings drivers_Drivings = new Drivers_drivings(_driverBusiness,_drivingBusiness);
            drivers_Drivings.ShowDialog();
            RefreshData();
        }
    }
}
