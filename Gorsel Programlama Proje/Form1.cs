using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Gorsel_Programlama_Proje
{
    public partial class Form1 : Form
    {
        ArrayList gogus = new ArrayList();
        ArrayList sirt = new ArrayList();
        ArrayList omuz = new ArrayList();
        ArrayList kol = new ArrayList();
        ArrayList bacak = new ArrayList();
        ArrayList karın = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }
        //Bölgelerin hareketlerini listeleme
        void listele_gogus()
        {
            gogus.Clear();
            gogus.Add("Barbell Bench Press");
            gogus.Add("Chest Press Machine");
            gogus.Add("Dumbbell Flys");
            gogus.Add("Dips");
            gogus.Add("Push Ups");
            gogus.Add("Dumbell Bench Press");
            for (int i = 0; i < gogus.Count; i++)
                checkedListBox1.Items.Add(gogus[i]);
        }
        void listele_sırt()
        {
            sirt.Clear();
            sirt.Add("Lat Pull Down");
            sirt.Add("Barbel Row");
            sirt.Add("Barfiks");
            sirt.Add("Seated Cabel Row");
            sirt.Add("Close-Grip Pull-Down");
            sirt.Add("Reverse Cable Crossover");
            for (int i = 0; i < sirt.Count; i++)
                checkedListBox1.Items.Add(sirt[i]);
        }

        void listele_omuz()
        {
            omuz.Clear();
            omuz.Add("Overhead Press");
            omuz.Add("Front Raise");
            omuz.Add("Lateral Raise");
            omuz.Add("Rear Delt Fly");
            omuz.Add("Cable External Rotasyon");
            for (int i = 0; i < omuz.Count; i++)
                checkedListBox1.Items.Add(omuz[i]);
        }
        void listele_kol()
        {
            kol.Clear();
            kol.Add("Barbell Curl");
            kol.Add("Dumbell İncline Curl");
            kol.Add("Barbell Reverse Curl");
            kol.Add("Hammer Curl");
            kol.Add("Preacher Curl");
            kol.Add("Dumbell Kickback");
            kol.Add("Rope Pussdown");
            kol.Add("Chip Up");
            kol.Add("Concentration Curl");
            for (int i = 0; i < kol.Count; i++)
                checkedListBox1.Items.Add(kol[i]);
        }
        void listele_bacak()
        {
            bacak.Clear();
            bacak.Add("Barbell Squat");
            bacak.Add("Leg Press");
            bacak.Add("Front Squat");
            bacak.Add("Standing Leg Curl");
            bacak.Add("Walking Lunge");
            for (int i = 0; i < bacak.Count; i++)
                checkedListBox1.Items.Add(bacak[i]);
        }
        void listele_karın()
        {
            karın.Clear();
            karın.Add("Abdominal Crunch");
            karın.Add("Legs Up Crunch");
            karın.Add("Lying Knee Sit Up Crunch");
            karın.Add("Lying Legs Up");
            karın.Add("Vertical Leg Crunch");
            karın.Add("Side Crunch");
            karın.Add("Plank");
            for (int i = 0; i < karın.Count; i++)
                checkedListBox1.Items.Add(karın[i]);
        }
        //Tarih Ekleme
        private void buton_ekle_Click(object sender, EventArgs e)
        {
            DateTime tarihsec = tarih_tarihsec.Value.Date;
            string secilentarih = tarihsec.ToString("dd-MM-yyyy");
            string gunismi = tarihsec.ToString("dddd", new System.Globalization.CultureInfo("tr-TR"));
            //Ekli tarih tekrar eklenirse
            if (gunlistesi.Items.Contains(secilentarih + " " + gunismi))
            {
                MessageBox.Show("Seçilen Tarih Zaten Eklenmiş!");
            }
            else if (tarihsec < DateTime.Now.Date)//Seçilen tarih bugünden önceyse
            {
                MessageBox.Show("Geçmiş Bir Günü Seçemezsiniz!");
            }
            else
            {
                gunlistesi.Items.Add(secilentarih + " " + gunismi);
                comboBox1.Items.Add(secilentarih + " " + gunismi);
                comboBox1.Enabled = true;
            }

        }
        //Eklenen tarihi silme
        private void button2_Click(object sender, EventArgs e)
        {
            int secilenisil = gunlistesi.SelectedIndex;
            gunlistesi.Items.RemoveAt(secilenisil);
            comboBox1.Items.RemoveAt(secilenisil);
        }
        //Seçilen bölgeyi listeleme
        private void button1_Click(object sender, EventArgs e)
        {   //Bölge seçilmemişse uyarı versin
            if (comboBox2.SelectedIndex == -1)
                MessageBox.Show("Lütfen Bir Tarih ve Bölge Seçiniz!");
            //Bölgelerin listelenmesi
            else if (comboBox2.SelectedIndex == 0)
            {
                checkedListBox1.Items.Clear();
                listele_gogus();
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                checkedListBox1.Items.Clear();
                listele_sırt();
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                checkedListBox1.Items.Clear();
                listele_omuz();
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                checkedListBox1.Items.Clear();
                listele_kol();
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                checkedListBox1.Items.Clear();
                listele_bacak();
            }
            else if (comboBox2.SelectedIndex == 5)
            {
                checkedListBox1.Items.Clear();
                listele_karın();
            }
            checkedListBox1.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
        }

        //Seçilen hareketleri listeye ekleme
        private void button3_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
                MessageBox.Show("Seçim Yapmadınız!");
            else
            {
                foreach (var i in checkedListBox1.CheckedItems)
                {//Aynı hareket eklenmesin
                    string secimler = comboBox1.Text + " / " + comboBox2.Text + " / " + i.ToString();
                    if (!listBox1.Items.Contains(secimler))
                    {
                        listBox1.Items.Add(secimler);
                        listBox2.Items.Add(secimler);
                    }
                    else
                    {

                        MessageBox.Show("Şu Seçimi Zaten Yaptınız : " + i.ToString());
                    }

                }
                //Check edilenleri kaldırma
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    checkedListBox1.SetItemChecked(j, false);
                }
            }

        }
        private void rastgelesayiuret()
        {
            Random random = new Random();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            checkedListBox1.SetItemChecked(i, false);
                int rastgelesayi = random.Next(0, checkedListBox1.Items.Count);
            for (int j = 0; j <= rastgelesayi; j++)
            {
                int rastdondur = random.Next(0, checkedListBox1.Items.Count);
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(rastdondur, true);
                }
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//Tarih seçilmediyse bölge seçme açılmasın
            checkedListBox1.Items.Clear();
            comboBox2.Enabled = Enabled;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            rastgelesayiuret();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {   //listboxtan seçilen itemi silsin
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Listeden Seçim Yapmadınız.");
            }
            else
            {
                int secilenindex = listBox1.SelectedIndex;
                listBox2.Items.RemoveAt(secilenindex);
                listBox1.Items.RemoveAt(secilenindex);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {   //Listbox itemlerini silme
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {   //
            if (numericUpDown2.Value == 0 || numericUpDown1.Value == 0)
            {
                MessageBox.Show("Tekrar Sayısı ve Süre 0 olamaz!");
                return;
            }

            if (listBox2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Listeden Seçim Yapmadınız!");
                return;
            }

            var secilenTarih = listBox2.SelectedItem.ToString();
            var secilenSet = numericUpDown3.Value + ". Set";
            var secilenDetay = numericUpDown2.Value + " Saniye | " + numericUpDown1.Value + " Tekrar.";

            string setBilgisi = secilenTarih + " - " + secilenSet;
            if (listBox3.Items.Contains(setBilgisi))
            {
                MessageBox.Show(secilenSet + " zaten listede mevcut!");
                return;
            }

            listBox3.Items.Add(setBilgisi);
            listBox4.Items.Add(secilenSet);
            listBox5.Items.Add(secilenDetay);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //listbox3'te seçilen satırı silme
            int index = listBox3.SelectedIndex;
            listBox3.Items.RemoveAt(index);
            listBox4.Items.RemoveAt(index);
            listBox5.Items.RemoveAt(index);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //listbox3'teki her şeyi silme
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button7.Enabled = true;
        }

    }
}
