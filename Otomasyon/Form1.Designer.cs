namespace Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grsBtutton = new Button();
            label1 = new Label();
            label2 = new Label();
            kullaniciAdiTBox = new TextBox();
            sifreTBox = new TextBox();
            SuspendLayout();
            // 
            // grsBtutton
            // 
            grsBtutton.Location = new Point(199, 244);
            grsBtutton.Name = "grsBtutton";
            grsBtutton.Size = new Size(75, 23);
            grsBtutton.TabIndex = 0;
            grsBtutton.Text = "Giriş";
            grsBtutton.UseVisualStyleBackColor = true;
            grsBtutton.Click += grsBtutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 70);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 141);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // kullaniciAdiTBox
            // 
            kullaniciAdiTBox.Location = new Point(190, 71);
            kullaniciAdiTBox.Name = "kullaniciAdiTBox";
            kullaniciAdiTBox.Size = new Size(100, 23);
            kullaniciAdiTBox.TabIndex = 3;
            // 
            // sifreTBox
            // 
            sifreTBox.Location = new Point(190, 141);
            sifreTBox.Name = "sifreTBox";
            sifreTBox.Size = new Size(100, 23);
            sifreTBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 333);
            Controls.Add(sifreTBox);
            Controls.Add(kullaniciAdiTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grsBtutton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button grsBtutton;
        private Label label1;
        private Label label2;
        private TextBox kullaniciAdiTBox;
        private TextBox sifreTBox;
    }
}