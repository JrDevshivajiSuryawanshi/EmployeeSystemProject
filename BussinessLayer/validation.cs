using BussinessLayer;
using BussinessLayerLogics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//using IProperities;

namespace BussinessLayer
{
    public class validation 
    {
       
        #region .
        //{
        //    DataTable dt = new DataTable();
        //    DataRow dr = new DataRow();
        //    Regex ValFname = new Regex(@"^[a-zA-Z ]{1,15}$");
        //    Regex ValLname = new Regex(@"^[a-zA-Z]{1,10}$");
        //    DateTime dateTime;
        //    Regex ValPhone = new Regex(@"^[0-9]{10}$");
        //    Regex ValDesignation = new Regex(@"^[a-zA-Z]{1,15}$");
        //    Regex ValEmployeeId = new Regex(@"^[a-zA-Z0-9]{7}$");
        //    int a = 1;
        //    if (dr[0].ToString().Length == 0)
        //    {
        //       logger.Writelog ("First Name Empty at row: " + a);
        //    }
        //    else if (!ValFname.IsMatch(dr[0].ToString()))
        //    {
        //        logger.Writelog("First Name Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    else if (dr[1].ToString().Length == 0)
        //    {

        //        logger.Writelog("Last Name Empty at row: " + a);
        //    }
        //    else if (!ValLname.IsMatch(dr[1].ToString()))
        //    {

        //        logger.Writelog("Last Name Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    else if (dr[2].ToString().Length == 0)
        //    {

        //        logger.Writelog("Date of birth Empty at row: " + a);
        //    }
        //    else if (!DateTime.TryParse(dr[2].ToString(), out dateTime))
        //    {

        //        logger.Writelog("Date of birth Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    else if (dr[3].ToString().Length == 0)
        //    {

        //        logger.Writelog("Phone Number Empty at row: " + a);
        //    }
        //    else if (!ValPhone.IsMatch(dr[3].ToString()))
        //    {

        //        logger.Writelog("Phone Number Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    else if (dr[4].ToString().Length == 0)
        //    {

        //        logger.Writelog("Designation Empty at row: " + a);
        //    }
        //    else if (!ValDesignation.IsMatch(dr[4].ToString()))
        //    {

        //        logger.Writelog("Designation Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    else if (dr[5].ToString().Length == 0)
        //    {

        //        logger.Writelog("Employee Id Empty at row: " + a);
        //    }
        //    else if (!ValEmployeeId.IsMatch(dr[5].ToString()))
        //    {


        //        logger.Writelog("Employee Id Invalid: " + dr[a].ToString() + " at row: " + a);
        //    }
        //    a++;

        //    if (ValFname.IsMatch(dr[0].ToString()) && ValLname.IsMatch(dr[1].ToString()) && DateTime.TryParse(dr[2].ToString(), out dateTime) && ValPhone.IsMatch(dr[3].ToString()) && ValDesignation.IsMatch(dr[4].ToString()) && ValEmployeeId.IsMatch(dr[5].ToString()))
        //    {
        //        //tb.Rows.Add(dr.ItemArray);
        //    }
        //    else
        //    {
        //        // tbl.Rows.Add(dr.ItemArray);
        //    }
        //    return true;
        //}

        //  dataGridView2.DataSource = tb;
        // dataGridView3.DataSource = tbl;
        #endregion

    }
}
























//private void NameValidation()
//{
//    foreach (Cell item in dt)
//    {
//        if (string.IsNullOrEmpty(prop.Value))
//        {
//            prop.ErrorDescription = "You need to fill up this Cell.";
//        }
//        else
//        {
//            if (prop.Firstname.Length > 27)
//            {
//                prop.ErrorDescription = "The MAX length of this field is 27 characters.";
//            }
//        }

//        if (!string.IsNullOrEmpty(prop.ErrorDescription))
//        {
//            logger.writelog(item);
//        }
//    }


//private void btnReset_Click(object sender, EventArgs e)
//{
//    //  ins.clearmethod(prop);
//    clearmethod();
//}

//public void clearmethod()
//{
//    tbfname.Text = string.Empty;
//    tblname.Text = string.Empty;
//    tbdesignatio.Text = string.Empty;
//    tbmbl.Text = string.Empty;
//    tbempid.Text = string.Empty;
//}


