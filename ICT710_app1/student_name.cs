/**********************************
 * Program: ICT710_app1
 * Author:  Brian Vasseur
 * Date:    May 9, 2019
 * Purpose: This program is designed to accept a student name and mark
 *          and display the output in a readonly text field
 *          
 *          This example uses a Masked input for percent with validation and 
 *          conversion to integer. The output allows for a word wrapped multiline
 *          textbox in case the student has a very long name.
 *          
 **********************************/
 
using System;
using System.Windows.Forms;

namespace ICT710_app1
{
    public partial class frm_student_grade : Form
    {
        public frm_student_grade()
        {
            InitializeComponent();
        }

        // Calculate button: display a message in txt_result field
        private void button1_Click(object sender, EventArgs e)
        {
            txt_result.Text = txt_std_name.Text + " received " + 
                txt_std_grade.Text + "% as a final mark.";  
        }
        // don't need this. but old habits are hard to change
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Student mark must be an integer between 0 and 100.
        // No real error handling at this time, just set it to 0.
        /* Comment this out for now this is the wrong event handler
         * commented out in form designer
         * 
        private void txt_std_grade_TextChanged(object sender, EventArgs e)
        {
            int student_mark = Convert.ToInt32(txt_std_grade.Text);
            if (student_mark > 100 || student_mark < 0)
            {
                txt_std_grade.Text = "0";
                MessageBox.Show("zero");
            }
            else
            {
                txt_std_grade.Text = Convert.ToString(student_mark);
                MessageBox.Show(txt_std_grade.Text);
            }
        }
        */
    }
}
