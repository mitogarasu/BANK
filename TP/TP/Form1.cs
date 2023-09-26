using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ostatok = 0;
        int trata;

        int markets = 0;
        int rest = 0;
        int pharmacy = 0;
        int trans = 0;
        int electronics = 0;
        int transport = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            ostatok += Convert.ToInt32(textBox1.Text);
            textBox2.Text = Convert.ToString(ostatok);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            trata = Convert.ToInt32(textBox1.Text);
            if(trata > ostatok)
            {
                MessageBox.Show("Недостаточно средств");
            }
            else
            {
                ostatok -= trata;
                textBox2.Text = Convert.ToString(ostatok);

                if(comboBox1.Text == "Супермаркеты")
                {
                    markets += trata;
                }

                if (comboBox1.Text == "Рестораны и кафе")
                {
                    rest += trata;
                }

                if (comboBox1.Text == "Аптеки")
                {
                    pharmacy += trata;
                }

                if (comboBox1.Text == "Переводы")
                {
                    trans += trata;
                }

                if (comboBox1.Text == "Электроника")
                {
                    electronics += trata;
                }

                if (comboBox1.Text == "Транспорт")
                {
                    transport += trata;
                }
            }

            label3.Text = Convert.ToString(markets);
            label4.Text = Convert.ToString(rest);
            label5.Text = Convert.ToString(pharmacy);
            label6.Text = Convert.ToString(trans);
            label7.Text = Convert.ToString(electronics);
            label8.Text = Convert.ToString(transport);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
