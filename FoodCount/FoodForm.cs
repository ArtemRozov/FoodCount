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
    public partial class FoodForm : Form
    {
        private int todayKalories = 0;
        public FoodForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
        }

        private void FoodForm_Activated(object sender, EventArgs e)
        {
            if(Product.newest)
            {
                Product.newest = false;
                dataGridView1.Rows
                    .Add(Product.product, Product.mass, Product.kalories);

                todayKalories += int.Parse(Product.kalories);
                label3.Text = todayKalories.ToString() + " ккал";
            }
        }

        private void обзорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            GoalLabel.Text = Product.meta + " ккал";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            todayKalories = 0;
            label3.Text = "0 ккал";
        }

        private void таблицяКалорійностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KalorityTableForm kalorityTableForm = new KalorityTableForm();
            kalorityTableForm.ShowDialog();
        }
    }
}
