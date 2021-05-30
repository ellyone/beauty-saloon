
namespace MongoDBApp
{
    partial class AdminPanel
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.linkLabelAddEmployee = new System.Windows.Forms.LinkLabel();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.adminTextBoxEmployee = new System.Windows.Forms.RichTextBox();
            this.adminListBoxEmployee = new System.Windows.Forms.ListBox();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.linkLabelAddService = new System.Windows.Forms.LinkLabel();
            this.buttonDeleteService = new System.Windows.Forms.Button();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.adminTextBoxService = new System.Windows.Forms.RichTextBox();
            this.adminListBoxService = new System.Windows.Forms.ListBox();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.linkLabelAddUser = new System.Windows.Forms.LinkLabel();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonEditUser = new System.Windows.Forms.Button();
            this.adminTextBoxUser = new System.Windows.Forms.RichTextBox();
            this.adminListBoxUser = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBoxForApprove = new System.Windows.Forms.ListBox();
            this.linkLabelExitAdmin = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            this.tabPageService.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageService);
            this.tabControl1.Controls.Add(this.tabPageUsers);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.linkLabelAddEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonEditEmployee);
            this.tabPageEmployee.Controls.Add(this.adminTextBoxEmployee);
            this.tabPageEmployee.Controls.Add(this.adminListBoxEmployee);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(750, 550);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Мастера";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // linkLabelAddEmployee
            // 
            this.linkLabelAddEmployee.AutoSize = true;
            this.linkLabelAddEmployee.Location = new System.Drawing.Point(565, 526);
            this.linkLabelAddEmployee.Name = "linkLabelAddEmployee";
            this.linkLabelAddEmployee.Size = new System.Drawing.Size(179, 17);
            this.linkLabelAddEmployee.TabIndex = 8;
            this.linkLabelAddEmployee.TabStop = true;
            this.linkLabelAddEmployee.Text = "Добавить нового мастера";
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(512, 491);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(232, 23);
            this.buttonDeleteEmployee.TabIndex = 7;
            this.buttonDeleteEmployee.Text = "Удалить";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(257, 491);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(232, 23);
            this.buttonEditEmployee.TabIndex = 6;
            this.buttonEditEmployee.Text = "Редактировать";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // adminTextBoxEmployee
            // 
            this.adminTextBoxEmployee.Location = new System.Drawing.Point(257, 93);
            this.adminTextBoxEmployee.Name = "adminTextBoxEmployee";
            this.adminTextBoxEmployee.ReadOnly = true;
            this.adminTextBoxEmployee.Size = new System.Drawing.Size(487, 382);
            this.adminTextBoxEmployee.TabIndex = 5;
            this.adminTextBoxEmployee.Text = "";
            // 
            // adminListBoxEmployee
            // 
            this.adminListBoxEmployee.FormattingEnabled = true;
            this.adminListBoxEmployee.ItemHeight = 16;
            this.adminListBoxEmployee.Location = new System.Drawing.Point(6, 93);
            this.adminListBoxEmployee.Name = "adminListBoxEmployee";
            this.adminListBoxEmployee.Size = new System.Drawing.Size(245, 452);
            this.adminListBoxEmployee.TabIndex = 4;
            this.adminListBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.adminListBoxEmployee_SelectedIndexChanged);
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.linkLabelAddService);
            this.tabPageService.Controls.Add(this.buttonDeleteService);
            this.tabPageService.Controls.Add(this.buttonEditService);
            this.tabPageService.Controls.Add(this.adminTextBoxService);
            this.tabPageService.Controls.Add(this.adminListBoxService);
            this.tabPageService.Location = new System.Drawing.Point(4, 25);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(750, 550);
            this.tabPageService.TabIndex = 1;
            this.tabPageService.Text = "Услуги";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // linkLabelAddService
            // 
            this.linkLabelAddService.AutoSize = true;
            this.linkLabelAddService.Location = new System.Drawing.Point(583, 528);
            this.linkLabelAddService.Name = "linkLabelAddService";
            this.linkLabelAddService.Size = new System.Drawing.Size(161, 17);
            this.linkLabelAddService.TabIndex = 4;
            this.linkLabelAddService.TabStop = true;
            this.linkLabelAddService.Text = "Добавить новую услугу";
            // 
            // buttonDeleteService
            // 
            this.buttonDeleteService.Location = new System.Drawing.Point(512, 491);
            this.buttonDeleteService.Name = "buttonDeleteService";
            this.buttonDeleteService.Size = new System.Drawing.Size(232, 23);
            this.buttonDeleteService.TabIndex = 3;
            this.buttonDeleteService.Text = "Удалить";
            this.buttonDeleteService.UseVisualStyleBackColor = true;
            // 
            // buttonEditService
            // 
            this.buttonEditService.Location = new System.Drawing.Point(257, 491);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(232, 23);
            this.buttonEditService.TabIndex = 2;
            this.buttonEditService.Text = "Редактировать";
            this.buttonEditService.UseVisualStyleBackColor = true;
            // 
            // adminTextBoxService
            // 
            this.adminTextBoxService.Location = new System.Drawing.Point(257, 93);
            this.adminTextBoxService.Name = "adminTextBoxService";
            this.adminTextBoxService.ReadOnly = true;
            this.adminTextBoxService.Size = new System.Drawing.Size(487, 382);
            this.adminTextBoxService.TabIndex = 1;
            this.adminTextBoxService.Text = "";
            // 
            // adminListBoxService
            // 
            this.adminListBoxService.FormattingEnabled = true;
            this.adminListBoxService.ItemHeight = 16;
            this.adminListBoxService.Location = new System.Drawing.Point(6, 93);
            this.adminListBoxService.Name = "adminListBoxService";
            this.adminListBoxService.Size = new System.Drawing.Size(245, 452);
            this.adminListBoxService.TabIndex = 0;
            this.adminListBoxService.SelectedIndexChanged += new System.EventHandler(this.adminListBoxService_SelectedIndexChanged);
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Controls.Add(this.linkLabelAddUser);
            this.tabPageUsers.Controls.Add(this.buttonDeleteUser);
            this.tabPageUsers.Controls.Add(this.buttonEditUser);
            this.tabPageUsers.Controls.Add(this.adminTextBoxUser);
            this.tabPageUsers.Controls.Add(this.adminListBoxUser);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 25);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Size = new System.Drawing.Size(750, 550);
            this.tabPageUsers.TabIndex = 2;
            this.tabPageUsers.Text = "Пользователи";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // linkLabelAddUser
            // 
            this.linkLabelAddUser.AutoSize = true;
            this.linkLabelAddUser.Location = new System.Drawing.Point(528, 528);
            this.linkLabelAddUser.Name = "linkLabelAddUser";
            this.linkLabelAddUser.Size = new System.Drawing.Size(216, 17);
            this.linkLabelAddUser.TabIndex = 8;
            this.linkLabelAddUser.TabStop = true;
            this.linkLabelAddUser.Text = "Добавить нового пользователя";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(512, 491);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(232, 23);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonEditUser
            // 
            this.buttonEditUser.Location = new System.Drawing.Point(257, 491);
            this.buttonEditUser.Name = "buttonEditUser";
            this.buttonEditUser.Size = new System.Drawing.Size(232, 23);
            this.buttonEditUser.TabIndex = 6;
            this.buttonEditUser.Text = "Редактировать";
            this.buttonEditUser.UseVisualStyleBackColor = true;
            // 
            // adminTextBoxUser
            // 
            this.adminTextBoxUser.Location = new System.Drawing.Point(257, 93);
            this.adminTextBoxUser.Name = "adminTextBoxUser";
            this.adminTextBoxUser.ReadOnly = true;
            this.adminTextBoxUser.Size = new System.Drawing.Size(487, 382);
            this.adminTextBoxUser.TabIndex = 5;
            this.adminTextBoxUser.Text = "";
            // 
            // adminListBoxUser
            // 
            this.adminListBoxUser.FormattingEnabled = true;
            this.adminListBoxUser.ItemHeight = 16;
            this.adminListBoxUser.Location = new System.Drawing.Point(6, 93);
            this.adminListBoxUser.Name = "adminListBoxUser";
            this.adminListBoxUser.Size = new System.Drawing.Size(245, 452);
            this.adminListBoxUser.TabIndex = 4;
            this.adminListBoxUser.SelectedIndexChanged += new System.EventHandler(this.adminListBoxUser_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonApprove);
            this.tabPage4.Controls.Add(this.richTextBox1);
            this.tabPage4.Controls.Add(this.listBoxForApprove);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(750, 550);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonApprove
            // 
            this.buttonApprove.Location = new System.Drawing.Point(352, 285);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(118, 26);
            this.buttonApprove.TabIndex = 2;
            this.buttonApprove.Text = "Подтвердить";
            this.buttonApprove.UseVisualStyleBackColor = true;
            this.buttonApprove.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(201, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(269, 276);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // listBoxForApprove
            // 
            this.listBoxForApprove.FormattingEnabled = true;
            this.listBoxForApprove.ItemHeight = 16;
            this.listBoxForApprove.Location = new System.Drawing.Point(3, 3);
            this.listBoxForApprove.Name = "listBoxForApprove";
            this.listBoxForApprove.Size = new System.Drawing.Size(192, 276);
            this.listBoxForApprove.TabIndex = 0;
            // 
            // linkLabelExitAdmin
            // 
            this.linkLabelExitAdmin.AutoSize = true;
            this.linkLabelExitAdmin.Location = new System.Drawing.Point(691, 11);
            this.linkLabelExitAdmin.Name = "linkLabelExitAdmin";
            this.linkLabelExitAdmin.Size = new System.Drawing.Size(50, 17);
            this.linkLabelExitAdmin.TabIndex = 1;
            this.linkLabelExitAdmin.TabStop = true;
            this.linkLabelExitAdmin.Text = "Выйти";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.linkLabelExitAdmin);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminPanel";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            this.tabPageService.ResumeLayout(false);
            this.tabPageService.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageService;
        public System.Windows.Forms.ListBox adminListBoxService;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.RichTextBox adminTextBoxEmployee;
        public System.Windows.Forms.ListBox adminListBoxEmployee;
        private System.Windows.Forms.Button buttonDeleteService;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.RichTextBox adminTextBoxService;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonEditUser;
        private System.Windows.Forms.RichTextBox adminTextBoxUser;
        public System.Windows.Forms.ListBox adminListBoxUser;
        private System.Windows.Forms.LinkLabel linkLabelAddEmployee;
        private System.Windows.Forms.LinkLabel linkLabelAddService;
        private System.Windows.Forms.LinkLabel linkLabelAddUser;
        private System.Windows.Forms.Button buttonApprove;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBoxForApprove;
        private System.Windows.Forms.LinkLabel linkLabelExitAdmin;
    }
}