namespace OOSD
{
    partial class Reservation
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
            this.reserve = new System.Windows.Forms.Button();
            this.title_text = new System.Windows.Forms.TextBox();
            this.user_text = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.user_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reserve
            // 
            this.reserve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reserve.Location = new System.Drawing.Point(80, 104);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(75, 23);
            this.reserve.TabIndex = 0;
            this.reserve.Text = "Reserve";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // title_text
            // 
            this.title_text.Location = new System.Drawing.Point(99, 9);
            this.title_text.Multiline = true;
            this.title_text.Name = "title_text";
            this.title_text.Size = new System.Drawing.Size(156, 28);
            this.title_text.TabIndex = 1;
            // 
            // user_text
            // 
            this.user_text.Location = new System.Drawing.Point(99, 58);
            this.user_text.Multiline = true;
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(156, 30);
            this.user_text.TabIndex = 2;
            this.user_text.Visible = false;
            // 
            // title_label
            // 
            this.title_label.Location = new System.Drawing.Point(12, 12);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(87, 28);
            this.title_label.TabIndex = 3;
            this.title_label.Text = "Book Title ID";
            // 
            // user_label
            // 
            this.user_label.Location = new System.Drawing.Point(12, 61);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(87, 27);
            this.user_label.TabIndex = 4;
            this.user_label.Text = "User Name";
            this.user_label.Visible = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 150);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.title_text);
            this.Controls.Add(this.reserve);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.TextBox title_text;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Label user_label;
    }
}