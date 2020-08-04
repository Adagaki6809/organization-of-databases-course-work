using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kurs
{
    public partial class Form1 : Form
    {
        private AdminForm af;
        private AdminForm kf;
        private AdminForm pf;

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Админ";
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '#';
            textBox1.TextAlign = HorizontalAlignment.Center; // пишем текст из середин
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Админ" && textBox1.Text == "111")
            {
                af = new AdminForm();
                af.AdmForm();
                af.GetForm1(this);
                af.Show();
                this.Hide();
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Кассир" && textBox1.Text == "222")
            {
                kf = new AdminForm();
                kf.KassirForm();
                kf.GetForm1(this);
                kf.Show();
                this.Hide();
                return;
            }

            if (comboBox1.SelectedItem.ToString() == "Информбюро" && textBox1.Text == "333")
            {
                pf = new AdminForm();
                pf.PolzForm();
                pf.GetForm1(this);
                pf.Show();
                this.Hide();
                return;
            }

            if ((comboBox1.SelectedItem.ToString() == "Админ" && textBox1.Text != "111") || (comboBox1.SelectedItem.ToString() == "Кассир" && textBox1.Text != "222") || (comboBox1.SelectedItem.ToString() == "Информбюро" && textBox1.Text != "333"))
            {
                MessageBox.Show("Неправильный логин или пароль. Повторите ввод.");
                
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter))
            {
                if (comboBox1.SelectedItem.ToString() == "Админ" && textBox1.Text == "111")
                {
                    af = new AdminForm();
                    af.AdmForm();
                    af.GetForm1(this);
                    af.Show();
                    this.Hide();
                    return;
                }

                if (comboBox1.SelectedItem.ToString() == "Кассир" && textBox1.Text == "222")
                {
                    kf = new AdminForm();
                    kf.KassirForm();
                    kf.GetForm1(this);
                    kf.Show();
                    this.Hide();
                    return;
                }

                if (comboBox1.SelectedItem.ToString() == "Информбюро" && textBox1.Text == "333")
                {
                    pf = new AdminForm();
                    pf.PolzForm();
                    pf.GetForm1(this);
                    pf.Show();
                    this.Hide();
                    return;
                }

                if ((comboBox1.SelectedItem.ToString() == "Админ" && textBox1.Text != "111") || (comboBox1.SelectedItem.ToString() == "Кассир" && textBox1.Text != "222") || (comboBox1.SelectedItem.ToString() == "Информбюро" && textBox1.Text != "333"))
                {
                    MessageBox.Show("Неправильный логин или пароль. Повторите ввод.");

                }
            }
        }
    }
}
