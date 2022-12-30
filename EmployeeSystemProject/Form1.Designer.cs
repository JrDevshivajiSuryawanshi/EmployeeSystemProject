namespace EmployeeSystemProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbmbl = new System.Windows.Forms.TextBox();
            this.tbdesignatio = new System.Windows.Forms.TextBox();
            this.tbempid = new System.Windows.Forms.TextBox();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSave = new System.Windows.Forms.Button();
            this.brnopen = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(560, 12);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.RowHeadersWidth = 62;
            this.dgvExcel.RowTemplate.Height = 33;
            this.dgvExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExcel.Size = new System.Drawing.Size(1160, 207);
            this.dgvExcel.TabIndex = 0;
            this.dgvExcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcel_CellClick);
            // 
            // tbfname
            // 
            this.tbfname.Location = new System.Drawing.Point(63, 68);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(279, 31);
            this.tbfname.TabIndex = 1;
            this.tbfname.Text = "Firstname";
            // 
            // tblname
            // 
            this.tblname.Location = new System.Drawing.Point(63, 114);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(279, 31);
            this.tblname.TabIndex = 2;
            this.tblname.Text = "Lastname";
            // 
            // tbmbl
            // 
            this.tbmbl.Location = new System.Drawing.Point(63, 188);
            this.tbmbl.Name = "tbmbl";
            this.tbmbl.Size = new System.Drawing.Size(279, 31);
            this.tbmbl.TabIndex = 4;
            this.tbmbl.Text = "11223";
            // 
            // tbdesignatio
            // 
            this.tbdesignatio.Location = new System.Drawing.Point(63, 238);
            this.tbdesignatio.Name = "tbdesignatio";
            this.tbdesignatio.Size = new System.Drawing.Size(279, 31);
            this.tbdesignatio.TabIndex = 5;
            this.tbdesignatio.Text = "Designation";
            // 
            // tbempid
            // 
            this.tbempid.Location = new System.Drawing.Point(63, 285);
            this.tbempid.Name = "tbempid";
            this.tbempid.Size = new System.Drawing.Size(279, 31);
            this.tbempid.TabIndex = 6;
            this.tbempid.Text = "EmployeeId";
            // 
            // dobpicker
            // 
            this.dobpicker.CustomFormat = "";
            this.dobpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobpicker.Location = new System.Drawing.Point(64, 152);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(278, 31);
            this.dobpicker.TabIndex = 7;
            this.dobpicker.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(45, 364);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(142, 45);
            this.BtnSave.TabIndex = 8;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // brnopen
            // 
            this.brnopen.Location = new System.Drawing.Point(243, 364);
            this.brnopen.Name = "brnopen";
            this.brnopen.Size = new System.Drawing.Size(142, 45);
            this.brnopen.TabIndex = 9;
            this.brnopen.Text = "Open";
            this.brnopen.UseVisualStyleBackColor = true;
            this.brnopen.Click += new System.EventHandler(this.brnopen_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(491, 416);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(0, 25);
            this.lbltotal.TabIndex = 10;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(401, 364);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(142, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(560, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 207);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.brnopen);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.dobpicker);
            this.Controls.Add(this.tbempid);
            this.Controls.Add(this.tbdesignatio);
            this.Controls.Add(this.tbmbl);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.dgvExcel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvExcel;
        private TextBox tbfname;
        private TextBox tblname;
        private TextBox tbmbl;
        private TextBox tbdesignatio;
        private TextBox tbempid;
        private DateTimePicker dobpicker;
        private Button BtnSave;
        private Button brnopen;
        private Label lbltotal;
        private Button btnReset;
        private DataGridView dataGridView1;
    }
}