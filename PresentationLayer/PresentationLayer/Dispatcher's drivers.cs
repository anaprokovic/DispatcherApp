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
    public partial class Dispatcher_s_drivings : Form
    {
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDriverBusiness _driverBusiness;
        public Dispatcher_s_drivings(IDispatcherBusiness dispatcherBusiness, IDriverBusiness driverBusiness)
        {
            this._dispatcherBusiness = dispatcherBusiness;
            this._driverBusiness = driverBusiness;
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dispatcherBusiness.GetAllDispatchers().Count != 0 && comboBoxDispatchers.SelectedItem == null)
                {
                    listBoxDispatchers.Items.Clear();

                    listBoxDispatchers.Items.Add("Please choose dispatcher!");
                }
                else if (_dispatcherBusiness.GetAllDispatchers().Count != 0)
                {
                    var array = comboBoxDispatchers.SelectedItem.ToString().Split(' ');

                    String name = array[0];
                    String surname = array[1];

                    int id = _dispatcherBusiness.GetDispatcherByNameSurname(name, surname).Id;

                    List<Driver> drivers = _driverBusiness.GetDriversByDispatcherID(id);

                    if (drivers.Count() == 0)
                    {
                        listBoxDispatchers.Items.Clear();

                        listBoxDispatchers.Items.Add("Dispatcher doesn't have any drivers yet.");
                    }
                    else
                    {
                        listBoxDispatchers.Items.Clear();

                        foreach (Driver driver in drivers)
                            listBoxDispatchers.Items.Add("Name: " + driver.Name + " Surname: " + driver.Surname + " Phone number: " + driver.PhoneNumber);
                    }
                }
                else
                {
                    listBoxDispatchers.Items.Clear();

                    listBoxDispatchers.Items.Add("No clients in database!");
                }

            }

            catch
            {
                MessageBox.Show("Make sure you choose correct name and surname!", "Warning");
            }
        }

        private void Dispatcher_s_drivings_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            listBoxDispatchers.Items.Clear();
            listBoxDispatchers.Items.Add("No data to show! Please fill the 'ID' field and press 'SHOW DRIVERS' button");

            comboBoxDispatchers.Items.Clear();

            List<Dispatcher> dispatchers = _dispatcherBusiness.GetAllDispatchers();

            foreach (Dispatcher dispatcher in dispatchers)
                comboBoxDispatchers.Items.Add(dispatcher);

            if (dispatchers.Count == 0)
            {
                listBoxDispatchers.Items.Clear();

                listBoxDispatchers.Items.Add("No dispatchers in database!");
            }
        }
    }
}
