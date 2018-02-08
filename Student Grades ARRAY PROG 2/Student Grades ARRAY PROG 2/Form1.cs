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
