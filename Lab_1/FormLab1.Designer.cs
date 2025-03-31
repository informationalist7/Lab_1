namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            txt_p3 = new TextBox();
            txt_p2 = new TextBox();
            txt_p1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_p3);
            groupBox1.Controls.Add(txt_p2);
            groupBox1.Controls.Add(txt_p1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ймовірності подій";
            // 
            // txt_p3
            // 
            txt_p3.Location = new Point(75, 126);
            txt_p3.Name = "txt_p3";
            txt_p3.Size = new Size(303, 32);
            txt_p3.TabIndex = 5;
            txt_p3.Text = "0,2";
            // 
            // txt_p2
            // 
            txt_p2.Location = new Point(75, 75);
            txt_p2.Name = "txt_p2";
            txt_p2.Size = new Size(303, 32);
            txt_p2.TabIndex = 4;
            txt_p2.Text = "0,3";
            // 
            // txt_p1
            // 
            txt_p1.Location = new Point(75, 31);
            txt_p1.Name = "txt_p1";
            txt_p1.Size = new Size(303, 32);
            txt_p1.TabIndex = 3;
            txt_p1.Text = "0,5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 133);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 2;
            label3.Text = "p3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 82);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 1;
            label2.Text = "p2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 25);
            label1.TabIndex = 0;
            label1.Text = "p1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(522, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вкладення коштів";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Column1, Column2, Column3 });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(994, 427);
            dataGridView1.TabIndex = 0;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Назва альтернативи";
            Name.Name = "Name";
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            Column1.DefaultCellStyle = dataGridViewCellStyle1;
            Column1.HeaderText = "При стабільному зростанні";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            Column2.DefaultCellStyle = dataGridViewCellStyle2;
            Column2.HeaderText = "При стагнації";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.TopCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle3;
            Column3.HeaderText = "При високих темпах інфляції";
            Column3.Name = "Column3";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView2);
            groupBox3.Location = new Point(10, 202);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(506, 223);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Найкраща альтернатива";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.Location = new Point(10, 431);
            button1.Name = "button1";
            button1.Size = new Size(506, 36);
            button1.TabIndex = 0;
            button1.Text = "Розрахунок";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(500, 192);
            dataGridView2.TabIndex = 0;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column4.HeaderText = "Назва";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Column5.HeaderText = "Значення";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 121;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1534, 482);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторна робота №1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txt_p1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txt_p3;
        private TextBox txt_p2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button button1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
