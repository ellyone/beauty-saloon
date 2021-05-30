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
using MongoDBApp.Structures;

namespace MongoDBApp
{
    public partial class AgreementForm : Form
    {
        string _id;
        public AgreementForm(string id, string date)
        {
            InitializeComponent();
            label1.Text += String.Format("\n {0}?", date);
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var filter = BsonDocument.Parse("{ _id : ObjectId(\"" + _id + "\")}");
            var update = BsonDocument.Parse("{$set : {status : \"2\"}}");

            MongoConnection conn = new MongoConnection();
            var collection = conn.database.GetCollection<BsonDocument>("orders");
            collection.UpdateOne(filter, update);

            AgreementForm.ActiveForm.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgreementForm.ActiveForm.Hide();
        }
    }
}
