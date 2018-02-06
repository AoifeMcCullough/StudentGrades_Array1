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
    }
}
