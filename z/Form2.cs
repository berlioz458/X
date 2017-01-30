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
    public partial class Form2 : Form
    {
        public int pos_x;
        public int pos_y;

        public Form2(int x, int y)
        {
            InitializeComponent();
            pos_x = x;
            pos_y = y;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Кабинет". При необходимости она может быть перемещена или удалена.
            this.кабинетTableAdapter.Fill(this.database2DataSet.Кабинет);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Преподаватель". При необходимости она может быть перемещена или удалена.
            this.преподавательTableAdapter.Fill(this.database2DataSet.Преподаватель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Предмет". При необходимости она может быть перемещена или удалена.
            this.предметTableAdapter.Fill(this.database2DataSet.Предмет);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                string s = main.textBox1.Text;
                main.textBox1.Text = pos_x + " " +  pos_y;
                main.dataGridView1.Rows[pos_x].Cells[pos_y].Value = comboBox1.Text;
                //main.dataGridView1.SelectedCells[1] = comboBox1.Text;
            }
            Close();
        }
    }
}
