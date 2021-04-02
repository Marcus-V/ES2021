using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer.MediaDSTableAdapters;

namespace DataAccessLayer
{
    public class MediaDAO
    {
        private MediaDS mediaDataSet;
        private ViewMediaTableAdapter viewMediaAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabGenreTableAdapter genreTableAdapter;
        private TabMediaTableAdapter tabMediaTableAdapter;
        private TabBorrowTableAdapter borrowTableAdapter;
        private TabReservedTableAdapter reservedTableAdapter;

        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            viewMediaAdapter = new ViewMediaTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            genreTableAdapter = new TabGenreTableAdapter();
            tabMediaTableAdapter = new TabMediaTableAdapter();
            borrowTableAdapter = new TabBorrowTableAdapter();
            reservedTableAdapter = new TabReservedTableAdapter();
        }

        public MediaDS.ViewMediaDataTable ListMedia()
        {
            viewMediaAdapter.Fill(mediaDataSet.ViewMedia);
            return mediaDataSet.ViewMedia;
        }
        public MediaDS.ViewMediaDataTable ListMediaByPublishYear(int publishYear)
        {
            viewMediaAdapter.FillByPublishYear(mediaDataSet.ViewMedia, publishYear);
            return mediaDataSet.ViewMedia;
        }
        public MediaDS.TabLanguageDataTable ListLanguages()
        {
            languageTableAdapter.Fill(mediaDataSet.TabLanguage);
            return mediaDataSet.TabLanguage;
        }
        public MediaDS.TabGenreDataTable ListGenres()
        {
            genreTableAdapter.Fill(mediaDataSet.TabGenre);
            return mediaDataSet.TabGenre;
        }

        public MediaDS.ViewMediaDataTable ListMediaByTitle(string title)
        {
            viewMediaAdapter.FillWithTitle(mediaDataSet.ViewMedia, title);
            return mediaDataSet.ViewMedia;
        }

        public MediaDS.ViewMediaDataTable ListMediaByGenre(string genre)
        {
            viewMediaAdapter.FillByGenre(mediaDataSet.ViewMedia, genre);
            return mediaDataSet.ViewMedia;
        }
        public int AddMedia(string title,int genreId, int directorId, int languageId, int year, decimal budget)
        {
            return tabMediaTableAdapter.InsertMedia(title, genreId, directorId, languageId, year, budget);
        }
        public int UpdateMedia(string title, int genreId, int directorId, int languageId, int year, decimal budget, int mediaId)
        {

            return tabMediaTableAdapter.UpdateMedia(title, genreId, directorId, languageId, year, budget, mediaId);
        }
        public int DeleteMediaByID(int mediaId)
        {
            return tabMediaTableAdapter.DeleteMedia(mediaId);
        }
        //tabBorrow Crud operations
        public MediaDS.TabBorrowDataTable ListBorrow()
        {
            borrowTableAdapter.FillWithBorrowList(mediaDataSet.TabBorrow);
            return mediaDataSet.TabBorrow;
        }
        public int AddBorrow(int uid, int mediaID, string borrowDate, string returnDate, string actualReturnDate, decimal lateFee)
        {
            return borrowTableAdapter.InsertBorrowRequest(uid, mediaID, borrowDate, returnDate, actualReturnDate, lateFee);
        }
        public int UpdateBorrowRequest( string actualReturnDate, int bid)
        {

            return borrowTableAdapter.UpdateBorrowRequest(actualReturnDate, bid);
        }
        //tabReserved Crud operations
        public MediaDS.TabReservedDataTable ListReserved()
        {
            reservedTableAdapter.Fill(mediaDataSet.TabReserved);
            return mediaDataSet.TabReserved;
        }
        
        public int InsertNewReservation(int uid, int mediaID, string reservedDate)
        {
            return reservedTableAdapter.InsertReservation(uid, mediaID, reservedDate);
        }

        public int UpdateReservation(int uid, int mediaID, string reservedDate, int rid)
        {
            return reservedTableAdapter.UpdateReservation(uid, mediaID, reservedDate, rid);
        }
    }
}
