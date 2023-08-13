namespace Otomasyon
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            urunAdiTBox = new TextBox();
            kategoriComboBox = new ComboBox();
            birimFiyatiNumericUpDown = new NumericUpDown();
            stokMiktariNumericUpDown = new NumericUpDown();
            groupBox1 = new GroupBox();
            kaydetButton = new Button();
            guncelleButton = new Button();
            silButton = new Button();
            groupBox2 = new GroupBox();
            urunlerListView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            geriButton = new Button();
            ((System.ComponentModel.ISupportInitialize)birimFiyatiNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stokMiktariNumericUpDown).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Kategori:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 140);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Stok Miktarı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 107);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Birim Fiyatı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 74);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Ürün Adı:";
            // 
            // urunAdiTBox
            // 
            urunAdiTBox.Location = new Point(122, 71);
            urunAdiTBox.Name = "urunAdiTBox";
            urunAdiTBox.Size = new Size(208, 23);
            urunAdiTBox.TabIndex = 4;
            // 
            // kategoriComboBox
            // 
            kategoriComboBox.FormattingEnabled = true;
            kategoriComboBox.Location = new Point(122, 42);
            kategoriComboBox.Name = "kategoriComboBox";
            kategoriComboBox.Size = new Size(208, 23);
            kategoriComboBox.TabIndex = 5;
            // 
            // birimFiyatiNumericUpDown
            // 
            birimFiyatiNumericUpDown.Location = new Point(122, 105);
            birimFiyatiNumericUpDown.Name = "birimFiyatiNumericUpDown";
            birimFiyatiNumericUpDown.Size = new Size(208, 23);
            birimFiyatiNumericUpDown.TabIndex = 6;
            // 
            // stokMiktariNumericUpDown
            // 
            stokMiktariNumericUpDown.Location = new Point(122, 138);
            stokMiktariNumericUpDown.Name = "stokMiktariNumericUpDown";
            stokMiktariNumericUpDown.Size = new Size(208, 23);
            stokMiktariNumericUpDown.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(stokMiktariNumericUpDown);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(birimFiyatiNumericUpDown);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(kategoriComboBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(urunAdiTBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 185);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Ekleme Paneli";
            // 
            // kaydetButton
            // 
            kaydetButton.Location = new Point(395, 25);
            kaydetButton.Name = "kaydetButton";
            kaydetButton.Size = new Size(180, 52);
            kaydetButton.TabIndex = 9;
            kaydetButton.Text = "KAYDET";
            kaydetButton.UseVisualStyleBackColor = true;
            kaydetButton.Click += kaydetButton_Click;
            // 
            // guncelleButton
            // 
            guncelleButton.Location = new Point(395, 82);
            guncelleButton.Name = "guncelleButton";
            guncelleButton.Size = new Size(180, 52);
            guncelleButton.TabIndex = 10;
            guncelleButton.Text = "GÜNCELLE";
            guncelleButton.UseVisualStyleBackColor = true;
            // 
            // silButton
            // 
            silButton.Location = new Point(395, 145);
            silButton.Name = "silButton";
            silButton.Size = new Size(180, 52);
            silButton.TabIndex = 11;
            silButton.Text = "SİL";
            silButton.UseVisualStyleBackColor = true;
            silButton.Click += silButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(urunlerListView);
            groupBox2.Location = new Point(12, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(571, 235);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürünler";
            // 
            // urunlerListView
            // 
            urunlerListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            urunlerListView.GridLines = true;
            urunlerListView.Location = new Point(6, 22);
            urunlerListView.Name = "urunlerListView";
            urunlerListView.Size = new Size(559, 207);
            urunlerListView.TabIndex = 0;
            urunlerListView.UseCompatibleStateImageBehavior = false;
            urunlerListView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ürün Adı";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Birim Fiyatı";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Stok Miktarı";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kategori";
            columnHeader4.Width = 140;
            // 
            // geriButton
            // 
            geriButton.Location = new Point(18, 457);
            geriButton.Name = "geriButton";
            geriButton.Size = new Size(557, 52);
            geriButton.TabIndex = 13;
            geriButton.Text = "KATEGORİ EKLEME EKRANINA DÖN";
            geriButton.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 521);
            Controls.Add(geriButton);
            Controls.Add(groupBox2);
            Controls.Add(silButton);
            Controls.Add(guncelleButton);
            Controls.Add(kaydetButton);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)birimFiyatiNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stokMiktariNumericUpDown).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox urunAdiTBox;
        private ComboBox kategoriComboBox;
        private NumericUpDown birimFiyatiNumericUpDown;
        private NumericUpDown stokMiktariNumericUpDown;
        private GroupBox groupBox1;
        private Button kaydetButton;
        private Button guncelleButton;
        private Button silButton;
        private GroupBox groupBox2;
        private ListView urunlerListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button geriButton;
    }
}