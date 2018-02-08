using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Grades_ARRAY_PROG_2
{
    public partial class FrmStudentGrades : Form
    {
        //Variables & Arrays
        const int arraysize = 30;

        private static string[] strStudentName = new string[arraysize];
        private static string[] strStudentNumber = new string[arraysize];
        private static string[] strGroup = new string[arraysize];

        private static int[] intEnglish = new int[arraysize];
        private static int[] intMaths = new int[arraysize];
        private static int[] intScience = new int[arraysize];

        private static int intRecordCount = 0;
        private static int intLoopCounter = 0;
        private static float fAverage = 0;
        private static String strGrade = "";

        public FrmStudentGrades()
        {
            InitializeComponent();
        }

        private void lblMaths_Click(object sender, EventArgs e)
        {

        }

        private void lblScience_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Calling halt procedure
            Halt();
        }

        //Procedure to exit application
        public static void Halt()
        {
            //Local Variable to store results
            DialogResult dr;

            //Accept Result
            dr = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //If yes then close
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
