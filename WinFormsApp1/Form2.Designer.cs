namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAvgScore = new TextBox();
            btnAdd = new Button();
            btnExit = new Button();
            cmbFaculty = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 41);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã Số Sinh Viên:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 70);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 0;
            label2.Text = "Tên Sinh Viên:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 98);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Khoa:";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 128);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Điểm TB:";
            label4.Click += label1_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(161, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(308, 23);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(308, 23);
            txtName.TabIndex = 1;
            // 
            // txtAvgScore
            // 
            txtAvgScore.Location = new Point(161, 125);
            txtAvgScore.Name = "txtAvgScore";
            txtAvgScore.Size = new Size(308, 23);
            txtAvgScore.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Lime;
            btnAdd.Location = new Point(267, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 39);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Thêm Mới";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Location = new Point(381, 184);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 39);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // cmbFaculty
            // 
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Items.AddRange(new object[] { "Công nghệ thông tin", "Ngôn ngữ Anh", "Quản trị kinh doanh" });
            cmbFaculty.Location = new Point(161, 95);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(308, 23);
            cmbFaculty.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 258);
            Controls.Add(cmbFaculty);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(txtAvgScore);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAvgScore;
        private Button btnAdd;
        private Button btnExit;
        private ComboBox cmbFaculty;
    }
}