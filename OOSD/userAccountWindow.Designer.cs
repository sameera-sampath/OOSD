namespace OOSD
{
    partial class userAccountWindow
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
            this.passwordButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.borrowHistryButton = new System.Windows.Forms.Button();
            this.viewReservationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordButton
            // 
            this.passwordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.passwordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordButton.Location = new System.Drawing.Point(35, 112);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(123, 35);
            this.passwordButton.TabIndex = 5;
            this.passwordButton.Text = "Change Password";
            this.passwordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordButton.UseVisualStyleBackColor = false;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // emailButton
            // 
            this.emailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.emailButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailButton.Location = new System.Drawing.Point(222, 112);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(123, 35);
            this.emailButton.TabIndex = 6;
            this.emailButton.Text = "Change Email Address";
            this.emailButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.emailButton.UseVisualStyleBackColor = false;
            this.emailButton.Click += new System.EventHandler(this.emailButton_Click);
            // 
            // borrowHistryButton
            // 
            this.borrowHistryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.borrowHistryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowHistryButton.Location = new System.Drawing.Point(222, 30);
            this.borrowHistryButton.Name = "borrowHistryButton";
            this.borrowHistryButton.Size = new System.Drawing.Size(123, 35);
            this.borrowHistryButton.TabIndex = 7;
            this.borrowHistryButton.Text = "View History";
            this.borrowHistryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.borrowHistryButton.UseVisualStyleBackColor = false;
            this.borrowHistryButton.Click += new System.EventHandler(this.borrowHistryButton_Click);
            // 
            // viewReservationsButton
            // 
            this.viewReservationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.viewReservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewReservationsButton.Location = new System.Drawing.Point(35, 30);
            this.viewReservationsButton.Name = "viewReservationsButton";
            this.viewReservationsButton.Size = new System.Drawing.Size(123, 35);
            this.viewReservationsButton.TabIndex = 8;
            this.viewReservationsButton.Text = "View Reservations";
            this.viewReservationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewReservationsButton.UseVisualStyleBackColor = false;
            this.viewReservationsButton.Click += new System.EventHandler(this.viewReservationsButton_Click);
            // 
            // userAccountWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 201);
            this.Controls.Add(this.viewReservationsButton);
            this.Controls.Add(this.borrowHistryButton);
            this.Controls.Add(this.emailButton);
            this.Controls.Add(this.passwordButton);
            this.Name = "userAccountWindow";
            this.Text = "User Account";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button borrowHistryButton;
        private System.Windows.Forms.Button viewReservationsButton;
    }
}