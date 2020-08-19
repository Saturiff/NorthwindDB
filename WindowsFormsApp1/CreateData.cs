using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class CreateData : Form
    {
        public CreateData(Form1 parentWindow)
        {
            InitializeComponent();

            parent = parentWindow;

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
                new SQLData { name = "Photo",           param = "@Photo",           c = null,               sqlType = SqlDbType.Image,    type = typeof(byte[])},
                new SQLData { name = "Notes",           param = "@Notes",           c = TB_Notes,           sqlType = SqlDbType.NText,    type = typeof(string)},
                new SQLData { name = "ReportsTo",       param = "@ReportsTo",       c = TB_ReportsTo,       sqlType = SqlDbType.Int,      type = typeof(int)   },
                new SQLData { name = "PhotoPath",       param = "@PhotoPath",       c = TB_PhotoPath,       sqlType = SqlDbType.NVarChar, type = typeof(string)}
            };
        }

        private Form1 parent;
        private List<SQLData> sqlDataManager;

        private struct SQLData
        {
            public string name;
            public string param;
            public Control c;
            public SqlDbType sqlType;
            public Type type;
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            foreach (var feild in sqlDataManager)
            {
                if (feild.c != null && ((TextBox)feild.c).Text == string.Empty)
                {
                    MessageBox.Show("Empty Textbox.");
                    return;
                }
            }

            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = Settings.Default.NorthwindConnectionString;
                    cn.Open();
                    string sqlStr = "SET IDENTITY_INSERT Employees ON;INSERT INTO Employees("
                             + string.Join(",", sqlDataManager.Select(x => x.name))
                             + ")VALUES("
                             + string.Join(",", sqlDataManager.Select(x => x.param)) 
                             + ");SET IDENTITY_INSERT Employees OFF;";
                    SqlCommand cmd = new SqlCommand(sqlStr, cn);

                    foreach (var feild in sqlDataManager)
                        cmd.Parameters.Add(new SqlParameter(feild.param, feild.sqlType));
                    
                    foreach (var feild in sqlDataManager)
                        cmd.Parameters[feild.param].Value = (feild.c != null) ? Convert.ChangeType(feild.c.Text, feild.type)
                                                                              : DBNull.Value;
                    
                    cmd.ExecuteNonQuery();

                    parent.UpdateList(cmd.Parameters["@EmployeeID"].Value.ToString());
                }
                MessageBox.Show("Add data successed.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Error from add data.");
            }
        }
    }
}
