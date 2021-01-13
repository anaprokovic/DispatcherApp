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
    public partial class Delete_driver : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        public Delete_driver(IDriverBusiness driverBusiness)
        {
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void Delete_driver_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Driver> drivers = _driverBusiness.GetDrivers();

            listBoxDrivers.Items.Clear();

            foreach (Driver driver in drivers)
                listBoxDrivers.Items.Add(driver.Id + ". Name: " + driver.Name + " Surname: " + driver.Surname+" Phone number: "+driver.PhoneNumber);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);

                if (_driverBusiness.GetDriverById(id) != null)
                {
                    this._driverBusiness.DeleteDriver(id);
                    MessageBox.Show("Driver successfully deleted!", "Success");
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
