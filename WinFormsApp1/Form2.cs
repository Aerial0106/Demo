using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        List<Student> students;
        DataGridView dgvStudent;
        public Form2(List<Student> students, DataGridView dgvStudent)
        {
            InitializeComponent();
            this.students = students;
            this.dgvStudent = dgvStudent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || txtAvgScore.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (students.Where(s => s.clID == txtID.Text).Count() > 0)
            {
                MessageBox.Show("Bị trùng mã số sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (int.Parse(txtAvgScore.Text) > 10 || int.Parse(txtID.Text) < 0)
            {
                MessageBox.Show("Điểm không quá 10 và dưới 0", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            students.Add(new Student() {clSTT = students.Count() + 1, clID = txtID.Text, clName = txtName.Text, clFaculty = cmbFaculty.Text, clAvgScore = double.Parse(txtAvgScore.Text) });
            dgvStudent.DataSource = null;
            dgvStudent.DataSource = students;
        }
    }
}
