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
            MySeries.MyTVList.add(new TV(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), comboBox1.Text, int.Parse(comboBox2.Text), textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox6.Text) + (int.Parse(textBox5.Text) * 60), textBox7.Text, textBox8.Text));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySeries.MyAnimeList.add(new Anime(textBox14.Text, textBox15.Text, dateTimePicker2.Value.ToString("yyyy-MM-dd"), comboBox3.Text, int.Parse(comboBox4.Text), textBox16.Text, int.Parse(textBox13.Text), int.Parse(textBox11.Text) + (int.Parse(textBox12.Text) * 60), textBox10.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MySeries.MyBookList.add(new Book(textBox29.Text, textBox30.Text, dateTimePicker4.Value.ToString("yyyy-MM-dd"), comboBox7.Text, int.Parse(comboBox8.Text), textBox31.Text, textBox9.Text, int.Parse(textBox28.Text), int.Parse(textBox27.Text)));
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

        private void button10_Click(object sender, EventArgs e)
        {
            MySeries.MyComicList.add(new Comic(textBox33.Text, textBox34.Text, dateTimePicker5.Value.ToString("yyyy-MM-dd"), comboBox9.Text, int.Parse(comboBox10.Text), textBox35.Text, textBox25.Text, int.Parse(textBox32.Text), int.Parse(textBox36.Text), int.Parse(textBox26.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySeries.MyMangaList.add(new Manga(textBox20.Text, textBox21.Text, dateTimePicker3.Value.ToString("yyyy-MM-dd"), comboBox5.Text, int.Parse(comboBox6.Text), textBox22.Text, textBox17.Text, int.Parse(textBox19.Text), int.Parse(textBox40.Text), int.Parse(textBox18.Text), comboBox11.Text));
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MySeries.MyGameList.add(new Videogame(textBox37.Text, textBox38.Text, dateTimePicker6.Value.ToString("yyyy-MM-dd"), comboBox12.Text, int.Parse(comboBox13.Text), textBox39.Text, textBox24.Text, textBox23.Text));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox37.Clear();
            textBox38.Clear();
            comboBox12.SelectedIndex = 0;
            comboBox13.SelectedIndex = 0;
            textBox39.Clear();
            textBox24.Clear();
            textBox23.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox14.Clear();
            textBox15.Clear();
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            textBox16.Clear();
            textBox13.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox10.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox29.Clear();
            textBox30.Clear();
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;
            textBox31.Clear();
            textBox9.Clear();
            textBox28.Clear();
            textBox27.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox33.Clear();
            textBox34.Clear();
            comboBox9.SelectedIndex = 0;
            comboBox10.SelectedIndex = 0;
            textBox35.Clear();
            textBox25.Clear();
            textBox32.Clear();            
            textBox36.Clear();
            textBox26.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox20.Clear();
            textBox21.Clear();
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            textBox22.Clear();
            textBox17.Clear();
            textBox19.Clear();
            textBox40.Clear();
            textBox18.Clear();
            comboBox11.SelectedIndex = 0;
        }
    }
}
