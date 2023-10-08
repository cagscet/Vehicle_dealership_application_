namespace AracAlSatKirala
{
    partial class Frmpersonel
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnAracKayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.combocin = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtyas = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.maskedtel = new System.Windows.Forms.MaskedTextBox();
            this.maskedtc = new System.Windows.Forms.MaskedTextBox();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ekleme Ekranı";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ImageIndex = 5;
            this.button2.Location = new System.Drawing.Point(220, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 49);
            this.button2.TabIndex = 43;
            this.button2.Text = "Ana Menü";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnAracKayit
            // 
            this.BtnAracKayit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAracKayit.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAracKayit.ImageIndex = 5;
            this.BtnAracKayit.Location = new System.Drawing.Point(46, 495);
            this.BtnAracKayit.Name = "BtnAracKayit";
            this.BtnAracKayit.Size = new System.Drawing.Size(116, 49);
            this.BtnAracKayit.TabIndex = 42;
            this.BtnAracKayit.Text = "Kaydet";
            this.BtnAracKayit.UseVisualStyleBackColor = false;
            this.BtnAracKayit.Click += new System.EventHandler(this.BtnAracKayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "İsim : ";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(136, 108);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(200, 20);
            this.txtisim.TabIndex = 45;
            // 
            // combocin
            // 
            this.combocin.FormattingEnabled = true;
            this.combocin.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.combocin.Location = new System.Drawing.Point(136, 193);
            this.combocin.Name = "combocin";
            this.combocin.Size = new System.Drawing.Size(200, 21);
            this.combocin.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Soyad : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 48;
            this.label4.Text = "Cinsiyet :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 49;
            this.label5.Text = "Yaş : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(88, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 50;
            this.label6.Text = "TC : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(49, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 51;
            this.label7.Text = "Telefon : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(64, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 23);
            this.label8.TabIndex = 52;
            this.label8.Text = "Email : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(19, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 53;
            this.label9.Text = "Kayıt Tarihi : ";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(136, 150);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(200, 20);
            this.txtsoyad.TabIndex = 54;
            // 
            // txtyas
            // 
            this.txtyas.Location = new System.Drawing.Point(136, 236);
            this.txtyas.Name = "txtyas";
            this.txtyas.Size = new System.Drawing.Size(200, 20);
            this.txtyas.TabIndex = 55;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(136, 350);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(200, 20);
            this.txtmail.TabIndex = 57;
            // 
            // maskedtel
            // 
            this.maskedtel.Location = new System.Drawing.Point(136, 312);
            this.maskedtel.Mask = "(999) 000-0000";
            this.maskedtel.Name = "maskedtel";
            this.maskedtel.Size = new System.Drawing.Size(200, 20);
            this.maskedtel.TabIndex = 58;
            // 
            // maskedtc
            // 
            this.maskedtc.Location = new System.Drawing.Point(136, 277);
            this.maskedtc.Mask = "00000000000";
            this.maskedtc.Name = "maskedtc";
            this.maskedtc.Size = new System.Drawing.Size(200, 20);
            this.maskedtc.TabIndex = 59;
            this.maskedtc.ValidatingType = typeof(int);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(136, 390);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 20);
            this.datetime.TabIndex = 60;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(136, 428);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(200, 20);
            this.txtmaas.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(60, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 23);
            this.label10.TabIndex = 61;
            this.label10.Text = "Maaş : ";
            // 
            // Frmpersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 566);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.maskedtc);
            this.Controls.Add(this.maskedtel);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtyas);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combocin);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAracKayit);
            this.Controls.Add(this.label1);
            this.Name = "Frmpersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Ekleme Ekranı";
            this.Load += new System.EventHandler(this.Frmpersonel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnAracKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.ComboBox combocin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtyas;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.MaskedTextBox maskedtel;
        private System.Windows.Forms.MaskedTextBox maskedtc;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.Label label10;
    }
}