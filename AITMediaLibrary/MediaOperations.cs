using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AITMediaLibrary
{
    public partial class MediaOperations : Form
    {
        private BorrowLogic borrowLogic = new BorrowLogic();
        private BorrowModel selectedBorrowItem = null;

        private ReservationLogic reservationLogic = new ReservationLogic();
        private ReservationModel selectedReservedItem = null;
        public MediaOperations()
        {
            InitializeComponent();
        }
        
        private void RefreshBorrowList()
        {
            borrowDataGridView.DataSource = borrowLogic.ListBorrowedItems();
        }
        private void SelectBorrowItem(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1)//-1 for clicking column names
            {
                List<BorrowModel> borrow = (List<BorrowModel>)borrowDataGridView.DataSource;
                selectedBorrowItem = borrow.ElementAt<BorrowModel>(row);
            }
        }

        private void RefreshReservedList()
        {
            reservedDataGridView.DataSource = reservationLogic.ListReservedItems();
        }

        private void SelectReservedItem(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1)//-1 for clicking column names
            {
                List<ReservationModel> borrow = (List<ReservationModel>)reservedDataGridView.DataSource;
                selectedReservedItem= borrow.ElementAt<ReservationModel>(row);
            }
        }

        private void refreshBorrowListBtn_Click(object sender, EventArgs e)
        {
            RefreshBorrowList();
        }

        private void borrowBtn_Click(object sender, EventArgs e)
        {
            decimal lateFee = 0;
            borrowLogic.AddBorrow(
                int.Parse(userIdBorrowTxtBox.Text),
                int.Parse(mediaIdBorrowTxtBox.Text),
                borrowDateTimePicker.Value.ToString("yyyy-MM-dd"),
                estimatedDateTimePicker.Value.ToString("yyyy-MM-dd"),
                actualDateTimePicker.Value.ToString("yyyy-MM-dd"),
                lateFee
                );

            RefreshBorrowList();
        }

        private void refreshReservationsListBtn_Click(object sender, EventArgs e)
        {
            RefreshReservedList();
        }

        private void reserveMediaBtn_Click(object sender, EventArgs e)
        {
            reservationLogic.InsertNewReservation(
                int.Parse(userIdResTxtBox.Text),
                int.Parse(mediaIdRestxtBox.Text),
                reservationDateTimePicker.Value.ToString("yyyy-MM-dd")
                );
            RefreshReservedList();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void updateBorrowBtn_Click(object sender, EventArgs e)
        {
            if (selectedBorrowItem != null)
            {
                int rowsAffected = 
                    borrowLogic.UpdateBorrowRequest(uActRturndateTimePicker.Value.ToString("yyyy-MM-dd")
                    ,selectedBorrowItem.BID);
                if (rowsAffected > 0)
                {
                    MessageBox.Show(selectedBorrowItem.BID + " Borrow Item updated");
                }
                RefreshBorrowList();
            }
        }

        private void borrowDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            try
            {
            if (row >= 0)
            {
                List<BorrowModel> models = (List<BorrowModel>)borrowDataGridView.DataSource;
                //get selected row
                BorrowModel borrow = models.ElementAt(row);
                    //change label to show Borrow id
                    //figure out why only works on a few cells not all ( ids and actual return date dont pass value)
                    selectedBorrowItemLbl.Text = "Update BID = " + borrow.BID.ToString();
            }
            }
            catch(Exception ex)
            {
            Console.WriteLine(ex.Message);
            }
        }
    }
}