//  private DataSet ReadExcelFile(string excelPath)
// {
//DataSet ds = new DataSet();
//string connectionString = GetConnectionString(excelPath);
//using (OleDbConnection conn = new OleDbConnection(connectionString))
//{
//    conn.Open();
//    OleDbCommand cmd = new OleDbCommand();
//    cmd.Connection = conn;
//    // Get all Sheets in Excel File  
//    // DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);  
//    // Loop through all Sheets to get data  
//    // foreach (DataRow dr in dtSheet.Rows[2])  
//    // {  
//    string sheetName = "Student$";
//    //if (!sheetName.EndsWith("$"))  
//    // continue;  
//    // Get all rows from the Sheet  
//    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";
//    System.Data.DataTable dt = new System.Data.DataTable();
//    dt.TableName = sheetName.Replace("$", string.Empty);
//    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
//    da.Fill(dt);
//    ds.Tables.Add(dt);
//    //}  
//    //string schema = ds.GetXmlSchema();  
//    cmd = null;
//    conn.Close();
//}
//return ds;
//  }
//  private string GetConnectionString(string excelPath)
//{
//Dictionary<string, string> props = new Dictionary<string, string>();
//// XLSX - Excel 2007, 2010, 2012, 2013  
//props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
//props["Extended Properties"] = "Excel 12.0 XML";
//props["Data Source"] = excelPath; 
//// XLS - Excel 2003 and Older  
////props["Provider"] = "Microsoft.Jet.OLEDB.4.0";  
////props["Extended Properties"] = "Excel 8.0";  
////props["Data Source"] = "C:\\MyExcel.xls";  
//StringBuilder sb = new StringBuilder();
//foreach (KeyValuePair<string, string> prop in props)
//{
//    sb.Append(prop.Key);
//    sb.Append('=');
//    sb.Append(prop.Value);
//    sb.Append(';');
//}
//return sb.ToString();
//}

//below 2nd foreach
//foreach (DataRow tr in dt.Rows)
//{
//    try
//    {
//        prop.Firstname = tr[0].ToString();
//        prop.Lastname = tr[1].ToString();
//        prop.DOB = DateTime.Parse(tr[2].ToString());
//        prop.Mobilenumber = long.Parse(tr[3].ToString());
//        prop.Designation = tr[4].ToString();
//        prop.EmployeeId = tr[5].ToString();

//        MessageBox.Show(ins.insert(prop));
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show(ex.Message, "Wrong input");
//    }

//}
/* using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
{
    bool isFirstRow = true;
    var rows = workbook.Worksheet(1).RowsUsed();

    foreach (var row in rows)
    {
        if (isFirstRow)
        {
            foreach (IXLCell cell in row.Cells())
                dt.Columns.Add(cell.Value.ToString());
            isFirstRow = false;
        }
        else
        {
            dt.Rows.Add();
            int i = 0;
            foreach (IXLCell cell in row.Cells())
                dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
        }

    }
    */

