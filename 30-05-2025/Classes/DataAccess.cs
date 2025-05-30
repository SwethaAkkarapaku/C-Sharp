using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
namespace AdvTravelEzeeWin.Classes
{
    public class DataAccess
    {
        private const string ConnectionString = "Data Source=WKSCHE03TRNG087\\SQLEXPRESS;Initial Catalog=AdvTravelEzeeDB;Integrated Security=SSPI;Trust Server Certificate=True";
        DataSet dataSet;
        SqlDataAdapter locationDataAdapter;
        private DataAccess()
        {
            dataSet = new DataSet();
            locationDataAdapter = new SqlDataAdapter("select *from Location", ConnectionString);
        }
        public static DataAccess _dataAccessInstance;
        public static DataAccess DataAccessInstance
        {
            get
            {
                if(_dataAccessInstance == null)
                {
                    _dataAccessInstance = new DataAccess();
                }
                return _dataAccessInstance;
            }
        }

        public bool AddLocation(string LocName)
        {
            if(string.IsNullOrEmpty(LocName))
            {
                Console.WriteLine("enter location name");
            }
            var dtLoc = dataSet.Tables["Loc"];
            var dr = dtLoc.NewRow();
            dr[0] = Guid.NewGuid();
            dr[1] = LocName;
            dtLoc.Rows.Add(dr);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(locationDataAdapter);
            locationDataAdapter.Update(dataSet, "Loc");
            return true;
        }
        public DataTable GetAllLocations()
        {
            locationDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            locationDataAdapter.Fill(dataSet, "Loc");
            return dataSet.Tables["Loc"];
        }
    }
}
