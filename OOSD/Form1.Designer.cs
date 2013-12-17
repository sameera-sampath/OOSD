namespace OOSD
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.loginLabel = new System.Windows.Forms.Label();
            this.userAccountButton = new System.Windows.Forms.Button();
            this.lendReturnButton = new System.Windows.Forms.Button();
            this.catologButton = new System.Windows.Forms.Button();
            this.circulationButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.SystemColors.Control;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Maroon;
            this.loginLabel.Location = new System.Drawing.Point(410, 219);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(125, 13);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Please LogIn to continue";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // userAccountButton
            // 
            this.userAccountButton.AutoSize = true;
            this.userAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.userAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAccountButton.ForeColor = System.Drawing.Color.Navy;
            this.userAccountButton.Image = global::OOSD.Properties.Resources.Custom_Icon_Design_Pretty_Office_11_Logout;
            this.userAccountButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userAccountButton.Location = new System.Drawing.Point(413, 94);
            this.userAccountButton.Name = "userAccountButton";
            this.userAccountButton.Size = new System.Drawing.Size(153, 38);
            this.userAccountButton.TabIndex = 12;
            this.userAccountButton.Text = "User Account";
            this.userAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userAccountButton.UseVisualStyleBackColor = false;
            this.userAccountButton.Visible = false;
            this.userAccountButton.Click += new System.EventHandler(this.userAccountButton_Click);
            // 
            // lendReturnButton
            // 
            this.lendReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lendReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lendReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lendReturnButton.ForeColor = System.Drawing.Color.Navy;
            this.lendReturnButton.Image = global::OOSD.Properties.Resources.Visualpharm_Icons8_Metro_Style_Sciences_Classes_Literature;
            this.lendReturnButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lendReturnButton.Location = new System.Drawing.Point(26, 166);
            this.lendReturnButton.Name = "lendReturnButton";
            this.lendReturnButton.Size = new System.Drawing.Size(153, 38);
            this.lendReturnButton.TabIndex = 10;
            this.lendReturnButton.Text = "Lending\r\nReturning";
            this.lendReturnButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lendReturnButton.UseVisualStyleBackColor = false;
            this.lendReturnButton.Visible = false;
            this.lendReturnButton.Click += new System.EventHandler(this.lendReturnButton_Click);
            // 
            // catologButton
            // 
            this.catologButton.AutoSize = true;
            this.catologButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.catologButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.catologButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.catologButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catologButton.ForeColor = System.Drawing.Color.Navy;
            this.catologButton.Image = global::OOSD.Properties.Resources.Carlosjj_Google_Jfk_Catalogs;
            this.catologButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catologButton.Location = new System.Drawing.Point(28, 94);
            this.catologButton.Name = "catologButton";
            this.catologButton.Size = new System.Drawing.Size(151, 38);
            this.catologButton.TabIndex = 8;
            this.catologButton.Text = "Cataloge";
            this.catologButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.catologButton.UseVisualStyleBackColor = false;
            this.catologButton.Click += new System.EventHandler(this.catologButton_Click);
            // 
            // circulationButton
            // 
            this.circulationButton.AutoSize = true;
            this.circulationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.circulationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.circulationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circulationButton.ForeColor = System.Drawing.Color.Navy;
            this.circulationButton.Image = global::OOSD.Properties.Resources.Deleket_Soft_Scraps_Button_Talk_Balloon;
            this.circulationButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.circulationButton.Location = new System.Drawing.Point(223, 94);
            this.circulationButton.Name = "circulationButton";
            this.circulationButton.Size = new System.Drawing.Size(151, 38);
            this.circulationButton.TabIndex = 7;
            this.circulationButton.Text = "Circulations";
            this.circulationButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.circulationButton.UseVisualStyleBackColor = false;
            this.circulationButton.Click += new System.EventHandler(this.circulationButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.AutoSize = true;
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.Navy;
            this.adminButton.Image = global::OOSD.Properties.Resources.Designcontest_Ecommerce_Business_Admin;
            this.adminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.Location = new System.Drawing.Point(223, 166);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(153, 38);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "Adminstration";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.Navy;
            this.searchButton.Image = global::OOSD.Properties.Resources.Treetog_I_Search;
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchButton.Location = new System.Drawing.Point(223, 24);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 38);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.AutoSize = true;
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reportsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.Navy;
            this.reportsButton.Image = global::OOSD.Properties.Resources.Louie_Mantia_Monsters_Inc_MI_Scare_Report;
            this.reportsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.Location = new System.Drawing.Point(413, 166);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(153, 38);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "Reports";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Visible = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsBuon_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Navy;
            this.loginButton.Image = global::OOSD.Properties.Resources.Aha_Soft_Security_Secrecy;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(28, 24);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(151, 38);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Navy;
            this.closeButton.Image = global::OOSD.Properties.Resources.Double_J_Design_Super_Mono_3d_Button_round_cancel;
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Location = new System.Drawing.Point(413, 24);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(153, 38);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.close_Click);
            // 
            // MainWindow
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 253);
            this.Controls.Add(this.userAccountButton);
            this.Controls.Add(this.lendReturnButton);
            this.Controls.Add(this.catologButton);
            this.Controls.Add(this.circulationButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.reportsButton);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.closeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        public System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.Button circulationButton;
        public System.Windows.Forms.Button catologButton;
        private System.Windows.Forms.Label loginLabel;
        public System.Windows.Forms.Button reportsButton;
        public System.Windows.Forms.Button adminButton;
        public System.Windows.Forms.Button lendReturnButton;
        public System.Windows.Forms.Button userAccountButton;






    }
}

