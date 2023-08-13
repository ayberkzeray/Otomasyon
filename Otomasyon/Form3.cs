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
    public partial class Form3 : Form
    {
        CategoryService categoryService;
        ProductService productService;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            productService = new ProductService();
            UrunleriListele();
            kategoriComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            var categoryNames = categoryService.GetAll().Select(x => x.Name);

            if (categoryNames.Count() > 0)
            {
                foreach (var item in categoryNames)
                {
                    kategoriComboBox.Items.Add(item);
                }
                kategoriComboBox.SelectedItem = categoryNames.FirstOrDefault();
            }
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (kategoriComboBox.SelectedItem == null)
            {
                MessageBox.Show("Ürün kategorisi seçin!");
                return;
            }
            if (String.IsNullOrEmpty(urunAdiTBox.Text) || urunAdiTBox.Text.Trim().Count() < 0)
            {
                MessageBox.Show("Lütfen Ürün adı giriniz.");
                return;
            }
            if (birimFiyatiNumericUpDown.Value < 1)
            {
                MessageBox.Show("Birim fiyatı ekleyiniz");
                return;
            }
            if (stokMiktariNumericUpDown.Value < 1)
            {
                MessageBox.Show("Stok miktarı ekleyiniz");
                return;
            }
            var category = categoryService.GetByName(kategoriComboBox.SelectedItem.ToString());
            Product product = new Product()
            {
                //Category = category, 
                CategoryID = category.ID,
                IsActive = true,
                Name = urunAdiTBox.Text,
                Stock = Convert.ToInt16(stokMiktariNumericUpDown.Value),
                UnitPrice = birimFiyatiNumericUpDown.Value,
                AddedDate = DateTime.Now
            };
            productService.Add(product);

            MessageBox.Show("Ürün eklendi");
            UrunleriListele();
        }
        void UrunleriListele()
        {
            urunlerListView.Items.Clear();
            var products = productService.GetAll();

            foreach (var product in products)
            {
                ListViewItem listViewItem = new ListViewItem(product.ID.ToString());
                listViewItem.SubItems.Add(product.Name);
                listViewItem.SubItems.Add(product.UnitPrice.ToString());
                listViewItem.SubItems.Add(product.Stock.ToString());
                listViewItem.SubItems.Add(categoryService.GetById(product.CategoryID).Name);

                urunlerListView.Items.Add(listViewItem);
            }
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            var urun = urunlerListView.SelectedItems[0].Text;
            productService.Delete(Convert.ToInt32(urun));
            UrunleriListele();
        }
    }
}
