using Shared.Interfaces.Business;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class New_driver : Form
    {
        private readonly IDriverBusiness _driverBusiness;
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private String regex = "^[0-9]";
        private bool valid = false;
        public New_driver(IDriverBusiness driverBusiness, IDispatcherBusiness dispatcherBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void New_driver_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            List<Dispatcher> dispatchers = _dispatcherBusiness.GetAllDispatchers();

            comboBoxDispatchers.Items.Clear();

            foreach (Dispatcher dispatcher in dispatchers)
                comboBoxDispatchers.Items.Add(dispatcher.Name + " " + dispatcher.Surname);

            comboBoxDispatchers.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_dispatcher new_Dispatcher = new New_dispatcher(_dispatcherBusiness);
            new_Dispatcher.ShowDialog();
            RefreshData();
        }

        private void buttonAddDriver_Click(object sender, EventArgs e)
        {
            try
            {
                String DispatcherNameSurname = comboBoxDispatchers.SelectedItem.ToString();
                String[] array = DispatcherNameSurname.Split(' ');

                Dispatcher temp = _dispatcherBusiness.GetDispatcherByNameSurname(array[0], array[1]);

                if (temp != null && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxPhoneNumber.Text != "" && valid)
                {
                    Driver driver = new Driver();

                    driver.Name = textBoxName.Text;
                    driver.Surname = textBoxSurname.Text;
                    driver.PhoneNumber = textBoxPhoneNumber.Text;
                    driver.DispatcherID = temp.Id;

                    _driverBusiness.InsertDriver(driver);

                    MessageBox.Show("Driver successfully inserted to database!", "Success");
                    this.Dispose();
                }
                else
                    MessageBox.Show("Make sure you filled in correct data!", "Check data");


            }
            catch
            {
                MessageBox.Show("Make sure you filled in correct data!","Check data");
            }
        }

        private void textBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if(Regex.Match(textBoxPhoneNumber.Text,regex).Success)
            {
                valid = true;
                labelPhoneNumberRegex.Text = "";
            }
            else
            {
                valid = false;
                labelPhoneNumberRegex.Text = "Invalid phone number";
            }
        }
    }
}
