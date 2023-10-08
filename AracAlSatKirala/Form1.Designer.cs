namespace AracAlSatKirala
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnMusteriEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // BtnMusteriEkle
            // 
            this.BtnMusteriEkle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnMusteriEkle.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMusteriEkle.ImageIndex = 5;
            this.BtnMusteriEkle.ImageList = this.ımageList1;
            this.BtnMusteriEkle.Location = new System.Drawing.Point(91, 96);
            this.BtnMusteriEkle.Name = "BtnMusteriEkle";
            this.BtnMusteriEkle.Size = new System.Drawing.Size(148, 95);
            this.BtnMusteriEkle.TabIndex = 0;
            this.BtnMusteriEkle.Text = "Müşteri Ekleme";
            this.BtnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMusteriEkle.UseVisualStyleBackColor = false;
            this.BtnMusteriEkle.Click += new System.EventHandler(this.BtnMusteriEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "gelir.jpg");
            this.ımageList1.Images.SetKeyName(1, "fatura.png");
            this.ımageList1.Images.SetKeyName(2, "Calculator-icon-by-ahlangraphic-8-580x386.jpg");
            this.ımageList1.Images.SetKeyName(3, "vector-group-people-icon.jpg");
            this.ımageList1.Images.SetKeyName(4, "sale.png");
            this.ımageList1.Images.SetKeyName(5, "add-user.png");
            this.ımageList1.Images.SetKeyName(6, "png-transparent-computer-icons-crowd-audience-social-group-crowd-miscellaneous-mo" +
        "nochrome-black.png");
            this.ımageList1.Images.SetKeyName(7, "210-2102296_car-icon-sedan-sedan-car-icon-png-transparent.png");
            this.ımageList1.Images.SetKeyName(8, "araclist.png");
            this.ımageList1.Images.SetKeyName(9, "müsteri.png");
            this.ımageList1.Images.SetKeyName(10, "b879930fa5ad4b58c70fe0da422b6e42.jpg");
            this.ımageList1.Images.SetKeyName(11, "sözleşme.png");
            this.ımageList1.Images.SetKeyName(12, "exit.png");
            this.ımageList1.Images.SetKeyName(13, "not.jpg");
            this.ımageList1.Images.SetKeyName(14, "list.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 3;
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(290, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "Müşteri Listesi";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ImageKey = "210-2102296_car-icon-sedan-sedan-car-icon-png-transparent.png";
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(495, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 95);
            this.button3.TabIndex = 2;
            this.button3.Text = "Araç Ekleme";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ImageKey = "araclist.png";
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(702, 96);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "Araç Listesi";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ImageKey = "add-user.png";
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(91, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(148, 95);
            this.button5.TabIndex = 4;
            this.button5.Text = "Personel Ekle";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ImageKey = "vector-group-people-icon.jpg";
            this.button6.ImageList = this.ımageList1;
            this.button6.Location = new System.Drawing.Point(290, 249);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 95);
            this.button6.TabIndex = 5;
            this.button6.Text = "Personel Listesi";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ImageKey = "b879930fa5ad4b58c70fe0da422b6e42.jpg";
            this.button7.ImageList = this.ımageList1;
            this.button7.Location = new System.Drawing.Point(495, 249);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(148, 95);
            this.button7.TabIndex = 6;
            this.button7.Text = "Araç Satış";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ImageKey = "müsteri.png";
            this.button8.ImageList = this.ımageList1;
            this.button8.Location = new System.Drawing.Point(702, 249);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 95);
            this.button8.TabIndex = 7;
            this.button8.Text = "Araç Kiralama";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ImageIndex = 14;
            this.button9.ImageList = this.ımageList1;
            this.button9.Location = new System.Drawing.Point(495, 396);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(148, 95);
            this.button9.TabIndex = 8;
            this.button9.Text = "Görev Listesi";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ImageKey = "fatura.png";
            this.button11.ImageList = this.ımageList1;
            this.button11.Location = new System.Drawing.Point(91, 396);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(148, 95);
            this.button11.TabIndex = 10;
            this.button11.Text = "Faturalar";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ImageKey = "gelir.jpg";
            this.button12.ImageList = this.ımageList1;
            this.button12.Location = new System.Drawing.Point(290, 396);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(148, 95);
            this.button12.TabIndex = 11;
            this.button12.Text = "Gelir-Gider ";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button14.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(702, 396);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(148, 95);
            this.button14.TabIndex = 13;
            this.button14.Text = "Hakkımızda";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Red;
            this.button17.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button17.ImageList = this.ımageList1;
            this.button17.Location = new System.Drawing.Point(702, 532);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(148, 95);
            this.button17.TabIndex = 16;
            this.button17.Text = "Çıkış";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ana Sayfa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(490, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "label2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(734, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 26);
            this.label11.TabIndex = 19;
            this.label11.Text = "label3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 644);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnMusteriEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMusteriEkle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

