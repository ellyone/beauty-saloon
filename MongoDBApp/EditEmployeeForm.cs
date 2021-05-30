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
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace MongoDBApp
{
    public partial class EditEmployeeForm : Form
    {
        Employee obj;

        public EditEmployeeForm(Employee emp)
        {
            InitializeComponent();
            obj = emp;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            CategoriesList cat_list = new CategoriesList();
            foreach (var i in cat_list.CategoryData)
            {
                checkedListBoxEditEmployeeSpecialty.Items.Add(i.name);
            }
            textBoxEditEmployeeName.Text = obj.document["name"];
            textBoxEditEmployeeDesc.Text = obj.document["description"];
            foreach (var i in obj.document["specialty"].Split(','))
            {
                checkedListBoxEditEmployeeSpecialty.SetItemChecked(Int32.Parse(i) - 1, true);
            }
        }

        private void buttonSaveEmployee_Click(object sender, EventArgs e)
        {

            CategoriesList cat_list = new CategoriesList();
            string str_cat = "";
            foreach(var i in checkedListBoxEditEmployeeSpecialty.CheckedItems)
            {
                foreach(var j in cat_list.CategoryData)
                {
                    if (j.name == i.ToString())
                        str_cat = str_cat + j.id.ToString() + ",";
                }
            }
            str_cat=str_cat.Remove(str_cat.Length-1, 1);

            var filter = BsonDocument.Parse("{ \"_id\" : ObjectId(\"" + obj.document["_id"] + "\") }");
            var update = BsonDocument.Parse("{$set : {\"name\" : \"" + textBoxEditEmployeeName.Text + "\", \"description\" : \"" + textBoxEditEmployeeDesc.Text + "\", \"specialty\" : \"" + str_cat + "\"}}");

            if (obj.EditEmployee(filter, update))
            {
                labelEditEmployeeItog.Text = "Выполнено!";
            }
            else
            {
                labelEditEmployeeItog.Text = "Ошибка!";
            }
        }

        private void linkLabelReturnFromEditEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditEmployeeForm.ActiveForm.Hide();
            AdminPanel EditForm = new AdminPanel();
            EditForm.Show();
        }
    }
}
