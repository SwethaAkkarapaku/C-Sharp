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
    public partial class NewLocation : Form
    {
        Admin _adminModule;
        public NewLocation(Admin adminModule)
        {
            _adminModule = adminModule;
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textLocNo.Text)||string.IsNullOrEmpty(textLocName.Text))
            {
                MessageBox.Show("enter details");
            }
            else
            {
                TravelEzeeManagement.Location loc=new TravelEzeeManagement.Location();
                loc.LocationId=int.Parse(textLocNo.Text);
                loc.Name=textLocName.Text;
                _adminModule.AddLocation(loc);
                MessageBox.Show("location added successfully");
                DialogResult = DialogResult.OK;
                this.Close();  
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
