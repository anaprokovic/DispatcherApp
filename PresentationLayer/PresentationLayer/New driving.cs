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
    public partial class New_driving : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDrivingBusiness _drivingBusiness;
        private bool valid = false;
        public New_driving(IDispatcherBusiness dispatcherBusiness, IDriverBusiness driverBusiness, IDrivingBusiness drivingBusiness)
        {
            this._drivingBusiness = drivingBusiness;
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_driver new_Driver = new New_driver(_driverBusiness, _dispatcherBusiness);
            new_Driver.ShowDialog();
            RefreshData();
        }
        private void RefreshData()
        {
            List<Driver> drivers = _driverBusiness.GetDrivers();

            comboBoxDrivers.Items.Clear();

            foreach (Driver driver in drivers)
                comboBoxDrivers.Items.Add(driver.Name + " " + driver.Surname);

            comboBoxDrivers.SelectedIndex = 0;
        }

        private void New_driving_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                String DriverNameSurname = comboBoxDrivers.SelectedItem.ToString();
                String[] array = DriverNameSurname.Split(' ');

                Driver temp = _driverBusiness.GetDriverByNameSurname(array[0], array[1]);

                if (temp != null && textBoxMileage.Text != "" && textBoxPrice.Text != "" && textBoxDispatcherEarning.Text != "" && valid)
                {
                    Driving driving = new Driving();

                    driving.Mileage = Convert.ToInt32(textBoxMileage.Text);
                    driving.PricePerKM = Convert.ToDecimal(textBoxPrice.Text);
                    driving.TotalEarning = driving.Mileage * driving.PricePerKM;
                    driving.DriverID = temp.Id;
                    driving.DispatcherEarning = driving.TotalEarning * Convert.ToInt32(textBoxDispatcherEarning.Text)/100;

                    _drivingBusiness.InsertDriving(driving);

                    MessageBox.Show("Driving successfully inserted to database!", "Success");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Make sure you filled in correct data!", "Check data");


            }
            catch
            {
                MessageBox.Show("Make sure you filled in correct data!", "Check data");
            }
        }

        private void textBoxDispatcherEarning_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxDispatcherEarning.Text) < 0 || Convert.ToInt32(textBoxDispatcherEarning.Text) > 100)
                {
                    labelPercentage.Text = "Percentage value must be a number between 0 and 100";
                    valid = false;
                }
                else
                {
                    labelPercentage.Text = "";
                    valid = true;
                }
            }
            catch { }
        }
    }
}
