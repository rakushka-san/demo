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
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            string table = tableTextBox.Text;
            int clientsAmount = Convert.ToInt32(clientsAmountTextBox.Text);
            string orderText = orderTextBox.Text;
            string status = "Принят";

            DateTime currentDateTime = DateTime.Now;
            string date = currentDateTime.Date.ToShortDateString();
            string time = $"{currentDateTime.TimeOfDay.Hours}:{currentDateTime.TimeOfDay.Minutes}";

            if (string.IsNullOrEmpty(table) ||
                string.IsNullOrEmpty(orderText))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Order order = new Order(table, clientsAmount, orderText, status, date, time);
            SeasonDB.createOrder(order);
            MessageBox.Show("Заказ добавлен");
            Close();
        }
    }
}
