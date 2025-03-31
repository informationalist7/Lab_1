namespace Lab_1
{
    public partial class Form1 : Form
    {
        List<Alternative> alternatives;
        double[] coefficient = new double[3];
        public Form1()
        {
            InitializeComponent();
            FillTable();
            alternatives = new List<Alternative>();
        }

        void FillTable()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Виготовлення блокнотів";
            dataGridView1.Rows[0].Cells[1].Value = 14;
            dataGridView1.Rows[0].Cells[2].Value = 8;
            dataGridView1.Rows[0].Cells[3].Value = 5;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[1].Cells[0].Value = "Виготовлення зошитів";
            dataGridView1.Rows[1].Cells[1].Value = 9;
            dataGridView1.Rows[1].Cells[2].Value = 4;
            dataGridView1.Rows[1].Cells[3].Value = 4;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[2].Cells[0].Value = "Виготовлення фотокниг";
            dataGridView1.Rows[2].Cells[1].Value = 12;
            dataGridView1.Rows[2].Cells[2].Value = 7;
            dataGridView1.Rows[2].Cells[3].Value = 4;
        }

        void GetCoefficients()
        {
            coefficient[0] = Convert.ToDouble(txt_p1.Text);
            coefficient[1] = Convert.ToDouble(txt_p2.Text);
            coefficient[2] = Convert.ToDouble(txt_p3.Text);
        }
        void GetAlternatives()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Alternative alternative = new Alternative();
                alternative.Name = dataGridView1.Rows[i].Cells[0].Value.ToString();
                alternative.Stability = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                alternative.Stagnation = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                alternative.HighInflation = Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
                alternatives.Add(alternative);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alternatives.Clear();
            GetCoefficients();
            GetAlternatives();
            BLL bll = new BLL(alternatives, coefficient);
            List<Alternative> maxAlternatives = bll.GetMaxAlternatives();
            int i = 0;
            dataGridView2.Rows.Clear();
            foreach (var alternative in maxAlternatives)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = alternative.Name;
                dataGridView2.Rows[i].Cells[1].Value = alternative.Result.ToString();
                i++;
            }
        }
    }
}
