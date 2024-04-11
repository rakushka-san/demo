namespace SeasonCafe
{
    partial class AdminForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminTabControl = new System.Windows.Forms.TabControl();
            this.ordersTab = new System.Windows.Forms.TabPage();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientsAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffTab = new System.Windows.Forms.TabPage();
            this.updateStaffButton = new System.Windows.Forms.Button();
            this.addStaffButton = new System.Windows.Forms.Button();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PasswordCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftsTab = new System.Windows.Forms.TabPage();
            this.assignStaffButton = new System.Windows.Forms.Button();
            this.addShiftButton = new System.Windows.Forms.Button();
            this.shiftsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminTabControl.SuspendLayout();
            this.ordersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.staffTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.shiftsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminTabControl
            // 
            this.adminTabControl.Controls.Add(this.ordersTab);
            this.adminTabControl.Controls.Add(this.staffTab);
            this.adminTabControl.Controls.Add(this.shiftsTab);
            this.adminTabControl.Location = new System.Drawing.Point(12, 117);
            this.adminTabControl.Name = "adminTabControl";
            this.adminTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminTabControl.SelectedIndex = 0;
            this.adminTabControl.Size = new System.Drawing.Size(776, 396);
            this.adminTabControl.TabIndex = 0;
            // 
            // ordersTab
            // 
            this.ordersTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ordersTab.Controls.Add(this.ordersDataGridView);
            this.ordersTab.Location = new System.Drawing.Point(4, 22);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ordersTab.Size = new System.Drawing.Size(768, 370);
            this.ordersTab.TabIndex = 0;
            this.ordersTab.Text = "Заказы";
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Table,
            this.ClientsAmount,
            this.Order,
            this.Status});
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.ordersDataGridView.Enabled = false;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(762, 333);
            this.ordersDataGridView.TabIndex = 0;
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
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // staffTab
            // 
            this.staffTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.staffTab.Controls.Add(this.updateStaffButton);
            this.staffTab.Controls.Add(this.addStaffButton);
            this.staffTab.Controls.Add(this.staffDataGridView);
            this.staffTab.Location = new System.Drawing.Point(4, 22);
            this.staffTab.Name = "staffTab";
            this.staffTab.Padding = new System.Windows.Forms.Padding(3);
            this.staffTab.Size = new System.Drawing.Size(768, 370);
            this.staffTab.TabIndex = 1;
            this.staffTab.Text = "Сотрудники";
            // 
            // updateStaffButton
            // 
            this.updateStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.updateStaffButton.Location = new System.Drawing.Point(597, 342);
            this.updateStaffButton.Name = "updateStaffButton";
            this.updateStaffButton.Size = new System.Drawing.Size(165, 23);
            this.updateStaffButton.TabIndex = 3;
            this.updateStaffButton.Text = "Сохранить";
            this.updateStaffButton.UseVisualStyleBackColor = false;
            this.updateStaffButton.Click += new System.EventHandler(this.updateStaffButton_Click);
            // 
            // addStaffButton
            // 
            this.addStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.addStaffButton.Location = new System.Drawing.Point(6, 342);
            this.addStaffButton.Name = "addStaffButton";
            this.addStaffButton.Size = new System.Drawing.Size(165, 23);
            this.addStaffButton.TabIndex = 2;
            this.addStaffButton.Text = "Добавить сотрудника";
            this.addStaffButton.UseVisualStyleBackColor = false;
            this.addStaffButton.Click += new System.EventHandler(this.addStaffButton_Click);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.staffDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.PasswordCol});
            this.staffDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.staffDataGridView.Location = new System.Drawing.Point(3, 3);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(762, 333);
            this.staffDataGridView.TabIndex = 1;
            // 
            // idColumn
            // 
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Имя";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Роль";
            this.dataGridViewTextBoxColumn2.Items.AddRange(new object[] {
            "Администратор",
            "Официант",
            "Повар"});
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn3.Items.AddRange(new object[] {
            "Работает",
            "Уволен"});
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // PasswordCol
            // 
            this.PasswordCol.HeaderText = "Пароль";
            this.PasswordCol.Name = "PasswordCol";
            this.PasswordCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // shiftsTab
            // 
            this.shiftsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.shiftsTab.Controls.Add(this.assignStaffButton);
            this.shiftsTab.Controls.Add(this.addShiftButton);
            this.shiftsTab.Controls.Add(this.shiftsDataGridView);
            this.shiftsTab.Location = new System.Drawing.Point(4, 22);
            this.shiftsTab.Name = "shiftsTab";
            this.shiftsTab.Padding = new System.Windows.Forms.Padding(3);
            this.shiftsTab.Size = new System.Drawing.Size(768, 370);
            this.shiftsTab.TabIndex = 2;
            this.shiftsTab.Text = "Смены";
            // 
            // assignStaffButton
            // 
            this.assignStaffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.assignStaffButton.Location = new System.Drawing.Point(597, 341);
            this.assignStaffButton.Name = "assignStaffButton";
            this.assignStaffButton.Size = new System.Drawing.Size(165, 23);
            this.assignStaffButton.TabIndex = 4;
            this.assignStaffButton.Text = "Назначить персонал";
            this.assignStaffButton.UseVisualStyleBackColor = false;
            this.assignStaffButton.Click += new System.EventHandler(this.assignStaffButton_Click);
            // 
            // addShiftButton
            // 
            this.addShiftButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(51)))));
            this.addShiftButton.Location = new System.Drawing.Point(6, 342);
            this.addShiftButton.Name = "addShiftButton";
            this.addShiftButton.Size = new System.Drawing.Size(165, 23);
            this.addShiftButton.TabIndex = 3;
            this.addShiftButton.Text = "Добавить смену";
            this.addShiftButton.UseVisualStyleBackColor = false;
            this.addShiftButton.Click += new System.EventHandler(this.addShiftButton_Click);
            // 
            // shiftsDataGridView
            // 
            this.shiftsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.shiftsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.shiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.shiftsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.shiftsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.shiftsDataGridView.Name = "shiftsDataGridView";
            this.shiftsDataGridView.Size = new System.Drawing.Size(762, 333);
            this.shiftsDataGridView.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Начало";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Конец";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 300F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Персонал";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.InitialImage = global::SeasonCafe.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 111);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminTabControl);
            this.MinimumSize = new System.Drawing.Size(816, 563);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.adminTabControl.ResumeLayout(false);
            this.ordersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.staffTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.shiftsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminTabControl;
        private System.Windows.Forms.TabPage ordersTab;
        private System.Windows.Forms.TabPage staffTab;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button addStaffButton;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.TabPage shiftsTab;
        private System.Windows.Forms.Button addShiftButton;
        private System.Windows.Forms.DataGridView shiftsDataGridView;
        private System.Windows.Forms.Button updateStaffButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordCol;
        private System.Windows.Forms.Button assignStaffButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

