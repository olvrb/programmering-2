using netflix.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netflix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Library library = new Library();

        private void PopulateDatabase()
        {
            library.AddTitle(new Show("Brooklyn Nine Nine", new List<Rating> { new Rating(10) }, new Bitmap(1024, 1024), new List<Season> { new Season(new List<Episode> { new Episode(10) }) }));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDatabase();

            foreach (var title in library.GetTitles())
            {
                titles_listBox.Items.Add(title.Name);
            }
        }

        private void Titles_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = (string)titles_listBox.Items[titles_listBox.SelectedIndex];
            Title selectedTitle = library.GetTitleByName(name);
            bool isShow = selectedTitle is Show;

            info_box.Text += $"Name: {selectedTitle.Name}\n";
            info_box.Text += $"Average Rating: {selectedTitle.AverageRating}\n";
            if (isShow)
            {
                info_box.Text += $"Amount of seasons: {((Show)selectedTitle).Seasons.Count}\n";
            }
        }
    }
}
