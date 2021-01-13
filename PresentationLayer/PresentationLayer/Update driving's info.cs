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
    public partial class Update_driving_s_info : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDrivingBusiness _drivingBusiness;
        private bool valid = false;
        public Update_driving_s_info(IDriverBusiness driverBusiness, IDrivingBusiness drivingBusiness)
        {
            this._drivingBusiness = drivingBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void Update_driving_s_info_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Driver> drivers = _driverBusiness.GetDrivers();

            comboBoxDrivers.Items.Clear();

            foreach (Driver driver in drivers)
                comboBoxDrivers.Items.Add(driver.Name + " " + driver.Surname);

            comboBoxDrivers.SelectedIndex = 0;

            List<Driving> drivings = this._drivingBusiness.GetDrivings();

            listBoxDrivings.Items.Clear();
            if(drivings.Count > 0)
                foreach (Driving driving in drivings)
                    listBoxDrivings.Items.Add(driving.Id + ". Mileage: " + driving.Mileage + "km Price per km: " + driving.PricePerKM + "$ Total earning: " + driving.TotalEarning + "$ Dispatcher earning: " + driving.DispatcherEarning+"$");
            else
                listBoxDrivings.Items.Add("No drivings yet");
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
                    driving.DispatcherEarning = driving.TotalEarning * Convert.ToInt32(textBoxDispatcherEarning.Text) / 100;

                    int id = Convert.ToInt32(textBoxId.Text);

                    if (_drivingBusiness.GetDrivingsById(id) != null)
                    {
                        this._drivingBusiness.UpdateDriving(driving, id);
                        MessageBox.Show("Data successfully updated!", "Success");
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Please fill in data in correct id!", "Check id");
                    }
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
