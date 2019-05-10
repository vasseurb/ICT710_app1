using System;

namespace ICT710_app1
{
    partial class frm_student_grade
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
            this.txt_std_name = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.lbl_student_grade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_std_grade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_std_name
            // 
            this.txt_std_name.Location = new System.Drawing.Point(123, 46);
            this.txt_std_name.Name = "txt_std_name";
            this.txt_std_name.Size = new System.Drawing.Size(141, 20);
            this.txt_std_name.TabIndex = 10;
            // 
            // btn_calculate
            // 
            this.btn_calculate.AccessibleDescription = "Calculate Mark";
            this.btn_calculate.AccessibleName = "Calculate";
            this.btn_calculate.Location = new System.Drawing.Point(30, 136);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(100, 23);
            this.btn_calculate.TabIndex = 30;
            this.btn_calculate.Text = "&Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.AccessibleDescription = "Exit the program";
            this.btn_exit.AccessibleName = "Exit";
            this.btn_exit.Location = new System.Drawing.Point(164, 136);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 23);
            this.btn_exit.TabIndex = 40;
            this.btn_exit.Text = "&Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(30, 193);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(234, 40);
            this.txt_result.TabIndex = 4;
            this.txt_result.TabStop = false;
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Location = new System.Drawing.Point(27, 49);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(75, 13);
            this.lbl_student_name.TabIndex = 5;
            this.lbl_student_name.Text = "Student Name";
            this.lbl_student_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_student_grade
            // 
            this.lbl_student_grade.AutoSize = true;
            this.lbl_student_grade.Location = new System.Drawing.Point(27, 86);
            this.lbl_student_grade.Name = "lbl_student_grade";
            this.lbl_student_grade.Size = new System.Drawing.Size(76, 13);
            this.lbl_student_grade.TabIndex = 6;
            this.lbl_student_grade.Text = "Student Grade";
            this.lbl_student_grade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Student Mark Calculator";
            // 
            // txt_std_grade
            // 
            this.txt_std_grade.Location = new System.Drawing.Point(123, 83);
            this.txt_std_grade.Name = "txt_std_grade";
            this.txt_std_grade.Size = new System.Drawing.Size(45, 20);
            this.txt_std_grade.TabIndex = 20;
            this.txt_std_grade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
 //           this.txt_std_grade.TextChanged += new System.EventHandler(this.txt_std_grade_TextChanged);
            // 
            // frm_student_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 275);
            this.Controls.Add(this.txt_std_grade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_student_grade);
            this.Controls.Add(this.lbl_student_name);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_std_name);
            this.Name = "frm_student_grade";
            this.Text = "Student Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_std_name;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.Label lbl_student_grade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_std_grade;
    }
}