//allcodebytest
/*
 using BussinessLayer;
using BussinessLayerLogics;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Logging;
using System.Data.OleDb;
using System.Text;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace EmployeeSystemProject
{
    public partial class Form1 : Form
    {
        Properties prop = new Properties();
        BLLInsert ins = new BLLInsert();
        System.Data.DataTable dt = new System.Data.DataTable();
        //   DataSet ds = new DataSet();
        public int celldata;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                prop.Firstname = tbfname.Text;
                prop.Lastname = tbfname.Text;
                prop.DOB = Convert.ToDateTime(dobpicker.Value.ToShortDateString());
                prop.Mobilenumber = Convert.ToInt32(tbmbl.Text);
                prop.Designation = tbdesignatio.Text;
                prop.EmployeeId = tbempid.Text;
                MessageBox.Show(ins.insert(prop));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wrong input");
            }
        }

        private void dgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            celldata = e.RowIndex;
            DataGridViewRow gdv = dgvExcel.Rows[celldata];
            tbfname.Text = gdv.Cells[0].Value.ToString();
            tblname.Text = gdv.Cells[1].Value.ToString();
            //dobpicker = Convert.ToDateTime(gdv.Cells[2].Value.ToString());
            ; tbmbl.Text = gdv.Cells[3].Value.ToString();
            tbdesignatio.Text = gdv.Cells[4].Value.ToString();
            tbempid.Text = gdv.Cells[5].Value.ToString();
            #region gridview
            // tbfname.Text = dgvExcel.Rows[0].Cells[0].Value.ToString();
            // tblname.Text = dgvExcel.Rows[1].Cells[0].Value.ToString();
            //dobpicker.Text = dgvExcel.Rows[0].Cells[0].Value.ToString();
            //DateTime dt = DateTime.ParseExact(dgvExcel.CurrentCell.Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // dobpicker.Value= dt;
            // tbdesignatio.Text = dgvExcel.Rows[2].Cells[0].Value.ToString();

            // tbmbl.Text = dgvExcel.Rows[3].Cells[0].Value.ToString();
            // tbempid.Text = dgvExcel.Rows[4].Cells[0].Value.ToString();

            #endregion
        }

        private void brnopen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = ofd.FileName;
                    string fileExtension = System.IO.Path.GetExtension(filepath);
                    string connectionstring = "";
                    if (fileExtension == ".xls")
                        connectionstring = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source=" + filepath + ";Extended Properties=\"Excel 8.0;HDR =Yes; IMEX=2\"";
                    else if (fileExtension == " .xlsx")
                        connectionstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\"Excel 12.0;HDR =Yes; IMEX=2\"";

                    OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\2101811\Downloads\DB_EmployeeDatabase.accdb");
                    OleDbCommand command = new OleDbCommand("Select * from [Sheet1$]", connection);
                    connection.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    dgvExcel.DataSource = ds.Tables[0];
                    MessageBox.Show("Excel file is imported");
                }

                foreach (DataGridViewRow row in dgvExcel.Rows)
                {
                    string mobileNumber = row.Cells["Mobile Number"].Value.ToString();

                    Regex regex = new Regex(@"^\d{10}$");
                    if (!regex.IsMatch(mobileNumber))
                    {
                        string errormessage = "invalid mobile number : " + mobileNumber;
                        using (StreamWriter write = new StreamWriter("Log.text")) ;
                    }
                }
            }
            #region .   
            //lbltotal.Text = $"Total rocords : {dgvExcel.RowCount}";
            #endregion

        }


       

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearmethod();
        }

        public void clearmethod()
        {
            tbfname.Text = string.Empty;
            tblname.Text = string.Empty;
            tbdesignatio.Text = string.Empty;
            tbmbl.Text = string.Empty;
            tbempid.Text = string.Empty;
        }


      
    }
}


 */










