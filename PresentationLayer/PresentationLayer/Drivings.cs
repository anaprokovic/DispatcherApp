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
    public partial class Drivings : Form
    {
        private readonly IDrivingBusiness _drivingBusiness;
        private readonly IDispatcherBusiness _dispatcherBusiness;
        private readonly IDriverBusiness _driverBusiness;
        public Drivings(IDrivingBusiness drivingBusiness, IDispatcherBusiness dispatcherBusiness, IDriverBusiness driverBusiness)
        {
            this._driverBusiness = driverBusiness;
            this._dispatcherBusiness = dispatcherBusiness;
            this._drivingBusiness = drivingBusiness;
            InitializeComponent();
        }

        private void Drivings_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            List<Driving> drivings = _drivingBusiness.GetDrivings();

            listBoxDrivings.Items.Clear();
            if (drivings.Count > 0)
                foreach (Driving driving in drivings)
                    listBoxDrivings.Items.Add(driving.Id + ". Mileage: " + driving.Mileage + "km Price per km: " + driving.PricePerKM + "$ Total earning: " + driving.TotalEarning + "$ Dispatcher earning: " + driving.DispatcherEarning + "$");
            else
                listBoxDrivings.Items.Add("No drivings yet");
        }

        private void buttonNewDriving_Click(object sender, EventArgs e)
        {
            New_driving new_Driving = new New_driving(_dispatcherBusiness,_driverBusiness,_drivingBusiness);
            new_Driving.ShowDialog();
            RefreshData();
        }

        private void buttonUpdateDriving_Click(object sender, EventArgs e)
        {
            Update_driving_s_info update_Driving_Info = new Update_driving_s_info(_driverBusiness,_drivingBusiness);
            update_Driving_Info.ShowDialog();
            RefreshData();
        }

        private void buttonDeleteDriving_Click(object sender, EventArgs e)
        {
            Delete_driving delete_Driving = new Delete_driving(_drivingBusiness);
            delete_Driving.ShowDialog();
            RefreshData();
        }
    }
}
