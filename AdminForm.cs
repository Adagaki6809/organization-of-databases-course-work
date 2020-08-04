using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kurs
{

    public partial class AdminForm : Form
    {
        private Form1 form1;

        public AdminForm()
        {
            InitializeComponent();
        }

        public void AdmForm()
        {
            this.Text = "Железнодорожный вокзал [Администратор]";
            tabControl1.TabPages[4].Dispose();
        }

        public void KassirForm()
        {
            this.Text = "Железнодорожный вокзал [Кассир]";
            tabControl1.TabPages[0].Dispose();
            tabControl1.TabPages[0].Dispose();
            tabControl1.TabPages[2].Dispose();

            bindingNavigatorDeleteItem4.Enabled = false;
            bindingNavigatorDeleteItem5.Enabled = false;
            bindingNavigatorDeleteItem6.Enabled = false;
            bindingNavigatorDeleteItem7.Enabled = false;

            richTextBox1.Dispose();
            richTextBox2.Dispose();
            richTextBox3.Dispose();
            richTextBox4.Dispose();
            richTextBox5.Dispose();

            button2.Dispose();
            button3.Dispose();
            button4.Dispose();
            button5.Dispose();
            button6.Dispose();
        }

        public void PolzForm()
        {
            this.Text = "Железнодорожный вокзал [Информбюро]";
            tabControl1.TabPages[4].Dispose();

            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView4.ReadOnly = true;
            dataGridView5.ReadOnly = true;
            dataGridView6.ReadOnly = true;
            dataGridView7.ReadOnly = true;
            dataGridView8.ReadOnly = true;
            dataGridView9.ReadOnly = true;
            dataGridView10.ReadOnly = true;

            button1.Enabled = false;

            richTextBox1.Dispose();
            richTextBox2.Dispose();
            richTextBox3.Dispose();
            richTextBox4.Dispose();
            richTextBox5.Dispose();

            button2.Dispose();
            button3.Dispose();
            button4.Dispose();
            button5.Dispose();
            button6.Dispose();

            bindingNavigator1.Dispose();
            bindingNavigator2.Dispose();
            bindingNavigator3.Dispose();
            bindingNavigator4.Dispose();
            bindingNavigator5.Dispose();
            bindingNavigator6.Dispose();
            bindingNavigator7.Dispose();
            bindingNavigator8.Dispose();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainStationDBDataSet.bilet". При необходимости она может быть перемещена или удалена.
            this.biletTableAdapter.Fill(this.trainStationDBDataSet1.bilet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainStationDBDataSet.stanc". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.trainStationDBDataSet1.client);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainStationDBDataSet.reys". При необходимости она может быть перемещена или удалена.
            this.reysTableAdapter.Fill(this.trainStationDBDataSet1.reys);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainStationDBDataSet.marshrut". При необходимости она может быть перемещена или удалена.
            this.stancTableAdapter.Fill(this.trainStationDBDataSet1.stanc);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "trainStationDBDataSet.poezd". При необходимости она может быть перемещена или удалена.
            this.poezdTableAdapter.Fill(this.trainStationDBDataSet1.poezd);
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        public void GetForm1(Form1 f)
        {
            form1 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.poezdTableAdapter.Update(this.trainStationDBDataSet1.poezd);
            this.stancTableAdapter.Update(this.trainStationDBDataSet1.stanc);
            this.reysTableAdapter.Update(this.trainStationDBDataSet1.reys);
            this.clientTableAdapter.Update(this.trainStationDBDataSet1.client);
            this.biletTableAdapter.Update(this.trainStationDBDataSet1.bilet);


            this.poezdTableAdapter.Fill(this.trainStationDBDataSet1.poezd);
            dataGridView1.Refresh();
            this.reysTableAdapter.Fill(this.trainStationDBDataSet1.reys);
            dataGridView2.Refresh();

            this.stancTableAdapter.Fill(this.trainStationDBDataSet1.stanc);
            dataGridView3.Refresh();
            this.reysTableAdapter.Fill(this.trainStationDBDataSet1.reys);
            dataGridView4.Refresh();

            this.reysTableAdapter.Fill(this.trainStationDBDataSet1.reys);
            dataGridView5.Refresh();
            this.clientTableAdapter.Fill(this.trainStationDBDataSet1.client);
            this.biletTableAdapter.Fill(this.trainStationDBDataSet1.bilet);
            dataGridView6.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
            {
                SqlCommand command = new SqlCommand(richTextBox1.Text, connection);
                command.Connection.Open();
                DataTable tab = new DataTable();
                tab.Load(command.ExecuteReader());
                poezdBindingSource.DataSource = tab.DefaultView;
                dataGridView1.Refresh();
                dataGridView2.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
            {
                SqlCommand command = new SqlCommand(richTextBox2.Text, connection);
                command.Connection.Open();

                DataTable tab = new DataTable();
                tab.Load(command.ExecuteReader());
                stancBindingSource.DataSource = tab.DefaultView;
                dataGridView3.Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
            {
                SqlCommand command = new SqlCommand(richTextBox3.Text, connection);
                command.Connection.Open();

                DataTable tab = new DataTable();
                tab.Load(command.ExecuteReader());
                reysBindingSource.DataSource = tab.DefaultView;
                dataGridView5.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
            {
                SqlCommand command = new SqlCommand(richTextBox4.Text, connection);
                command.Connection.Open();

                DataTable tab = new DataTable();
                tab.Load(command.ExecuteReader());
                clientBindingSource.DataSource = tab.DefaultView;
                dataGridView7.Refresh();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {/*
            using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
            {
                SqlCommand command = new SqlCommand(richTextBox5.Text, connection);
                command.Connection.Open();

                DataTable tab = new DataTable();
                tab.Load(command.ExecuteReader());
                marshrutBindingSource.DataSource = tab.DefaultView;
                dataGridView9.Refresh();
            }*/
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(richTextBox1.Text, connection);
                    command.Connection.Open();
                    DataTable tab = new DataTable();
                    tab.Load(command.ExecuteReader());
                    poezdBindingSource.DataSource = tab.DefaultView;
                    dataGridView1.Refresh();
                    dataGridView2.Refresh();
                }
            }
        }

        private void richTextBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(richTextBox2.Text, connection);
                    command.Connection.Open();

                    DataTable tab = new DataTable();
                    tab.Load(command.ExecuteReader());
                    stancBindingSource.DataSource = tab.DefaultView;
                    dataGridView3.Refresh();
                }
            }
        }

        private void richTextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(richTextBox3.Text, connection);
                    command.Connection.Open();

                    DataTable tab = new DataTable();
                    tab.Load(command.ExecuteReader());
                    reysBindingSource.DataSource = tab.DefaultView;
                    dataGridView5.Refresh();
                }
            }
        }

        private void richTextBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.W)
            {
                using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(richTextBox4.Text, connection);
                    command.Connection.Open();

                    DataTable tab = new DataTable();
                    tab.Load(command.ExecuteReader());
                    clientBindingSource.DataSource = tab.DefaultView;
                    dataGridView7.Refresh();
                }
            }
        }

        private void richTextBox5_KeyUp(object sender, KeyEventArgs e)
        {/*
            if (e.Control && e.KeyCode == Keys.W)
            {
                using (SqlConnection connection = new SqlConnection(new Kurs.Properties.Settings().TrainStationDBConnectionString))
                {
                    SqlCommand command = new SqlCommand(richTextBox5.Text, connection);
                    command.Connection.Open();

                    DataTable tab = new DataTable();
                    tab.Load(command.ExecuteReader());
                    marshrutBindingSource.DataSource = tab.DefaultView;
                    dataGridView9.Refresh();
                }
            }*/
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView5_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView7_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView4_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView6_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }

        private void dataGridView8_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный формат данных!");
        }
    }
}