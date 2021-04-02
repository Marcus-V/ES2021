using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.ViewMediaDataTable mediaTable;
        private MediaDS.TabLanguageDataTable languageTable;
        private MediaDS.TabGenreDataTable genreTable;
        private MediaDS.TabMediaDataTable tabMediaTable;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.ViewMediaDataTable();
            languageTable = new MediaDS.TabLanguageDataTable();
            genreTable = new MediaDS.TabGenreDataTable();
            tabMediaTable = new MediaDS.TabMediaDataTable(); 
        }

        public List<MediaModel> ListMedia()
        {
            List<MediaModel> allMedia = new List<MediaModel>();
            mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                allMedia.Add(media);
            }
            return allMedia;
        }
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> allMedia = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                allMedia.Add(media);
            }
            return allMedia;
        }
        public List<PairModel> ListLanguages()
        {
            //unused code from file in canvas that allows list all languages based on TabLanguage
            List<PairModel> list = new List<PairModel>();
            languageTable = mediaDAO.ListLanguages();
            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
        public List<PairModel> ListGenres()
        {
            //unused code from file in canvas that allows list all genres based on TabGenre
            List<PairModel> list = new List<PairModel>();
            genreTable = mediaDAO.ListGenres();
            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }

        public List<MediaModel> ListMediaByTitle(string title)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByTitle(title);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }

        //search by genre 
        public List<MediaModel> ListMediaGenre(string genre)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByGenre(genre);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
    }
}
