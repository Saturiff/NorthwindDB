using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            sqlDataManager = new List<SQLData>
            {
                new SQLData { name = "EmployeeID",      param = "@EmployeeID",      c = TB_EmployeeID,      sqlType = SqlDbType.Int,      type = typeof(int)   },
                new SQLData { name = "LastName",        param = "@LastName",        c = TB_LastName,        sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "FirstName",       param = "@FirstName",       c = TB_FirstName,       sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "Title",           param = "@Title",           c = TB_Title,           sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "TitleOfCourtesy", param = "@TitleOfCourtesy", c = TB_TitleOfCourtesy, sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "BirthDate",       param = "@BirthDate",       c = TB_BirthDate,       sqlType = SqlDbType.DateTime, type = typeof(string)},
                new SQLData { name = "HireDate",        param = "@HireDate",        c = TB_HireDate,        sqlType = SqlDbType.DateTime, type = typeof(string)},
                new SQLData { name = "Address",         param = "@Address",         c = TB_Address,         sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "City",            param = "@City",            c = TB_City,            sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "Region",          param = "@Region",          c = TB_Region,          sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "PostalCode",      param = "@PostalCode",      c = TB_PostalCode,      sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "Country",         param = "@Country",         c = TB_Country ,        sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "HomePhone",       param = "@HomePhone",       c = TB_HomePhone,       sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "Extension",       param = "@Extension",       c = TB_Extension,       sqlType = SqlDbType.NVarChar, type = typeof(string)},
                new SQLData { name = "Photo",           param = "@Photo",           c = PB_Photo,           sqlType = SqlDbType.Image,    type = typeof(byte[])},
                new SQLData { name = "Notes",           param = "@Notes",           c = TB_Notes,           sqlType = SqlDbType.NText,    type = typeof(string)},
                new SQLData { name = "ReportsTo",       param = "@ReportsTo",       c = TB_ReportsTo,       sqlType = SqlDbType.Int,      type = typeof(int)   },
                new SQLData { name = "PhotoPath",       param = "@PhotoPath",       c = TB_PhotoPath,       sqlType = SqlDbType.NVarChar, type = typeof(string)}
            };
        }

        private List<SQLData> sqlDataManager;

        private struct SQLData
        {
            public string name;
            public string param;
            public Control c;
            public SqlDbType sqlType;
            public Type type;
        }

        private void Form1_Load(object sender, EventArgs e) => UpdateList();

        public void UpdateList(string empID = "")
        {
            employeesTableAdapter.Fill(northwindDataSet.Employees);
            if (empID == string.Empty)
                CB_ID.SelectedIndex = 0;
            else
                CB_ID.Text = empID;
            ShowData();
        }

        private void ShowData()
        {
            foreach (var feild in sqlDataManager)
            {
                DataTable dt = northwindDataSet.Tables[0];
                object data = null;
                for (int i = 0; i < CB_ID.Items.Count; i++)
                {
                    if (CB_ID.Text == dt.Rows[i]["EmployeeID"].ToString())
                    {
                        data = dt.Rows[i][feild.name];
                        break;
                    }
                }
                if (feild.name == "Photo")
                {
                    if (data is DBNull)
                    {
                        ((PictureBox)feild.c).Image = null;
                        continue;
                    }
                    byte[] photoStream = (byte[])data;
                    MemoryStream mem = new MemoryStream();
                    mem.Write(photoStream, 78, photoStream.Length - 78);
                    ((PictureBox)feild.c).Image = Image.FromStream(mem);
                    mem.Dispose();
                }
                else
                    ((TextBox)feild.c).Text = data.ToString();
            }
        }

        private void B_Query_Click(object sender, EventArgs e) => ShowData();

        private void B_Create_Click(object sender, EventArgs e)
        {
            CreateData window = new CreateData(this);
            window.Show();
        }

        private void B_Update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = Properties.Settings.Default.NorthwindConnectionString;
                    cn.Open();
                    List<string> s1 = new List<string>(sqlDataManager.Where(x => x.name != "EmployeeID").Select(x => x.name)),
                                 s2 = new List<string>(sqlDataManager.Where(x => x.name != "EmployeeID").Select(x => x.param));

                    string sqlStr = "UPDATE Employees SET " + string.Join(",", s1.Zip(s2, (x, y) => x + "=" + y).ToList()) 
                                  + " WHERE EmployeeID = @EmployeeID";

                    SqlCommand cmd = new SqlCommand(sqlStr, cn);

                    foreach (var feild in sqlDataManager)
                        cmd.Parameters.Add(new SqlParameter(feild.param, feild.sqlType));

                    foreach (var feild in sqlDataManager)
                        cmd.Parameters[feild.param].Value = (feild.name != "Photo") ? Convert.ChangeType(feild.c.Text, feild.type)
                                                                                    : DBNull.Value;
                    cmd.ExecuteNonQuery();

                    UpdateList(cmd.Parameters["@EmployeeID"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error form update data.");
            }
        }

        private void B_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = Properties.Settings.Default.NorthwindConnectionString;
                    cn.Open();
                    string sqlStr = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(sqlStr, cn);
                    cmd.Parameters.Add(new SqlParameter("@EmployeeID", SqlDbType.Int));
                    cmd.Parameters["@EmployeeID"].Value = sqlDataManager.Single(x => x.name == "EmployeeID").c.Text;

                    cmd.ExecuteNonQuery();
                }
                UpdateList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error form delete data.");
            }
        }
    }
}
