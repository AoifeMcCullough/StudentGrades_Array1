using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrades_Array
{
    public partial class FrmStudentGrades : Form
    { //Variable and Arrays
        const int arraySize = 30;
        private static String[] strStudentName = new String[arraySize];
        private static String[] strStudentNumber = new String[arraySize];
        private static String[] strGroup = new String[arraySize];


        private static int[] intEnglish = new int[arraySize];
        private static int[] intMaths = new int[arraySize];
        private static int[] intScience = new int[arraySize];

        private static int intRecordCount = 0;
        private static int intLoopCounter = 0;
        private static float fAverage = 0;
        private static String strGrade = "";
        private static int intRecord = 0;



        public FrmStudentGrades()
        {
            InitializeComponent();
        }

        private void txtStudentNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Calling the Halt procedure
            Halt();
        }
        //Procedure to Exit
        public static void Halt()
        { //Local variable to store result
            DialogResult dr;
            //Accept Response
            dr = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //If Yes then close program
            if (dr == DialogResult.Yes)
            { Application.Exit();
            }
        }

        private void btnEnterDetails_Click(object sender, EventArgs e)
        {
            //Enter Student Details
            EnterDetails();
        }
        //Procedure to Enter Student Details
        public void EnterDetails()
        {
            strStudentName[intRecordCount] = txtStudentName.Text;
            strStudentNumber[intRecordCount] = txtStudentNumber.Text;
            strGroup[intRecordCount] = cboGroup.Text;

            intEnglish[intRecordCount] = Convert.ToInt32(txtEnglish.Text);
            intMaths[intRecordCount] = Convert.ToInt32(txtMaths.Text);
            intScience[intRecordCount] = Convert.ToInt32(txtScience.Text);

            //Increase Counter
            intRecordCount++;

            //Display Message
            MessageBox.Show("Info Saved");

            //Clear Form
            ClearDetails();
        }
        //Procedure to clear all Details
        public void ClearDetails()
        {
            txtStudentName.Text = "";
            txtStudentNumber.Text = "";
            cboGroup.Text = "";

            txtEnglish.Text = "";
            txtMaths.Text = "";
            txtScience.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //check records entered
            if (intRecordCount == 0)
            {
                MessageBox.Show("No records entered ");
                return;
            }
            //search through array
            for (int intLoopCounter = 0;
                intLoopCounter < intRecordCount; intLoopCounter++)
            {
                if (txtSearchNumber.Text.Equals
                    (strStudentNumber[intLoopCounter]))
                {
                    txtStudent_Name.Text = "" + strStudentName[intLoopCounter];
                    txtStudent_Number.Text = "" + strStudentNumber[intLoopCounter];
                    txt_Group.Text = "" + strGroup[intLoopCounter];
                    txtEnglishMark.Text = "" + intEnglish[intLoopCounter];
                    txtMathsMark.Text = "" + intMaths[intLoopCounter];
                    txtScienceMark.Text = "" + intScience[intLoopCounter];
                    //Add additional code to display all values
                    intRecordCount = intLoopCounter;
                    return;
                }
            }
            MessageBox.Show("No match found");
        }

       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Calculate Average Mark
            //intLoopCounter = intRecordCount - 1;
            fAverage = AverageMark(intEnglish[intRecord], intMaths[intRecord], intScience[intRecord]);


            //Calculate Average Mark
            strGrade = CalculateGrade(fAverage);


            //Display Result Details
            DisplayDetails();

        }
        //Function to calculate Average Mark
        public float AverageMark(int intNumber1, int intNumber2, int intNumber3)
        {


            float Average = (float)(intNumber1 + intNumber2 + intNumber3) / 3;
            return Average;

        }
        //Function to Enter Student Details
        public string CalculateGrade(float Mark)
        {
            string strFinalGrade = "";
            if (Mark >= 80)
            {
                strFinalGrade = " You achieved a Distinction";

            }
            else if (Mark >= 60)
            {
                strFinalGrade = " You achieved a Merit";
            }

            else if (Mark >= 40)
            {
                strFinalGrade = " You achieved a Pass";
            }
            else
            {
                strFinalGrade = " You must take a resit";
            }

            return strFinalGrade;

        }
        //Procedure to Enter Student Details
        public void DisplayDetails()
        {

            lbl_Student_Details.Text = strGroup[intLoopCounter] + ":   " + strStudentNumber[intRecord] + ":   " + strStudentName[intRecord];
            lbl_Average_Mark.Text = fAverage.ToString("#0.00");
            lbl_Student_Grade.Text = strGrade;

        }

        private void tbResults_Click(object sender, EventArgs e)
        {

        }

        private void lbl_StudentGrade_Click(object sender, EventArgs e)
        {

        }

        private void lbl_AverageMark_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Procedure to clear all Details
            
            {
                txtStudentName.Text = "";
                txtStudentNumber.Text = "";
                cboGroup.Text = "";

                txtEnglish.Text = "";
                txtMaths.Text = "";
                txtScience.Text = "";
            }
        }
    }
}
