using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDBApp.Structures;

namespace MongoDBApp
{
    public partial class PriceList : Form
    {
        ServiceList ser = new ServiceList();
        public PriceList()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BsonDocument filter = new BsonDocument();
            ser = ser.GetService(filter);

            foreach (var i in ser.ServiceData)
            {
                listPrice.Items.Add(i.document["name"]);
            }
        }

        private void linkMenu2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PriceList.ActiveForm.Hide();
            Start Menu = new Start();
            Menu.Show();
        }

        private void listPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listPrice.SelectedIndex;
            Service obj = new Service();
            obj = ser.ServiceData[index];
            string cat = obj.document["category"];
            List<Category> cat_list = obj.Categories.CategoryData.ToList();
            PriceTextBox.Text = String.Format("\t\t{0}\n\n\t{1}\n\nЦена: {2}\n\nКатегория: {3}",
                obj.document["name"],
                obj.document["description"],
                obj.document["price"],
                cat_list[Int32.Parse(cat)-1].name);
        }
    }
}
