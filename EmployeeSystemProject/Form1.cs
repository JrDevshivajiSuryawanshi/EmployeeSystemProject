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
        System.Data.DataTable dt3 = new System.Data.DataTable();


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
                //  prop.DOB = Convert.ToDateTime(dobpicker.Value.ToShortDateString());
            //    prop.DOB = dobpicker.Value;
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
            dt2.Columns.Add("First Name", typeof(string));
            dt2.Columns.Add("Last Name", typeof(string));
            dt2.Columns.Add("DOB", typeof(DateTime));
            dt2.Columns.Add("Mobile Number", typeof(int));
            dt2.Columns.Add("Designation", typeof(string));
            dt2.Columns.Add("Employee Id", typeof(string));

            Properties prop = new Properties();
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
                      //  MessageBox.Show("Excel file is imported");\
                        dgvExcel.DataSource = dt.DefaultView;
                        // MessageBox.Show(ins.insert(prop));

                        foreach (DataRow row in dt.Rows)
                        {


                            
                            string valfirstname = row[0].ToString();
                            Regex regexall = new Regex(@"^[a-zA-Z]{1,15}$");
                            if (!regexall.IsMatch(valfirstname))
                            {
                                string errormessage = "invalid fname  : " + valfirstname;
                                logger.Writelog("firstname is  " + errormessage);
                            }
                            // else if(valfirstname == null)
                            //{
                            //  logger.Writelog("FistName is Empty =========" + valfirstname);
                            //}
                            else
                            {
                                prop.Firstname = valfirstname;
                            }


                            string vallname = row[1].ToString();

                           if (!regexall.IsMatch(vallname))
                            {
                                string errormessage = "invalid lastname : " + vallname; 
                                logger.Writelog("valname" + errormessage);
                            }
                            else
                            {
                                prop.Lastname = vallname;
                            }
                            #region .
                            /*  string dob = row.Cells[2].Value.ToString();
                              DateTime datetime;
                              if (!DateTime.TryParse(row.Cells[2].Value.ToString(), out datetime))
                              {
                                  string erromessage = "Invalid Date Format :" + datetime;
                                  logger.Writelog("Date Time " + erromessage);
                              }*/
                            #endregion

                            string dob = row[2].ToString();
                            DateTime dateTime;
                            ///  DateTime dateTime = DateTime.ParseExact(this.Text, "MM/dd/yyyy", null);
                            if (!DateTime.TryParse(row[2].ToString(), out dateTime))
                            {
                                string errormessage = "invalid Date : " + dateTime;
                                logger.Writelog("Date " + errormessage);
                            }
                            else
                            {
                                prop.DOB = Convert.ToDateTime(dateTime);
                            }


                            string mobileNumber = row[3].ToString();

                            Regex mblregex = new Regex(@"^[0-9]{10}$");
                            if (!mblregex.IsMatch(mobileNumber))
                            {
                                string errormessage = "invalid mobile number : " + mobileNumber;
                                logger.Writelog("mbl" + errormessage);
                            }
                            else
                            {
                                prop.Mobilenumber = Convert.ToInt32(mobileNumber);
                            }


                            string valdesignation = row[4].ToString();
                            if (!regexall.IsMatch(valdesignation))
                            {
                                string errormessage = "invalid designation : " + valdesignation;
                                logger.Writelog("designation" + errormessage);
                            }
                            else
                            {
                                prop.Designation = valdesignation;
                            }

                            string employeeid = row[5].ToString();
                            Regex empregex = new Regex(@"^[a-zA-Z0-9]{7}$");
                            if (!empregex.IsMatch(employeeid))
                            {
                                string errormessage = "invalid employee id : " + employeeid;
                                // using (StreamWriter write = new StreamWriter("Logs.text")) ;
                                logger.Writelog("empid" + errormessage);
                            }
                            else
                            {
                                prop.EmployeeId = employeeid;
                            }

                            // dataGridView1.DataSource = dt2;
                           //  if (regexall.IsMatch(valfirstname) && regexall.IsMatch(vallname) && !DateTime.TryParse(row[2].ToString(), out dateTime) && mblregex.IsMatch(mobileNumber) && regexall.IsMatch(valdesignation) && empregex.IsMatch(employeeid))
                           if (regexall.IsMatch(row[0].ToString()) && regexall.IsMatch(row[1].ToString()) && !DateTime.TryParse(row[2].ToString(), out dateTime) && mblregex.IsMatch(row[3].ToString()) && regexall.IsMatch(row[4].ToString()) && empregex.IsMatch(row[5].ToString()))

                            {

                                dt2.Rows.Add(row.ItemArray);
                                // ins.insert(prop);
                            }
                            
                        }
                    
                        
                      
                         foreach (DataRow inserte in dt.Rows)
                         {
                                prop.Firstname = inserte[0].ToString(); 
                                prop.Lastname = inserte[1].ToString();
                                 prop.DOB = DateTime.Parse(inserte[2].ToString());
                              //  prop.DOB = insert[2].ToString();
                                prop.Mobilenumber = Convert.ToInt32(inserte[3].ToString());
                                prop.Designation = inserte[4].ToString();
                                prop.EmployeeId = inserte[5].ToString();
                              
                            MessageBox.Show(ins.insert(prop));
                         }
                           dataGridView1.DataSource = dt2.DefaultView ;

                        
                    }
                    #region .   
                    //lbltotal.Text = $"Total rocords : {dgvExcel.RowCount}";
                    #endregion

                }
            }
        }
    }
}




