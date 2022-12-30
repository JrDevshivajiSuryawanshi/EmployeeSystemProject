using BussinessLayerLogics;
using DataLayer;
using System.Net;

namespace BussinessLayer
{
    public class BLLInsert
    {
        public string  insert(Properties obj)
        {
            Queries ins = new Queries();
            if(ins.insertRecord(obj) == true)
            {
                return "Data Inserted Succefully";
            }
            else
            {
                return "Unalbe to insert data";
            }
        }
        public void clearmethod(Properties obj)
        {
     //       obj.Firstname = string.Empty;
     //       obj.Firstname = "";
     //       obj.Lastname = string.Empty;
     ////       obj.Mobilenumber = Convert.ToInt32(string.Empty);
     //       obj.Designation= string.Empty;
     //       obj.EmployeeId= string.Empty;
            //tbfname.Text = string.Empty;
            //tblname.Text = string.Empty;
            //tbdesignatio.Text = string.Empty;
            //tbmbl.Text = string.Empty;
            //tbempid.Text = string.Empty;
        }
       

    }
}













































/* 
 * public string valexcel(Properties obj) 
        {
            validation val= new validation();
            if (val.insertVal(obj) == true)
            {
                return "Data validated Succefully";
            }
            else
            {
                return "Unalbe to insert data";
            }
        }
*/