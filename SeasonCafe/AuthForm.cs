using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeasonCafe
{
    public partial class AuthForm : Form
    {
        private SqliteConnection connection;
        private SqliteCommand command;

        public AuthForm()
        {
            InitializeComponent();
            CreateTables();
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Staff user = SeasonDB.Auth(login, password);

            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            switch (user.role) 
            {
                case "Администратор":
                    AdminForm adminForm = new AdminForm();
                    adminForm.user = user;
                    Hide();
                    adminForm.ShowDialog();
                    Close();
                    return;
                case "Официант":
                    WaiterForm waiterForm = new WaiterForm();
                    waiterForm.user = user;
                    Hide();
                    waiterForm.ShowDialog();
                    Close();
                    return;
                case "Повар":
                    CookForm cookForm = new CookForm();
                    cookForm.user = user;
                    Hide();
                    cookForm.ShowDialog();
                    Close();
                    return;
            }
        }

        private void CreateTables()
        {
            SeasonDB.createOrderTable();
            SeasonDB.createStaffTable();
            SeasonDB.createShiftTable();
            SeasonDB.createStaffShiftTable();
        }
    }
}
