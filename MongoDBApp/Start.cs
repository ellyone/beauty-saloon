using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MongoDBApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Price_button_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Hide();
            PriceList PriceForm = new PriceList();
            PriceForm.Show();
        }

        private void Employee_button_Click(object sender, EventArgs e)
        {
            Start.ActiveForm.Hide();
            EmployeeForm EmployeeForm = new EmployeeForm();
            EmployeeForm.Show();
        }

        private void linkLabelEnterAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Start.ActiveForm.Hide();
            AdminAuthorization EnterAdmin = new AdminAuthorization();
            EnterAdmin.Show();
        }

        private void linkLabelEnterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Start.ActiveForm.Hide();
            UserAuthorization EnterUser = new UserAuthorization();
            EnterUser.Show();
        }
    }
}
