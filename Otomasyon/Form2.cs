using Otomasyon.Models;
using Otomasyon.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class Form2 : Form
    {
        CategoryService categoryService;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kategoriEkleButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(kategoriAdiTBox.Text) || String.IsNullOrEmpty(kategoriAciklamasiTBox.Text))
            {
                MessageBox.Show("Lütfen Kategori Alanlarını Doldurunuz!");
            }
            else if (kategoriAdiTBox.Text.Trim().Length < 2)
            {
                MessageBox.Show("Lütfen kategori adı en az 2 karakter olabilir!");
            }
            else if (kategoriAciklamasiTBox.Text.Trim().Length < 10)
            {
                MessageBox.Show("Lütfen kategori adı en az 10 karakter olabilir!");
            }
            else
            {
                Category category = new Category() { Name = kategoriAdiTBox.Text, Description = kategoriAciklamasiTBox.Text };
                categoryService.Add(category);

                MessageBox.Show($"{kategoriAdiTBox.Text} başarıyla eklenmiştir.");

                KategoriListesiGetir();
            }
        }
        void KategoriListesiGetir()
        {
            List<Category> categories = categoryService.GetAll().ToList();

            kategoriListView.Items.Clear();

            foreach (Category category in categories)
            {
                ListViewItem listViewItem = new ListViewItem(category.ID.ToString());
                listViewItem.SubItems.Add(category.Name);
                listViewItem.SubItems.Add(category.Description);

                kategoriListView.Items.Add(listViewItem);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            KategoriListesiGetir();
            kategoriListView.FullRowSelect = true;
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            if (kategoriListView.Items.Count > 0)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen Önce Kategori Ekleyiniz!");
            }
            
        }
    }
}
