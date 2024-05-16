using MySeries.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySeries
{
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NewEntry_Load(object sender, EventArgs e)
        {

        }

        private void Anime_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySeries.MyTVList.add(new TV(textBox1.Text, textBox2.Text, dateTimePicker1.Text, comboBox1.Text, int.Parse(comboBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox6.Text), textBox7.Text, textBox8.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySeries.MyAnimeList.add(new Anime(textBox14.Text, textBox15.Text, dateTimePicker2.Text, comboBox3.Text, int.Parse(comboBox4.Text), textBox16.Text, int.Parse(textBox13.Text), int.Parse(textBox11.Text), textBox10.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySeries.MyAnimeList.add(new Book(textBox29.Text, textBox30.Text, dateTimePicker3.Text, comboBox5.Text, int.Parse(comboBox6.Text), textBox31.Text, textBox9.Text, int.Parse(textBox28.Text), int.Parse(textBox27.Text)));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
