
namespace MongoDBApp
{
    partial class Start
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Price_button = new System.Windows.Forms.Button();
            this.Employee_button = new System.Windows.Forms.Button();
            this.linkLabelEnterAdmin = new System.Windows.Forms.LinkLabel();
            this.linkLabelEnterUser = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Price_button
            // 
            this.Price_button.BackColor = System.Drawing.Color.PeachPuff;
            this.Price_button.Location = new System.Drawing.Point(187, 138);
            this.Price_button.Name = "Price_button";
            this.Price_button.Size = new System.Drawing.Size(212, 84);
            this.Price_button.TabIndex = 0;
            this.Price_button.Text = "Прайс";
            this.Price_button.UseVisualStyleBackColor = false;
            this.Price_button.Click += new System.EventHandler(this.Price_button_Click);
            // 
            // Employee_button
            // 
            this.Employee_button.BackColor = System.Drawing.Color.PeachPuff;
            this.Employee_button.Location = new System.Drawing.Point(405, 138);
            this.Employee_button.Name = "Employee_button";
            this.Employee_button.Size = new System.Drawing.Size(212, 84);
            this.Employee_button.TabIndex = 2;
            this.Employee_button.Text = "Наши мастера";
            this.Employee_button.UseVisualStyleBackColor = false;
            this.Employee_button.Click += new System.EventHandler(this.Employee_button_Click);
            // 
            // linkLabelEnterAdmin
            // 
            this.linkLabelEnterAdmin.AutoSize = true;
            this.linkLabelEnterAdmin.Location = new System.Drawing.Point(594, 371);
            this.linkLabelEnterAdmin.Name = "linkLabelEnterAdmin";
            this.linkLabelEnterAdmin.Size = new System.Drawing.Size(180, 17);
            this.linkLabelEnterAdmin.TabIndex = 4;
            this.linkLabelEnterAdmin.TabStop = true;
            this.linkLabelEnterAdmin.Text = "Войти как администратор";
            this.linkLabelEnterAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEnterAdmin_LinkClicked);
            // 
            // linkLabelEnterUser
            // 
            this.linkLabelEnterUser.AutoSize = true;
            this.linkLabelEnterUser.Location = new System.Drawing.Point(594, 350);
            this.linkLabelEnterUser.Name = "linkLabelEnterUser";
            this.linkLabelEnterUser.Size = new System.Drawing.Size(124, 17);
            this.linkLabelEnterUser.TabIndex = 5;
            this.linkLabelEnterUser.TabStop = true;
            this.linkLabelEnterUser.Text = "Войти как клиент";
            this.linkLabelEnterUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEnterUser_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(782, 394);
            this.Controls.Add(this.linkLabelEnterUser);
            this.Controls.Add(this.linkLabelEnterAdmin);
            this.Controls.Add(this.Employee_button);
            this.Controls.Add(this.Price_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Price_button;
        private System.Windows.Forms.Button Employee_button;
        private System.Windows.Forms.LinkLabel linkLabelEnterAdmin;
        private System.Windows.Forms.LinkLabel linkLabelEnterUser;
    }
}

