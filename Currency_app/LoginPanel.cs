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

namespace Currency_app
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        string sql_s = "Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=CurrencyApp;Integrated Security=True";

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel registerPanel = new RegisterPanel();

            if (Application.OpenForms["RegisterPanel"] == null)
            {
                registerPanel.Show();
            }
            else
            {
                Application.OpenForms["RegisterPanel"].Focus();
            }
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            using (SqlConnection sql = new SqlConnection(sql_s))
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand("Select * from Tbl_Users where Username=@p1 and Password=@p2", sql);

                cmd.Parameters.AddWithValue("@p1", username_txt.Text);
                cmd.Parameters.AddWithValue("@p2", password_txt.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    UserPanel userPanel = new UserPanel();
                    userPanel.username = username_txt.Text;
                    userPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter your username or password correctly!");
                }

            }
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            AcceptButton = btn_login;
        }
    }
}
