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

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string searchWord = textBox1.Text;

            List<Artwork> matches = new List<Artwork>();

            foreach (Artwork artwork in MySeries.MyTVList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }

            foreach (Artwork artwork in MySeries.MyAnimeList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }

            foreach (Artwork artwork in MySeries.MyBookList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }
            foreach (Artwork artwork in MySeries.MyComicList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }

            foreach (Artwork artwork in MySeries.MyMangaList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }

            foreach (Artwork artwork in MySeries.MyGameList.getList())
            {
                if (artwork.ToString().Contains(searchWord))
                    matches.Add(artwork);
            }

            for (int i = 0; i < matches.Count; i++)
            {
                var index = dataGridView1.Rows.Add();

                Artwork artwork = matches[i];

                dataGridView1.Rows[index].Cells[0].Value = artwork.Title;
                dataGridView1.Rows[index].Cells[1].Value = artwork.Author;
                dataGridView1.Rows[index].Cells[2].Value = artwork.Date;
                dataGridView1.Rows[index].Cells[3].Value = artwork.Genre;
                dataGridView1.Rows[index].Cells[4].Value = artwork.Rating;
            }
        }
    }
}
