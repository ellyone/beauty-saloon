
namespace MongoDBApp
{
    partial class UserAuthorization
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
            this.labelError = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnterPass = new System.Windows.Forms.TextBox();
            this.textBoxEnterLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(88, 57);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 17);
            this.labelError.TabIndex = 11;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(133, 231);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // textBoxEnterPass
            // 
            this.textBoxEnterPass.Location = new System.Drawing.Point(91, 203);
            this.textBoxEnterPass.Name = "textBoxEnterPass";
            this.textBoxEnterPass.Size = new System.Drawing.Size(171, 22);
            this.textBoxEnterPass.TabIndex = 7;
            // 
            // textBoxEnterLogin
            // 
            this.textBoxEnterLogin.Location = new System.Drawing.Point(91, 139);
            this.textBoxEnterLogin.Name = "textBoxEnterLogin";
            this.textBoxEnterLogin.Size = new System.Drawing.Size(171, 22);
            this.textBoxEnterLogin.TabIndex = 6;
            // 
            // UserAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 453);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnterPass);
            this.Controls.Add(this.textBoxEnterLogin);
            this.Name = "UserAuthorization";
            this.Text = "UserAuthorization";
            this.Load += new System.EventHandler(this.UserAuthorization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnterPass;
        private System.Windows.Forms.TextBox textBoxEnterLogin;
    }
}