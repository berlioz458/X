using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Поток". При необходимости она может быть перемещена или удалена.
            this.потокTableAdapter.Fill(this.database2DataSet.Поток);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Курс". При необходимости она может быть перемещена или удалена.
            this.курсTableAdapter.Fill(this.database2DataSet.Курс);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Факультет". При необходимости она может быть перемещена или удалена.
            this.факультетTableAdapter.Fill(this.database2DataSet.Факультет);

            this.dataGridView1.Rows.Add("8:00");
            this.dataGridView1.Rows.Add("9:50");
            this.dataGridView1.Rows.Add("11:40");
            this.dataGridView1.Rows.Add("13:45");
            this.dataGridView1.Rows.Add("15:35");
            this.dataGridView1.Rows.Add("17:25");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Form2 f = new Form2();
            //f.Show();
        }

        private void clear_table()
        {
            //dataGridView1.Columns.RemoveAt(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear_table();
            int k;
            string potok = comboBox3.Text;
            k = database2DataSet.Поток.Rows.Count;
            for (int i = 0; i < k; i++)
            {
                if (database2DataSet.Поток[i][2].ToString() == potok)
                {
                    int n;
                    n = (int)database2DataSet.Поток[i][3];
                    for (int j = 0; j < n; j++)
                    {
                        dataGridView1.Columns.Add("aaa", database2DataSet.Поток[i][2].ToString());
                    }
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 f = new Form2(dataGridView1.CurrentCell.RowIndex, dataGridView1.CurrentCell.ColumnIndex);
            f.Owner = this;
            f.Show();
        }
    }
}
