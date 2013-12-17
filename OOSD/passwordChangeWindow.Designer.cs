namespace OOSD
{
    partial class passwordChangeWindow
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
            this.newPasswordBox2 = new System.Windows.Forms.TextBox();
            this.newPasswordBox1 = new System.Windows.Forms.TextBox();
            this.currentPasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changePasswordButton);
            this.groupBox1.Controls.Add(this.newPasswordBox2);
            this.groupBox1.Controls.Add(this.newPasswordBox1);
            this.groupBox1.Controls.Add(this.currentPasswordBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(174, 147);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(156, 23);
            this.changePasswordButton.TabIndex = 6;
            this.changePasswordButton.Text = "Change";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // newPasswordBox2
            // 
            this.newPasswordBox2.Location = new System.Drawing.Point(174, 109);
            this.newPasswordBox2.Name = "newPasswordBox2";
            this.newPasswordBox2.PasswordChar = '*';
            this.newPasswordBox2.Size = new System.Drawing.Size(156, 20);
            this.newPasswordBox2.TabIndex = 5;
            // 
            // newPasswordBox1
            // 
            this.newPasswordBox1.Location = new System.Drawing.Point(174, 71);
            this.newPasswordBox1.Name = "newPasswordBox1";
            this.newPasswordBox1.PasswordChar = '*';
            this.newPasswordBox1.Size = new System.Drawing.Size(156, 20);
            this.newPasswordBox1.TabIndex = 4;
            // 
            // currentPasswordBox
            // 
            this.currentPasswordBox.Location = new System.Drawing.Point(174, 32);
            this.currentPasswordBox.Name = "currentPasswordBox";
            this.currentPasswordBox.PasswordChar = '*';
            this.currentPasswordBox.Size = new System.Drawing.Size(156, 20);
            this.currentPasswordBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-enter new Password";
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
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Current Password";
            // 
            // passwordChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 218);
            this.Controls.Add(this.groupBox1);
            this.Name = "passwordChangeWindow";
            this.Text = "Change Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox newPasswordBox2;
        private System.Windows.Forms.TextBox newPasswordBox1;
        private System.Windows.Forms.TextBox currentPasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}