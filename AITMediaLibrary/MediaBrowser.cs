using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogic;

namespace AITMediaLibrary
{
    public partial class MediaBrowser : Form
    {
        public MediaBrowser()
        {
            InitializeComponent();
        }

        private void MediaBrowser_Load(object sender, EventArgs e)
        {
            userDetailLbl.Text ="Username: "+ CurrentUser.Username + " \nUser Level: " + CurrentUser.UserLevel;
        }

        private void publishYearSearchBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void searchPublishYearButton_Click(object sender, EventArgs e)
        {
            if (publishYearTxtBox.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {
                    //find media based on whats typed into the publish year textbox
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(Int32.Parse(publishYearTxtBox.Text));
                }
                catch (Exception ex)
                {
                    //if user typed in something that can't be parsed into an int e.g "sdfsdf" then- 
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByPublishYear(0); //chuck in zero for the year
                }
            }
        }

        private void listMediaBtn_Click_1(object sender, EventArgs e)
        {
            MediaLogic mediaLogic = new MediaLogic();

            //set data source for data grid view
            mediaDataGridView.DataSource = mediaLogic.ListMedia();
        }

        private void mediaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //use the e arg to get info on which cell was clicked. I only care about the row
            int row = e.RowIndex;
            if (row >= 0)
            {
                //BUG FIX: Logic error on Matts side, my bad
                //get list of models from the data grid view (changes based on searches etc)
                List<MediaModel> models = (List<MediaModel>)mediaDataGridView.DataSource;
                //get selected row media
                MediaModel media = models.ElementAt<MediaModel>(row);
                //change label to show name of media
                mediaLbl.Text = media.MediaTitle;
            }
        }

        private void titleSearchBtn_Click(object sender, EventArgs e)
        {
            if (titleTextBox.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByTitle(titleTextBox.Text);
                }
                catch (Exception ex)
                {
                    mediaDataGridView.DataSource = mediaLogic.ListMediaByTitle("");
                }
            }
        }

        private void genreSearchBtn_Click(object sender, EventArgs e)
        {
            if (genreTxtBox.Text != "")
            {
                MediaLogic mediaLogic = new MediaLogic();
                try
                {
                    //find media based on genre
                    mediaDataGridView.DataSource = mediaLogic.ListMediaGenre(genreTxtBox.Text);
                }
                catch (Exception ex)
                {
                    mediaDataGridView.DataSource = mediaLogic.ListMediaGenre("");
                }
            }
        }

        private void logOutBtn_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
