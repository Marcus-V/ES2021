using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaModel
    {
        #region attributes

        private int mediaId;
        private string mediaTitle;
        private int mediaPublishYear;
        private string mediaDirector;
        private string mediaGenre;
        private string mediaLanguage;
        private decimal mediaBudget;

        #endregion
        #region properties
        public int MediaID
        {
            set { mediaId = value; }
            get { return mediaId; }
        }
        public string MediaTitle
        {
            set { mediaTitle = value; }
            get { return mediaTitle; }
        }
        public int MediaPublishYear
        {
            set { mediaPublishYear = value; }
            get { return mediaPublishYear; }
        }
        public string MediaDirector
        {
            set { mediaDirector = value; }
            get { return mediaDirector; }
        }
        public string MediaGenre
        {
            set { mediaGenre = value; }
            get { return mediaGenre; }
        }
        public string MediaLanguage
        {
            set { mediaLanguage = value; }
            get { return mediaLanguage; }
        }
        public decimal MediaBudget
        {
            set { mediaBudget = value; }
            get { return mediaBudget; }
        }
        #endregion

        public static MediaModel Parse(MediaDS.ViewMediaRow mediaRow)
        {
            if (mediaRow == null)
                return null;

            MediaModel media = new MediaModel();
            media.MediaID = mediaRow.MediaID;
            media.MediaTitle = mediaRow.Title;
            media.MediaPublishYear = mediaRow.PublishYear;
            media.MediaDirector = mediaRow.DirectorName;
            media.MediaGenre = mediaRow.GenreName;
            media.MediaLanguage = mediaRow.LanguageName;
            media.MediaBudget = mediaRow.Budget;
            return media;
        }
    }
}
