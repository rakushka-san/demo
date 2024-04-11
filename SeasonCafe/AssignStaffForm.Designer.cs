namespace SeasonCafe
{
    partial class AssignStaffForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.assignStaffButton = new System.Windows.Forms.Button();
            this.staffOnShiftCheckedListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 119);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // assignStaffButton
            // 
            this.assignStaffButton.AutoSize = true;
            this.assignStaffButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.assignStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.assignStaffButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.assignStaffButton.Location = new System.Drawing.Point(0, 427);
            this.assignStaffButton.Name = "assignStaffButton";
            this.assignStaffButton.Size = new System.Drawing.Size(800, 23);
            this.assignStaffButton.TabIndex = 13;
            this.assignStaffButton.Text = "Сохранить";
            this.assignStaffButton.UseVisualStyleBackColor = false;
            this.assignStaffButton.Click += new System.EventHandler(this.assignStaffButton_Click);
            // 
            // staffOnShiftCheckedListBox
            // 
            this.staffOnShiftCheckedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.staffOnShiftCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffOnShiftCheckedListBox.FormattingEnabled = true;
            this.staffOnShiftCheckedListBox.Location = new System.Drawing.Point(0, 119);
            this.staffOnShiftCheckedListBox.Name = "staffOnShiftCheckedListBox";
            this.staffOnShiftCheckedListBox.Size = new System.Drawing.Size(800, 308);
            this.staffOnShiftCheckedListBox.TabIndex = 14;
            // 
            // AssignStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.staffOnShiftCheckedListBox);
            this.Controls.Add(this.assignStaffButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AssignStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignStaffForm";
            this.Load += new System.EventHandler(this.AssignStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button assignStaffButton;
        private System.Windows.Forms.CheckedListBox staffOnShiftCheckedListBox;
    }
}