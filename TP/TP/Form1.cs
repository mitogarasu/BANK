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

        Month January = new Month();
        Month February = new Month();
        Month March = new Month();
        Month April = new Month();
        Month May = new Month();
        Month June = new Month();
        Month July = new Month();
        Month August = new Month();
        Month September = new Month();
        Month October = new Month();
        Month November = new Month();
        Month December = new Month();

     //  Month[] mon = new Month[12];
       
        int ostatok = 0;
        int trata;

        int markets = 0;
        int rest = 0;
        int pharmacy = 0;
        int trans = 0;
        int electronics = 0;
        int transport = 0;

        int random = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox3.Text) <= 0)
            {
                MessageBox.Show("Неверно введена сумма");
            }
            if (comboBox3.Text == "Январь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                January.Remainder += ostatok;
                textBox2.Text = January.Remainder.ToString();
            }

            if (comboBox3.Text == "Февраль")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                February.Remainder += ostatok;
                textBox2.Text = February.Remainder.ToString();
            }

            if (comboBox3.Text == "Март")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                March.Remainder += ostatok;
                textBox2.Text = March.Remainder.ToString();
            }

            if (comboBox3.Text == "Апрель")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                April.Remainder += ostatok;
                textBox2.Text = April.Remainder.ToString();
            }

            if (comboBox3.Text == "Май")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                May.Remainder += ostatok;
                textBox2.Text = May.Remainder.ToString();
            }

            if (comboBox3.Text == "Июнь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                June.Remainder += ostatok;
                textBox2.Text = June.Remainder.ToString();
            }

            if (comboBox3.Text == "Июль")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                July.Remainder += ostatok;
                textBox2.Text = July.Remainder.ToString();
            }

            if (comboBox3.Text == "Август")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                August.Remainder += ostatok;
                textBox2.Text = August.Remainder.ToString();
            }

            if (comboBox3.Text == "Сентябрь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                September.Remainder += ostatok;
                textBox2.Text = September.Remainder.ToString();
            }

            if (comboBox3.Text == "Октябрь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                October.Remainder += ostatok;
                textBox2.Text = October.Remainder.ToString();
            }

            if (comboBox3.Text == "Ноябрь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                November.Remainder += ostatok;
                textBox2.Text = November.Remainder.ToString();
            }

            if (comboBox3.Text == "Декабрь")
            {
                ostatok = Convert.ToInt32(textBox3.Text);
                December.Remainder += ostatok;
                textBox2.Text = December.Remainder.ToString();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            trata = Convert.ToInt32(textBox1.Text);
   
            if (comboBox3.Text == "Январь")
            {
                if (trata > January.Remainder)
                {
                        MessageBox.Show("Недостаточно средств");
                }
                else
                {
                        January.Spending += trata;
                        January.Remainder -= trata;

                        textBox2.Text = January.Remainder.ToString();

                        if (comboBox1.Text == "Супермаркеты")
                        {
                            January.SupermarketExpenses += trata;
                        }

                        if (comboBox1.Text == "Рестораны и кафе")
                        {
                            January.RestaurantExpenses += trata;
                        }

                        if (comboBox1.Text == "Аптеки")
                        {
                            January.PharmacyExpenses += trata;
                        }

                        if (comboBox1.Text == "Переводы")
                        {
                            January.TransferExpenses += trata;
                        }

                        if (comboBox1.Text == "Электроника")
                        {
                            January.ElectronicsExpenses += trata;
                        }

                        if (comboBox1.Text == "Транспорт")
                        {
                            January.TransportExpenses += trata;
                        }

                        January.AddToExpensesHistory(comboBox1.Text + " " + trata);
                        listBox1.Items.Clear();
                        January.Check(listBox1);

                        label3.Text = Convert.ToString(January.SupermarketExpenses);
                        label4.Text = Convert.ToString(January.RestaurantExpenses);
                        label5.Text = Convert.ToString(January.PharmacyExpenses);
                        label6.Text = Convert.ToString(January.TransferExpenses);
                        label7.Text = Convert.ToString(January.ElectronicsExpenses);
                        label8.Text = Convert.ToString(January.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Февраль")
            {
                if (trata > February.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    February.Spending += trata;
                    February.Remainder -= trata;

                    textBox2.Text = February.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        February.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        February.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        February.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        February.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        February.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        February.TransportExpenses += trata;
                    }

                    February.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    February.Check(listBox1);

                    label3.Text = Convert.ToString(February.SupermarketExpenses);
                    label4.Text = Convert.ToString(February.RestaurantExpenses);
                    label5.Text = Convert.ToString(February.PharmacyExpenses);
                    label6.Text = Convert.ToString(February.TransferExpenses);
                    label7.Text = Convert.ToString(February.ElectronicsExpenses);
                    label8.Text = Convert.ToString(February.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Март")
            {
                if (trata > March.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    March.Spending += trata;
                    March.Remainder -= trata;

                    textBox2.Text = March.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        March.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        March.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        March.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        March.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        March.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        March.TransportExpenses += trata;
                    }

                    March.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    March.Check(listBox1);

                    label3.Text = Convert.ToString(March.SupermarketExpenses);
                    label4.Text = Convert.ToString(March.RestaurantExpenses);
                    label5.Text = Convert.ToString(March.PharmacyExpenses);
                    label6.Text = Convert.ToString(March.TransferExpenses);
                    label7.Text = Convert.ToString(March.ElectronicsExpenses);
                    label8.Text = Convert.ToString(March.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Апрель")
            {
                if (trata > April.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    April.Spending += trata;
                    April.Remainder -= trata;

                    textBox2.Text = April.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        April.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        April.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        April.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        April.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        April.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        April.TransportExpenses += trata;
                    }

                    April.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    April.Check(listBox1);

                    label3.Text = Convert.ToString(April.SupermarketExpenses);
                    label4.Text = Convert.ToString(April.RestaurantExpenses);
                    label5.Text = Convert.ToString(April.PharmacyExpenses);
                    label6.Text = Convert.ToString(April.TransferExpenses);
                    label7.Text = Convert.ToString(April.ElectronicsExpenses);
                    label8.Text = Convert.ToString(April.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Май")
            {
                if (trata > May.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    May.Spending += trata;
                    May.Remainder -= trata;

                    textBox2.Text = May.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        May.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        May.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        May.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        May.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        May.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        May.TransportExpenses += trata;
                    }

                    May.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    May.Check(listBox1);

                    label3.Text = Convert.ToString(May.SupermarketExpenses);
                    label4.Text = Convert.ToString(May.RestaurantExpenses);
                    label5.Text = Convert.ToString(May.PharmacyExpenses);
                    label6.Text = Convert.ToString(May.TransferExpenses);
                    label7.Text = Convert.ToString(May.ElectronicsExpenses);
                    label8.Text = Convert.ToString(May.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Июнь")
            {
                if (trata > June.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    June.Spending += trata;
                    June.Remainder -= trata;

                    textBox2.Text = June.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        June.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        June.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        June.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        June.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        June.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        June.TransportExpenses += trata;
                    }

                    June.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    June.Check(listBox1);

                    label3.Text = Convert.ToString(June.SupermarketExpenses);
                    label4.Text = Convert.ToString(June.RestaurantExpenses);
                    label5.Text = Convert.ToString(June.PharmacyExpenses);
                    label6.Text = Convert.ToString(June.TransferExpenses);
                    label7.Text = Convert.ToString(June.ElectronicsExpenses);
                    label8.Text = Convert.ToString(June.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Июль")
            {
                if (trata > July.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    July.Spending += trata;
                    July.Remainder -= trata;

                    textBox2.Text = July.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        July.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        July.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        July.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        July.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        July.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        July.TransportExpenses += trata;
                    }

                    July.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    July.Check(listBox1);

                    label3.Text = Convert.ToString(July.SupermarketExpenses);
                    label4.Text = Convert.ToString(July.RestaurantExpenses);
                    label5.Text = Convert.ToString(July.PharmacyExpenses);
                    label6.Text = Convert.ToString(July.TransferExpenses);
                    label7.Text = Convert.ToString(July.ElectronicsExpenses);
                    label8.Text = Convert.ToString(July.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Август")
            {
                if (trata > August.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    August.Spending += trata;
                    August.Remainder -= trata;

                    textBox2.Text = August.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        August.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        August.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        August.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        August.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        August.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        August.TransportExpenses += trata;
                    }

                    August.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    August.Check(listBox1);

                    label3.Text = Convert.ToString(August.SupermarketExpenses);
                    label4.Text = Convert.ToString(August.RestaurantExpenses);
                    label5.Text = Convert.ToString(August.PharmacyExpenses);
                    label6.Text = Convert.ToString(August.TransferExpenses);
                    label7.Text = Convert.ToString(August.ElectronicsExpenses);
                    label8.Text = Convert.ToString(August.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Сентябрь")
            {
                if (trata > September.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    September.Spending += trata;
                    September.Remainder -= trata;

                    textBox2.Text = September.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        September.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        September.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        September.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        September.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        September.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        September.TransportExpenses += trata;
                    }

                    September.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    September.Check(listBox1);

                    label3.Text = Convert.ToString(September.SupermarketExpenses);
                    label4.Text = Convert.ToString(September.RestaurantExpenses);
                    label5.Text = Convert.ToString(September.PharmacyExpenses);
                    label6.Text = Convert.ToString(September.TransferExpenses);
                    label7.Text = Convert.ToString(September.ElectronicsExpenses);
                    label8.Text = Convert.ToString(September.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Октябрь")
            {
                if (trata > October.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    October.Spending += trata;
                    October.Remainder -= trata;

                    textBox2.Text = October.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        October.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        October.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        October.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        October.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        October.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        October.TransportExpenses += trata;
                    }

                    October.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    October.Check(listBox1);

                    label3.Text = Convert.ToString(October.SupermarketExpenses);
                    label4.Text = Convert.ToString(October.RestaurantExpenses);
                    label5.Text = Convert.ToString(October.PharmacyExpenses);
                    label6.Text = Convert.ToString(October.TransferExpenses);
                    label7.Text = Convert.ToString(October.ElectronicsExpenses);
                    label8.Text = Convert.ToString(October.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Ноябрь")
            {
                if (trata > November.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    November.Spending += trata;
                    November.Remainder -= trata;

                    textBox2.Text = November.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        November.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        November.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        November.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        November.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        November.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        November.TransportExpenses += trata;
                    }

                    November.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    November.Check(listBox1);

                    label3.Text = Convert.ToString(November.SupermarketExpenses);
                    label4.Text = Convert.ToString(November.RestaurantExpenses);
                    label5.Text = Convert.ToString(November.PharmacyExpenses);
                    label6.Text = Convert.ToString(November.TransferExpenses);
                    label7.Text = Convert.ToString(November.ElectronicsExpenses);
                    label8.Text = Convert.ToString(November.TransportExpenses);

                }


            }
            if (comboBox3.Text == "Декабрь")
            {
                if (trata > December.Remainder)
                {
                    MessageBox.Show("Недостаточно средств");
                }
                else
                {
                    December.Spending += trata;
                    December.Remainder -= trata;

                    textBox2.Text = December.Remainder.ToString();

                    if (comboBox1.Text == "Супермаркеты")
                    {
                        December.SupermarketExpenses += trata;
                    }

                    if (comboBox1.Text == "Рестораны и кафе")
                    {
                        December.RestaurantExpenses += trata;
                    }

                    if (comboBox1.Text == "Аптеки")
                    {
                        December.PharmacyExpenses += trata;
                    }

                    if (comboBox1.Text == "Переводы")
                    {
                        December.TransferExpenses += trata;
                    }

                    if (comboBox1.Text == "Электроника")
                    {
                        December.ElectronicsExpenses += trata;
                    }

                    if (comboBox1.Text == "Транспорт")
                    {
                        December.TransportExpenses += trata;
                    }

                    December.AddToExpensesHistory(comboBox1.Text + " " + trata);
                    listBox1.Items.Clear();
                    December.Check(listBox1);

                    label3.Text = Convert.ToString(December.SupermarketExpenses);
                    label4.Text = Convert.ToString(December.RestaurantExpenses);
                    label5.Text = Convert.ToString(December.PharmacyExpenses);
                    label6.Text = Convert.ToString(December.TransferExpenses);
                    label7.Text = Convert.ToString(December.ElectronicsExpenses);
                    label8.Text = Convert.ToString(December.TransportExpenses);

                }


            }


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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox3.Text == "Январь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = January.Remainder.ToString();
                listBox1.Items.Clear();
                January.Check(listBox1);

                label3.Text = Convert.ToString(January.SupermarketExpenses);
                label4.Text = Convert.ToString(January.RestaurantExpenses);
                label5.Text = Convert.ToString(January.PharmacyExpenses);
                label6.Text = Convert.ToString(January.TransferExpenses);
                label7.Text = Convert.ToString(January.ElectronicsExpenses);
                label8.Text = Convert.ToString(January.TransportExpenses);
            }
            if (comboBox3.Text == "Февраль")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = February.Remainder.ToString();
                listBox1.Items.Clear();
                February.Check(listBox1);

                label3.Text = Convert.ToString(February.SupermarketExpenses);
                label4.Text = Convert.ToString(February.RestaurantExpenses);
                label5.Text = Convert.ToString(February.PharmacyExpenses);
                label6.Text = Convert.ToString(February.TransferExpenses);
                label7.Text = Convert.ToString(February.ElectronicsExpenses);
                label8.Text = Convert.ToString(February.TransportExpenses);
            }
            if (comboBox3.Text == "Март")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = March.Remainder.ToString();
                listBox1.Items.Clear();
                March.Check(listBox1);

                label3.Text = Convert.ToString(March.SupermarketExpenses);
                label4.Text = Convert.ToString(March.RestaurantExpenses);
                label5.Text = Convert.ToString(March.PharmacyExpenses);
                label6.Text = Convert.ToString(March.TransferExpenses);
                label7.Text = Convert.ToString(March.ElectronicsExpenses);
                label8.Text = Convert.ToString(March.TransportExpenses);
            }
            if (comboBox3.Text == "Апрель")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = April.Remainder.ToString();
                listBox1.Items.Clear();
                April.Check(listBox1);

                label3.Text = Convert.ToString(April.SupermarketExpenses);
                label4.Text = Convert.ToString(April.RestaurantExpenses);
                label5.Text = Convert.ToString(April.PharmacyExpenses);
                label6.Text = Convert.ToString(April.TransferExpenses);
                label7.Text = Convert.ToString(April.ElectronicsExpenses);
                label8.Text = Convert.ToString(April.TransportExpenses);
            }
            if (comboBox3.Text == "Май")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = May.Remainder.ToString();
                listBox1.Items.Clear();
                May.Check(listBox1);

                label3.Text = Convert.ToString(May.SupermarketExpenses);
                label4.Text = Convert.ToString(May.RestaurantExpenses);
                label5.Text = Convert.ToString(May.PharmacyExpenses);
                label6.Text = Convert.ToString(May.TransferExpenses);
                label7.Text = Convert.ToString(May.ElectronicsExpenses);
                label8.Text = Convert.ToString(May.TransportExpenses);
            }
            if (comboBox3.Text == "Июнь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = June.Remainder.ToString();
                listBox1.Items.Clear();
                June.Check(listBox1);

                label3.Text = Convert.ToString(June.SupermarketExpenses);
                label4.Text = Convert.ToString(June.RestaurantExpenses);
                label5.Text = Convert.ToString(June.PharmacyExpenses);
                label6.Text = Convert.ToString(June.TransferExpenses);
                label7.Text = Convert.ToString(June.ElectronicsExpenses);
                label8.Text = Convert.ToString(June.TransportExpenses);
            }
            if (comboBox3.Text == "Июль")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = July.Remainder.ToString();
                listBox1.Items.Clear();
                July.Check(listBox1);

                label3.Text = Convert.ToString(July.SupermarketExpenses);
                label4.Text = Convert.ToString(July.RestaurantExpenses);
                label5.Text = Convert.ToString(July.PharmacyExpenses);
                label6.Text = Convert.ToString(July.TransferExpenses);
                label7.Text = Convert.ToString(July.ElectronicsExpenses);
                label8.Text = Convert.ToString(July.TransportExpenses);
            }
            if (comboBox3.Text == "Август")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = August.Remainder.ToString();
                listBox1.Items.Clear();
                August.Check(listBox1);

                label3.Text = Convert.ToString(August.SupermarketExpenses);
                label4.Text = Convert.ToString(August.RestaurantExpenses);
                label5.Text = Convert.ToString(August.PharmacyExpenses);
                label6.Text = Convert.ToString(August.TransferExpenses);
                label7.Text = Convert.ToString(August.ElectronicsExpenses);
                label8.Text = Convert.ToString(August.TransportExpenses);
            }
            if (comboBox3.Text == "Сентябрь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = September.Remainder.ToString();
                listBox1.Items.Clear();
                September.Check(listBox1);

                label3.Text = Convert.ToString(September.SupermarketExpenses);
                label4.Text = Convert.ToString(September.RestaurantExpenses);
                label5.Text = Convert.ToString(September.PharmacyExpenses);
                label6.Text = Convert.ToString(September.TransferExpenses);
                label7.Text = Convert.ToString(September.ElectronicsExpenses);
                label8.Text = Convert.ToString(September.TransportExpenses);
            }
            if (comboBox3.Text == "Октябрь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = October.Remainder.ToString();
                listBox1.Items.Clear();
                October.Check(listBox1);

                label3.Text = Convert.ToString(October.SupermarketExpenses);
                label4.Text = Convert.ToString(October.RestaurantExpenses);
                label5.Text = Convert.ToString(October.PharmacyExpenses);
                label6.Text = Convert.ToString(October.TransferExpenses);
                label7.Text = Convert.ToString(October.ElectronicsExpenses);
                label8.Text = Convert.ToString(October.TransportExpenses);
            }
            if (comboBox3.Text == "Ноябрь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = November.Remainder.ToString();
                listBox1.Items.Clear();
                November.Check(listBox1);

                label3.Text = Convert.ToString(November.SupermarketExpenses);
                label4.Text = Convert.ToString(November.RestaurantExpenses);
                label5.Text = Convert.ToString(November.PharmacyExpenses);
                label6.Text = Convert.ToString(November.TransferExpenses);
                label7.Text = Convert.ToString(November.ElectronicsExpenses);
                label8.Text = Convert.ToString(November.TransportExpenses);
            }
            if (comboBox3.Text == "Декабрь")
            {
                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = December.Remainder.ToString();
                listBox1.Items.Clear();
                December.Check(listBox1);

                label3.Text = Convert.ToString(December.SupermarketExpenses);
                label4.Text = Convert.ToString(December.RestaurantExpenses);
                label5.Text = Convert.ToString(December.PharmacyExpenses);
                label6.Text = Convert.ToString(December.TransferExpenses);
                label7.Text = Convert.ToString(December.ElectronicsExpenses);
                label8.Text = Convert.ToString(December.TransportExpenses);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
