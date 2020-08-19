namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.B_Query = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_PhotoPath = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TB_ReportsTo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_Extension = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_Notes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_HomePhone = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_PostalCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Country = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TB_Region = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TB_City = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TB_HireDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_TitleOfCourtesy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_BirthDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Title = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_LastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EmployeeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PB_Photo = new System.Windows.Forms.PictureBox();
            this.CB_ID = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new WindowsFormsApp1.NorthwindDataSet();
            this.employeesTableAdapter = new WindowsFormsApp1.NorthwindDataSetTableAdapters.EmployeesTableAdapter();
            this.B_Delete = new System.Windows.Forms.Button();
            this.B_Update = new System.Windows.Forms.Button();
            this.B_Create = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Query
            // 
            this.B_Query.Location = new System.Drawing.Point(279, 10);
            this.B_Query.Name = "B_Query";
            this.B_Query.Size = new System.Drawing.Size(75, 23);
            this.B_Query.TabIndex = 0;
            this.B_Query.Text = "Query";
            this.B_Query.UseVisualStyleBackColor = true;
            this.B_Query.Click += new System.EventHandler(this.B_Query_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "member id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TB_PhotoPath);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TB_ReportsTo);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.TB_Extension);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.TB_Notes);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.TB_HomePhone);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.TB_PostalCode);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TB_Country);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TB_Region);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TB_Address);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TB_City);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.TB_HireDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TB_TitleOfCourtesy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TB_BirthDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TB_Title);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TB_LastName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TB_FirstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_EmployeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PB_Photo);
            this.panel1.Location = new System.Drawing.Point(35, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 350);
            this.panel1.TabIndex = 3;
            // 
            // TB_PhotoPath
            // 
            this.TB_PhotoPath.Location = new System.Drawing.Point(315, 320);
            this.TB_PhotoPath.Name = "TB_PhotoPath";
            this.TB_PhotoPath.Size = new System.Drawing.Size(100, 22);
            this.TB_PhotoPath.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(224, 323);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 12);
            this.label14.TabIndex = 31;
            this.label14.Text = "PhotoPath";
            // 
            // TB_ReportsTo
            // 
            this.TB_ReportsTo.Location = new System.Drawing.Point(315, 292);
            this.TB_ReportsTo.Name = "TB_ReportsTo";
            this.TB_ReportsTo.Size = new System.Drawing.Size(100, 22);
            this.TB_ReportsTo.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(224, 295);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 12);
            this.label16.TabIndex = 29;
            this.label16.Text = "ReportsTo";
            // 
            // TB_Extension
            // 
            this.TB_Extension.Location = new System.Drawing.Point(315, 236);
            this.TB_Extension.Name = "TB_Extension";
            this.TB_Extension.Size = new System.Drawing.Size(100, 22);
            this.TB_Extension.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 239);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "Extension";
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(315, 264);
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(100, 22);
            this.TB_Notes.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(224, 267);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 12);
            this.label18.TabIndex = 26;
            this.label18.Text = "Notes";
            // 
            // TB_HomePhone
            // 
            this.TB_HomePhone.Location = new System.Drawing.Point(315, 208);
            this.TB_HomePhone.Name = "TB_HomePhone";
            this.TB_HomePhone.Size = new System.Drawing.Size(100, 22);
            this.TB_HomePhone.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(224, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 12);
            this.label19.TabIndex = 23;
            this.label19.Text = "HomePhone";
            // 
            // TB_PostalCode
            // 
            this.TB_PostalCode.Location = new System.Drawing.Point(112, 292);
            this.TB_PostalCode.Name = "TB_PostalCode";
            this.TB_PostalCode.Size = new System.Drawing.Size(100, 22);
            this.TB_PostalCode.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "PostalCode";
            // 
            // TB_Country
            // 
            this.TB_Country.Location = new System.Drawing.Point(112, 320);
            this.TB_Country.Name = "TB_Country";
            this.TB_Country.Size = new System.Drawing.Size(100, 22);
            this.TB_Country.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 12);
            this.label9.TabIndex = 20;
            this.label9.Text = "Country";
            // 
            // TB_Region
            // 
            this.TB_Region.Location = new System.Drawing.Point(112, 264);
            this.TB_Region.Name = "TB_Region";
            this.TB_Region.Size = new System.Drawing.Size(100, 22);
            this.TB_Region.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "Region";
            // 
            // TB_Address
            // 
            this.TB_Address.Location = new System.Drawing.Point(112, 208);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(100, 22);
            this.TB_Address.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "Address";
            // 
            // TB_City
            // 
            this.TB_City.Location = new System.Drawing.Point(112, 236);
            this.TB_City.Name = "TB_City";
            this.TB_City.Size = new System.Drawing.Size(100, 22);
            this.TB_City.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "City";
            // 
            // TB_HireDate
            // 
            this.TB_HireDate.Location = new System.Drawing.Point(112, 180);
            this.TB_HireDate.Name = "TB_HireDate";
            this.TB_HireDate.Size = new System.Drawing.Size(100, 22);
            this.TB_HireDate.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "HireDate";
            // 
            // TB_TitleOfCourtesy
            // 
            this.TB_TitleOfCourtesy.Location = new System.Drawing.Point(112, 124);
            this.TB_TitleOfCourtesy.Name = "TB_TitleOfCourtesy";
            this.TB_TitleOfCourtesy.Size = new System.Drawing.Size(100, 22);
            this.TB_TitleOfCourtesy.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "TitleOfCourtesy";
            // 
            // TB_BirthDate
            // 
            this.TB_BirthDate.Location = new System.Drawing.Point(112, 152);
            this.TB_BirthDate.Name = "TB_BirthDate";
            this.TB_BirthDate.Size = new System.Drawing.Size(100, 22);
            this.TB_BirthDate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "BirthDate";
            // 
            // TB_Title
            // 
            this.TB_Title.Location = new System.Drawing.Point(112, 96);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(100, 22);
            this.TB_Title.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "Title";
            // 
            // TB_LastName
            // 
            this.TB_LastName.Location = new System.Drawing.Point(112, 40);
            this.TB_LastName.Name = "TB_LastName";
            this.TB_LastName.Size = new System.Drawing.Size(100, 22);
            this.TB_LastName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "LastName";
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.Location = new System.Drawing.Point(112, 68);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(100, 22);
            this.TB_FirstName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "FirstName";
            // 
            // TB_EmployeeID
            // 
            this.TB_EmployeeID.Location = new System.Drawing.Point(112, 12);
            this.TB_EmployeeID.Name = "TB_EmployeeID";
            this.TB_EmployeeID.Size = new System.Drawing.Size(100, 22);
            this.TB_EmployeeID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "EmployeeID";
            // 
            // PB_Photo
            // 
            this.PB_Photo.Location = new System.Drawing.Point(226, 12);
            this.PB_Photo.Name = "PB_Photo";
            this.PB_Photo.Size = new System.Drawing.Size(189, 190);
            this.PB_Photo.TabIndex = 0;
            this.PB_Photo.TabStop = false;
            // 
            // CB_ID
            // 
            this.CB_ID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.employeesBindingSource, "EmployeeID", true));
            this.CB_ID.DataSource = this.employeesBindingSource;
            this.CB_ID.DisplayMember = "EmployeeID";
            this.CB_ID.FormattingEnabled = true;
            this.CB_ID.Location = new System.Drawing.Point(147, 28);
            this.CB_ID.Name = "CB_ID";
            this.CB_ID.Size = new System.Drawing.Size(100, 20);
            this.CB_ID.TabIndex = 4;
            this.CB_ID.ValueMember = "EmployeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "NorthwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // B_Delete
            // 
            this.B_Delete.Location = new System.Drawing.Point(375, 49);
            this.B_Delete.Name = "B_Delete";
            this.B_Delete.Size = new System.Drawing.Size(75, 23);
            this.B_Delete.TabIndex = 12;
            this.B_Delete.Text = "Delete";
            this.B_Delete.UseVisualStyleBackColor = true;
            this.B_Delete.Click += new System.EventHandler(this.B_Delete_Click);
            // 
            // B_Update
            // 
            this.B_Update.Location = new System.Drawing.Point(279, 49);
            this.B_Update.Name = "B_Update";
            this.B_Update.Size = new System.Drawing.Size(75, 23);
            this.B_Update.TabIndex = 11;
            this.B_Update.Text = "Update";
            this.B_Update.UseVisualStyleBackColor = true;
            this.B_Update.Click += new System.EventHandler(this.B_Update_Click);
            // 
            // B_Create
            // 
            this.B_Create.Location = new System.Drawing.Point(375, 10);
            this.B_Create.Name = "B_Create";
            this.B_Create.Size = new System.Drawing.Size(75, 23);
            this.B_Create.TabIndex = 10;
            this.B_Create.Text = "Create";
            this.B_Create.UseVisualStyleBackColor = true;
            this.B_Create.Click += new System.EventHandler(this.B_Create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.B_Delete);
            this.Controls.Add(this.B_Update);
            this.Controls.Add(this.B_Create);
            this.Controls.Add(this.CB_ID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_Query);
            this.Name = "Form1";
            this.Text = "北風傢俱有限公司";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Query;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PB_Photo;
        private System.Windows.Forms.TextBox TB_PhotoPath;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TB_ReportsTo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TB_Extension;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_Notes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TB_HomePhone;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TB_PostalCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Country;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TB_Region;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_City;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TB_HireDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_TitleOfCourtesy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_BirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Title;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_LastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_FirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_EmployeeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_ID;
        private NorthwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private NorthwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.Button B_Delete;
        private System.Windows.Forms.Button B_Update;
        private System.Windows.Forms.Button B_Create;
    }
}

