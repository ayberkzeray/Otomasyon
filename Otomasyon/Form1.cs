﻿using Otomasyon.Context;

namespace Otomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OtomasyonDbContext db;
        private void grsBtutton_Click(object sender, EventArgs e)
        {
            if (db.Users.FirstOrDefault(u => u.UserName == kullaniciAdiTBox.Text && u.Password == sifreTBox.Text) != null)
            {
                MessageBox.Show("Tebrikler Giriş yaptınız!");
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş bilgilerinde bir hata var!");
                kullaniciAdiTBox.Text = string.Empty;
                sifreTBox.Text = string.Empty;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new OtomasyonDbContext();
            sifreTBox.PasswordChar = '*';

#if DEBUG
            kullaniciAdiTBox.Text = "ayb";
            sifreTBox.Text = "1234";
#endif
        }
    }
}