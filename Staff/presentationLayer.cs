using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entityLayer;
using dataAccessLayer;
using logicLayer;

namespace Staff
{
    public partial class presentationLayer : Form
    {
        public presentationLayer()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<entityStaff> list = logicStaff.list();
            dataGridView1.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            entityStaff entityStaff = new entityStaff();
            entityStaff.StaffName = txtName.Text;
            entityStaff.StaffSurname = txtSurname.Text;
            entityStaff.StaffDepartment = txtDepartment.Text;
            entityStaff.StaffCity = txtCity.Text;
            entityStaff.StaffSalary = short.Parse(txtSalary.Text);
            logicLayer.logicStaff.save(entityStaff);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            entityStaff entityStaff = new entityStaff();
            entityStaff.StaffId = int.Parse(txtId.Text);
            logicLayer.logicStaff.delete(entityStaff);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            entityStaff entityStaff = new entityStaff();
            entityStaff.StaffId = int.Parse(txtId.Text);
            entityStaff.StaffName = txtName.Text;
            entityStaff.StaffSurname = txtSurname.Text;
            entityStaff.StaffDepartment = txtDepartment.Text;
            entityStaff.StaffCity = txtCity.Text;
            entityStaff.StaffSalary = short.Parse(txtSalary.Text);
            logicLayer.logicStaff.update(entityStaff);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