/*
 
khkfskasfljalsfdjlasjfliajfalsdflkjdsaf
adsfkhaskjfj


using BussinessLayer;
using BussinessLayerLogics;
using System.Data;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Globalization;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.Logging;
using System.Data.OleDb;
using System.Text;
using DocumentFormat.OpenXml.Vml;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;

namespace EmployeeSystemProject
{
    public partial class Form1 : Form
    {
        Properties prop = new Properties();
        BLLInsert ins = new BLLInsert();
        System.Data.DataTable dt = new System.Data.DataTable();
        System.Data.DataTable dt2 = new System.Data.DataTable();
        DataSet ds = new DataSet();
        public int celldata;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                prop.Firstname = tbfname.Text;
                prop.Lastname = tblname.Text;
                prop.DOB = Convert.ToDateTime(dobpicker.Value.ToShortDateString());
                prop.Mobilenumber = Convert.ToInt32(tbmbl.Text);
                prop.Designation = tbdesignatio.Text;
                prop.EmployeeId = tbempid.Text;
                MessageBox.Show(ins.insert(prop));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Wrong input");
            }
        }

        private void dgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            celldata = e.RowIndex;
            DataGridViewRow gdv = dgvExcel.Rows[celldata];
            tbfname.Text = gdv.Cells[0].Value.ToString();
            tblname.Text = gdv.Cells[1].Value.ToString();
            //dobpicker = Convert.ToDateTime(gdv.Cells[2].Value.ToString());
            tbmbl.Text = gdv.Cells[3].Value.ToString();
            tbdesignatio.Text = gdv.Cells[4].Value.ToString();
            tbempid.Text = gdv.Cells[5].Value.ToString();
            #region gridview
            // tbfname.Text = dgvExcel.Rows[0].Cells[0].Value.ToString();
            // tblname.Text = dgvExcel.Rows[1].Cells[0].Value.ToString();
            //dobpicker.Text = dgvExcel.Rows[0].Cells[0].Value.ToString();
            //DateTime dt = DateTime.ParseExact(dgvExcel.CurrentCell.Value.ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            // dobpicker.Value= dt;
            // tbdesignatio.Text = dgvExcel.Rows[2].Cells[0].Value.ToString();

            // tbmbl.Text = dgvExcel.Rows[3].Cells[0].Value.ToString();
            // tbempid.Text = dgvExcel.Rows[4].Cells[0].Value.ToString();

            #endregion
        }

        private void brnopen_Click(object sender, EventArgs e)
        {
           


        }

            private void btnReset_Click(object sender, EventArgs e)
            {
                clearmethod();
            }

            public void clearmethod()
            {
                tbfname.Text = string.Empty;
                tblname.Text = string.Empty;
                tbdesignatio.Text = string.Empty;
                tbmbl.Text = string.Empty;
                tbempid.Text = string.Empty;
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        bool isFirstRow = true;
                        var rows = workbook.Worksheet(1).RowsUsed();

                        foreach (var row in rows)
                        {
                            if (isFirstRow)
                            {
                                foreach (IXLCell cell in row.Cells())
                                    dt.Columns.Add(cell.Value.ToString());
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in row.Cells())
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();

                            }

                        }
                        MessageBox.Show("Excel file is imported");
                        dgvExcel.DataSource = dt.DefaultView;
                        // MessageBox.Show(ins.insert(prop));



                        foreach (DataGridViewRow row in dgvExcel.Rows)
                        {
                            string valfirstname = row.Cells[0].Value.ToString();

                            //  Regex regex = new Regex(@"^{a-z}$");
                            Regex regex = new Regex(@"^[a-zA-Z]{1,15}$");
                            if (!regex.IsMatch(valfirstname))
                            {
                                string errormessage = "invalid fname  : " + valfirstname;
                                //using (StreamWriter write = new StreamWriter("Logs.text"));
                                logger.Writelog("dd " + errormessage);
                            }



                            string vallname = row.Cells[1].Value.ToString();

                            Regex regex2 = new Regex(@"^[a-zA-Z]{1,15}$");
                            if (!regex2.IsMatch(vallname))
                            {
                                string errormessage = "invalid lastname : " + vallname;
                                //using (StreamWriter write = new StreamWriter("Logs.text")) ;
                                logger.Writelog("valname" + errormessage);
                            }
                            #region .
                            /*  string dob = row.Cells[2].Value.ToString();
                              DateTime datetime;
                              if (!DateTime.TryParse(row.Cells[2].Value.ToString(), out datetime))
                              {
                                  string erromessage = "Invalid Date Format :" + datetime;
                                  logger.Writelog("Date Time " + erromessage);
                              }
#endregion

string mobileNumber = row.Cells[3].Value.ToString();

Regex mblregex = new Regex(@"^[0-9]{10}$");
if (!mblregex.IsMatch(mobileNumber))
{
    string errormessage = "invalid mobile number : " + mobileNumber;
    //  using (StreamWriter write = new StreamWriter("Logs.text")) ;
    logger.Writelog("mbl" + errormessage);
}

string valdesignation = row.Cells[4].Value.ToString();
Regex desregex = new Regex(@"^[a-z\sA-Z]{1,15}$");
if (!desregex.IsMatch(valdesignation))
{
    string errormessage = "invalid designation : " + valdesignation;
    //  using (StreamWriter write = new StreamWriter("Logs.text")) ;
    logger.Writelog("designation" + errormessage);
}

string employeeid = row.Cells[5].Value.ToString();

Regex empregex = new Regex(@"^[a-zA-Z0-9]{7}$");
if (!empregex.IsMatch(employeeid))
{
    string errormessage = "invalid employee id : " + employeeid;
    // using (StreamWriter write = new StreamWriter("Logs.text")) ;
    logger.Writelog("empid" + errormessage);
}
                            // dataGridView1.DataSource = dt2;


                        }
                    }
                    #region .   
                    //lbltotal.Text = $"Total rocords : {dgvExcel.RowCount}";
                    #endregion

                }
            }
        }
    }
}
*/