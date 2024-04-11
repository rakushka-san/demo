namespace SeasonCafe
{
    partial class WaiterForm
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
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.updateOrdersButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminTabControl.SuspendLayout();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.ordersTab);
            this.adminTabControl.Location = new System.Drawing.Point(12, 117);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(776, 395);
            this.adminTabControl.TabIndex = 2;
            // 
            // ordersTab
            // 
            this.ordersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ordersTab.Controls.Add(this.ordersDataGridView);
            this.ordersTab.Controls.Add(this.addOrderButton);
            this.ordersTab.Controls.Add(this.updateOrdersButton);
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(768, 369);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.Text = "Заказы";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Table,
            this.ClientsAmount,
            this.Order,
            this.Status});
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(762, 333);
            this.ordersDataGridView.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Время";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Table
            // 
            this.Table.HeaderText = "Столик";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            // 
            // ClientsAmount
            // 
            this.ClientsAmount.HeaderText = "Количество клиентов";
            this.ClientsAmount.Name = "ClientsAmount";
            this.ClientsAmount.ReadOnly = true;
            // 
            // Order
            // 
            this.Order.HeaderText = "Заказ";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Items.AddRange(new object[] {
            "Принят",
            "Готовится",
            "Готов",
            "Оплачен"});
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addOrderButton
            // 
            this.addOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.addOrderButton.Location = new System.Drawing.Point(6, 342);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(165, 23);
            this.addOrderButton.TabIndex = 5;
            this.addOrderButton.Text = "Добавить заказ";
            this.addOrderButton.UseVisualStyleBackColor = false;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // updateOrdersButton
            // 
            this.updateOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.updateOrdersButton.Location = new System.Drawing.Point(597, 342);
            this.updateOrdersButton.Name = "updateOrdersButton";
            this.updateOrdersButton.Size = new System.Drawing.Size(165, 23);
            this.updateOrdersButton.TabIndex = 4;
            this.updateOrdersButton.Text = "Сохранить";
            this.updateOrdersButton.UseVisualStyleBackColor = false;
            this.updateOrdersButton.Click += new System.EventHandler(this.updateOrdersButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 111);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // WaiterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.adminTabControl);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(816, 558);
            this.Name = "WaiterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Официант";
            this.Load += new System.EventHandler(this.WaiterForm_Load);
            this.adminTabControl.ResumeLayout(false);
            this.ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.Button updateOrdersButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
    }
}