using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace MyDemographicsInfoService
{
    [ServiceContract]
    public interface IMyDemographicsInfoService
    {
        [OperationContract]
        DataSet GetDemographicsWithOutDB();

        [OperationContract]
        DataSet GetDemographicsUsingDBWithConfig();

        [OperationContract]
        DataSet GetDemographicsUsingDBWithOutConfig();
    }
}
