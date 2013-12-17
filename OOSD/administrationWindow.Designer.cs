namespace OOSD
{
    partial class administrationWindow
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
            this.addUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.suspendUserButton = new System.Windows.Forms.Button();
            this.passwordResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addUserButton.Location = new System.Drawing.Point(12, 12);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(151, 46);
            this.addUserButton.TabIndex = 16;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.d_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.removeUserButton.Location = new System.Drawing.Point(12, 85);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(151, 46);
            this.removeUserButton.TabIndex = 17;
            this.removeUserButton.Text = "Remove User";
            this.removeUserButton.UseVisualStyleBackColor = false;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // suspendUserButton
            // 
            this.suspendUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.suspendUserButton.Location = new System.Drawing.Point(213, 85);
            this.suspendUserButton.Name = "suspendUserButton";
            this.suspendUserButton.Size = new System.Drawing.Size(151, 46);
            this.suspendUserButton.TabIndex = 18;
            this.suspendUserButton.Text = "Suspend User";
            this.suspendUserButton.UseVisualStyleBackColor = false;
            this.suspendUserButton.Click += new System.EventHandler(this.suspendUserButton_Click);
            // 
            // passwordResetButton
            // 
            this.passwordResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passwordResetButton.Location = new System.Drawing.Point(213, 12);
            this.passwordResetButton.Name = "passwordResetButton";
            this.passwordResetButton.Size = new System.Drawing.Size(151, 46);
            this.passwordResetButton.TabIndex = 19;
            this.passwordResetButton.Text = "Password Reset";
            this.passwordResetButton.UseVisualStyleBackColor = false;
            this.passwordResetButton.Click += new System.EventHandler(this.passwordResetButton_Click);
            // 
            // administrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 144);
            this.Controls.Add(this.passwordResetButton);
            this.Controls.Add(this.suspendUserButton);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.addUserButton);
            this.Name = "administrationWindow";
            this.Text = "Administration";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button suspendUserButton;
        private System.Windows.Forms.Button passwordResetButton;
    }
}