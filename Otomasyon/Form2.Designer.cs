namespace Otomasyon
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            kategoriAdiTBox = new TextBox();
            kategoriAciklamasiTBox = new TextBox();
            groupBox1 = new GroupBox();
            kategoriEkleButton = new Button();
            groupBox2 = new GroupBox();
            kategoriListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            urunEkleButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori Adı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 98);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Açıklaması:";
            // 
            // kategoriAdiTBox
            // 
            kategoriAdiTBox.Location = new Point(143, 43);
            kategoriAdiTBox.Name = "kategoriAdiTBox";
            kategoriAdiTBox.Size = new Size(184, 23);
            kategoriAdiTBox.TabIndex = 2;
            // 
            // kategoriAciklamasiTBox
            // 
            kategoriAciklamasiTBox.Location = new Point(143, 95);
            kategoriAciklamasiTBox.Name = "kategoriAciklamasiTBox";
            kategoriAciklamasiTBox.Size = new Size(184, 23);
            kategoriAciklamasiTBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(kategoriAciklamasiTBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(kategoriAdiTBox);
            groupBox1.Location = new Point(36, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 146);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori Ekleme Paneli";
            // 
            // kategoriEkleButton
            // 
            kategoriEkleButton.Location = new Point(36, 185);
            kategoriEkleButton.Name = "kategoriEkleButton";
            kategoriEkleButton.Size = new Size(382, 61);
            kategoriEkleButton.TabIndex = 5;
            kategoriEkleButton.Text = "KATEGORİ EKLE";
            kategoriEkleButton.UseVisualStyleBackColor = true;
            kategoriEkleButton.Click += kategoriEkleButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(kategoriListView);
            groupBox2.Location = new Point(41, 285);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(377, 299);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kategoriler";
            // 
            // kategoriListView
            // 
            kategoriListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            kategoriListView.GridLines = true;
            kategoriListView.LabelWrap = false;
            kategoriListView.Location = new Point(6, 22);
            kategoriListView.Name = "kategoriListView";
            kategoriListView.Size = new Size(365, 271);
            kategoriListView.TabIndex = 0;
            kategoriListView.UseCompatibleStateImageBehavior = false;
            kategoriListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Kategori Adı";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Açıklama";
            columnHeader3.Width = 200;
            // 
            // urunEkleButton
            // 
            urunEkleButton.Location = new Point(36, 597);
            urunEkleButton.Name = "urunEkleButton";
            urunEkleButton.Size = new Size(382, 61);
            urunEkleButton.TabIndex = 7;
            urunEkleButton.Text = "ÜRÜN EKLE";
            urunEkleButton.UseVisualStyleBackColor = true;
            urunEkleButton.Click += urunEkleButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 670);
            Controls.Add(urunEkleButton);
            Controls.Add(groupBox2);
            Controls.Add(kategoriEkleButton);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kategoriAdiTBox;
        private TextBox kategoriAciklamasiTBox;
        private GroupBox groupBox1;
        private Button kategoriEkleButton;
        private GroupBox groupBox2;
        private ListView kategoriListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button urunEkleButton;
    }
}