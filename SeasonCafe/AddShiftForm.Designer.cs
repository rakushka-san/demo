namespace SeasonCafe
{
    partial class AddShiftForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shiftStartTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shiftDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.shiftEndTextBox = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addShiftButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.shiftStartTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.shiftDateDateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.shiftEndTextBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 179);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // shiftStartTextBox
            // 
            this.shiftStartTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftStartTextBox.Location = new System.Drawing.Point(80, 29);
            this.shiftStartTextBox.Mask = "00:00";
            this.shiftStartTextBox.Name = "shiftStartTextBox";
            this.shiftStartTextBox.Size = new System.Drawing.Size(175, 20);
            this.shiftStartTextBox.TabIndex = 20;
            this.shiftStartTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Начало";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Конец";
            // 
            // shiftDateDateTimePicker
            // 
            this.shiftDateDateTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.shiftDateDateTimePicker.Location = new System.Drawing.Point(80, 3);
            this.shiftDateDateTimePicker.Name = "shiftDateDateTimePicker";
            this.shiftDateDateTimePicker.Size = new System.Drawing.Size(175, 20);
            this.shiftDateDateTimePicker.TabIndex = 17;
            // 
            // shiftEndTextBox
            // 
            this.shiftEndTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shiftEndTextBox.Location = new System.Drawing.Point(80, 55);
            this.shiftEndTextBox.Mask = "00:00";
            this.shiftEndTextBox.Name = "shiftEndTextBox";
            this.shiftEndTextBox.Size = new System.Drawing.Size(175, 20);
            this.shiftEndTextBox.TabIndex = 19;
            this.shiftEndTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 119);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // addShiftButton
            // 
            this.addShiftButton.AutoSize = true;
            this.addShiftButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addShiftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.addShiftButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addShiftButton.Location = new System.Drawing.Point(0, 275);
            this.addShiftButton.Name = "addShiftButton";
            this.addShiftButton.Size = new System.Drawing.Size(258, 23);
            this.addShiftButton.TabIndex = 14;
            this.addShiftButton.Text = "Добавить смену";
            this.addShiftButton.UseVisualStyleBackColor = false;
            this.addShiftButton.Click += new System.EventHandler(this.addShiftButton_Click);
            // 
            // AddShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(258, 298);
            this.Controls.Add(this.addShiftButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(274, 337);
            this.Name = "AddShiftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddShiftForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker shiftDateDateTimePicker;
        private System.Windows.Forms.Button addShiftButton;
        private System.Windows.Forms.MaskedTextBox shiftStartTextBox;
        private System.Windows.Forms.MaskedTextBox shiftEndTextBox;
    }
}