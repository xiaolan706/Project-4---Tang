namespace Project_4_Course_Capston__Tang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoursesNumber1 = new System.Windows.Forms.TextBox();
            this.txtStudentsName1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOnline = new System.Windows.Forms.RadioButton();
            this.rdoHybrid = new System.Windows.Forms.RadioButton();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.cdrMeetingDate1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCourseSection = new System.Windows.Forms.TextBox();
            this.txtCourseSubject = new System.Windows.Forms.TextBox();
            this.txtMeetingDate = new System.Windows.Forms.TextBox();
            this.txtStudentsName2 = new System.Windows.Forms.TextBox();
            this.txtCoursesNumber2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.course_InformationDataSet = new Project_4_Course_Capston__Tang.Course_InformationDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Project_4_Course_Capston__Tang.Course_InformationDataSetTableAdapters.CourseTableAdapter();
            this.tableAdapterManager = new Project_4_Course_Capston__Tang.Course_InformationDataSetTableAdapters.TableAdapterManager();
            this.courseComboBox = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_InformationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Course\'s Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student\'s &Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Meeting &Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course &Subject:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCoursesNumber1
            // 
            this.txtCoursesNumber1.Location = new System.Drawing.Point(223, 49);
            this.txtCoursesNumber1.Name = "txtCoursesNumber1";
            this.txtCoursesNumber1.Size = new System.Drawing.Size(222, 26);
            this.txtCoursesNumber1.TabIndex = 1;
            // 
            // txtStudentsName1
            // 
            this.txtStudentsName1.Location = new System.Drawing.Point(223, 100);
            this.txtStudentsName1.Name = "txtStudentsName1";
            this.txtStudentsName1.Size = new System.Drawing.Size(222, 26);
            this.txtStudentsName1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOnline);
            this.groupBox1.Controls.Add(this.rdoHybrid);
            this.groupBox1.Location = new System.Drawing.Point(223, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Section";
            // 
            // rdoOnline
            // 
            this.rdoOnline.AutoSize = true;
            this.rdoOnline.Location = new System.Drawing.Point(193, 39);
            this.rdoOnline.Name = "rdoOnline";
            this.rdoOnline.Size = new System.Drawing.Size(79, 24);
            this.rdoOnline.TabIndex = 6;
            this.rdoOnline.Text = "Online";
            this.rdoOnline.UseVisualStyleBackColor = true;
            // 
            // rdoHybrid
            // 
            this.rdoHybrid.AutoSize = true;
            this.rdoHybrid.Checked = true;
            this.rdoHybrid.Location = new System.Drawing.Point(32, 39);
            this.rdoHybrid.Name = "rdoHybrid";
            this.rdoHybrid.Size = new System.Drawing.Size(79, 24);
            this.rdoHybrid.TabIndex = 5;
            this.rdoHybrid.TabStop = true;
            this.rdoHybrid.Text = "Hybrid";
            this.rdoHybrid.UseVisualStyleBackColor = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(178, 586);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(132, 40);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "S&et";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(404, 586);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(132, 40);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "&Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // cdrMeetingDate1
            // 
            this.cdrMeetingDate1.Location = new System.Drawing.Point(223, 151);
            this.cdrMeetingDate1.MaxDate = new System.DateTime(2019, 1, 31, 0, 0, 0, 0);
            this.cdrMeetingDate1.MaxSelectionCount = 1;
            this.cdrMeetingDate1.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.cdrMeetingDate1.Name = "cdrMeetingDate1";
            this.cdrMeetingDate1.ShowToday = false;
            this.cdrMeetingDate1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCourseSection);
            this.groupBox2.Controls.Add(this.txtCourseSubject);
            this.groupBox2.Controls.Add(this.txtMeetingDate);
            this.groupBox2.Controls.Add(this.txtStudentsName2);
            this.groupBox2.Controls.Add(this.txtCoursesNumber2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(607, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 512);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Course Information";
            // 
            // txtCourseSection
            // 
            this.txtCourseSection.Location = new System.Drawing.Point(189, 401);
            this.txtCourseSection.Name = "txtCourseSection";
            this.txtCourseSection.ReadOnly = true;
            this.txtCourseSection.Size = new System.Drawing.Size(212, 26);
            this.txtCourseSection.TabIndex = 9;
            // 
            // txtCourseSubject
            // 
            this.txtCourseSubject.Location = new System.Drawing.Point(189, 321);
            this.txtCourseSubject.Name = "txtCourseSubject";
            this.txtCourseSubject.ReadOnly = true;
            this.txtCourseSubject.Size = new System.Drawing.Size(212, 26);
            this.txtCourseSubject.TabIndex = 8;
            // 
            // txtMeetingDate
            // 
            this.txtMeetingDate.Location = new System.Drawing.Point(189, 241);
            this.txtMeetingDate.Name = "txtMeetingDate";
            this.txtMeetingDate.ReadOnly = true;
            this.txtMeetingDate.Size = new System.Drawing.Size(212, 26);
            this.txtMeetingDate.TabIndex = 7;
            // 
            // txtStudentsName2
            // 
            this.txtStudentsName2.Location = new System.Drawing.Point(189, 161);
            this.txtStudentsName2.Name = "txtStudentsName2";
            this.txtStudentsName2.ReadOnly = true;
            this.txtStudentsName2.Size = new System.Drawing.Size(212, 26);
            this.txtStudentsName2.TabIndex = 6;
            // 
            // txtCoursesNumber2
            // 
            this.txtCoursesNumber2.Location = new System.Drawing.Point(189, 81);
            this.txtCoursesNumber2.Name = "txtCoursesNumber2";
            this.txtCoursesNumber2.ReadOnly = true;
            this.txtCoursesNumber2.Size = new System.Drawing.Size(212, 26);
            this.txtCoursesNumber2.TabIndex = 5;
            this.txtCoursesNumber2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Course Section:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Course Subject:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Meeting Date:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Student\'s Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Course\'s Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_InformationDataSet
            // 
            this.course_InformationDataSet.DataSetName = "Course_InformationDataSet";
            this.course_InformationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.course_InformationDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = this.courseTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_4_Course_Capston__Tang.Course_InformationDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseComboBox
            // 
            this.courseComboBox.DataSource = this.courseBindingSource;
            this.courseComboBox.DisplayMember = "Subject";
            this.courseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.courseComboBox.FormattingEnabled = true;
            this.courseComboBox.Location = new System.Drawing.Point(223, 427);
            this.courseComboBox.Name = "courseComboBox";
            this.courseComboBox.Size = new System.Drawing.Size(222, 28);
            this.courseComboBox.TabIndex = 13;
            this.courseComboBox.ValueMember = "Subject";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(669, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 40);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 657);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.courseComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cdrMeetingDate1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStudentsName1);
            this.Controls.Add(this.txtCoursesNumber1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Course Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.course_InformationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCoursesNumber1;
        private System.Windows.Forms.TextBox txtStudentsName1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoOnline;
        private System.Windows.Forms.RadioButton rdoHybrid;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.MonthCalendar cdrMeetingDate1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCourseSection;
        private System.Windows.Forms.TextBox txtCourseSubject;
        private System.Windows.Forms.TextBox txtMeetingDate;
        private System.Windows.Forms.TextBox txtStudentsName2;
        private System.Windows.Forms.TextBox txtCoursesNumber2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Course_InformationDataSet course_InformationDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private Course_InformationDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private Course_InformationDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox courseComboBox;
        private System.Windows.Forms.Button btnExit;
    }
}

