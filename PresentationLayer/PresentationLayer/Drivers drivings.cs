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
    public partial class Drivers_drivings : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDrivingBusiness _drivingBusiness;
        public Drivers_drivings(IDriverBusiness driverBusiness, IDrivingBusiness drivingBusiness)
        {
            this._driverBusiness = driverBusiness;
            this._drivingBusiness = drivingBusiness;
            InitializeComponent();
        }

        private void buttonShowDrivings_Click(object sender, EventArgs e)
        {
            try
            {
                if (_driverBusiness.GetDrivers().Count != 0 && comboBoxDrivers.SelectedItem == null)
                {
                    listBoxDrivings.Items.Clear();

                    listBoxDrivings.Items.Add("Please choose driver!");
                }
                else if (_driverBusiness.GetDrivers().Count != 0)
                {
                    var array = comboBoxDrivers.SelectedItem.ToString().Split(' ');

                    String name = array[0];
                    String surname = array[1];

                    int id = _driverBusiness.GetDriverByNameSurname(name, surname).Id;

                    List<Driving> drivings = _drivingBusiness.GetDrivingsByDriverId(id);

                    if (drivings.Count() == 0)
                    {
                        listBoxDrivings.Items.Clear();

                        listBoxDrivings.Items.Add("Driver doesn't have any drivings yet.");
                    }
                    else
                    {
                        listBoxDrivings.Items.Clear();

                        foreach (Driving driving in drivings)
                            listBoxDrivings.Items.Add("Mileage: " + driving.Mileage + " Price per KM: " + driving.PricePerKM + " Total earning: " + driving.TotalEarning+" Dispatcher earning: "+driving.DispatcherEarning);
                    }
                }
                else
                {
                    listBoxDrivings.Items.Clear();

                    listBoxDrivings.Items.Add("No drivings in database!");
                }

            }

            catch
            {
                MessageBox.Show("Make sure you choose correct name and surname!", "Warning");
            }

        }

        private void Drivers_drivings_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            listBoxDrivings.Items.Clear();
            listBoxDrivings.Items.Add("No data to show! Please fill the 'ID' field and press 'SHOW DRIVINGS' button");

            comboBoxDrivers.Items.Clear();

            List<Driver> drivers = _driverBusiness.GetDrivers();

            foreach (Driver driver in drivers)
                comboBoxDrivers.Items.Add(driver);

            if (drivers.Count == 0)
            {
                listBoxDrivings.Items.Clear();

                listBoxDrivings.Items.Add("No drivers in database!");
            }
        }
    }
}
