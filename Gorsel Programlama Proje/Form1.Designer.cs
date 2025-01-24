namespace Gorsel_Programlama_Proje
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gunlistesi = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buton_ekle = new System.Windows.Forms.Button();
            this.tarih_tarihsec = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.gunlistesi);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.buton_ekle);
            this.tabPage1.Controls.Add(this.tarih_tarihsec);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage1.Size = new System.Drawing.Size(1070, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tarih";
            // 
            // gunlistesi
            // 
            this.gunlistesi.FormattingEnabled = true;
            this.gunlistesi.ItemHeight = 29;
            this.gunlistesi.Location = new System.Drawing.Point(665, 63);
            this.gunlistesi.Name = "gunlistesi";
            this.gunlistesi.Size = new System.Drawing.Size(338, 352);
            this.gunlistesi.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buton_ekle
            // 
            this.buton_ekle.Location = new System.Drawing.Point(114, 252);
            this.buton_ekle.Name = "buton_ekle";
            this.buton_ekle.Size = new System.Drawing.Size(131, 62);
            this.buton_ekle.TabIndex = 3;
            this.buton_ekle.Text = "Ekle";
            this.buton_ekle.UseVisualStyleBackColor = true;
            this.buton_ekle.Click += new System.EventHandler(this.buton_ekle_Click);
            // 
            // tarih_tarihsec
            // 
            this.tarih_tarihsec.CalendarMonthBackground = System.Drawing.Color.White;
            this.tarih_tarihsec.Location = new System.Drawing.Point(210, 134);
            this.tarih_tarihsec.Name = "tarih_tarihsec";
            this.tarih_tarihsec.Size = new System.Drawing.Size(215, 34);
            this.tarih_tarihsec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(45, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tarih Seçiniz:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage2.Size = new System.Drawing.Size(1070, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Günün Programı";
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(861, 411);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 71);
            this.button6.TabIndex = 12;
            this.button6.Text = "Tüm Seçimleri Sil";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "SEÇİLENLER LİSTESİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(697, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "HAREKET LİSTESİ";
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(587, 411);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(165, 71);
            this.button5.TabIndex = 9;
            this.button5.Text = "Seçimi Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(861, 334);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 71);
            this.button4.TabIndex = 8;
            this.button4.Text = "Rastgele Seç";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(587, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 71);
            this.button3.TabIndex = 7;
            this.button3.Text = "Seçimleri Kaydet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(18, 204);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(491, 265);
            this.listBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(403, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hareketleri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(587, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(439, 265);
            this.checkedListBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Göğüs",
            "Sırt",
            "Omuz",
            "Kol",
            "Bacak",
            "Karın"});
            this.comboBox2.Location = new System.Drawing.Point(203, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 37);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 58);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çalışacağınız\r\nBölgeyi Seçin:\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 37);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tarih Seçin:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.numericUpDown3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1070, 506);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Antrenman";
            
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.listBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox5, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(449, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(602, 264);
            this.tableLayoutPanel1.TabIndex = 11;
            
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 22;
            this.listBox3.Location = new System.Drawing.Point(3, 3);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(354, 246);
            this.listBox3.TabIndex = 7;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 22;
            this.listBox4.Location = new System.Drawing.Point(364, 3);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(69, 246);
            this.listBox4.TabIndex = 8;
            // 
            // listBox5
            // 
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox5.ForeColor = System.Drawing.Color.ForestGreen;
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 20;
            this.listBox5.Location = new System.Drawing.Point(441, 3);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(158, 244);
            this.listBox5.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(343, 340);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 67);
            this.button9.TabIndex = 10;
            this.button9.Text = "Seçimleri Kaydet";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(684, 384);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(169, 56);
            this.button8.TabIndex = 9;
            this.button8.Text = "Hepsini Sil";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(684, 322);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(169, 56);
            this.button7.TabIndex = 8;
            this.button7.Text = "Seçimi Sil";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(180, 301);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown3.TabIndex = 6;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(10, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Kaçıncı Set:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(10, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Süre (saniye):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(10, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tekrar Sayısı:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(180, 411);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown2.TabIndex = 2;
            
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(180, 354);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 34);
            this.numericUpDown1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(12, 14);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(374, 264);
            this.listBox2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1106, 576);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Spor Takip Programı | Arda Karaoğlu";
            
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tarih_tarihsec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buton_ekle;
        private System.Windows.Forms.ListBox gunlistesi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
    }
}

