﻿namespace Currency_app
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usd_combo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.eur_combo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dolar_buy = new System.Windows.Forms.Label();
            this.dolar_sel = new System.Windows.Forms.Label();
            this.eur_buy = new System.Windows.Forms.Label();
            this.eur_sel = new System.Windows.Forms.Label();
            this.currency_lbl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.amount_lbl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_bank = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(-2, -24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 650);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 13F);
            this.label1.Location = new System.Drawing.Point(41, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Currency_app.Properties.Resources.user_149071;
            this.pictureBox1.Location = new System.Drawing.Point(50, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usd_combo
            // 
            this.usd_combo.AutoSize = true;
            this.usd_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usd_combo.Enabled = false;
            this.usd_combo.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usd_combo.ForeColor = System.Drawing.SystemColors.Window;
            this.usd_combo.Location = new System.Drawing.Point(278, 39);
            this.usd_combo.Name = "usd_combo";
            this.usd_combo.Size = new System.Drawing.Size(79, 23);
            this.usd_combo.TabIndex = 1;
            this.usd_combo.Text = "USD/TRY";
            this.usd_combo.Click += new System.EventHandler(this.usd_combo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Currency_app.Properties.Resources.united_states_3373318;
            this.pictureBox2.Location = new System.Drawing.Point(228, 39);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Currency_app.Properties.Resources.european_union_5372767;
            this.pictureBox3.Location = new System.Drawing.Point(226, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // eur_combo
            // 
            this.eur_combo.AutoSize = true;
            this.eur_combo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eur_combo.Enabled = false;
            this.eur_combo.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eur_combo.ForeColor = System.Drawing.SystemColors.Window;
            this.eur_combo.Location = new System.Drawing.Point(278, 72);
            this.eur_combo.Name = "eur_combo";
            this.eur_combo.Size = new System.Drawing.Size(77, 23);
            this.eur_combo.TabIndex = 3;
            this.eur_combo.Text = "EUR/TRY";
            this.eur_combo.Click += new System.EventHandler(this.eur_combo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(364, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Forex Buying";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(466, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Forex Selling";
            // 
            // dolar_buy
            // 
            this.dolar_buy.AutoSize = true;
            this.dolar_buy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dolar_buy.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolar_buy.ForeColor = System.Drawing.Color.Chartreuse;
            this.dolar_buy.Location = new System.Drawing.Point(381, 42);
            this.dolar_buy.Name = "dolar_buy";
            this.dolar_buy.Size = new System.Drawing.Size(17, 20);
            this.dolar_buy.TabIndex = 7;
            this.dolar_buy.Text = "0";
            // 
            // dolar_sel
            // 
            this.dolar_sel.AutoSize = true;
            this.dolar_sel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dolar_sel.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dolar_sel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dolar_sel.Location = new System.Drawing.Point(480, 42);
            this.dolar_sel.Name = "dolar_sel";
            this.dolar_sel.Size = new System.Drawing.Size(17, 20);
            this.dolar_sel.TabIndex = 8;
            this.dolar_sel.Text = "0";
            // 
            // eur_buy
            // 
            this.eur_buy.AutoSize = true;
            this.eur_buy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.eur_buy.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eur_buy.ForeColor = System.Drawing.Color.Chartreuse;
            this.eur_buy.Location = new System.Drawing.Point(381, 74);
            this.eur_buy.Name = "eur_buy";
            this.eur_buy.Size = new System.Drawing.Size(17, 20);
            this.eur_buy.TabIndex = 9;
            this.eur_buy.Text = "0";
            // 
            // eur_sel
            // 
            this.eur_sel.AutoSize = true;
            this.eur_sel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.eur_sel.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eur_sel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eur_sel.Location = new System.Drawing.Point(480, 75);
            this.eur_sel.Name = "eur_sel";
            this.eur_sel.Size = new System.Drawing.Size(17, 20);
            this.eur_sel.TabIndex = 10;
            this.eur_sel.Text = "0";
            // 
            // currency_lbl
            // 
            this.currency_lbl.Enabled = false;
            this.currency_lbl.Location = new System.Drawing.Point(324, 145);
            this.currency_lbl.Name = "currency_lbl";
            this.currency_lbl.Size = new System.Drawing.Size(136, 22);
            this.currency_lbl.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(232, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Currency:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(238, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount:";
            // 
            // amount_lbl
            // 
            this.amount_lbl.Location = new System.Drawing.Point(324, 183);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(136, 22);
            this.amount_lbl.TabIndex = 13;
            this.amount_lbl.TextChanged += new System.EventHandler(this.amount_lbl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(263, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total:";
            // 
            // total_lbl
            // 
            this.total_lbl.Enabled = false;
            this.total_lbl.Location = new System.Drawing.Point(324, 223);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(136, 22);
            this.total_lbl.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buy",
            "Sell"});
            this.comboBox1.Location = new System.Drawing.Point(368, 271);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 31);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_bank
            // 
            this.btn_bank.Enabled = false;
            this.btn_bank.Font = new System.Drawing.Font("Microsoft YaHei Light", 8F);
            this.btn_bank.Location = new System.Drawing.Point(236, 271);
            this.btn_bank.Name = "btn_bank";
            this.btn_bank.Size = new System.Drawing.Size(121, 34);
            this.btn_bank.TabIndex = 18;
            this.btn_bank.Text = "Banking";
            this.btn_bank.UseVisualStyleBackColor = true;
            this.btn_bank.Click += new System.EventHandler(this.btn_bank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(581, 596);
            this.Controls.Add(this.btn_bank);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.currency_lbl);
            this.Controls.Add(this.eur_sel);
            this.Controls.Add(this.eur_buy);
            this.Controls.Add(this.dolar_sel);
            this.Controls.Add(this.dolar_buy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.eur_combo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.usd_combo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usd_combo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label eur_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dolar_buy;
        private System.Windows.Forms.Label dolar_sel;
        private System.Windows.Forms.Label eur_buy;
        private System.Windows.Forms.Label eur_sel;
        private System.Windows.Forms.TextBox currency_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox amount_lbl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox total_lbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_bank;
    }
}
