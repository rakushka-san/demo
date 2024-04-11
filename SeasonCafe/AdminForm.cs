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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SeasonCafe
{
    public partial class AdminForm : Form
    {
        public Staff user;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fillOrdersTable();
            fillStaffTable();
            fillShiftsTable();
        }

        private void fillOrdersTable()
        {
            List<Order> orders = SeasonDB.getOrders();
            int rowIndex = 0;

            foreach (Order order in orders)
            {
                ordersDataGridView.Rows.Add();
                ordersDataGridView.Rows[rowIndex].Cells[0].Value = order.date;
                ordersDataGridView.Rows[rowIndex].Cells[1].Value = order.time;
                ordersDataGridView.Rows[rowIndex].Cells[2].Value = order.table;
                ordersDataGridView.Rows[rowIndex].Cells[3].Value = order.clientsAmount;
                ordersDataGridView.Rows[rowIndex].Cells[4].Value = order.order;
                ordersDataGridView.Rows[rowIndex].Cells[5].Value = order.status;

                rowIndex++;
            }
        }

        private void fillStaffTable()
        {
            List<Staff> staff = SeasonDB.getStaff();
            int rowIndex = 0;

            foreach (Staff staffElement in staff)
            {
                staffDataGridView.Rows.Add();
                staffDataGridView.Rows[rowIndex].Cells[0].Value = staffElement.id;
                staffDataGridView.Rows[rowIndex].Cells[1].Value = staffElement.surname;
                staffDataGridView.Rows[rowIndex].Cells[2].Value = staffElement.firstname;
                staffDataGridView.Rows[rowIndex].Cells[3].Value = staffElement.role;
                staffDataGridView.Rows[rowIndex].Cells[4].Value = staffElement.status;
                staffDataGridView.Rows[rowIndex].Cells[5].Value = staffElement.login;
                staffDataGridView.Rows[rowIndex].Cells[6].Value = staffElement.password;
                rowIndex++;
            }
        }

        private void fillShiftsTable()
        {
            List<Shift> shifts = SeasonDB.getShifts();
            int rowIndex = 0;

            foreach (Shift shift in shifts)
            {
                shiftsDataGridView.Rows.Add();
                shiftsDataGridView.Rows[rowIndex].Cells[0].Value = shift.id;
                shiftsDataGridView.Rows[rowIndex].Cells[1].Value = shift.date;
                shiftsDataGridView.Rows[rowIndex].Cells[2].Value = shift.start;
                shiftsDataGridView.Rows[rowIndex].Cells[3].Value = shift.end;

                string staffString = "";

                foreach (Staff staff in shift.staff)
                {
                    staffString += $"{staff.surname} {staff.firstname} ({staff.role}) \n";
                }

                shiftsDataGridView.Rows[rowIndex].Cells[4].Value = staffString;
                rowIndex++;
            }
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaffForm addStaffForm = new AddStaffForm();
            addStaffForm.ShowDialog();
            staffDataGridView.Rows.Clear();
            fillStaffTable();
        }

        private void updateStaffButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < staffDataGridView.Rows.Count - 1; i++)
            {
                int id = Convert.ToInt32(staffDataGridView.Rows[i].Cells[0].Value.ToString());
                string surname = staffDataGridView.Rows[i].Cells[1].Value.ToString();
                string firstname = staffDataGridView.Rows[i].Cells[2].Value.ToString();
                string role = staffDataGridView.Rows[i].Cells[3].Value.ToString();
                string status = staffDataGridView.Rows[i].Cells[4].Value.ToString();
                string login = staffDataGridView.Rows[i].Cells[5].Value.ToString();
                string password = staffDataGridView.Rows[i].Cells[6].Value.ToString();

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

                Staff staff = new Staff(id, firstname, surname, role, status, login, password);
                SeasonDB.updateStaff(staff);
            }

            MessageBox.Show("Сохранено");
        }

        private void addShiftButton_Click(object sender, EventArgs e)
        {
            AddShiftForm addShiftForm = new AddShiftForm();
            addShiftForm.ShowDialog();
            shiftsDataGridView.Rows.Clear();
            fillShiftsTable();
        }

        private void assignStaffButton_Click(object sender, EventArgs e)
        {
            if (shiftsDataGridView.SelectedRows.Count != 1) 
            {
                MessageBox.Show("Для назначения персонала выделите одну строку со сменой");
            }
            int shiftId = Convert.ToInt32(shiftsDataGridView.SelectedRows[0].Cells[0].Value.ToString());

            AssignStaffForm assignStaffForm = new AssignStaffForm(shiftId);
            assignStaffForm.ShowDialog();
            shiftsDataGridView.Rows.Clear();
            fillShiftsTable();
        }
    }
}
