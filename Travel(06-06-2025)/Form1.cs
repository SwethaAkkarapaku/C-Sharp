using System.Linq;

namespace TravelCoreEF
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess;
        public Form1()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {

            // DestBox
            //if(SourceBox.Count>0)
            Location srcLoc = SourceBox.SelectedItem as Location;
            Location destLoc = DestBox.SelectedItem as Location;
            if (srcLoc != null && destLoc != null)
            {
                long SrcId = srcLoc.LocationId;
                long DestId = destLoc.LocationId;
                if (SrcId != DestId)
                {
                    List<Service> srv = dataAccess.GetServicesBasedonLocation(SrcId, DestId);
                    searchList.DataSource = srv;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //searchList.DataSource = dataAccess.GetAllServicesView();
            //DataAccess dataAccess = new DataAccess();
            List<Location> locations = dataAccess.GetAllLocations();

            Location[] locs = new Location[locations.Count];
            locations.ToArray().CopyTo(locs, 0);

            SourceBox.DataSource = locations;
            SourceBox.DisplayMember = "LocationName";

            List<Location> locations1 = locs.ToList();
            DestBox.DataSource = locations1;
            DestBox.DisplayMember = "LocationName";
        }
    }
}
