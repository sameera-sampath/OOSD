namespace OOSD
{
    partial class removeUserWindow
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
            this.removeUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.removeUserText = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeUser);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.removeUserText);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 160);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove Users";
            // 
            // removeUser
            // 
            this.removeUser.AutoSize = true;
            this.removeUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.removeUser.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.removeUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.removeUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeUser.ForeColor = System.Drawing.Color.Navy;
            this.removeUser.Image = global::OOSD.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_list_remove_user;
            this.removeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeUser.Location = new System.Drawing.Point(163, 104);
            this.removeUser.Name = "removeUser";
            this.removeUser.Size = new System.Drawing.Size(121, 38);
            this.removeUser.TabIndex = 14;
            this.removeUser.Text = "Done";
            this.removeUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removeUser.UseVisualStyleBackColor = false;
            this.removeUser.Click += new System.EventHandler(this.removeUser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "User ID";
            // 
            // removeUserText
            // 
            this.removeUserText.Location = new System.Drawing.Point(163, 34);
            this.removeUserText.Name = "removeUserText";
            this.removeUserText.Size = new System.Drawing.Size(121, 20);
            this.removeUserText.TabIndex = 1;
            // 
            // removeUserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 182);
            this.Controls.Add(this.groupBox2);
            this.Name = "removeUserWindow";
            this.Text = "Remove User";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox removeUserText;
    }
}