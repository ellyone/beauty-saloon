using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDBApp.Structures;
using MongoDB.Bson;

namespace MongoDBApp
{
    public partial class EmployeeForm : Form
    {
        Structures.EmployeeList emp = new Structures.EmployeeList();
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BsonDocument filter = new BsonDocument();
            emp = emp.GetEmployee(filter);

            foreach (var i in emp.EmployeeData) 
            {
                listEmployee.Items.Add(i.document["name"]);
            }
        }

        private void linkMenu3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeForm.ActiveForm.Hide();
            Start Menu = new Start();
            Menu.Show();
        }

        private void listEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmployeeTextBox.Text = String.Format("\t\t{0}\n\n\t{1}", 
                emp.EmployeeData[listEmployee.SelectedIndex].document[emp.EmployeeData[listEmployee.SelectedIndex].Keys[1]], 
                emp.EmployeeData[listEmployee.SelectedIndex].document[emp.EmployeeData[listEmployee.SelectedIndex].Keys[2]]);
        }
    }
}
