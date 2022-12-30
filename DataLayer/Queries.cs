using BussinessLayerLogics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Microsoft.VisualBasic;

namespace DataLayer
{

    public class Queries
    {
       // Database db = new Database();

        public bool insertRecord(Properties obj)
        {
            try
            {
                //  OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2101811\Downloads\DB_EmployeeDatabase.accdb");
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2101811\Downloads\DB_EmployeeSystemProject.accdb"); //database2

                OleDbCommand cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tbl_EmployeeSystemProject(FirstName, LastName, DOB, MobileNumber, Designation, EmployeeId)VALUES('" + obj.Firstname + "','" + obj.Lastname + "','" + obj.DOB + "','" + obj.Mobilenumber + "','" + obj.Designation + "','" + obj.EmployeeId + "')";
                cmd.ExecuteNonQuery();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (OverflowException ex)
            {
                throw ex;
            }
            
        }
      
    }
}
