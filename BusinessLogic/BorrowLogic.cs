using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class BorrowLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.TabBorrowDataTable borrowTable;

        public BorrowLogic()
        {
            mediaDAO = new MediaDAO();
            borrowTable = new MediaDS.TabBorrowDataTable();
        }

        public List<BorrowModel> ListBorrowedItems()
        {
            List<BorrowModel> borrowList = new List<BorrowModel>();
            borrowTable = mediaDAO.ListBorrow();

            foreach (MediaDS.TabBorrowRow row in borrowTable.Rows)
            {
                BorrowModel borrowItem = BorrowModel.Parse(row);
                borrowList.Add(borrowItem);
            }
            return borrowList;
        }

        //add new borrow
        public int AddBorrow(int uid, int mediaID, string borrowDate, string returnDate, string actualReturnDate, decimal lateFee)
        {
            return mediaDAO.AddBorrow(uid, mediaID, borrowDate, returnDate, actualReturnDate, lateFee);
        }

        //update borrow
        public int UpdateBorrowRequest(string newActualReturnDate, int bid)
        {
            return mediaDAO.UpdateBorrowRequest( newActualReturnDate, bid);
        }
    }
}