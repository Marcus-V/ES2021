using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            welcomeLbl.Text = "Welcome " + AitLibary.username;

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["AitLibary"];
            form.Show();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Update();
        }
    }
}
