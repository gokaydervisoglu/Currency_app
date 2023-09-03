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
    public partial class RegisterPanel : Form
    {
        public RegisterPanel()
        {
            InitializeComponent();
        }

        string sql_s = "Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=CurrencyApp;Integrated Security=True";

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && surname.Text != "" && username.Text != "" && password.Text != "")
            {

                using (SqlConnection sql = new SqlConnection(sql_s))
                {
                    sql.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Tbl_Users (Name,Surname,Username,Password) values (@p1,@p2,@p3,@p4)", sql);

                    cmd.Parameters.AddWithValue("@p1", name.Text);
                    cmd.Parameters.AddWithValue("@p2", surname.Text);
                    cmd.Parameters.AddWithValue("@p3", username.Text);
                    cmd.Parameters.AddWithValue("@p4", password.Text);

                    cmd.ExecuteNonQuery();

                    DialogResult result = MessageBox.Show("Register Succesfully", "Information", MessageBoxButtons.OK);

                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }

                }
            }
            else
            {
                MessageBox.Show("Please enter everything completely!");
            }



        }

        private void RegisterPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["LoginPanel"].Focus();
        }
    }
}
