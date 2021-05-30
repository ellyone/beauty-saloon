
namespace MongoDBApp
{
    partial class PriceList
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
            this.listPrice = new System.Windows.Forms.ListBox();
            this.PriceTextBox = new System.Windows.Forms.RichTextBox();
            this.linkMenu2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // listPrice
            // 
            this.listPrice.FormattingEnabled = true;
            this.listPrice.ItemHeight = 16;
            this.listPrice.Location = new System.Drawing.Point(12, 91);
            this.listPrice.Name = "listPrice";
            this.listPrice.Size = new System.Drawing.Size(240, 500);
            this.listPrice.TabIndex = 0;
            this.listPrice.SelectedIndexChanged += new System.EventHandler(this.listPrice_SelectedIndexChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(258, 91);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(512, 500);
            this.PriceTextBox.TabIndex = 1;
            this.PriceTextBox.Text = "";
            // 
            // linkMenu2
            // 
            this.linkMenu2.AutoSize = true;
            this.linkMenu2.Location = new System.Drawing.Point(12, 13);
            this.linkMenu2.Name = "linkMenu2";
            this.linkMenu2.Size = new System.Drawing.Size(127, 17);
            this.linkMenu2.TabIndex = 2;
            this.linkMenu2.TabStop = true;
            this.linkMenu2.Text = "Вернуться в меню";
            this.linkMenu2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkMenu2_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 603);
            this.Controls.Add(this.linkMenu2);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.listPrice);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPrice;
        private System.Windows.Forms.RichTextBox PriceTextBox;
        private System.Windows.Forms.LinkLabel linkMenu2;
    }
}