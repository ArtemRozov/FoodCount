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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox_Age.Text) < 25)
            {
                switch (comboBox_Activity.Text)
                {
                    case "Сидячий спосіб життя": textBox_Result.Text = "2000"; break;
                    case "Помірно активний спосіб життя": textBox_Result.Text = "2200"; break;
                    case "Спортсмени та активні люди": textBox_Result.Text = "2400"; break;
                    default: ShowDialog(); break;
                }
            } else if(int.Parse(textBox_Age.Text) > 24 && int.Parse(textBox_Age.Text) < 50)
            {
                switch (comboBox_Activity.Text)
                {
                    case "Сидячий спосіб життя": textBox_Result.Text = "1800"; break;
                    case "Помірно активний спосіб життя": textBox_Result.Text = "2100"; break;
                    case "Спортсмени та активні люди": textBox_Result.Text = "2300"; break;
                    default: ShowDialog(); break;
                }
            } else if (int.Parse(textBox_Age.Text) > 49)
            {
                switch (comboBox_Activity.Text)
                {
                    case "Сидячий спосіб життя": textBox_Result.Text = "1600"; break;
                    case "Помірно активний спосіб життя": textBox_Result.Text = "1800"; break;
                    case "Спортсмени та активні люди": textBox_Result.Text = "2000"; break;
                    default: ShowDialog(); break;
                }
            }
        }

        private void харчуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm();
            foodForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product.meta = textBox_Result.Text;
        }

        private void таблицяКалорійностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KalorityTableForm k = new KalorityTableForm();
            k.ShowDialog();
        }
    }
}