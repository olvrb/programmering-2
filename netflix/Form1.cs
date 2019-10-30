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

        // Helper for the current selected title
        private Title selectedTitle => library.GetTitleByName((string)titles_listBox.Items[titles_listBox.SelectedIndex]);
        // Helper for the current selected season
        private Season selectedSeason => ((Show)selectedTitle).GetSeasonByNumber(seasons_listBox.SelectedIndex);


        private Library library = new Library();

        // Populate database for demo
        private void PopulateDatabase()
        {
            library.Populate();
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
            if (titles_listBox.SelectedIndex == -1) return;

            // Dispose of previous info
            info_box.Clear();
            seasons_listBox.Items.Clear();

            updateTitles();
        }

        private void Seasons_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seasons_listBox.SelectedIndex == -1) return;

            episodes_listBox.Items.Clear();

            updateEpisodes();
        }

        private void updateTitles()
        {
            bool isShow = selectedTitle is Show;

            pictureBox1.Image = selectedTitle.Poster;

            info_box.Text += $"Name: {selectedTitle.Name}\n";
            info_box.Text += $"Average Rating: {selectedTitle.AverageRating}\n";

            if (isShow)
            {
                info_box.Text += $"Amount of seasons: {((Show)selectedTitle).Seasons.Count}\n";
                updateSeasons();
            }
        }

        private void updateSeasons()
        {
            // Add all seasons of the selected Show to listbox
            for (int i = 0; i < ((Show)selectedTitle).Seasons.Count; i++)
            {
                // +1 becomes season 0 is not a thing.
                seasons_listBox.Items.Add(i + 1);
            }
        } 

        private void updateEpisodes()
        {
            // Add all episodes of selected season to listbox
            foreach (var episode in selectedSeason.Episodes)
            {
                episodes_listBox.Items.Add(episode.Name);
            }
        }
    }
}
