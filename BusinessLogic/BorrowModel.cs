using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowModel
    {
        private int bid;
        private int uid;
        private int mediaId;
        private string borrowDate;
        private string returnDate;
        private string actualReturnDate;
        private decimal lateFee;

        public int BID
        {
            set { bid = value; }
            get { return bid; }
        }
        public int UID
        {
            set { uid = value; }
            get { return uid; }
        }
        public int MediaID
        {
            set { mediaId = value; }
            get { return mediaId; }
        }
        public string BorrowDate
        {
            set { borrowDate = value; }
            get { return borrowDate; }
        }

        public string ReturnDate
        {
            set { returnDate = value; }
            get { return returnDate; }
        }

        public string ActualReturnDate
        {
            set { actualReturnDate = value; }
            get { return actualReturnDate; }
        }

        public decimal LateFee
        {
            set { lateFee = value; }
            get { return lateFee; }
        }

        public static BorrowModel Parse(MediaDS.TabBorrowRow borrowRow)
        {
            if (borrowRow == null)
                return null;

            BorrowModel borrow = new BorrowModel();
            borrow.bid = borrowRow.BID;
            borrow.uid = borrowRow.UID;
            borrow.mediaId = borrowRow.MediaID;
            borrow.borrowDate = borrowRow.BorrowDate.ToString("yyyyMMdd");
            borrow.returnDate = borrowRow.ReturnDate.ToString("yyyyMMdd");
            borrow.actualReturnDate = borrowRow.ActualReturnDate.ToString("yyyyMMdd");
            borrow.lateFee = borrowRow.LateFee;

            return borrow;
        }

    }
}
