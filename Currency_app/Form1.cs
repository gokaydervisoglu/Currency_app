using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Xml;
using System.Diagnostics.Eventing.Reader;

namespace Currency_app
{
    public partial class Form1 : Form
    {
        bool key;
        bool combo;
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {
            currency();
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
    }
}
