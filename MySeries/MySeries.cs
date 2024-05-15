using MySeries.Classes;
using SQL;
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
    public partial class MySeries : Form
    {
        private int childFormNumber = 0;
        public static Repository MyTVList = new Repository("TV");
        public static Repository MyAnimeList = new Repository("Anime");
        public static Repository MyBookList = new Repository("Book");
        public static Repository MyComicList = new Repository("Comics");
        public static Repository MyMangaList = new Repository("Mangas");
        public static Repository MyGameList = new Repository("Videogames");

        public MySeries()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MySeries_Load(object sender, EventArgs e)
        {
            SQLConnection.open();
            TV series = new TV("Stranger Things", "Duffer", "2016", "thriller", 9, "Pretty good", 34, 45, "Duffer", "Duffer"); 
            TV series2 = new TV("Breaking Bad", "Vince Gilligan", "2008", "drama", 8, "Awesome", 62, 45, "Vince Gilligan", "Vince Gilligan");
            TV series3 = new TV("Wednesday", "Alfred Gough", "2022", "comedy", 10, "I love Jenna Ortega", 8, 45, "Tim Burton", "Tim Burton");
            MyTVList.add(series);
            MyTVList.add(series2);
            MyTVList.add(series3);
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewEntry form = new NewEntry();
            form.MdiParent = this;
            form.Show();
        }

        private void animeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            MyLists form = new MyLists();
            form.MdiParent = this;
            form.Show();
        }

        private void newEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search form = new Search();
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
