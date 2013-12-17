namespace OOSD
{
    partial class emailChangeWindow
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentPasswordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeEmailButton = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.currentPasswordBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.changeEmailButton);
            this.groupBox2.Controls.Add(this.emailBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change Email";
            // 
            // currentPasswordBox
            // 
            this.currentPasswordBox.Location = new System.Drawing.Point(174, 29);
            this.currentPasswordBox.Name = "currentPasswordBox";
            this.currentPasswordBox.PasswordChar = '*';
            this.currentPasswordBox.Size = new System.Drawing.Size(327, 20);
            this.currentPasswordBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter Current Password";
            // 
            // changeEmailButton
            // 
            this.changeEmailButton.Location = new System.Drawing.Point(174, 137);
            this.changeEmailButton.Name = "changeEmailButton";
            this.changeEmailButton.Size = new System.Drawing.Size(156, 23);
            this.changeEmailButton.TabIndex = 7;
            this.changeEmailButton.Text = "Change";
            this.changeEmailButton.UseVisualStyleBackColor = true;
            this.changeEmailButton.Click += new System.EventHandler(this.changeEmailButton_Click);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(174, 81);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(325, 20);
            this.emailBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // emailChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 208);
            this.Controls.Add(this.groupBox2);
            this.Name = "emailChangeWindow";
            this.Text = "Change Email Address";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changeEmailButton;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox currentPasswordBox;
        private System.Windows.Forms.Label label1;

    }
}