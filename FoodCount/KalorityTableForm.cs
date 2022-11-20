using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCount
{
    public partial class KalorityTableForm : Form
    {
        public KalorityTableForm()
        {
            InitializeComponent();
        }

        private void обзорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void харчуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodForm f = new FoodForm();
            f.Show();
            Close();
        }

        private void KalorityTableForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add("Яйцо куряче", "157");
            dataGridView1.Rows.Add("Сир", "330");
            dataGridView1.Rows.Add("Кефір", "60");
            dataGridView1.Rows.Add("Цукерки", "535");
            dataGridView1.Rows.Add("Макарони", "337");
            dataGridView1.Rows.Add("Білий хліб", "369");
            dataGridView1.Rows.Add("Чорний хліб", "214");
            dataGridView1.Rows.Add("Яблуко", "46");
            dataGridView1.Rows.Add("Хурма", "53");
            dataGridView1.Rows.Add("Скумбрія", "211");
            dataGridView1.Rows.Add("Сом", "161");
            dataGridView1.Rows.Add("Арахіс", "470");
            dataGridView1.Rows.Add("Морква", "33");
            dataGridView1.Rows.Add("Капуста", "28");
            dataGridView1.Rows.Add("Чорний чай", "146");
        }
    }
}
