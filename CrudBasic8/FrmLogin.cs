using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CrudBasic8
{
    public partial class FrmLogin : Form
    {
        db_siswaEntities db = new db_siswaEntities();
        Users user = null;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(usernameRegisTextBox.Text) && !String.IsNullOrWhiteSpace(passwordRegisTextBox.Text))
            {
                user = new Users()
                {
                    username = usernameRegisTextBox.Text,
                    password = passwordRegisTextBox.Text
                };
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Succes created Account");
                registerPanel.Visible = false;
            }
            else
            {
                MessageBox.Show("You must fill your name or your password!");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(username_txtBox.Text) && !String.IsNullOrWhiteSpace(password_txtbox.Text))
            {
                user = db.Users
                    .Where(X => X.username == username_txtBox.Text && X.password == password_txtbox.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    MessageBox.Show("Welcome " + user.username + " !");
                    Form1 frm1 = new Form1();
                    this.Hide();

                    frm1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your username or password is wrong!");
                }
            }
            else
            {
                MessageBox.Show("You must fill username and password!");
            }
        }
    }
}
