namespace Student_Grades_ARRAY_PROG_2
{
    partial class FrmStudentGrades
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
            this.tbStudentGrades = new System.Windows.Forms.TabControl();
            this.tbStudentDetails = new System.Windows.Forms.TabPage();
            this.lblScience = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblInforMarks = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tbGrades = new System.Windows.Forms.TabPage();
            this.tbResults = new System.Windows.Forms.TabPage();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbStudentGrades.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStudentGrades
            // 
            this.tbStudentGrades.Controls.Add(this.tbStudentDetails);
            this.tbStudentGrades.Controls.Add(this.tbGrades);
            this.tbStudentGrades.Controls.Add(this.tbResults);
            this.tbStudentGrades.Location = new System.Drawing.Point(13, 29);
            this.tbStudentGrades.Name = "tbStudentGrades";
            this.tbStudentGrades.SelectedIndex = 0;
            this.tbStudentGrades.Size = new System.Drawing.Size(585, 349);
            this.tbStudentGrades.TabIndex = 0;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.btnExit);
            this.tbStudentDetails.Controls.Add(this.btnEnter);
            this.tbStudentDetails.Controls.Add(this.txtScience);
            this.tbStudentDetails.Controls.Add(this.txtMaths);
            this.tbStudentDetails.Controls.Add(this.txtEnglish);
            this.tbStudentDetails.Controls.Add(this.lblScience);
            this.tbStudentDetails.Controls.Add(this.lblMaths);
            this.tbStudentDetails.Controls.Add(this.lblEnglish);
            this.tbStudentDetails.Controls.Add(this.lblInforMarks);
            this.tbStudentDetails.Controls.Add(this.cboGroup);
            this.tbStudentDetails.Controls.Add(this.txtStudentNumber);
            this.tbStudentDetails.Controls.Add(this.txtStudentName);
            this.tbStudentDetails.Controls.Add(this.lblGroup);
            this.tbStudentDetails.Controls.Add(this.lblStudentNumber);
            this.tbStudentDetails.Controls.Add(this.lblStudentName);
            this.tbStudentDetails.Controls.Add(this.lblInfo);
            this.tbStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDetails.Size = new System.Drawing.Size(577, 323);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.Text = "Student Details";
            this.tbStudentDetails.UseVisualStyleBackColor = true;
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Location = new System.Drawing.Point(330, 110);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(46, 13);
            this.lblScience.TabIndex = 10;
            this.lblScience.Text = "Science";
            this.lblScience.Click += new System.EventHandler(this.lblScience_Click);
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Location = new System.Drawing.Point(327, 80);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(36, 13);
            this.lblMaths.TabIndex = 9;
            this.lblMaths.Text = "Maths";
            this.lblMaths.Click += new System.EventHandler(this.lblMaths_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(327, 47);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(41, 13);
            this.lblEnglish.TabIndex = 8;
            this.lblEnglish.Text = "English";
            // 
            // lblInforMarks
            // 
            this.lblInforMarks.AutoSize = true;
            this.lblInforMarks.Location = new System.Drawing.Point(327, 20);
            this.lblInforMarks.Name = "lblInforMarks";
            this.lblInforMarks.Size = new System.Drawing.Size(144, 13);
            this.lblInforMarks.TabIndex = 7;
            this.lblInforMarks.Text = "Please Enter Students Marks";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "DPD1A",
            "DPD1B",
            "BRF1A",
            "BRF1B"});
            this.cboGroup.Location = new System.Drawing.Point(135, 103);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(121, 21);
            this.cboGroup.TabIndex = 6;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(135, 73);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 5;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(135, 45);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(26, 106);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Location = new System.Drawing.Point(26, 76);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lblStudentNumber.TabIndex = 2;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(26, 48);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 13);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(23, 20);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(142, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Please enter student Results";
            // 
            // tbGrades
            // 
            this.tbGrades.Location = new System.Drawing.Point(4, 22);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrades.Size = new System.Drawing.Size(577, 323);
            this.tbGrades.TabIndex = 1;
            this.tbGrades.Text = "Grades";
            this.tbGrades.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(4, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbResults.Size = new System.Drawing.Size(577, 323);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Results";
            this.tbResults.UseVisualStyleBackColor = true;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(402, 44);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(100, 20);
            this.txtEnglish.TabIndex = 11;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(402, 77);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(100, 20);
            this.txtMaths.TabIndex = 12;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(402, 107);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(100, 20);
            this.txtScience.TabIndex = 13;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(402, 219);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Enter Details";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(402, 258);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // FrmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 420);
            this.Controls.Add(this.tbStudentGrades);
            this.Name = "FrmStudentGrades";
            this.Text = "Student Grades";
            this.tbStudentGrades.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbStudentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbStudentGrades;
        private System.Windows.Forms.TabPage tbStudentDetails;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblInforMarks;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TabPage tbGrades;
        private System.Windows.Forms.TabPage tbResults;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
    }
}

