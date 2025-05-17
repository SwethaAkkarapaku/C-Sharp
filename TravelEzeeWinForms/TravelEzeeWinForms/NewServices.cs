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
    public partial class NewServices : Form
    {
        
        Admin _adminModule;
        public NewServices(Admin adminModule)
        {
            _adminModule = adminModule;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textServiceNo.Text) || string.IsNullOrEmpty(textFromLocation.Text)|| string.IsNullOrEmpty(textToLocation.Text)|| string.IsNullOrEmpty(textServiceTypeId.Text))
            {
                MessageBox.Show("enter details");
            }
            //else
            //{
            //    TravelEzeeManagement.Service service = new TravelEzeeManagement.Service();
            //    service.ServiceNo = int.Parse(textServiceNo.Text);
            //    service.FromLocation = textFromLocation.Text;
            //    service.
            //    _adminModule.AddLocation(loc);
            //    MessageBox.Show("location added successfully");
            //    DialogResult = DialogResult.OK;
            //    this.Close();
            //}
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
