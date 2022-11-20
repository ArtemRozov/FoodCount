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
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product.product = comboBox1.Text;
            Product.mass = textBox1.Text;

            switch (comboBox1.Text)
            {
                case "Яйцо куряче": Product.kalories = 
                            (157.0 * (double.Parse(textBox1.Text) / 100)).ToString();                   
                         break;
                case "Сир": Product.kalories =
                            (330.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                         break;
                case "Кефір": Product.kalories =
                            (60.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                         break;
                case "Цукерки": Product.kalories =
                            (535.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                         break;
                case "Макарони": Product.kalories =
                             (337.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                         break;
                case "Білий хліб": Product.kalories =
                             (369.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                         break;
                case "Чорний хліб": Product.kalories =
                             (214.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Яблуко": Product.kalories =
                             (46.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Хурма": Product.kalories =
                             (53.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Скумбрія": Product.kalories =
                             (211.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Сом": Product.kalories =
                             (161.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Арахіс": Product.kalories =
                             (470.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Морква": Product.kalories =
                             (33.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Капуста": Product.kalories =
                             (28.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                case "Чорний чай": Product.kalories =
                             (146.0 * (double.Parse(textBox1.Text) / 100)).ToString();
                        break;
                default: break;
            }

            Product.newest = true;
            Close();
        }
    }
}

