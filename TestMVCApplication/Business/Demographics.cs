using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DataAccess;
using System.Data;

namespace Business
{
    public class Demographics
    {

        public static List<DemographicInformation> GetIndividulDemographicData()
        {
            DemographicInformation IndivDemo = new DemographicInformation();
            var IndivDemoList = new List<DemographicInformation>();
            DataSet dsGetDemographicsReport = new DataSet();

            //2rd Assignment
            //Get the demographics from database but get the connection string details from web.Config file
            dsGetDemographicsReport = DADemographicsInformation.GetDemographicsUsingDBWithConfig();

            //3rd Assignment
            //Calling web service - Get the demographics from database but get the connection string details from web.Config file
            //var testService = new MyDemographicsInfoService.MyDemographicsInfoServiceClient();
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithConfig();

            //------------------------------------------------------------------------------------------
            //Get the demographics from database but define the connection string in this method
            //dsGetDemographicsReport = DADemographicsInformation.GetDemographicsUsingDBWithOutConfig();
            //dsGetDemographicsReport = testService.GetDemographicsUsingDBWithOutConfig();

            //var testServ = new DemoInformationService.DemoInformationServiceClient();
            //Get the demographics data by NOT USING the database
            //dsGetDemographicsReport = DADemographicsInformation.GetDemographicsWithOutDB();
            //dsGetDemographicsReport = testService.GetDemographicsWithOutDB();
            //------------------------------------------------------------------------------------------

            //Transfer Dataset details to List Object
            if (dsGetDemographicsReport.Tables.Count > 0)
            {
                IndivDemoList = dsGetDemographicsReport.Tables[0].AsEnumerable().Select(m => new DemographicInformation
                {
                    //Left side is Model Object - Right Side is Database columns
                    FirstName = Convert.ToString(m["FirstName"]),
                    LastName = Convert.ToString(m["LastName"]),
                    Sex = Convert.ToString(m["Sex"]),
                    Address = Convert.ToString(m["Address"])

                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return IndivDemoList;

        }

    }
}
