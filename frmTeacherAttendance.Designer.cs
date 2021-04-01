namespace TeacherAttendance
{
    partial class frmTeacherAttendance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DTPickerdate = new System.Windows.Forms.DateTimePicker();
            this.cmbCourses = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.DTPickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.DTPickerLeaveTime = new System.Windows.Forms.DateTimePicker();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.DGVAttendance = new System.Windows.Forms.DataGridView();
            this.cmbTeacherName = new System.Windows.Forms.ComboBox();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(327, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room/Lab";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(682, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Leave Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comment";
            // 
            // DTPickerdate
            // 
            this.DTPickerdate.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPickerdate.Location = new System.Drawing.Point(113, 34);
            this.DTPickerdate.Name = "DTPickerdate";
            this.DTPickerdate.Size = new System.Drawing.Size(205, 30);
            this.DTPickerdate.TabIndex = 7;
            // 
            // cmbCourses
            // 
            this.cmbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourses.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCourses.FormattingEnabled = true;
            this.cmbCourses.Location = new System.Drawing.Point(451, 33);
            this.cmbCourses.Name = "cmbCourses";
            this.cmbCourses.Size = new System.Drawing.Size(216, 31);
            this.cmbCourses.TabIndex = 9;
            this.cmbCourses.SelectionChangeCommitted += new System.EventHandler(this.CmbCourses_SelectionChangeCommitted);
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(113, 70);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(205, 31);
            this.cmbRoom.TabIndex = 10;
            this.cmbRoom.SelectionChangeCommitted += new System.EventHandler(this.CmbRoom_SelectionChangeCommitted);
            // 
            // DTPickerStartTime
            // 
            this.DTPickerStartTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerStartTime.Location = new System.Drawing.Point(452, 69);
            this.DTPickerStartTime.Name = "DTPickerStartTime";
            this.DTPickerStartTime.Size = new System.Drawing.Size(214, 30);
            this.DTPickerStartTime.TabIndex = 11;
            // 
            // DTPickerLeaveTime
            // 
            this.DTPickerLeaveTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPickerLeaveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTPickerLeaveTime.Location = new System.Drawing.Point(809, 68);
            this.DTPickerLeaveTime.Name = "DTPickerLeaveTime";
            this.DTPickerLeaveTime.Size = new System.Drawing.Size(217, 30);
            this.DTPickerLeaveTime.TabIndex = 12;
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(113, 110);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(913, 30);
            this.txtComment.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(463, 150);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            this.btnSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnSave_MouseClick);
            // 
            // DGVAttendance
            // 
            this.DGVAttendance.AllowUserToAddRows = false;
            this.DGVAttendance.AllowUserToDeleteRows = false;
            this.DGVAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAttendance.Location = new System.Drawing.Point(16, 191);
            this.DGVAttendance.Name = "DGVAttendance";
            this.DGVAttendance.ReadOnly = true;
            this.DGVAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAttendance.Size = new System.Drawing.Size(1010, 283);
            this.DGVAttendance.TabIndex = 16;
            this.DGVAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAttendance_CellClick);
            this.DGVAttendance.DoubleClick += new System.EventHandler(this.DGVAttendance_DoubleClick);
            // 
            // cmbTeacherName
            // 
            this.cmbTeacherName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeacherName.FormattingEnabled = true;
            this.cmbTeacherName.Location = new System.Drawing.Point(809, 32);
            this.cmbTeacherName.Name = "cmbTeacherName";
            this.cmbTeacherName.Size = new System.Drawing.Size(217, 31);
            this.cmbTeacherName.TabIndex = 17;
            this.cmbTeacherName.SelectionChangeCommitted += new System.EventHandler(this.CmbTeacherName_SelectionChangeCommitted);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Location = new System.Drawing.Point(296, 150);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 35);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // frmTeacherAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 486);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cmbTeacherName);
            this.Controls.Add(this.DGVAttendance);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.DTPickerLeaveTime);
            this.Controls.Add(this.DTPickerStartTime);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbCourses);
            this.Controls.Add(this.DTPickerdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTeacherAttendance";
            this.Text = "Teacher Attendance Tracker";
            this.Load += new System.EventHandler(this.FrmTeacherAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DTPickerdate;
        private System.Windows.Forms.ComboBox cmbCourses;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker DTPickerStartTime;
        private System.Windows.Forms.DateTimePicker DTPickerLeaveTime;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView DGVAttendance;
        private System.Windows.Forms.ComboBox cmbTeacherName;
        private System.Windows.Forms.Button btnModify;
    }
}

