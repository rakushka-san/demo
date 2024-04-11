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
    public partial class AddStaffForm : Form
    {
        public AddStaffForm()
        {
            InitializeComponent();
            statusComboBox.Text = "Работает";
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            string firstname = firstnameTextBox.Text;
            string surname = surnameTextBox.Text;
            string role = roleComboBox.Text;
            string status = statusComboBox.Text;
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(firstname) || 
                string.IsNullOrEmpty(surname) || 
                string.IsNullOrEmpty(role) || 
                string.IsNullOrEmpty(status) || 
                string.IsNullOrEmpty(login) || 
                string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Staff staff = new Staff(firstname, surname, role, status, login, password);
            SeasonDB.createStaff(staff);
            MessageBox.Show("Пользователь добавлен");
            Close();
        }
    }
}
