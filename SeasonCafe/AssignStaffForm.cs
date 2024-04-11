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
    public partial class AssignStaffForm : Form
    {
        private int shiftId { get; set; }
        private List<Staff> allStaff;

        public AssignStaffForm(int shiftId)
        {
            this.shiftId = shiftId;
            this.allStaff = SeasonDB.getStaff();
            InitializeComponent();
            fillCheckedListBox();
        }

        private void AssignStaffForm_Load(object sender, EventArgs e)
        {

        }

        private void fillCheckedListBox()
        {

            List<Staff> staffOnShift = SeasonDB.getShiftStaff(shiftId);

            int staffIndex = 0;
            foreach (Staff staff in allStaff)
            {
                staffOnShiftCheckedListBox.Items.Add($"{staff.surname} {staff.firstname} ({staff.role})");

                if (staffOnShift.FindIndex((staffOnShiftElement) => staffOnShiftElement.id == staff.id) != -1)
                {
                    staffOnShiftCheckedListBox.SetItemCheckState(staffIndex, CheckState.Checked);
                }

                staffIndex++;
            }
        }

        private void assignStaffButton_Click(object sender, EventArgs e)
        {
            SeasonDB.clearShiftStaff(shiftId);

            List<Staff> staffToAssign = new List<Staff>();

            foreach (int index in staffOnShiftCheckedListBox.CheckedIndices)
            {
                staffToAssign.Add(allStaff[index]);
            }

            foreach (Staff staff in staffToAssign)
            {
                SeasonDB.createStaffShift(staff.id, shiftId);
            }

            MessageBox.Show("Сохранено");
            Close();
        }
    }
}
