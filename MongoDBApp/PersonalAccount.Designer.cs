
namespace MongoDBApp
{
    partial class PersonalAccount
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
            this.tabPagePersonalInfo = new System.Windows.Forms.TabPage();
            this.labelNearVisit = new System.Windows.Forms.Label();
            this.labelCountVisits = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tabPageWriting = new System.Windows.Forms.TabPage();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelMasterAddWriting = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerWritingTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWritingService = new System.Windows.Forms.ComboBox();
            this.dateTimePickerWritingDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWritingEmployee = new System.Windows.Forms.ComboBox();
            this.labelWriting = new System.Windows.Forms.Label();
            this.textBoxWriting = new System.Windows.Forms.RichTextBox();
            this.listBoxUserOrders = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.listBoxUserVisits = new System.Windows.Forms.ListBox();
            this.linkLabelExitUser = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPagePersonalInfo.SuspendLayout();
            this.tabPageWriting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePersonalInfo);
            this.tabControl1.Controls.Add(this.tabPageWriting);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(758, 579);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePersonalInfo
            // 
            this.tabPagePersonalInfo.Controls.Add(this.labelNearVisit);
            this.tabPagePersonalInfo.Controls.Add(this.labelCountVisits);
            this.tabPagePersonalInfo.Controls.Add(this.labelUserName);
            this.tabPagePersonalInfo.Location = new System.Drawing.Point(4, 25);
            this.tabPagePersonalInfo.Name = "tabPagePersonalInfo";
            this.tabPagePersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePersonalInfo.Size = new System.Drawing.Size(750, 550);
            this.tabPagePersonalInfo.TabIndex = 0;
            this.tabPagePersonalInfo.Text = "Песональные данные";
            this.tabPagePersonalInfo.UseVisualStyleBackColor = true;
            // 
            // labelNearVisit
            // 
            this.labelNearVisit.AutoSize = true;
            this.labelNearVisit.Location = new System.Drawing.Point(8, 152);
            this.labelNearVisit.Name = "labelNearVisit";
            this.labelNearVisit.Size = new System.Drawing.Size(134, 17);
            this.labelNearVisit.TabIndex = 4;
            this.labelNearVisit.Text = "Ближайший визит: ";
            // 
            // labelCountVisits
            // 
            this.labelCountVisits.AutoSize = true;
            this.labelCountVisits.Location = new System.Drawing.Point(8, 123);
            this.labelCountVisits.Name = "labelCountVisits";
            this.labelCountVisits.Size = new System.Drawing.Size(109, 17);
            this.labelCountVisits.TabIndex = 1;
            this.labelCountVisits.Text = "Всего визитов: ";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserName.Location = new System.Drawing.Point(6, 3);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(0, 29);
            this.labelUserName.TabIndex = 0;
            // 
            // tabPageWriting
            // 
            this.tabPageWriting.Controls.Add(this.buttonWrite);
            this.tabPageWriting.Controls.Add(this.buttonCancel);
            this.tabPageWriting.Controls.Add(this.labelMasterAddWriting);
            this.tabPageWriting.Controls.Add(this.label5);
            this.tabPageWriting.Controls.Add(this.label3);
            this.tabPageWriting.Controls.Add(this.label2);
            this.tabPageWriting.Controls.Add(this.dateTimePickerWritingTime);
            this.tabPageWriting.Controls.Add(this.comboBoxWritingService);
            this.tabPageWriting.Controls.Add(this.dateTimePickerWritingDate);
            this.tabPageWriting.Controls.Add(this.comboBoxWritingEmployee);
            this.tabPageWriting.Controls.Add(this.labelWriting);
            this.tabPageWriting.Controls.Add(this.textBoxWriting);
            this.tabPageWriting.Controls.Add(this.listBoxUserOrders);
            this.tabPageWriting.Location = new System.Drawing.Point(4, 25);
            this.tabPageWriting.Name = "tabPageWriting";
            this.tabPageWriting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWriting.Size = new System.Drawing.Size(750, 550);
            this.tabPageWriting.TabIndex = 1;
            this.tabPageWriting.Text = "Мои записи";
            this.tabPageWriting.UseVisualStyleBackColor = true;
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(372, 407);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(184, 52);
            this.buttonWrite.TabIndex = 17;
            this.buttonWrite.Text = "Записаться";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(320, 287);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(107, 52);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Отменить запись";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelMasterAddWriting
            // 
            this.labelMasterAddWriting.AutoSize = true;
            this.labelMasterAddWriting.Location = new System.Drawing.Point(182, 415);
            this.labelMasterAddWriting.Name = "labelMasterAddWriting";
            this.labelMasterAddWriting.Size = new System.Drawing.Size(61, 17);
            this.labelMasterAddWriting.TabIndex = 13;
            this.labelMasterAddWriting.Text = "Мастер:";
            this.labelMasterAddWriting.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 415);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Услуга:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата:";
            // 
            // dateTimePickerWritingTime
            // 
            this.dateTimePickerWritingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWritingTime.Location = new System.Drawing.Point(182, 377);
            this.dateTimePickerWritingTime.Name = "dateTimePickerWritingTime";
            this.dateTimePickerWritingTime.Size = new System.Drawing.Size(170, 22);
            this.dateTimePickerWritingTime.TabIndex = 9;
            // 
            // comboBoxWritingService
            // 
            this.comboBoxWritingService.FormattingEnabled = true;
            this.comboBoxWritingService.Location = new System.Drawing.Point(6, 435);
            this.comboBoxWritingService.Name = "comboBoxWritingService";
            this.comboBoxWritingService.Size = new System.Drawing.Size(170, 24);
            this.comboBoxWritingService.TabIndex = 8;
            this.comboBoxWritingService.SelectedIndexChanged += new System.EventHandler(this.comboBoxWritingService_SelectedIndexChanged);
            // 
            // dateTimePickerWritingDate
            // 
            this.dateTimePickerWritingDate.Location = new System.Drawing.Point(6, 377);
            this.dateTimePickerWritingDate.Name = "dateTimePickerWritingDate";
            this.dateTimePickerWritingDate.Size = new System.Drawing.Size(170, 22);
            this.dateTimePickerWritingDate.TabIndex = 7;
            // 
            // comboBoxWritingEmployee
            // 
            this.comboBoxWritingEmployee.FormattingEnabled = true;
            this.comboBoxWritingEmployee.Location = new System.Drawing.Point(182, 435);
            this.comboBoxWritingEmployee.Name = "comboBoxWritingEmployee";
            this.comboBoxWritingEmployee.Size = new System.Drawing.Size(170, 24);
            this.comboBoxWritingEmployee.TabIndex = 6;
            this.comboBoxWritingEmployee.Visible = false;
            // 
            // labelWriting
            // 
            this.labelWriting.AutoSize = true;
            this.labelWriting.Location = new System.Drawing.Point(6, 329);
            this.labelWriting.Name = "labelWriting";
            this.labelWriting.Size = new System.Drawing.Size(85, 17);
            this.labelWriting.TabIndex = 2;
            this.labelWriting.Text = "Записаться";
            // 
            // textBoxWriting
            // 
            this.textBoxWriting.Location = new System.Drawing.Point(320, 37);
            this.textBoxWriting.Name = "textBoxWriting";
            this.textBoxWriting.ReadOnly = true;
            this.textBoxWriting.Size = new System.Drawing.Size(325, 244);
            this.textBoxWriting.TabIndex = 1;
            this.textBoxWriting.Text = "";
            // 
            // listBoxUserOrders
            // 
            this.listBoxUserOrders.FormattingEnabled = true;
            this.listBoxUserOrders.ItemHeight = 16;
            this.listBoxUserOrders.Location = new System.Drawing.Point(95, 37);
            this.listBoxUserOrders.Name = "listBoxUserOrders";
            this.listBoxUserOrders.Size = new System.Drawing.Size(219, 244);
            this.listBoxUserOrders.TabIndex = 0;
            this.listBoxUserOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxUserOrders_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox3);
            this.tabPage1.Controls.Add(this.listBoxUserVisits);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(750, 550);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Мои посещения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(231, 127);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(513, 244);
            this.richTextBox3.TabIndex = 22;
            this.richTextBox3.Text = "";
            // 
            // listBoxUserVisits
            // 
            this.listBoxUserVisits.FormattingEnabled = true;
            this.listBoxUserVisits.ItemHeight = 16;
            this.listBoxUserVisits.Location = new System.Drawing.Point(6, 127);
            this.listBoxUserVisits.Name = "listBoxUserVisits";
            this.listBoxUserVisits.Size = new System.Drawing.Size(219, 244);
            this.listBoxUserVisits.TabIndex = 21;
            // 
            // linkLabelExitUser
            // 
            this.linkLabelExitUser.AutoSize = true;
            this.linkLabelExitUser.Location = new System.Drawing.Point(720, 9);
            this.linkLabelExitUser.Name = "linkLabelExitUser";
            this.linkLabelExitUser.Size = new System.Drawing.Size(50, 17);
            this.linkLabelExitUser.TabIndex = 1;
            this.linkLabelExitUser.TabStop = true;
            this.linkLabelExitUser.Text = "Выйти";
            this.linkLabelExitUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PersonalAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.linkLabelExitUser);
            this.Controls.Add(this.tabControl1);
            this.Name = "PersonalAccount";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.PersonalAccount_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePersonalInfo.ResumeLayout(false);
            this.tabPagePersonalInfo.PerformLayout();
            this.tabPageWriting.ResumeLayout(false);
            this.tabPageWriting.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePersonalInfo;
        private System.Windows.Forms.TabPage tabPageWriting;
        private System.Windows.Forms.Label labelNearVisit;
        private System.Windows.Forms.Label labelCountVisits;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelMasterAddWriting;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerWritingTime;
        private System.Windows.Forms.ComboBox comboBoxWritingService;
        private System.Windows.Forms.DateTimePicker dateTimePickerWritingDate;
        private System.Windows.Forms.ComboBox comboBoxWritingEmployee;
        private System.Windows.Forms.Label labelWriting;
        private System.Windows.Forms.RichTextBox textBoxWriting;
        private System.Windows.Forms.ListBox listBoxUserOrders;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.ListBox listBoxUserVisits;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.LinkLabel linkLabelExitUser;
    }
}