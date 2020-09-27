using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cena = 0;//цена
            int n;//кол-во
            int sum;//сумма

            if (radioButton1.Checked == true)
                cena = 60;
            if (radioButton2.Checked == true)
                cena = 50;
            if (radioButton3.Checked == true)
                cena = 45;

            n = Convert.ToInt32(textBox1.Text);
            sum = n * cena;

            label3.Text = "Цена " + cena.ToString("c") + "\nКоличество: " + n.ToString() + "шт. \n" + "Сумма заказа: " + sum.ToString("C");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        //нажатие ENTER
                        button1.Focus();
                }
                return;
            }
            //остальные символы запрещены
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;

            label3.Text = "";
        }

        private void buttonPast_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void buttonList_1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonList_3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
