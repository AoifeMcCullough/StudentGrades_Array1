namespace StudentGrades_Array
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
            this.tbInformation = new System.Windows.Forms.TabControl();
            this.tbStudentDetails = new System.Windows.Forms.TabPage();
            this.tbGrades = new System.Windows.Forms.TabPage();
            this.tbResults = new System.Windows.Forms.TabPage();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentNumber = new System.Windows.Forms.Label();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblMaths = new System.Windows.Forms.Label();
            this.lblScience = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMaths = new System.Windows.Forms.TextBox();
            this.txtScience = new System.Windows.Forms.TextBox();
            this.btnEnterDetails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStudent_Number = new System.Windows.Forms.Label();
            this.txtSearchNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStudent_Marks = new System.Windows.Forms.Label();
            this.lblStudent_Name = new System.Windows.Forms.Label();
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.txtStudent_Name = new System.Windows.Forms.TextBox();
            this.txtStudent_Number = new System.Windows.Forms.TextBox();
            this.txt_Group = new System.Windows.Forms.TextBox();
            this.lblStudent_Marks_ = new System.Windows.Forms.Label();
            this.lbl_English = new System.Windows.Forms.Label();
            this.lbl_Maths_ = new System.Windows.Forms.Label();
            this.lbl_Science_ = new System.Windows.Forms.Label();
            this.txtEnglishMark = new System.Windows.Forms.TextBox();
            this.txtMathsMark = new System.Windows.Forms.TextBox();
            this.txtScienceMark = new System.Windows.Forms.TextBox();
            this.tbInformation.SuspendLayout();
            this.tbStudentDetails.SuspendLayout();
            this.tbGrades.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInformation
            // 
            this.tbInformation.Controls.Add(this.tbStudentDetails);
            this.tbInformation.Controls.Add(this.tbGrades);
            this.tbInformation.Controls.Add(this.tbResults);
            this.tbInformation.Location = new System.Drawing.Point(12, 75);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.SelectedIndex = 0;
            this.tbInformation.Size = new System.Drawing.Size(444, 339);
            this.tbInformation.TabIndex = 0;
            // 
            // tbStudentDetails
            // 
            this.tbStudentDetails.Controls.Add(this.btnEnterDetails);
            this.tbStudentDetails.Controls.Add(this.txtScience);
            this.tbStudentDetails.Controls.Add(this.txtMaths);
            this.tbStudentDetails.Controls.Add(this.txtEnglish);
            this.tbStudentDetails.Controls.Add(this.cboGroup);
            this.tbStudentDetails.Controls.Add(this.txtStudentNumber);
            this.tbStudentDetails.Controls.Add(this.txtStudentName);
            this.tbStudentDetails.Controls.Add(this.lblScience);
            this.tbStudentDetails.Controls.Add(this.lblMaths);
            this.tbStudentDetails.Controls.Add(this.lblEnglish);
            this.tbStudentDetails.Controls.Add(this.lblGroup);
            this.tbStudentDetails.Controls.Add(this.lblStudentNumber);
            this.tbStudentDetails.Controls.Add(this.lblStudentName);
            this.tbStudentDetails.Controls.Add(this.lblInstructions2);
            this.tbStudentDetails.Controls.Add(this.lblInstructions);
            this.tbStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tbStudentDetails.Name = "tbStudentDetails";
            this.tbStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbStudentDetails.Size = new System.Drawing.Size(436, 313);
            this.tbStudentDetails.TabIndex = 0;
            this.tbStudentDetails.Text = "Student Details";
            this.tbStudentDetails.UseVisualStyleBackColor = true;
            // 
            // tbGrades
            // 
            this.tbGrades.Controls.Add(this.txtScienceMark);
            this.tbGrades.Controls.Add(this.txtMathsMark);
            this.tbGrades.Controls.Add(this.txtEnglishMark);
            this.tbGrades.Controls.Add(this.lbl_Science_);
            this.tbGrades.Controls.Add(this.lbl_Maths_);
            this.tbGrades.Controls.Add(this.lbl_English);
            this.tbGrades.Controls.Add(this.lblStudent_Marks_);
            this.tbGrades.Controls.Add(this.txt_Group);
            this.tbGrades.Controls.Add(this.txtStudent_Number);
            this.tbGrades.Controls.Add(this.txtStudent_Name);
            this.tbGrades.Controls.Add(this.lbl_Group);
            this.tbGrades.Controls.Add(this.lbl_StudentNumber);
            this.tbGrades.Controls.Add(this.lblStudent_Name);
            this.tbGrades.Controls.Add(this.lblStudent_Marks);
            this.tbGrades.Controls.Add(this.label1);
            this.tbGrades.Controls.Add(this.btnSearch);
            this.tbGrades.Controls.Add(this.txtSearchNumber);
            this.tbGrades.Controls.Add(this.lblStudent_Number);
            this.tbGrades.Location = new System.Drawing.Point(4, 22);
            this.tbGrades.Name = "tbGrades";
            this.tbGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tbGrades.Size = new System.Drawing.Size(436, 313);
            this.tbGrades.TabIndex = 1;
            this.tbGrades.Text = "Grades";
            this.tbGrades.UseVisualStyleBackColor = true;
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(4, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.Padding = new System.Windows.Forms.Padding(3);
            this.tbResults.Size = new System.Drawing.Size(436, 313);
            this.tbResults.TabIndex = 2;
            this.tbResults.Text = "Results";
            this.tbResults.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(108, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(241, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Grades";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(23, 30);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(153, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Please enter the student marks";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Location = new System.Drawing.Point(224, 30);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(153, 13);
            this.lblInstructions2.TabIndex = 1;
            this.lblInstructions2.Text = "Please enter the student marks";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(26, 83);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(93, 16);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblStudentNumber
            // 
            this.lblStudentNumber.AutoSize = true;
            this.lblStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentNumber.Location = new System.Drawing.Point(29, 130);
            this.lblStudentNumber.Name = "lblStudentNumber";
            this.lblStudentNumber.Size = new System.Drawing.Size(104, 16);
            this.lblStudentNumber.TabIndex = 3;
            this.lblStudentNumber.Text = "Student Number";
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroup.Location = new System.Drawing.Point(29, 182);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(45, 16);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Group";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.Location = new System.Drawing.Point(268, 80);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(52, 16);
            this.lblEnglish.TabIndex = 5;
            this.lblEnglish.Text = "English";
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaths.Location = new System.Drawing.Point(268, 130);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(44, 16);
            this.lblMaths.TabIndex = 6;
            this.lblMaths.Text = "Maths";
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.Location = new System.Drawing.Point(263, 182);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(57, 16);
            this.lblScience.TabIndex = 7;
            this.lblScience.Text = "Science";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(138, 80);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 8;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(138, 130);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txtStudentNumber.TabIndex = 9;
            this.txtStudentNumber.TextChanged += new System.EventHandler(this.txtStudentNumber_TextChanged);
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Items.AddRange(new object[] {
            "DPD1A",
            "DPD1B",
            "BND1A",
            "BND1B"});
            this.cboGroup.Location = new System.Drawing.Point(138, 173);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(100, 21);
            this.cboGroup.TabIndex = 10;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(339, 72);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(91, 20);
            this.txtEnglish.TabIndex = 11;
            // 
            // txtMaths
            // 
            this.txtMaths.Location = new System.Drawing.Point(339, 122);
            this.txtMaths.Name = "txtMaths";
            this.txtMaths.Size = new System.Drawing.Size(91, 20);
            this.txtMaths.TabIndex = 12;
            // 
            // txtScience
            // 
            this.txtScience.Location = new System.Drawing.Point(339, 182);
            this.txtScience.Name = "txtScience";
            this.txtScience.Size = new System.Drawing.Size(91, 20);
            this.txtScience.TabIndex = 13;
            // 
            // btnEnterDetails
            // 
            this.btnEnterDetails.Location = new System.Drawing.Point(266, 246);
            this.btnEnterDetails.Name = "btnEnterDetails";
            this.btnEnterDetails.Size = new System.Drawing.Size(123, 43);
            this.btnEnterDetails.TabIndex = 14;
            this.btnEnterDetails.Text = "Enter Details";
            this.btnEnterDetails.UseVisualStyleBackColor = true;
            this.btnEnterDetails.Click += new System.EventHandler(this.btnEnterDetails_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(338, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 43);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStudent_Number
            // 
            this.lblStudent_Number.AutoSize = true;
            this.lblStudent_Number.Location = new System.Drawing.Point(43, 32);
            this.lblStudent_Number.Name = "lblStudent_Number";
            this.lblStudent_Number.Size = new System.Drawing.Size(84, 13);
            this.lblStudent_Number.TabIndex = 0;
            this.lblStudent_Number.Text = "Student Number";
            // 
            // txtSearchNumber
            // 
            this.txtSearchNumber.Location = new System.Drawing.Point(172, 32);
            this.txtSearchNumber.Name = "txtSearchNumber";
            this.txtSearchNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSearchNumber.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(322, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // lblStudent_Marks
            // 
            this.lblStudent_Marks.AutoSize = true;
            this.lblStudent_Marks.Location = new System.Drawing.Point(27, 86);
            this.lblStudent_Marks.Name = "lblStudent_Marks";
            this.lblStudent_Marks.Size = new System.Drawing.Size(76, 13);
            this.lblStudent_Marks.TabIndex = 4;
            this.lblStudent_Marks.Text = "Student Marks";
            // 
            // lblStudent_Name
            // 
            this.lblStudent_Name.AutoSize = true;
            this.lblStudent_Name.Location = new System.Drawing.Point(27, 116);
            this.lblStudent_Name.Name = "lblStudent_Name";
            this.lblStudent_Name.Size = new System.Drawing.Size(75, 13);
            this.lblStudent_Name.TabIndex = 5;
            this.lblStudent_Name.Text = "Student Name";
            this.lblStudent_Name.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(30, 147);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_StudentNumber.TabIndex = 6;
            this.lbl_StudentNumber.Text = "Student Number";
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Location = new System.Drawing.Point(30, 175);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(36, 13);
            this.lbl_Group.TabIndex = 7;
            this.lbl_Group.Text = "Group";
            // 
            // txtStudent_Name
            // 
            this.txtStudent_Name.Location = new System.Drawing.Point(131, 116);
            this.txtStudent_Name.Name = "txtStudent_Name";
            this.txtStudent_Name.Size = new System.Drawing.Size(100, 20);
            this.txtStudent_Name.TabIndex = 9;
            // 
            // txtStudent_Number
            // 
            this.txtStudent_Number.Location = new System.Drawing.Point(131, 139);
            this.txtStudent_Number.Name = "txtStudent_Number";
            this.txtStudent_Number.Size = new System.Drawing.Size(100, 20);
            this.txtStudent_Number.TabIndex = 10;
            // 
            // txt_Group
            // 
            this.txt_Group.Location = new System.Drawing.Point(131, 167);
            this.txt_Group.Name = "txt_Group";
            this.txt_Group.Size = new System.Drawing.Size(100, 20);
            this.txt_Group.TabIndex = 11;
            // 
            // lblStudent_Marks_
            // 
            this.lblStudent_Marks_.AutoSize = true;
            this.lblStudent_Marks_.Location = new System.Drawing.Point(280, 85);
            this.lblStudent_Marks_.Name = "lblStudent_Marks_";
            this.lblStudent_Marks_.Size = new System.Drawing.Size(76, 13);
            this.lblStudent_Marks_.TabIndex = 12;
            this.lblStudent_Marks_.Text = "Student Marks";
            // 
            // lbl_English
            // 
            this.lbl_English.AutoSize = true;
            this.lbl_English.Location = new System.Drawing.Point(264, 116);
            this.lbl_English.Name = "lbl_English";
            this.lbl_English.Size = new System.Drawing.Size(41, 13);
            this.lbl_English.TabIndex = 13;
            this.lbl_English.Text = "English";
            // 
            // lbl_Maths_
            // 
            this.lbl_Maths_.AutoSize = true;
            this.lbl_Maths_.Location = new System.Drawing.Point(264, 146);
            this.lbl_Maths_.Name = "lbl_Maths_";
            this.lbl_Maths_.Size = new System.Drawing.Size(36, 13);
            this.lbl_Maths_.TabIndex = 14;
            this.lbl_Maths_.Text = "Maths";
            // 
            // lbl_Science_
            // 
            this.lbl_Science_.AutoSize = true;
            this.lbl_Science_.Location = new System.Drawing.Point(264, 174);
            this.lbl_Science_.Name = "lbl_Science_";
            this.lbl_Science_.Size = new System.Drawing.Size(46, 13);
            this.lbl_Science_.TabIndex = 15;
            this.lbl_Science_.Text = "Science";
            // 
            // txtEnglishMark
            // 
            this.txtEnglishMark.Location = new System.Drawing.Point(314, 113);
            this.txtEnglishMark.Name = "txtEnglishMark";
            this.txtEnglishMark.Size = new System.Drawing.Size(100, 20);
            this.txtEnglishMark.TabIndex = 16;
            // 
            // txtMathsMark
            // 
            this.txtMathsMark.Location = new System.Drawing.Point(314, 139);
            this.txtMathsMark.Name = "txtMathsMark";
            this.txtMathsMark.Size = new System.Drawing.Size(100, 20);
            this.txtMathsMark.TabIndex = 17;
            // 
            // txtScienceMark
            // 
            this.txtScienceMark.Location = new System.Drawing.Point(313, 166);
            this.txtScienceMark.Name = "txtScienceMark";
            this.txtScienceMark.Size = new System.Drawing.Size(100, 20);
            this.txtScienceMark.TabIndex = 18;
            // 
            // FrmStudentGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 573);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbInformation);
            this.Name = "FrmStudentGrades";
            this.Text = "Student Grades";
            this.tbInformation.ResumeLayout(false);
            this.tbStudentDetails.ResumeLayout(false);
            this.tbStudentDetails.PerformLayout();
            this.tbGrades.ResumeLayout(false);
            this.tbGrades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbInformation;
        private System.Windows.Forms.TabPage tbStudentDetails;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblStudentNumber;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TabPage tbGrades;
        private System.Windows.Forms.TabPage tbResults;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEnterDetails;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStudent_Name;
        private System.Windows.Forms.Label lblStudent_Marks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchNumber;
        private System.Windows.Forms.Label lblStudent_Number;
        private System.Windows.Forms.TextBox txtStudent_Number;
        private System.Windows.Forms.TextBox txtStudent_Name;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.TextBox txtScienceMark;
        private System.Windows.Forms.TextBox txtMathsMark;
        private System.Windows.Forms.TextBox txtEnglishMark;
        private System.Windows.Forms.Label lbl_Science_;
        private System.Windows.Forms.Label lbl_Maths_;
        private System.Windows.Forms.Label lbl_English;
        private System.Windows.Forms.Label lblStudent_Marks_;
        private System.Windows.Forms.TextBox txt_Group;
    }
}

