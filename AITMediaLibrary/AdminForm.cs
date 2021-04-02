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
    public partial class AdminForm : Form
    {
        private UserLogic userLogic = new UserLogic();
        private UserModel selectedUser = null;

        public AdminForm()
        {
            InitializeComponent();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshUserList();
            //populate comboBox
            userLevelCombo.DataSource = Enum.GetValues(typeof(AppEnum.UserLevel));
        }

        private void RefreshUserList()
        {
            userGridView.DataSource = userLogic.GetListOfUsers();
        }

        private void SelectUser(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1)//-1 for clicking column names :/
            {
                //get users from the datagrid view
                //dataGridView's DataSource is an Object. So when we give it stuff it references
                //it as a basic type. DataGridView can display any objects properties, so it doesn't 
                //care what type.
                //HOWEVER, we know we put it in as a list of users and we want to work with
                //as a list of users when we get it. So cast it back into a list of users
                List<UserModel> users = (List<UserModel>)userGridView.DataSource;
                //get the user at this position in the list and reference them as the selected user
                selectedUser = users.ElementAt<UserModel>(row);
            }
        }

        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                
                //delete user in DB
                int affectedRows = userLogic.DeleteUserByUserID(selectedUser.UserID);
                if (affectedRows > 0)
                {
                    //dudes deleted, all good, yay, do whatever success stuff
                }
                else
                {
                    //couldnt find any users of this userID
                }
                //clear out selectedUser
                selectedUser = null;
                //refresh list
                RefreshUserList();
            }
        }

        private void updatePasswordBtn_Click(object sender, EventArgs e)
        {
            //TODO for assignment: MAKE SURE PASSWORD VALIDATION IS GOOD
            if (selectedUser != null)
            {
                //update selected user with new password ONLY IF current logged in user is an admin
                int rowsAffected = userLogic.UpdatePassword(newPasswordTextBox.Text, selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    MessageBox.Show(selectedUser.Username + " password updated!");      
                }

                RefreshUserList();
            }
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            //TODO for assignment: MAKE SURE PASSWORD VALIDATION IS GOOD AND NO FIELDS ARE LEFT EMPTY
            
            //Note: Combobox holds a list of strings, so we convert that string to the actual enum value it reperesents
            AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelCombo.Text);
            //we pass all the values to AddNewUser. We can cast enums to ints to get their numeric value
            userLogic.AddNewUser(usernameTextBox.Text, passwordTextBox.Text, (int)userLevel, emailTextBox.Text);

            RefreshUserList();
        }

        private void logOutAdminBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void mediaOperationsBtn_Click(object sender, EventArgs e)
        {
            MediaOperations mediaOperations = new MediaOperations();
            mediaOperations.Show();
            this.Hide();
        }

        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
