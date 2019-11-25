using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using netflix.Elements;
using netflix.Elements.Shows;

namespace netflix {
    public partial class LibraryView : Form {
        private readonly Library library = new Library();

        public LibraryView() {
            InitializeComponent();
        }

        // Helper for the current selected title
        private Title SelectedTitle =>
            library.GetTitleByName((string) titles_listBox.Items[titles_listBox.SelectedIndex]);

        // Helper for the current selected season
        private Season SelectedSeason => ((Show) SelectedTitle).GetSeasonByNumber(seasons_listBox.SelectedIndex);

        // Populate database for demo. This would ideally be done by fetching titles from a database,
        // Possibly an API, depending on the use case.
        private void PopulateDatabase() {
            library.Populate();
        }

        private void Form1_Load(object sender, EventArgs e) {
            PopulateDatabase();

            foreach (Title title in library) {
                titles_listBox.Items.Add(title.Name);
            }
        }

        private void Titles_listBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (titles_listBox.SelectedIndex == -1) {
                return;
            }

            // Dispose of previous info
            info_box.Clear();
            seasons_listBox.Items.Clear();

            UpdateTitles();
        }

        private void Seasons_listBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (seasons_listBox.SelectedIndex == -1) {
                return;
            }

            episodes_listBox.Items.Clear();

            UpdateEpisodes();
        }

        private void UpdateTitles() {
            bool isShow = SelectedTitle is Show;

            pictureBox1.Image = SelectedTitle.Thumbnail;

            info_box.Text += $"Name: {SelectedTitle.Name}\n";
            info_box.Text += $"Average Rating: {SelectedTitle.AverageRating}\n";
            info_box.Text += $"Description: {SelectedTitle.Description}\n";
            info_box.Text += $"Link: https://netflix.com/watch/{SelectedTitle.NetflixId}\n";

            if (isShow) {
                info_box.Text += $"Amount of seasons: {((Show) SelectedTitle).Seasons.Count}\n";
                UpdateSeasons();
            }
        }

        private void UpdateSeasons() {
            // Add all seasons of the selected Show to listbox
            for (int i = 0; i < ((Show) SelectedTitle).Seasons.Count; i++) {
                // +1 becomes season 0 is not a thing
                seasons_listBox.Items.Add(i + 1);
            }
        }

        private void UpdateEpisodes() {
            // Add all episodes of selected season to listbox
            foreach (Episode episode in SelectedSeason.Episodes) {
                episodes_listBox.Items.Add(episode.Name);
            }
        }

        private void UpdateTitleList() {
            titles_listBox.Items.Clear();
            foreach (Title title in library) {
                titles_listBox.Items.Add(title.Name);
            }
        }

        private void AddTitle_Click(object sender, EventArgs e) {
            AddTitleDialog testDialog = new AddTitleDialog();
            if (testDialog.ShowDialog(this) == DialogResult.OK) {
                testDialog.Close();
                // Don't freeze the UI thread
                Task.Run(() => {
                    library.AddTitle(new Title(testDialog.input.Text));
                    Invoke(new MethodInvoker(UpdateTitleList));
                });
            }
        }

        private void Info_box_LinkClicked(object sender, LinkClickedEventArgs e) {
            Process.Start(e.LinkText);
        }
    }
}