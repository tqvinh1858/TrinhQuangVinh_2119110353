
namespace Cau1.GUI
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaceBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtDateBirth = new System.Windows.Forms.DateTimePicker();
            this.chbGender = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPlaceBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDEmp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(95, 70);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(212, 28);
            this.cbDepartment.TabIndex = 52;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(796, 500);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(696, 500);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 49;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(596, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 50;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(496, 500);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 29);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.NameEmp,
            this.PlaceBirth,
            this.DateBirth,
            this.Gender,
            this.NameDepartment});
            this.dgvEmployee.Location = new System.Drawing.Point(37, 117);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployee.RowTemplate.Height = 29;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(879, 361);
            this.dgvEmployee.TabIndex = 47;
            this.dgvEmployee.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);
            // 
            // IdEmployee
            // 
            this.IdEmployee.DataPropertyName = "IdEmployee";
            this.IdEmployee.HeaderText = "Mã";
            this.IdEmployee.MinimumWidth = 6;
            this.IdEmployee.Name = "IdEmployee";
            // 
            // NameEmp
            // 
            this.NameEmp.DataPropertyName = "NameEmp";
            this.NameEmp.HeaderText = "Họ tên";
            this.NameEmp.MinimumWidth = 6;
            this.NameEmp.Name = "NameEmp";
            // 
            // PlaceBirth
            // 
            this.PlaceBirth.DataPropertyName = "PlaceBirth";
            this.PlaceBirth.HeaderText = "Nơi Sinh";
            this.PlaceBirth.MinimumWidth = 6;
            this.PlaceBirth.Name = "PlaceBirth";
            // 
            // DateBirth
            // 
            this.DateBirth.DataPropertyName = "DateBirth";
            this.DateBirth.HeaderText = "Ngày sinh";
            this.DateBirth.MinimumWidth = 6;
            this.DateBirth.Name = "DateBirth";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới Tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // NameDepartment
            // 
            this.NameDepartment.DataPropertyName = "NameDeparment";
            this.NameDepartment.HeaderText = "Đơn vị";
            this.NameDepartment.MinimumWidth = 6;
            this.NameDepartment.Name = "NameDepartment";
            // 
            // dtDateBirth
            // 
            this.dtDateBirth.CustomFormat = "";
            this.dtDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateBirth.Location = new System.Drawing.Point(733, 37);
            this.dtDateBirth.Name = "dtDateBirth";
            this.dtDateBirth.Size = new System.Drawing.Size(183, 27);
            this.dtDateBirth.TabIndex = 46;
            // 
            // chbGender
            // 
            this.chbGender.AutoSize = true;
            this.chbGender.Location = new System.Drawing.Point(790, 74);
            this.chbGender.Name = "chbGender";
            this.chbGender.Size = new System.Drawing.Size(126, 24);
            this.chbGender.TabIndex = 45;
            this.chbGender.Text = "Giới tính: Nam";
            this.chbGender.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Ngày sinh";
            // 
            // tbPlaceBirth
            // 
            this.tbPlaceBirth.Location = new System.Drawing.Point(391, 70);
            this.tbPlaceBirth.Name = "tbPlaceBirth";
            this.tbPlaceBirth.Size = new System.Drawing.Size(393, 27);
            this.tbPlaceBirth.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nơi sinh";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(391, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(256, 27);
            this.tbName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Đơn vị";
            // 
            // tbIDEmp
            // 
            this.tbIDEmp.Location = new System.Drawing.Point(95, 38);
            this.tbIDEmp.Name = "tbIDEmp";
            this.tbIDEmp.Size = new System.Drawing.Size(212, 27);
            this.tbIDEmp.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Mã";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 567);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.dtDateBirth);
            this.Controls.Add(this.chbGender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPlaceBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIDEmp);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployee";
            this.Text = "FormEmployee";
            this.Load += new System.EventHandler(this.FormEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaceBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDepartment;
        private System.Windows.Forms.DateTimePicker dtDateBirth;
        private System.Windows.Forms.CheckBox chbGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPlaceBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDEmp;
        private System.Windows.Forms.Label label1;
    }
}