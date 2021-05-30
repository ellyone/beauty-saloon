
namespace MongoDBApp
{
    partial class EditEmployeeForm
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
            this.checkedListBoxEditEmployeeSpecialty = new System.Windows.Forms.CheckedListBox();
            this.textBoxEditEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEditEmployeeDesc = new System.Windows.Forms.RichTextBox();
            this.buttonSaveEmployee = new System.Windows.Forms.Button();
            this.linkLabelReturnFromEditEmployee = new System.Windows.Forms.LinkLabel();
            this.labelEditEmployeeItog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxEditEmployeeSpecialty
            // 
            this.checkedListBoxEditEmployeeSpecialty.FormattingEnabled = true;
            this.checkedListBoxEditEmployeeSpecialty.Location = new System.Drawing.Point(131, 191);
            this.checkedListBoxEditEmployeeSpecialty.Name = "checkedListBoxEditEmployeeSpecialty";
            this.checkedListBoxEditEmployeeSpecialty.Size = new System.Drawing.Size(170, 140);
            this.checkedListBoxEditEmployeeSpecialty.TabIndex = 1;
            // 
            // textBoxEditEmployeeName
            // 
            this.textBoxEditEmployeeName.Location = new System.Drawing.Point(131, 12);
            this.textBoxEditEmployeeName.Name = "textBoxEditEmployeeName";
            this.textBoxEditEmployeeName.Size = new System.Drawing.Size(170, 22);
            this.textBoxEditEmployeeName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Специализация";
            // 
            // textBoxEditEmployeeDesc
            // 
            this.textBoxEditEmployeeDesc.Location = new System.Drawing.Point(131, 45);
            this.textBoxEditEmployeeDesc.Name = "textBoxEditEmployeeDesc";
            this.textBoxEditEmployeeDesc.Size = new System.Drawing.Size(170, 140);
            this.textBoxEditEmployeeDesc.TabIndex = 7;
            this.textBoxEditEmployeeDesc.Text = "";
            // 
            // buttonSaveEmployee
            // 
            this.buttonSaveEmployee.Location = new System.Drawing.Point(179, 415);
            this.buttonSaveEmployee.Name = "buttonSaveEmployee";
            this.buttonSaveEmployee.Size = new System.Drawing.Size(122, 23);
            this.buttonSaveEmployee.TabIndex = 8;
            this.buttonSaveEmployee.Text = "Сохранить";
            this.buttonSaveEmployee.UseVisualStyleBackColor = true;
            this.buttonSaveEmployee.Click += new System.EventHandler(this.buttonSaveEmployee_Click);
            // 
            // linkLabelReturnFromEditEmployee
            // 
            this.linkLabelReturnFromEditEmployee.AutoSize = true;
            this.linkLabelReturnFromEditEmployee.Location = new System.Drawing.Point(13, 421);
            this.linkLabelReturnFromEditEmployee.Name = "linkLabelReturnFromEditEmployee";
            this.linkLabelReturnFromEditEmployee.Size = new System.Drawing.Size(49, 17);
            this.linkLabelReturnFromEditEmployee.TabIndex = 9;
            this.linkLabelReturnFromEditEmployee.TabStop = true;
            this.linkLabelReturnFromEditEmployee.Text = "Назад";
            this.linkLabelReturnFromEditEmployee.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelReturnFromEditEmployee_LinkClicked);
            // 
            // labelEditEmployeeItog
            // 
            this.labelEditEmployeeItog.AutoSize = true;
            this.labelEditEmployeeItog.Location = new System.Drawing.Point(179, 392);
            this.labelEditEmployeeItog.Name = "labelEditEmployeeItog";
            this.labelEditEmployeeItog.Size = new System.Drawing.Size(0, 17);
            this.labelEditEmployeeItog.TabIndex = 10;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.labelEditEmployeeItog);
            this.Controls.Add(this.linkLabelReturnFromEditEmployee);
            this.Controls.Add(this.buttonSaveEmployee);
            this.Controls.Add(this.textBoxEditEmployeeDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEditEmployeeName);
            this.Controls.Add(this.checkedListBoxEditEmployeeSpecialty);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxEditEmployeeSpecialty;
        private System.Windows.Forms.TextBox textBoxEditEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxEditEmployeeDesc;
        private System.Windows.Forms.Button buttonSaveEmployee;
        private System.Windows.Forms.LinkLabel linkLabelReturnFromEditEmployee;
        private System.Windows.Forms.Label labelEditEmployeeItog;
    }
}