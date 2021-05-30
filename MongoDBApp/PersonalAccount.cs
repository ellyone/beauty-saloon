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
    public partial class PersonalAccount : Form
    {
        User obj;

        List<Employee> employeeID = new List<Employee>();
        List<Service> serviceID = new List<Service>();
        List<Visit> writingsID = new List<Visit>();
        List<Visit> visitsID = new List<Visit>();
        public PersonalAccount(User user)
        {
            InitializeComponent();
            obj = user;
        }

        private void PersonalAccount_Load(object sender, EventArgs e)
        {
            labelUserName.Text += obj.document["fname"] + " " + obj.document["lname"];
            labelCountVisits.Text += GetCountVisit(obj.document["_id"]);
            labelNearVisit.Text += GetNearestVisit(obj.document["_id"]);

            foreach (var item in GetWriting(obj.document["_id"]).VisitsData)
            {
                listBoxUserOrders.Items.Add(item.document["date"].Remove(10, 10));
                writingsID.Add(item);
            }

            foreach (var item in GetVisits(obj.document["_id"]).VisitsData)
            {
                listBoxUserVisits.Items.Add(item.document["date"].Remove(10, 10));
                visitsID.Add(item);
            }

            var services = new ServiceList();
            services = services.GetService(new BsonDocument());

            foreach (var item in services.ServiceData)
            {
                comboBoxWritingService.Items.Add(item.document["name"]);
                serviceID.Add(item);
            }
        }
        public string GetCountVisit(string id)
        {
            string yyyy = DateTime.Now.Year.ToString();
            string mm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();

            if (mm.Length < 2)
            {
                mm = "0" + mm;
            }
            if (dd.Length < 2)
            {
                dd = "0" + dd;
            }

            string time = DateTime.Now.TimeOfDay.ToString();
            var filter = BsonDocument.Parse("{user : ObjectId(\""+id+"\"), date : {$lt : ISODate(\""+yyyy+ "-"+mm+ "-"+dd+"T"+time+ "\")}, status : \"4\" }");

            var result = new Visits(filter);

            return result.VisitsData.ToList().Count.ToString();
        }

        public string GetNearestVisit(string id)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");

            string yyyy = DateTime.Now.Year.ToString();
            string mm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();

            if (mm.Length < 2)
            {
                mm = "0" + mm;
            }
            if (dd.Length < 2)
            {
                dd = "0" + dd;
            }

            string time = DateTime.Now.TimeOfDay.ToString();
            var filter = BsonDocument.Parse("{user : ObjectId(\"" + id + "\"), date : {$gt : ISODate(\"" + yyyy + "-" + mm + "-" + dd + "T" + time + "\")}, status : {$in : [\"1\", \"3\"]} }");
            var sort = BsonDocument.Parse("{date : 1 }");

            var result = collection.Find(filter).Sort(sort).Limit(1).ToListAsync();
            string str = "";
            foreach (var doc in result.Result)
            {
                str = doc.GetValue("date").ToString().Remove(10,10);
            }

            return str;
        }

        public Visits GetWriting(string id)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");

            string yyyy = DateTime.Now.Year.ToString();
            string mm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();

            if (mm.Length < 2)
            {
                mm = "0" + mm;
            }
            if (dd.Length < 2)
            {
                dd = "0" + dd;
            }
            string time = DateTime.Now.TimeOfDay.ToString();
            var filter = BsonDocument.Parse("{user : ObjectId(\"" + id + "\"), date : {$gt : ISODate(\"" + yyyy + "-" + mm + "-" + dd + "T" + time + "\")}, status : {$in : [\"1\", \"3\"]} }");
            var result = new Visits(filter);

            return result;
        }

        public Visits GetVisits(string id)
        {
            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");

            string yyyy = DateTime.Now.Year.ToString();
            string mm = DateTime.Now.Month.ToString();
            string dd = DateTime.Now.Day.ToString();

            if (mm.Length < 2)
            {
                mm = "0" + mm;
            }
            if (dd.Length < 2)
            {
                dd = "0" + dd;
            }
            string time = DateTime.Now.TimeOfDay.ToString();
            var filter = BsonDocument.Parse("{user : ObjectId(\"" + id + "\"), date : {$lt : ISODate(\"" + yyyy + "-" + mm + "-" + dd + "T" + time + "\")}, status : \"4\" }");
            var result = new Visits(filter);

            return result;
        }

        private void comboBoxWritingService_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employee = new EmployeeList();
            employee = employee.GetEmployee(new BsonDocument());

            foreach (var item in employee.EmployeeData)
            {
                foreach (var cat in item.document["specialty"].Split(','))
                {
                    if (Int32.Parse(serviceID[comboBoxWritingService.SelectedIndex].document["category"]) == Int32.Parse(cat))
                    {
                        comboBoxWritingEmployee.Items.Add(item.document["name"]);
                        employeeID.Add(item);
                    }
                }
            }

            comboBoxWritingEmployee.Visible = true;
            labelMasterAddWriting.Visible = true;
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            Visits tmp = new Visits(new BsonDocument());

            string yyyy = dateTimePickerWritingDate.Value.Year.ToString();
            string mm = dateTimePickerWritingDate.Value.Month.ToString();
            string dd = dateTimePickerWritingDate.Value.Day.ToString();

            if (mm.Length < 2)
            {
                mm = "0" + mm;
            }
            if (dd.Length < 2)
            {
                dd = "0" + dd;
            }
            string time = dateTimePickerWritingTime.Value.TimeOfDay.ToString();

            var insert = BsonDocument.Parse("{ date : "+ String.Format("ISODate(\"{0}-{1}-{2}T{3}Z\")", yyyy, mm, dd, time) + ", employee : ObjectId(\""+ employeeID[comboBoxWritingEmployee.SelectedIndex].document["_id"] + "\"), service : ObjectId(\""+ serviceID[comboBoxWritingService.SelectedIndex].document["_id"] + "\"), user : ObjectId(\""+ obj.document["_id"] + "\"), status : \"1\"}");
            tmp.AddVisit(insert);
        }

        private void listBoxUserOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AgreementForm agree = new AgreementForm(writingsID[listBoxUserOrders.SelectedIndex].document["_id"], listBoxUserOrders.SelectedItem.ToString());
            agree.TopLevel = true;
            agree.Show();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PersonalAccount.ActiveForm.Hide();
            Start start = new Start();
            start.Show();
        }
    }
}
