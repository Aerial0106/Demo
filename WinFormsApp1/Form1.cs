namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(students, dgvStudent);
            frm2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(students, dgvStudent);
            frm2.ShowDialog();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox toolStripTextBox = sender as ToolStripTextBox;
            if (toolStripTextBox.Text.Length == 0)
            {
                dgvStudent.DataSource = null;
                dgvStudent.DataSource = students;
            }
            else
            {
                dgvStudent.DataSource = null;
                List<Student> std = new List<Student>();
                std = students.Where(s => s.clName.Contains(toolStripTextBox.Text)).ToList();
                if (std.Count > 0)
                {
                    dgvStudent.DataSource = null;
                    dgvStudent.DataSource = std;
                }
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}