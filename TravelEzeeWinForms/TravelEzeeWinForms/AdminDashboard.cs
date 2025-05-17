using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelEzeeManagement;

namespace TravelEzeeWinForms
{
    public partial class AdminDashboard : Form
    {
        private Admin _adminModule;
        public AdminDashboard()
        {
            InitializeComponent();
            _adminModule = new Admin();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            _adminModule.ImportLocations();
            _adminModule.ImportServices();
            UpdateLocationGrid();
        }
        private void UpdateLocationGrid()
        {
            List<Location> locationslist = _adminModule.GetAllLocations();
            gridLocations.DataSource = null;
            gridLocations.DataSource = locationslist;
            gridLocations.Refresh();
        }

        private void BtnAddLocation_Click(object sender, EventArgs e)
        {
            NewLocation newLocation=new NewLocation(_adminModule);
            newLocation.ShowDialog();
            UpdateLocationGrid();
        }

        private void UpdateServiceGrid()
        {
            List<Service> serviceslist = _adminModule.GetAllServices();
            gridServices.DataSource = null;
            gridServices.DataSource = serviceslist;
            gridServices.Refresh();
        }
        private void BtnAddServices_Click(object sender, EventArgs e)
        {
            NewServices newLocation = new NewServices(_adminModule);
            newLocation.ShowDialog();
            UpdateServiceGrid();
        }
    }
}
