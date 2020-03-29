using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DADemographicsInformation
    {
        //Get the demographics data by NOT USING the database
        public static DataSet GetDemographicsWithOutDB()
        {
            
            DataSet dsGetDemographicsReport = new DataSet();
            dsGetDemographicsReport.DataSetName = "Demographics";
            DataTable dt = new DataTable("BasicInformation");
            dt.Clear();
            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("Sex", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["FirstName"] = "David";
            dr["LastName"] = "Johnson";
            dr["Sex"] = "Male";
            dr["Address"] = "111 Johns Drive, Mechanicsburg, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "John";
            dr["LastName"] = "Williams";
            dr["Sex"] = "Male";
            dr["Address"] = "433 Kings Road, Middletown, PA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Pete";
            dr["LastName"] = "Queen";
            dr["Sex"] = "Female";
            dr["Address"] = "25 Rings Road, Atlanta, GA";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["FirstName"] = "Jaswi";
            dr["LastName"] = "Edwars";
            dr["Sex"] = "Female";
            dr["Address"] = "121 Manner Drive, Camp Hill, PA";
            dt.Rows.Add(dr);


            dsGetDemographicsReport.Tables.Add(dt);

            return dsGetDemographicsReport;
        }

        //Get the demographics from database but define the connection string in this method
        public static DataSet GetDemographicsUsingDBWithOutConfig()
        {
            string connetionString = null;
            
            SqlConnection cnn;
            SqlCommand command;
            SqlDataReader dataReader;
            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();

            connetionString = "Data Source=TESTDATABASE;Initial Catalog=master;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);

            string sql = null;
            sql = "Select * from IndividualDemographics";
            
            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);                
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetDemographicsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetDemographicsReport;
        }

        //Get the demographics from database but get the connection string details from web.Config file
        public static DataSet GetDemographicsUsingDBWithConfig()
        {
            SqlConnection cnn;
            string sql = null;
            SqlCommand command;
            SqlDataReader dataReader;

            DataTable dt = new DataTable();
            DataSet dsGetDemographicsReport = new DataSet();

            var cs = ConfigurationManager.ConnectionStrings["DemographicsConnection_DEV"].ConnectionString;
            cnn = new SqlConnection(cs);
            sql = "Select * from IndividualDemographics";

            //Open the connection
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            dsGetDemographicsReport.Tables.Add(dt);
            dataReader.Close();
            command.Dispose();
            cnn.Close();

            return dsGetDemographicsReport;
        }

    }
}
