namespace OOSD
{
    partial class viewReservationsWindow
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.remainingReservationsBox = new System.Windows.Forms.TextBox();
            this.currentReservationsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.remainingReservationsBox);
            this.groupBox4.Controls.Add(this.currentReservationsBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(572, 310);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reservations";
            // 
            // remainingReservationsBox
            // 
            this.remainingReservationsBox.Location = new System.Drawing.Point(218, 249);
            this.remainingReservationsBox.Name = "remainingReservationsBox";
            this.remainingReservationsBox.ReadOnly = true;
            this.remainingReservationsBox.Size = new System.Drawing.Size(100, 20);
            this.remainingReservationsBox.TabIndex = 4;
            // 
            // currentReservationsBox
            // 
            this.currentReservationsBox.Location = new System.Drawing.Point(218, 214);
            this.currentReservationsBox.Name = "currentReservationsBox";
            this.currentReservationsBox.ReadOnly = true;
            this.currentReservationsBox.Size = new System.Drawing.Size(100, 20);
            this.currentReservationsBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remaining Reservations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Reservations";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(498, 178);
            this.dataGridView2.TabIndex = 0;
            // 
            // viewReservationsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 334);
            this.Controls.Add(this.groupBox4);
            this.Name = "viewReservationsWindow";
            this.Text = "Current Reservations";
            this.Load += new System.EventHandler(this.viewReservationsWindow_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox remainingReservationsBox;
        private System.Windows.Forms.TextBox currentReservationsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}