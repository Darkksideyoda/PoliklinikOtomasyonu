
namespace PoliklinikOtomasyonu
{
    partial class HastaRandevuEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaRandevuEkrani));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hastaTcKontrolTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.polklinikSecimComboBox = new System.Windows.Forms.ComboBox();
            this.doktorSecimComboBox = new System.Windows.Forms.ComboBox();
            this.RandevuTarihidateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.randevuSaatiTextbox = new System.Windows.Forms.TextBox();
            this.randevuSaatiGroupBox = new System.Windows.Forms.GroupBox();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.randevuyuKaydetButton = new System.Windows.Forms.Button();
            this.islemiSonlandirButton = new System.Windows.Forms.Button();
            this.randevuKontrolButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.randevuSaatiGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "HASTA TC:";
            // 
            // hastaTcKontrolTextBox
            // 
            this.hastaTcKontrolTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hastaTcKontrolTextBox.Location = new System.Drawing.Point(205, 116);
            this.hastaTcKontrolTextBox.MaxLength = 11;
            this.hastaTcKontrolTextBox.Name = "hastaTcKontrolTextBox";
            this.hastaTcKontrolTextBox.Size = new System.Drawing.Size(259, 24);
            this.hastaTcKontrolTextBox.TabIndex = 15;
            this.hastaTcKontrolTextBox.Text = "";
            this.hastaTcKontrolTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hastaTcKontrolTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(76, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "POLIKLINIK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "DOKTOR:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "RANDEVU TARİHİ:";
            // 
            // polklinikSecimComboBox
            // 
            this.polklinikSecimComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.polklinikSecimComboBox.FormattingEnabled = true;
            this.polklinikSecimComboBox.Items.AddRange(new object[] {
            "ALGOLOJİ",
            "BESLENME VE DİYET",
            "BEYİN VE SİNİR CERRAHİSİ",
            "ÇOCUK ALERJİSİ",
            "ÇOCUK CERRAHİSİ",
            "ÇOCUK ENDOKRİNOLOJİSİ",
            "ÇOCUK ENFEKSİYON",
            "ÇOCUK GÖĞÜS HASTALIKLARI",
            "ÇOCUK HEMATOLOJİSİ",
            "ÇOCUK KARDİYOLOJİSİ",
            "ÇOCUK METABOLİZMA",
            "ÇOCUK NEFROLOJİSİ",
            "ÇOCUK NÖROLOJİSİ",
            "ÇOCUK PSİKİYATRİSİ",
            "ÇOCUK SAĞLIĞI VE HASTALIKLARI",
            "ÇOCUK ÜROLOJİSİ",
            "DERMATOLOJİ (CİLDİYE)",
            "ENDOKRİNOLOJİ VE METABOLİZMA",
            "ENFEKSİYON HASTALIKLARI",
            "FİZİKSEL TIP VE REHABİLİTASYON",
            "GASTROENTEROLOJİ",
            "GELENEKSEL VE TAMAMLAYICI TIP(GETAMER)",
            "GENEL CERRAHİ",
            "GERİATRİ",
            "GÖĞÜS CERRAHİSİ",
            "GÖĞÜS HASTALIKLARI",
            "GÖZ HASTALIKLARI",
            "HEMATOLOJİ",
            "İÇ HASTALIKLARI",
            "KADIN HASTALIKLARI VE DOĞUM",
            "KALP VE DAMAR CERRAHİSİ",
            "KARDİYOLOJİ",
            "KEMİK YOĞUNLUĞU ÖLÇÜMÜ",
            "KULAK-BURUN-BOĞAZ HASTALIKLARI",
            "NEFROLOJİ",
            "NÖROLOJİ",
            "ORTOPEDİ VE TRAVMATOLOJİ",
            "PLASTİK REKONSTRÜKTİF VE ESTETİK CERRAHİ",
            "PSİKİYATRİ",
            "RADYASYON ONKOLOJİSİ",
            "TIBBİ GENETİK",
            "TIBBİ PATOLOJİ",
            "ÜROLOJİ"});
            this.polklinikSecimComboBox.Location = new System.Drawing.Point(205, 154);
            this.polklinikSecimComboBox.Name = "polklinikSecimComboBox";
            this.polklinikSecimComboBox.Size = new System.Drawing.Size(259, 26);
            this.polklinikSecimComboBox.TabIndex = 19;
            // 
            // doktorSecimComboBox
            // 
            this.doktorSecimComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.doktorSecimComboBox.FormattingEnabled = true;
            this.doktorSecimComboBox.Location = new System.Drawing.Point(205, 230);
            this.doktorSecimComboBox.Name = "doktorSecimComboBox";
            this.doktorSecimComboBox.Size = new System.Drawing.Size(259, 26);
            this.doktorSecimComboBox.TabIndex = 20;
            this.doktorSecimComboBox.Visible = false;
            // 
            // RandevuTarihidateTimePicker
            // 
            this.RandevuTarihidateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.RandevuTarihidateTimePicker.Location = new System.Drawing.Point(205, 191);
            this.RandevuTarihidateTimePicker.Name = "RandevuTarihidateTimePicker";
            this.RandevuTarihidateTimePicker.Size = new System.Drawing.Size(259, 24);
            this.RandevuTarihidateTimePicker.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "SEÇİLEN SAAT:";
            this.label5.Visible = false;
            // 
            // randevuSaatiTextbox
            // 
            this.randevuSaatiTextbox.Enabled = false;
            this.randevuSaatiTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.randevuSaatiTextbox.Location = new System.Drawing.Point(205, 272);
            this.randevuSaatiTextbox.Name = "randevuSaatiTextbox";
            this.randevuSaatiTextbox.Size = new System.Drawing.Size(259, 24);
            this.randevuSaatiTextbox.TabIndex = 24;
            this.randevuSaatiTextbox.Visible = false;
            // 
            // randevuSaatiGroupBox
            // 
            this.randevuSaatiGroupBox.Controls.Add(this.button27);
            this.randevuSaatiGroupBox.Controls.Add(this.button28);
            this.randevuSaatiGroupBox.Controls.Add(this.button29);
            this.randevuSaatiGroupBox.Controls.Add(this.button30);
            this.randevuSaatiGroupBox.Controls.Add(this.button31);
            this.randevuSaatiGroupBox.Controls.Add(this.button32);
            this.randevuSaatiGroupBox.Controls.Add(this.button21);
            this.randevuSaatiGroupBox.Controls.Add(this.button22);
            this.randevuSaatiGroupBox.Controls.Add(this.button23);
            this.randevuSaatiGroupBox.Controls.Add(this.button24);
            this.randevuSaatiGroupBox.Controls.Add(this.button25);
            this.randevuSaatiGroupBox.Controls.Add(this.button26);
            this.randevuSaatiGroupBox.Controls.Add(this.button15);
            this.randevuSaatiGroupBox.Controls.Add(this.button16);
            this.randevuSaatiGroupBox.Controls.Add(this.button17);
            this.randevuSaatiGroupBox.Controls.Add(this.button18);
            this.randevuSaatiGroupBox.Controls.Add(this.button19);
            this.randevuSaatiGroupBox.Controls.Add(this.button20);
            this.randevuSaatiGroupBox.Controls.Add(this.button9);
            this.randevuSaatiGroupBox.Controls.Add(this.button10);
            this.randevuSaatiGroupBox.Controls.Add(this.button11);
            this.randevuSaatiGroupBox.Controls.Add(this.button12);
            this.randevuSaatiGroupBox.Controls.Add(this.button13);
            this.randevuSaatiGroupBox.Controls.Add(this.button14);
            this.randevuSaatiGroupBox.Controls.Add(this.button8);
            this.randevuSaatiGroupBox.Controls.Add(this.button7);
            this.randevuSaatiGroupBox.Controls.Add(this.button6);
            this.randevuSaatiGroupBox.Controls.Add(this.button5);
            this.randevuSaatiGroupBox.Controls.Add(this.button4);
            this.randevuSaatiGroupBox.Controls.Add(this.button3);
            this.randevuSaatiGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.randevuSaatiGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.randevuSaatiGroupBox.Location = new System.Drawing.Point(12, 388);
            this.randevuSaatiGroupBox.Name = "randevuSaatiGroupBox";
            this.randevuSaatiGroupBox.Size = new System.Drawing.Size(464, 187);
            this.randevuSaatiGroupBox.TabIndex = 25;
            this.randevuSaatiGroupBox.TabStop = false;
            this.randevuSaatiGroupBox.Text = "RANDEVU SAATLERİ";
            this.randevuSaatiGroupBox.Visible = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.LimeGreen;
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button27.Location = new System.Drawing.Point(386, 155);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(69, 23);
            this.button27.TabIndex = 59;
            this.button27.Text = "14:50";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LimeGreen;
            this.button28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button28.Location = new System.Drawing.Point(311, 155);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(69, 23);
            this.button28.TabIndex = 58;
            this.button28.Text = "14:40";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LimeGreen;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button29.Location = new System.Drawing.Point(236, 155);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(69, 23);
            this.button29.TabIndex = 57;
            this.button29.Text = "14:30";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.LimeGreen;
            this.button30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button30.Location = new System.Drawing.Point(161, 155);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(69, 23);
            this.button30.TabIndex = 56;
            this.button30.Text = "14:20";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.LimeGreen;
            this.button31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button31.Location = new System.Drawing.Point(86, 155);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(69, 23);
            this.button31.TabIndex = 55;
            this.button31.Text = "14:10";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.LimeGreen;
            this.button32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button32.Location = new System.Drawing.Point(11, 155);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(69, 23);
            this.button32.TabIndex = 54;
            this.button32.Text = "14:00";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LimeGreen;
            this.button21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button21.Location = new System.Drawing.Point(386, 126);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(69, 23);
            this.button21.TabIndex = 53;
            this.button21.Text = "13:50";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.LimeGreen;
            this.button22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button22.Location = new System.Drawing.Point(311, 126);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(69, 23);
            this.button22.TabIndex = 52;
            this.button22.Text = "13:40";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LimeGreen;
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button23.Location = new System.Drawing.Point(236, 126);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(69, 23);
            this.button23.TabIndex = 51;
            this.button23.Text = "13:30";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LimeGreen;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button24.Location = new System.Drawing.Point(161, 126);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(69, 23);
            this.button24.TabIndex = 50;
            this.button24.Text = "13:20";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.LimeGreen;
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button25.Location = new System.Drawing.Point(86, 126);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(69, 23);
            this.button25.TabIndex = 49;
            this.button25.Text = "13:10";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LimeGreen;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button26.Location = new System.Drawing.Point(11, 126);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(69, 23);
            this.button26.TabIndex = 48;
            this.button26.Text = "13:00";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LimeGreen;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button15.Location = new System.Drawing.Point(386, 97);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(69, 23);
            this.button15.TabIndex = 47;
            this.button15.Text = "11:50";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LimeGreen;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button16.Location = new System.Drawing.Point(311, 97);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(69, 23);
            this.button16.TabIndex = 46;
            this.button16.Text = "11:40";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LimeGreen;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button17.Location = new System.Drawing.Point(236, 97);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(69, 23);
            this.button17.TabIndex = 45;
            this.button17.Text = "11:30";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LimeGreen;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button18.Location = new System.Drawing.Point(161, 97);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(69, 23);
            this.button18.TabIndex = 44;
            this.button18.Text = "11:20";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LimeGreen;
            this.button19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button19.Location = new System.Drawing.Point(86, 97);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(69, 23);
            this.button19.TabIndex = 43;
            this.button19.Text = "11:10";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LimeGreen;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button20.Location = new System.Drawing.Point(11, 97);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(69, 23);
            this.button20.TabIndex = 42;
            this.button20.Text = "11:00";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LimeGreen;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(386, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(69, 23);
            this.button9.TabIndex = 41;
            this.button9.Text = "10:50";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LimeGreen;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(311, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(69, 23);
            this.button10.TabIndex = 40;
            this.button10.Text = "10:40";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LimeGreen;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(236, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(69, 23);
            this.button11.TabIndex = 39;
            this.button11.Text = "10:30";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LimeGreen;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.Location = new System.Drawing.Point(161, 68);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(69, 23);
            this.button12.TabIndex = 38;
            this.button12.Text = "10:20";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LimeGreen;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button13.Location = new System.Drawing.Point(86, 68);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(69, 23);
            this.button13.TabIndex = 37;
            this.button13.Text = "10:10";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LimeGreen;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button14.Location = new System.Drawing.Point(11, 68);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(69, 23);
            this.button14.TabIndex = 36;
            this.button14.Text = "10:00";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LimeGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(386, 39);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(69, 23);
            this.button8.TabIndex = 35;
            this.button8.Text = "09:50";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(311, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(69, 23);
            this.button7.TabIndex = 34;
            this.button7.Text = "09:40";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(236, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(69, 23);
            this.button6.TabIndex = 33;
            this.button6.Text = "09:30";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(161, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(69, 23);
            this.button5.TabIndex = 32;
            this.button5.Text = "09:20";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(86, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 23);
            this.button4.TabIndex = 31;
            this.button4.Text = "09:10";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(11, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "09:00";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // randevuyuKaydetButton
            // 
            this.randevuyuKaydetButton.BackColor = System.Drawing.Color.PeachPuff;
            this.randevuyuKaydetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuyuKaydetButton.Image = ((System.Drawing.Image)(resources.GetObject("randevuyuKaydetButton.Image")));
            this.randevuyuKaydetButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.randevuyuKaydetButton.Location = new System.Drawing.Point(110, 625);
            this.randevuyuKaydetButton.Name = "randevuyuKaydetButton";
            this.randevuyuKaydetButton.Size = new System.Drawing.Size(75, 60);
            this.randevuyuKaydetButton.TabIndex = 26;
            this.randevuyuKaydetButton.Text = "KAYDET";
            this.randevuyuKaydetButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randevuyuKaydetButton.UseVisualStyleBackColor = false;
            this.randevuyuKaydetButton.Visible = false;
            this.randevuyuKaydetButton.Click += new System.EventHandler(this.randevuyuKaydetButton_Click);
            // 
            // islemiSonlandirButton
            // 
            this.islemiSonlandirButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.islemiSonlandirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.islemiSonlandirButton.Image = ((System.Drawing.Image)(resources.GetObject("islemiSonlandirButton.Image")));
            this.islemiSonlandirButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.islemiSonlandirButton.Location = new System.Drawing.Point(293, 625);
            this.islemiSonlandirButton.Name = "islemiSonlandirButton";
            this.islemiSonlandirButton.Size = new System.Drawing.Size(75, 60);
            this.islemiSonlandirButton.TabIndex = 27;
            this.islemiSonlandirButton.Text = "KAPAT";
            this.islemiSonlandirButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.islemiSonlandirButton.UseVisualStyleBackColor = false;
            this.islemiSonlandirButton.Visible = false;
            // 
            // randevuKontrolButton
            // 
            this.randevuKontrolButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.randevuKontrolButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.randevuKontrolButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.randevuKontrolButton.Location = new System.Drawing.Point(205, 230);
            this.randevuKontrolButton.Name = "randevuKontrolButton";
            this.randevuKontrolButton.Size = new System.Drawing.Size(259, 39);
            this.randevuKontrolButton.TabIndex = 28;
            this.randevuKontrolButton.Text = "Secili Poliklinikte Randevu Ara";
            this.randevuKontrolButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.randevuKontrolButton.UseVisualStyleBackColor = false;
            this.randevuKontrolButton.Click += new System.EventHandler(this.randevuKontrolButton_Click);
            // 
            // HastaRandevuEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(488, 697);
            this.Controls.Add(this.randevuKontrolButton);
            this.Controls.Add(this.islemiSonlandirButton);
            this.Controls.Add(this.randevuyuKaydetButton);
            this.Controls.Add(this.randevuSaatiGroupBox);
            this.Controls.Add(this.randevuSaatiTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RandevuTarihidateTimePicker);
            this.Controls.Add(this.doktorSecimComboBox);
            this.Controls.Add(this.polklinikSecimComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hastaTcKontrolTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HastaRandevuEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HastaRandevu";
            this.Load += new System.EventHandler(this.HastaRandevuEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.randevuSaatiGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker RandevuTarihidateTimePicker;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.GroupBox randevuSaatiGroupBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox doktorSecimComboBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox randevuSaatiTextbox;
        public System.Windows.Forms.Button randevuyuKaydetButton;
        public System.Windows.Forms.Button islemiSonlandirButton;
        public System.Windows.Forms.Button randevuKontrolButton;
        public System.Windows.Forms.ComboBox polklinikSecimComboBox;
        public System.Windows.Forms.RichTextBox hastaTcKontrolTextBox;
    }
}