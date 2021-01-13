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
    public partial class Delete_driving : Form
    {
        private readonly IDrivingBusiness _drivingBusiness;
        public Delete_driving(IDrivingBusiness drivingBusiness)
        {
            this._drivingBusiness = drivingBusiness;
            InitializeComponent();
        }

        private void Delete_driving_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Driving> drivings = _drivingBusiness.GetDrivings();

            listBoxDrivings.Items.Clear();

            foreach (Driving driving in drivings)
                listBoxDrivings.Items.Add(driving.Id + ". Mileage: " + driving.Mileage + "km Price per km: " + driving.PricePerKM + "$ Total earning: " + driving.TotalEarning + "$ Dispatcher earning: " + driving.DispatcherEarning + "$");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);

                if (_drivingBusiness.GetDrivingsById(id) != null)
                {
                    this._drivingBusiness.DeleteDriving(id);
                    MessageBox.Show("Driving successfully deleted!", "Success");
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
