using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Xml;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Currency_app
{
    public partial class UserPanel : Form
    {
        bool key;
        bool combo;
        bool edit = true;
        public string username;
        private decimal newusd;
        private decimal newtry;
        private decimal neweur;
        public UserPanel()
        {
            InitializeComponent();
        }

        string sql_s = "Data Source=DESKTOP-3HN2204\\SQLEXPRESS;Initial Catalog=CurrencyApp;Integrated Security=True";

        private  void Form1_Load(object sender, EventArgs e)
        {
            currency();
            amount_lbl.Text = "0";
            username_lbl.Text = username;

            list();

        }

        private void currency()
        {
            string currency = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldocument = new XmlDocument();
            xmldocument.Load(currency);

            dolar_buy.Text = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            dolar_sel.Text = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            eur_buy.Text = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            eur_sel.Text = xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

        }

        private void btn_bank_Click(object sender, EventArgs e)
        {

            decimal temp = decimal.Parse(amount_lbl.Text);
            decimal total = decimal.Parse(total_lbl.Text);
            decimal usd = decimal.Parse(usd_money.Text);
            decimal eur = decimal.Parse(eur_money.Text);
            decimal tr = decimal.Parse(try_money.Text);

            try
            {
                
                if (amount_lbl.Text == "0")
                {
                    MessageBox.Show("Please enter amount to currency transfer");
                }
                else if (combo == true && key == true && temp <= tr)
                {
                    //dolar buy
                    using (SqlConnection sql = new SqlConnection(sql_s))
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("Update Tbl_Users set USD=@p1,TRY=@p2 where Username=@p3", sql);

                        newusd = usd + total;
                        newtry = tr - temp;

                        cmd.Parameters.AddWithValue("@p1", newusd);
                        cmd.Parameters.AddWithValue("@p2", newtry);
                        cmd.Parameters.AddWithValue("@p3", username);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Process completed");
                }
                else if (combo == false && key == true && temp <= usd)
                {
                    //dolar sell
                    using (SqlConnection sql = new SqlConnection(sql_s))
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("Update Tbl_Users set USD=@p1,TRY=@p2 where Username=@p3", sql);

                        newusd = usd - temp;
                        newtry = tr + total;

                        cmd.Parameters.AddWithValue("@p1", newusd);
                        cmd.Parameters.AddWithValue("@p2", newtry);
                        cmd.Parameters.AddWithValue("@p3", username);

                        cmd.ExecuteNonQuery();
                    }
                 
                    MessageBox.Show("Process completed");
                }
                else if (combo == true && key == false && temp <= tr)
                {
                    //eur buy
                    using (SqlConnection sql = new SqlConnection(sql_s))
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("Update Tbl_Users set EUR=@p1,TRY=@p2 where Username=@p3", sql);

                        neweur = eur + total;
                        newtry = tr - temp;

                        cmd.Parameters.AddWithValue("@p1", neweur);
                        cmd.Parameters.AddWithValue("@p2", newtry);
                        cmd.Parameters.AddWithValue("@p3", username);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Process completed");
                }
                else if (combo == false && key == false && temp <= eur)
                {
                    //eur sell
                    using (SqlConnection sql = new SqlConnection(sql_s))
                    {
                        sql.Open();
                        SqlCommand cmd = new SqlCommand("Update Tbl_Users set EUR=@p1,TRY=@p2 where Username=@p3", sql);

                        neweur = eur - temp;
                        newtry = tr + total;

                        cmd.Parameters.AddWithValue("@p1", neweur);
                        cmd.Parameters.AddWithValue("@p2", newtry);
                        cmd.Parameters.AddWithValue("@p3", username);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Process completed");
                }
                else
                {
                    MessageBox.Show("Process Not completed, Try Again!");
                }
               
            }
            catch 
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                list();
            }


        }

        private void amount_lbl_TextChanged(object sender, EventArgs e)
        {
            bank();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                combo = true;
                if (key == true)
                    currency_lbl.Text = dolar_buy.Text;
                else
                    currency_lbl.Text = eur_buy.Text;
            }
            else
            {
                combo = false;
                if (key == true)
                    currency_lbl.Text = dolar_sel.Text;
                else
                    currency_lbl.Text = eur_sel.Text;
            }

            btn_bank.Enabled = true;
            usd_combo.Enabled = true;
            eur_combo.Enabled = true;
            bank();

        }

        private void usd_combo_Click(object sender, EventArgs e)
        {
            key = true;
            if (combo == true)
                currency_lbl.Text = dolar_buy.Text;
            else if(combo == false)
                currency_lbl.Text = dolar_sel.Text;
            bank();

        }

        private void eur_combo_Click(object sender, EventArgs e)
        {
            key = false;
            if (combo == true)
                currency_lbl.Text = eur_buy.Text;
            else if (combo == false)
                currency_lbl.Text = eur_sel.Text;
            bank();
        }

        private void bank()
        {
            if(amount_lbl.Text == "")
            {
                total_lbl.Text = "0";
            }
            else if (combo == true && key == true)
            {
                decimal tr = decimal.Parse(amount_lbl.Text.Replace(".", ","));
                decimal usd = decimal.Parse(dolar_buy.Text.Replace(".", ","));

                decimal result = tr / usd;
                total_lbl.Text = result.ToString($"0.{new string('0', 2)}").Replace(".", ",");
            }
            else if (combo == false && key == true)
            {
                decimal tr = decimal.Parse(amount_lbl.Text.Replace(".", ","));
                decimal usd = decimal.Parse(dolar_sel.Text.Replace(".", ","));

                decimal result = usd * tr;
                total_lbl.Text = result.ToString($"0.{new string('0', 2)}").Replace(".", ",");
            }
            else if (combo == true && key == false)
            {
                decimal tr = decimal.Parse(amount_lbl.Text.Replace(".", ","));
                decimal eur = decimal.Parse(eur_buy.Text.Replace(".", ","));

                decimal result = tr / eur;
                total_lbl.Text = result.ToString($"0.{new string('0', 2)}").Replace(".", ",");
            }
            else if (combo == false && key == false)
            {
                decimal tr = decimal.Parse(amount_lbl.Text.Replace(".", ","));
                decimal eur = decimal.Parse(eur_sel.Text.Replace(".", ","));

                decimal result = eur * tr;
                total_lbl.Text = result.ToString($"0.{new string('0', 2)}").Replace(".", ",");
            }
            else
            {
                total_lbl.Text = "0";
            }
        }

        private void UserPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["LoginPanel"].Close();
        }

        private void list()
        {
            using (SqlConnection sql = new SqlConnection(sql_s))
            {
                sql.Open();

                SqlCommand cmd = new SqlCommand("Select USD,EUR,TRY from Tbl_Users where Username=@p1", sql);
                cmd.Parameters.AddWithValue("@p1", username);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usd_money.Text = reader[0].ToString();
                    eur_money.Text = reader[1].ToString();
                    try_money.Text = reader[2].ToString();
                }

            }
        }

        private void usd_lbl_Click(object sender, EventArgs e)
        {
            amount_lbl.Text = usd_money.Text;
        }

        private void eur_lbl_Click(object sender, EventArgs e)
        {
            amount_lbl.Text = eur_money.Text;
        }

        private void try_lbl_Click(object sender, EventArgs e)
        {
            amount_lbl.Text = try_money.Text;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if(edit == true)
            {
                usd_money.ReadOnly = false;
                try_money.ReadOnly = false;
                eur_money.ReadOnly = false;

                usd_money.ForeColor = Color.Aqua;
                try_money.ForeColor = Color.Aqua;
                eur_money.ForeColor = Color.Aqua;

                btn_edit.Text = "Confirm";
                edit= false;

            }
            else
            {
                using (SqlConnection sql = new SqlConnection(sql_s))
                {
                    sql.Open();

                    SqlCommand cmd = new SqlCommand("Update Tbl_Users Set USD=@p1,EUR=@p2,TRY=@p3 where Username=@p4", sql);

                    cmd.Parameters.AddWithValue("@p1", usd_money.Text);
                    cmd.Parameters.AddWithValue("@p2", eur_money.Text);
                    cmd.Parameters.AddWithValue("@p3", try_money.Text);
                    cmd.Parameters.AddWithValue("@p4", username);

                    cmd.ExecuteNonQuery();
                    edit = true;
                }
                usd_money.ReadOnly = true;
                try_money.ReadOnly = true;
                eur_money.ReadOnly = true;

                usd_money.ForeColor = Color.White;
                try_money.ForeColor = Color.White;
                eur_money.ForeColor = Color.White;
                btn_edit.Text = "Edit";
            }
        }
    }
}
