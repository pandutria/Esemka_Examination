using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_Examination
{
    public partial class FormLogin : Form
    {
        private DataBaseDataContext db = new DataBaseDataContext();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';

            tbPassword.Text = tbUsername.Text = "root";
        }

        private bool validation()
        {
            if (tbUsername.Text == string.Empty || tbPassword.Text == string.Empty)
            {
                Support.MSI("all input Must be filled");
                return false;
            }

            return true;
        }

        private string MD5Create(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("x2")); 
                }
                return sb.ToString();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (validation())
                {
                    var hashPassword = MD5Create(tbPassword.Text);
                    var query = db.users.FirstOrDefault(x => x.username == tbUsername.Text && x.password == tbPassword.Text);
                     
                    if (query != null)
                    {
                        DataStorage.userId = query.id;
                        DataStorage.roleId = query.role_id;
                        new FormMain().Show();
                        Hide();
                    }
                    else Support.MSW("ensure your username & password correct");
                }
                
            } catch (Exception ex)
            {
                Support.MSE(ex.Message);
            } 
        }
    }
}
