using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace Personel_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            ent.Gorev = txtgorev.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Personel Eklendi!!!");
        }

        private void btnListele_Click_1(object sender, EventArgs e)
        {

            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        //SİL
        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("Personel Silindi!!!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtid.Text);
            ent.Ad = txtad.Text;
            ent.Soyad = txtsoyad.Text;
            ent.Sehir = txtsehir.Text;
            ent.Gorev = txtgorev.Text;
            ent.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
            MessageBox.Show("Personel Güncellendi!!!");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtgorev.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtmaas.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtsoyad.Text = "";
           txtsehir.Text = "";
           txtgorev.Text = "";
            txtmaas.Text = "";
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}

