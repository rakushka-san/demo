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
    public partial class AddShiftForm : Form
    {
        public AddShiftForm()
        {
            InitializeComponent();
        }

        private void addShiftButton_Click(object sender, EventArgs e)
        {
            string date = shiftDateDateTimePicker.Text;
            string start = shiftStartTextBox.Text;
            string end = shiftEndTextBox.Text;

            if (string.IsNullOrEmpty(date) ||
                string.IsNullOrEmpty(start) ||
                string.IsNullOrEmpty(end))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            Shift shift = new Shift(date, start, end);
            SeasonDB.createShift(shift);
            MessageBox.Show("Смена добавлена");
            Close();
        }
    }
}
