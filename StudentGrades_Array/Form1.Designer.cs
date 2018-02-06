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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tbInformation.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInformation
            // 
            this.tbInformation.Controls.Add(this.tabPage1);
            this.tbInformation.Controls.Add(this.tabPage2);
            this.tbInformation.Controls.Add(this.tabPage3);
            this.tbInformation.Location = new System.Drawing.Point(12, 75);
            this.tbInformation.Name = "tbInformation";
            this.tbInformation.SelectedIndex = 0;
            this.tbInformation.Size = new System.Drawing.Size(444, 339);
            this.tbInformation.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEnterDetails);
            this.tabPage1.Controls.Add(this.txtScience);
            this.tabPage1.Controls.Add(this.txtMaths);
            this.tabPage1.Controls.Add(this.txtEnglish);
            this.tabPage1.Controls.Add(this.cboGroup);
            this.tabPage1.Controls.Add(this.txtStudentNumber);
            this.tabPage1.Controls.Add(this.txtStudentName);
            this.tabPage1.Controls.Add(this.lblScience);
            this.tabPage1.Controls.Add(this.lblMaths);
            this.tabPage1.Controls.Add(this.lblEnglish);
            this.tabPage1.Controls.Add(this.lblGroup);
            this.tabPage1.Controls.Add(this.lblStudentNumber);
            this.tabPage1.Controls.Add(this.lblStudentName);
            this.tabPage1.Controls.Add(this.lblInstructions2);
            this.tabPage1.Controls.Add(this.lblInstructions);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grades";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(192, 74);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Results";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbInformation;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEnterDetails;
        private System.Windows.Forms.TextBox txtScience;
        private System.Windows.Forms.TextBox txtMaths;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Button btnExit;
    }
}

