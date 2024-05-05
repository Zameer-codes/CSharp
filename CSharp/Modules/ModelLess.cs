using Newtonsoft.Json;
using System.Dynamic;
using System.Reflection;

namespace CSharp.Modules
{
    public class ModelLess
    {
        public async Task TestDynamicData( string offDataJson)
        {
            //object testObj = new
            //{
            //    one = 1,
            //    two = 2,
            //    three = 3
            //};
            //OffCycleModel offCycleModel = new OffCycleModel()
            //{
            //    Client = "Test2",
            //    EarningsAndDeductionsCodes = JsonConvert.SerializeObject(testObj)
            //};
            //_context.Add(offCycleModel);
            //_context.SaveChanges();

            //foreach (PropertyInfo item in testObj.GetType().GetProperties())
            //{
            //    var 
            //}
            //List<OffCycleModel> OffCycleCompleteData = _context.offcycle.ToList();
            //foreach (var offCycle in OffCycleCompleteData)
            //{
            //    var ExtendedObj= new Dictionary<string,string>();
            //    var NewtonSoftData = JsonConvert.DeserializeObject<ExpandoObject>(offCycle.EarningsAndDeductionsCodes);

            //    //foreach (PropertyInfo item in NewtonSoftData.GetType().GetProperties())
            //    //{
            //    //    //ExtendedObj[item.Name] = item.GetValue(offCycle.EarningsAndDeductionsCodes, null);
            //    //    var test = item.GetValue(NewtonSoftData, null);
            //    //}

            //    //foreach(var item in NewtonSoftData)
            //    //{
            //    //    ExtendedObj[item.Key] = item.Value.ToString();
            //    //}
            //    return NewtonSoftData;
            //}
            //return null;



            //MyData myData = new MyData
            //{
            //    Name = "John",
            //    Age = 30
            //};

            //// New JSON data as a string
            //string newJsonData = "{\"Gender\": \"Male\", \"Country\": \"USA\"}";

            //// Deserialize the new JSON data
            //dynamic newJsonObject = JsonConvert.DeserializeObject<ExpandoObject>(newJsonData);

            //// Create a new dynamic object to hold the combined data
            //dynamic combinedData = new ExpandoObject();

            //// Copy properties from the MyData object to the combinedData object
            //combinedData.Name = myData.Name;
            //combinedData.Age = myData.Age;

            //// Merge properties from the new JSON data into the combinedData object
            //foreach (var property in newJsonObject)
            //{
            //    ((IDictionary<string, object>)combinedData)[property.Key] = property.Value;
            //}
            //return combinedData;


            var offDataModel = new OffCycleModel();

            //JsonElement offDataJson = new JsonElement();
            //if (apiObj is JsonElement jsonElement)
            //{
            //    offDataJson = jsonElement;
            //}


            /*
             {
 Co_Code : "",
                Process_Date : "",
                File_Number:"",
                Employee_Names : "test",
                State :"",
                Freq : "",
                Termed_Date : "",
                Pay_Rate : "",
                Check_Freq : "",
                Temp_rate : "",
                Reg_Hrs : "",
                OT_Hrs : "",
                Sick_Hrs : "",
                Reimb : "",
                Category : "",
                Week_Start : "",
                Week_End : "",
                Airfare_Reim : "93",
                Blood_Voucher : "09",
            }
             */

            /* var offDataJson = new{
                 Co_Code = "",
                 Process_Date = "",
                 File_Number="",
                 Employee_Names = "test",
                 State = "",
                 Freq = "",
                 Termed_Date = "",
                 Pay_Rate = "",
                 Check_Freq = "",
                 Temp_rate = "",
                 Reg_Hrs = "",
                 OT_Hrs = "",
                 Sick_Hrs = "",
                 Reimb = "",
                 Category = "",
                 Week_Start = "",
                 Week_End = "",
                 Airfare_Reim = "93",
                 Blood_Voucher = "09",
             };*/

            var offDataExpando = JsonConvert.DeserializeObject<ExpandoObject>(offDataJson);

            dynamic EAD_Codes = new ExpandoObject();

            List<string> AllPropertiesNames = new List<string>();
            foreach (PropertyInfo property in offDataModel.GetType().GetProperties())
            {
                AllPropertiesNames.Add(property.Name);
            }

            foreach (var item in offDataExpando)
            {
                foreach (PropertyInfo property in offDataModel.GetType().GetProperties())
                {
                    if (property.Name == item.Key)
                    {
                        property.SetValue(offDataModel, item.Value);
                    }
                }
                if (!AllPropertiesNames.Contains(item.Key) && item.Key != "OffCycleId")
                {
                    ((IDictionary<string, object>)EAD_Codes)[item.Key] = item.Value;
                }
            }
            offDataModel.EAD_Codes = JsonConvert.SerializeObject(EAD_Codes);

            Console.WriteLine("jhdjhsba");
        }
    }

    internal class OffCycleModel
    {
        public string EAD_Codes { get; set; }
    }
}
