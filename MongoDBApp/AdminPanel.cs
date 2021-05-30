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

namespace MongoDBApp
{
    public partial class AdminPanel : Form
    {
        EmployeeList emp = new EmployeeList();
        ServiceList ser = new ServiceList();
        UserList us = new UserList();
        List<Visit> list_visit = new List<Visit>();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            adminListBoxEmployee.Items.Clear();
            adminListBoxService.Items.Clear();
            adminListBoxUser.Items.Clear();
            listBoxForApprove.Items.Clear();

            BsonDocument filter = new BsonDocument();
            emp = emp.GetEmployee(filter);
            ser = ser.GetService(filter);
            us = us.GetUser(filter);

            foreach (var i in emp.EmployeeData)
            {
                adminListBoxEmployee.Items.Add(i.document["name"]);
            }

            foreach (var i in ser.ServiceData)
            {
                adminListBoxService.Items.Add(i.document["name"]);
            }

            foreach (var i in us.UserData)
            {
                adminListBoxUser.Items.Add(i.document["login"]);
            }

            //var dt = DateTime.Now.AddDays(1);
            //string tmp = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString() + "T00:00:00Z";
            //dt = DateTime.Now.AddDays(2);
            //string _tmp = dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + dt.Day.ToString() + "T00:00:00Z";
            //filter = BsonDocument.Parse("{ date : {$gt : ISODate (\""+tmp+ "\"), $lt : ISODate (\"" + _tmp + "\")} }");

            //Visits visits = new Visits(filter);
            //foreach (var i in visits.VisitsData)
            //{
            //    Service service = new Service();
            //    Employee employer = new Employee();
            //    User user = new User();

            //    filter = BsonDocument.Parse(String.Format("{ _id : }", i.document["service"]));

            //    MongoConnection conn = new MongoConnection();
            //    var collection = conn.database.GetCollection<BsonDocument>("service");
            //    var services = collection.Find(filter).Limit(1).ToBsonDocument();

            //    string name_service = services.GetValue("name").ToString();
            //    string price_sercice = services.GetValue("price").ToString();

            //    filter = BsonDocument.Parse(String.Format("{ _id : }", i.document["employee"]));

            //    collection = conn.database.GetCollection<BsonDocument>("employee");
            //    var employee = collection.Find(filter).Limit(1).ToBsonDocument();

            //    string name_employer = employee.GetValue("name").ToString();

            //    filter = BsonDocument.Parse(String.Format("{ _id : }", i.document["user"]));

            //    collection = conn.database.GetCollection<BsonDocument>("users");
            //    var users = collection.Find(filter).Limit(1).ToBsonDocument();

            //    string name_user = users.GetValue("name").ToString();
            //    string tel_user = users.GetValue("tel").ToString();

                //listBoxForApprove.Items.Add()
            //}
        }

        private void adminListBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = adminListBoxEmployee.SelectedIndex;
            Employee obj = new Employee();
            obj = emp.EmployeeData[index];
            string cat = obj.document["specialty"];
            List<Category> cat_list = obj.Categories.CategoryData.ToList();
            string str_cat = "";
            foreach (var i in cat.Split(','))
            {
                str_cat = str_cat + " " + cat_list[Int32.Parse(i) - 1].name;
            }
            adminTextBoxEmployee.Text = String.Format("\t\t{0}\n\nСпециальность: {2}\n\n{1}",
                obj.document["name"],
                obj.document["description"],
                str_cat);
        }

        private void adminListBoxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = adminListBoxService.SelectedIndex;
            Service obj = new Service();
            obj = ser.ServiceData[index];
            string cat = obj.document["category"];
            List<Category> cat_list = obj.Categories.CategoryData.ToList();
            adminTextBoxService.Text = String.Format("\t\t{0}\n\n\t{1}\n\nЦена: {2}\n\nКатегория: {3}",
                obj.document["name"],
                obj.document["description"],
                obj.document["price"],
                cat_list[Int32.Parse(cat) - 1].name);
        }

        private void adminListBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = adminListBoxUser.SelectedIndex;
            User obj = new User();
            obj = us.UserData[index];
            string role = obj.document["role"];
            List<Role> role_list = obj.Roles.RoleData.ToList();
            adminTextBoxUser.Text = String.Format("Login: {0}\n\nPassword: {1}\n\nФамилия: {2}\n\nИмя: {3}\n\n Роль: {4}",
                obj.document["login"],
                obj.document["pass"],
                obj.document["fname"],
                obj.document["lname"],
                role_list[Int32.Parse(role) - 1].name);
        }

        private void buttonEditEmployee_Click(object sender, EventArgs e)
        {
            AdminPanel.ActiveForm.Hide();
            EditEmployeeForm editForm = new EditEmployeeForm(emp.EmployeeData[adminListBoxEmployee.SelectedIndex]);
            editForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
