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
    public partial class MyLists : Form
    {
        public MyLists()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Book_Click(object sender, EventArgs e)
        {

        }

        private void MyLists_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < MySeries.MyTVList.getList().Count ; i++)
            {
                var index = dataGridView1.Rows.Add();

                Artwork series = MySeries.MyTVList.getList()[i];

                dataGridView1.Rows[index].Cells[0].Value = series.Title;
                dataGridView1.Rows[index].Cells[1].Value = series.Author;
                dataGridView1.Rows[index].Cells[2].Value = series.Date;
                dataGridView1.Rows[index].Cells[3].Value = series.Genre;
                dataGridView1.Rows[index].Cells[4].Value = series.Rating;
            }
        }
    }
}
