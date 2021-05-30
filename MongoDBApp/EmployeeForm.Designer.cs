
namespace MongoDBApp
{
    partial class EmployeeForm
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
            this.EmployeeTextBox = new System.Windows.Forms.RichTextBox();
            this.listEmployee = new System.Windows.Forms.ListBox();
            this.linkMenu3 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(258, 91);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(512, 500);
            this.EmployeeTextBox.TabIndex = 3;
            this.EmployeeTextBox.Text = "";
            // 
            // listEmployee
            // 
            this.listEmployee.FormattingEnabled = true;
            this.listEmployee.ItemHeight = 16;
            this.listEmployee.Location = new System.Drawing.Point(12, 91);
            this.listEmployee.Name = "listEmployee";
            this.listEmployee.Size = new System.Drawing.Size(240, 500);
            this.listEmployee.TabIndex = 2;
            this.listEmployee.SelectedIndexChanged += new System.EventHandler(this.listEmployee_SelectedIndexChanged);
            // 
            // linkMenu3
            // 
            this.linkMenu3.AutoSize = true;
            this.linkMenu3.Location = new System.Drawing.Point(9, 9);
            this.linkMenu3.Name = "linkMenu3";
            this.linkMenu3.Size = new System.Drawing.Size(127, 17);
            this.linkMenu3.TabIndex = 4;
            this.linkMenu3.TabStop = true;
            this.linkMenu3.Text = "Вернуться в меню";
            this.linkMenu3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMenu3_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.linkMenu3);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.listEmployee);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EmployeeTextBox;
        private System.Windows.Forms.ListBox listEmployee;
        private System.Windows.Forms.LinkLabel linkMenu3;
    }
}