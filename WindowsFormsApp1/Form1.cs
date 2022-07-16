using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeSearch;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();
            foreach(var item in items.SearchQuery(txtSearch.Text, 1))
            {
                Video video = new Video();
                video.Title = item.Title;
                video.Author = item.Author;
                video.Url = item.Url;
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using(MemoryStream ms = new MemoryStream(imageBytes))
                {

                }
            videoBindingSource.DataSource = list;
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        private BadImageFormatException Image(MemoryStream ms)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
