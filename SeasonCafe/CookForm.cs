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
    public partial class CookForm : Form
    {
        public Staff user;
        public CookForm()
        {
            InitializeComponent();
        }

        private void CookForm_Load(object sender, EventArgs e)
        {
            fillOrdersTable();
        }

        private void updateOrdersButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ordersDataGridView.Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[0].Value.ToString());
                string date = ordersDataGridView.Rows[i].Cells[1].Value.ToString();
                string time = ordersDataGridView.Rows[i].Cells[2].Value.ToString();
                string table = ordersDataGridView.Rows[i].Cells[3].Value.ToString();
                int clientsAmount = Convert.ToInt32(ordersDataGridView.Rows[i].Cells[4].Value.ToString());
                string orderText = ordersDataGridView.Rows[i].Cells[5].Value.ToString();
                string status = ordersDataGridView.Rows[i].Cells[6].Value.ToString();

                if (string.IsNullOrEmpty(date) ||
                string.IsNullOrEmpty(time) ||
                string.IsNullOrEmpty(table) ||
                string.IsNullOrEmpty(orderText) ||
                string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Заполните все поля");
                    return;
                }

                Order order = new Order(id, table, clientsAmount, orderText, status, date, time);
                SeasonDB.updateOrder(order);
            }

            MessageBox.Show("Сохранено");
        }

        private void fillOrdersTable()
        {
            List<Order> orders = SeasonDB.getCurrentOrders();
            int rowIndex = 0;

            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add();
                ordersDataGridView.Rows[rowIndex].Cells[0].Value = order.id;
                ordersDataGridView.Rows[rowIndex].Cells[1].Value = order.date;
                ordersDataGridView.Rows[rowIndex].Cells[2].Value = order.time;
                ordersDataGridView.Rows[rowIndex].Cells[3].Value = order.table;
                ordersDataGridView.Rows[rowIndex].Cells[4].Value = order.clientsAmount;
                ordersDataGridView.Rows[rowIndex].Cells[5].Value = order.order;
                ordersDataGridView.Rows[rowIndex].Cells[6].Value = order.status;

                rowIndex++;
            }
        }
    }
}
