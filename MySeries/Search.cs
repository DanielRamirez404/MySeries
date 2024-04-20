using MySeries.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySeries
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Load(object sender, EventArgs e)
        {
            //todo, this is just an example

            dataGridView1.Rows.Add();

            dataGridView1.Rows[0].Cells[0].Value = "Manga";
            dataGridView1.Rows[0].Cells[1].Value = "One Piece";
            dataGridView1.Rows[0].Cells[2].Value = "Eiichiro Oda";
            dataGridView1.Rows[0].Cells[3].Value = "1997";
            dataGridView1.Rows[0].Cells[4].Value = "Adventure";
            dataGridView1.Rows[0].Cells[5].Value = "10";

            var index = dataGridView1.Rows.Add();

            dataGridView1.Rows[index].Cells[0].Value = "Anime";
            dataGridView1.Rows[index].Cells[1].Value = "One Piece";
            dataGridView1.Rows[index].Cells[2].Value = "Eiichiro Oda";
            dataGridView1.Rows[index].Cells[3].Value = "1999";
            dataGridView1.Rows[index].Cells[4].Value = "Adventure";
            dataGridView1.Rows[index].Cells[5].Value = "8";

            index = dataGridView1.Rows.Add();

            dataGridView1.Rows[index].Cells[0].Value = "TV";
            dataGridView1.Rows[index].Cells[1].Value = "One Piece";
            dataGridView1.Rows[index].Cells[2].Value = "Matt Owens";
            dataGridView1.Rows[index].Cells[3].Value = "2023";
            dataGridView1.Rows[index].Cells[4].Value = "Live-Action";
            dataGridView1.Rows[index].Cells[5].Value = "8";
        }
    }
}
