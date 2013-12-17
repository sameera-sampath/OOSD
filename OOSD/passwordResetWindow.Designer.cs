namespace OOSD
{
    partial class passwordResetWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.newPasswordBox1 = new System.Windows.Forms.TextBox();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePasswordButton);
            this.groupBox1.Controls.Add(this.newPasswordBox1);
            this.groupBox1.Controls.Add(this.userIDBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(174, 121);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(156, 23);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "Change";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // newPasswordBox1
            // 
            this.newPasswordBox1.Location = new System.Drawing.Point(174, 71);
            this.newPasswordBox1.Name = "newPasswordBox1";
            this.newPasswordBox1.PasswordChar = '*';
            this.newPasswordBox1.Size = new System.Drawing.Size(156, 20);
            this.newPasswordBox1.TabIndex = 4;
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(174, 32);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(156, 20);
            this.userIDBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Name";
            // 
            // passwordResetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 183);
            this.Controls.Add(this.groupBox1);
            this.Name = "passwordResetWindow";
            this.Text = "Reset Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox newPasswordBox1;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}