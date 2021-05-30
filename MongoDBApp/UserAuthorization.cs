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
    public partial class UserAuthorization : Form
    {
        UserList us = new UserList();
        public UserAuthorization()
        {
            InitializeComponent();
        }

        private void UserAuthorization_Load(object sender, EventArgs e)
        {
            BsonDocument filter = new BsonDocument();
            us = us.GetUser(filter);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            bool enter1 = false;
            bool enter2 = false;

            foreach (var i in us.UserData)
            {
                if ((i.document["login"] == textBoxEnterLogin.Text) && (i.document["pass"] == textBoxEnterPass.Text))
                {
                    enter1 = true;
                    int role = Int32.Parse(i.document["role"]);
                    List<Role> list_role = i.Roles.RoleData.ToList();
                    if (list_role[role - 1].accessLevel == 1)
                    {
                        enter2 = true;
                        AdminAuthorization.ActiveForm.Hide();
                        PersonalAccount PerconalAccount = new PersonalAccount(i);
                        PerconalAccount.Show();
                        labelError.Text = "";
                        break;
                    }
                }
                if (!enter1)
                {
                    labelError.Text = "ОШИБКА! \nНет такого пользователя.";
                }
                else
                {
                    if (!enter2)
                    {
                        labelError.Text = "ОШИБКА! \nПользователь - не пользователь.";
                    }
                }
            }
        }
    }
}
