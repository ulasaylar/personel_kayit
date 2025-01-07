namespace PersonelKayit
{
    partial class FrmAnaForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.Lblmeslek = new System.Windows.Forms.Label();
            this.Lbldurum = new System.Windows.Forms.Label();
            this.Lblmaas = new System.Windows.Forms.Label();
            this.Lblsehir = new System.Windows.Forms.Label();
            this.Lblsoyad = new System.Windows.Forms.Label();
            this.Lblad = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Cmbsehir = new System.Windows.Forms.ComboBox();
            this.Mtxtmaas = new System.Windows.Forms.MaskedTextBox();
            this.Txtmeslek = new System.Windows.Forms.TextBox();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.Lblid = new System.Windows.Forms.Label();
            this.Txtad = new System.Windows.Forms.TextBox();
            this.Txtsoyad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btngrafikler = new System.Windows.Forms.Button();
            this.Btnistatistik = new System.Windows.Forms.Button();
            this.Btntemizle = new System.Windows.Forms.Button();
            this.Btngüncelle = new System.Windows.Forms.Button();
            this.Btnsil = new System.Windows.Forms.Button();
            this.Btnkaydet = new System.Windows.Forms.Button();
            this.Btnlistele = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelVeriTabanıDataSet = new PersonelKayit.PersonelVeriTabanıDataSet();
            this.tbl_PersonelTableAdapter = new PersonelKayit.PersonelVeriTabanıDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.labeldurum = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.Lblmeslek);
            this.groupBox1.Controls.Add(this.Lbldurum);
            this.groupBox1.Controls.Add(this.Lblmaas);
            this.groupBox1.Controls.Add(this.Lblsehir);
            this.groupBox1.Controls.Add(this.Lblsoyad);
            this.groupBox1.Controls.Add(this.Lblad);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.Cmbsehir);
            this.groupBox1.Controls.Add(this.Mtxtmaas);
            this.groupBox1.Controls.Add(this.Txtmeslek);
            this.groupBox1.Controls.Add(this.Txtid);
            this.groupBox1.Controls.Add(this.Lblid);
            this.groupBox1.Controls.Add(this.Txtad);
            this.groupBox1.Controls.Add(this.Txtsoyad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(146, 233);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 27);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Evli";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // Lblmeslek
            // 
            this.Lblmeslek.AutoSize = true;
            this.Lblmeslek.Location = new System.Drawing.Point(6, 268);
            this.Lblmeslek.Name = "Lblmeslek";
            this.Lblmeslek.Size = new System.Drawing.Size(140, 23);
            this.Lblmeslek.TabIndex = 18;
            this.Lblmeslek.Text = "Personel Meslek:";
            // 
            // Lbldurum
            // 
            this.Lbldurum.AutoSize = true;
            this.Lbldurum.Location = new System.Drawing.Point(6, 235);
            this.Lbldurum.Name = "Lbldurum";
            this.Lbldurum.Size = new System.Drawing.Size(140, 23);
            this.Lbldurum.TabIndex = 17;
            this.Lbldurum.Text = "Personel Durum:";
            // 
            // Lblmaas
            // 
            this.Lblmaas.AutoSize = true;
            this.Lblmaas.Location = new System.Drawing.Point(6, 199);
            this.Lblmaas.Name = "Lblmaas";
            this.Lblmaas.Size = new System.Drawing.Size(127, 23);
            this.Lblmaas.TabIndex = 16;
            this.Lblmaas.Text = "Personel Maaş:";
            // 
            // Lblsehir
            // 
            this.Lblsehir.AutoSize = true;
            this.Lblsehir.Location = new System.Drawing.Point(6, 162);
            this.Lblsehir.Name = "Lblsehir";
            this.Lblsehir.Size = new System.Drawing.Size(124, 23);
            this.Lblsehir.TabIndex = 15;
            this.Lblsehir.Text = "Personel Şehir:";
            // 
            // Lblsoyad
            // 
            this.Lblsoyad.AutoSize = true;
            this.Lblsoyad.Location = new System.Drawing.Point(6, 125);
            this.Lblsoyad.Name = "Lblsoyad";
            this.Lblsoyad.Size = new System.Drawing.Size(133, 23);
            this.Lblsoyad.TabIndex = 14;
            this.Lblsoyad.Text = "Personel Soyad:";
            // 
            // Lblad
            // 
            this.Lblad.AutoSize = true;
            this.Lblad.Location = new System.Drawing.Point(6, 88);
            this.Lblad.Name = "Lblad";
            this.Lblad.Size = new System.Drawing.Size(106, 23);
            this.Lblad.TabIndex = 13;
            this.Lblad.Text = "Personel Ad:";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(208, 233);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 27);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 233);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(55, 27);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Cmbsehir
            // 
            this.Cmbsehir.FormattingEnabled = true;
            this.Cmbsehir.Location = new System.Drawing.Point(146, 159);
            this.Cmbsehir.Name = "Cmbsehir";
            this.Cmbsehir.Size = new System.Drawing.Size(134, 31);
            this.Cmbsehir.TabIndex = 6;
            // 
            // Mtxtmaas
            // 
            this.Mtxtmaas.Location = new System.Drawing.Point(146, 196);
            this.Mtxtmaas.Mask = "0000";
            this.Mtxtmaas.Name = "Mtxtmaas";
            this.Mtxtmaas.Size = new System.Drawing.Size(134, 31);
            this.Mtxtmaas.TabIndex = 7;
            this.Mtxtmaas.ValidatingType = typeof(int);
            // 
            // Txtmeslek
            // 
            this.Txtmeslek.Location = new System.Drawing.Point(146, 265);
            this.Txtmeslek.Name = "Txtmeslek";
            this.Txtmeslek.Size = new System.Drawing.Size(134, 31);
            this.Txtmeslek.TabIndex = 8;
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(146, 48);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(134, 31);
            this.Txtid.TabIndex = 3;
            // 
            // Lblid
            // 
            this.Lblid.AutoSize = true;
            this.Lblid.Location = new System.Drawing.Point(6, 51);
            this.Lblid.Name = "Lblid";
            this.Lblid.Size = new System.Drawing.Size(103, 23);
            this.Lblid.TabIndex = 2;
            this.Lblid.Text = "Personel ID:";
            // 
            // Txtad
            // 
            this.Txtad.Location = new System.Drawing.Point(146, 85);
            this.Txtad.Name = "Txtad";
            this.Txtad.Size = new System.Drawing.Size(134, 31);
            this.Txtad.TabIndex = 4;
            // 
            // Txtsoyad
            // 
            this.Txtsoyad.Location = new System.Drawing.Point(146, 122);
            this.Txtsoyad.Name = "Txtsoyad";
            this.Txtsoyad.Size = new System.Drawing.Size(134, 31);
            this.Txtsoyad.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btngrafikler);
            this.groupBox2.Controls.Add(this.Btnistatistik);
            this.groupBox2.Controls.Add(this.Btntemizle);
            this.groupBox2.Controls.Add(this.Btngüncelle);
            this.groupBox2.Controls.Add(this.Btnsil);
            this.groupBox2.Controls.Add(this.Btnkaydet);
            this.groupBox2.Controls.Add(this.Btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // Btngrafikler
            // 
            this.Btngrafikler.Location = new System.Drawing.Point(73, 277);
            this.Btngrafikler.Name = "Btngrafikler";
            this.Btngrafikler.Size = new System.Drawing.Size(141, 35);
            this.Btngrafikler.TabIndex = 6;
            this.Btngrafikler.Text = "Grafikler";
            this.Btngrafikler.UseVisualStyleBackColor = true;
            this.Btngrafikler.Click += new System.EventHandler(this.Btngrafikler_Click);
            // 
            // Btnistatistik
            // 
            this.Btnistatistik.Location = new System.Drawing.Point(73, 236);
            this.Btnistatistik.Name = "Btnistatistik";
            this.Btnistatistik.Size = new System.Drawing.Size(141, 35);
            this.Btnistatistik.TabIndex = 5;
            this.Btnistatistik.Text = "İstatistik";
            this.Btnistatistik.UseVisualStyleBackColor = true;
            this.Btnistatistik.Click += new System.EventHandler(this.Btnistatistik_Click);
            // 
            // Btntemizle
            // 
            this.Btntemizle.Location = new System.Drawing.Point(73, 195);
            this.Btntemizle.Name = "Btntemizle";
            this.Btntemizle.Size = new System.Drawing.Size(141, 35);
            this.Btntemizle.TabIndex = 4;
            this.Btntemizle.Text = "Temizle";
            this.Btntemizle.UseVisualStyleBackColor = true;
            this.Btntemizle.Click += new System.EventHandler(this.Btntemizle_Click);
            // 
            // Btngüncelle
            // 
            this.Btngüncelle.Location = new System.Drawing.Point(73, 154);
            this.Btngüncelle.Name = "Btngüncelle";
            this.Btngüncelle.Size = new System.Drawing.Size(141, 35);
            this.Btngüncelle.TabIndex = 3;
            this.Btngüncelle.Text = "Güncelle";
            this.Btngüncelle.UseVisualStyleBackColor = true;
            this.Btngüncelle.Click += new System.EventHandler(this.Btngüncelle_Click);
            // 
            // Btnsil
            // 
            this.Btnsil.Location = new System.Drawing.Point(73, 113);
            this.Btnsil.Name = "Btnsil";
            this.Btnsil.Size = new System.Drawing.Size(141, 35);
            this.Btnsil.TabIndex = 2;
            this.Btnsil.Text = "Sil";
            this.Btnsil.UseVisualStyleBackColor = true;
            this.Btnsil.Click += new System.EventHandler(this.Btnsil_Click);
            // 
            // Btnkaydet
            // 
            this.Btnkaydet.Location = new System.Drawing.Point(73, 71);
            this.Btnkaydet.Name = "Btnkaydet";
            this.Btnkaydet.Size = new System.Drawing.Size(141, 35);
            this.Btnkaydet.TabIndex = 1;
            this.Btnkaydet.Text = "Kaydet";
            this.Btnkaydet.UseVisualStyleBackColor = true;
            this.Btnkaydet.Click += new System.EventHandler(this.Btnkaydet_Click);
            // 
            // Btnlistele
            // 
            this.Btnlistele.Location = new System.Drawing.Point(73, 30);
            this.Btnlistele.Name = "Btnlistele";
            this.Btnlistele.Size = new System.Drawing.Size(141, 35);
            this.Btnlistele.TabIndex = 0;
            this.Btnlistele.Text = "Listele";
            this.Btnlistele.UseVisualStyleBackColor = true;
            this.Btnlistele.Click += new System.EventHandler(this.Btnlistele_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(614, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 346);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 245);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 215);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "Perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "Perid";
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewCheckBoxColumn
            // 
            this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.personelVeriTabanıDataSet;
            // 
            // personelVeriTabanıDataSet
            // 
            this.personelVeriTabanıDataSet.DataSetName = "PersonelVeriTabanıDataSet";
            this.personelVeriTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // labeldurum
            // 
            this.labeldurum.AutoSize = true;
            this.labeldurum.Location = new System.Drawing.Point(614, 245);
            this.labeldurum.Name = "labeldurum";
            this.labeldurum.Size = new System.Drawing.Size(55, 23);
            this.labeldurum.TabIndex = 4;
            this.labeldurum.Text = "label1";
            this.labeldurum.Visible = false;
            this.labeldurum.TextChanged += new System.EventHandler(this.labeldurum_TextChanged);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(818, 603);
            this.Controls.Add(this.labeldurum);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmAnaForm";
            this.Text = "PersonelKayıt";            
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelVeriTabanıDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label Lblid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label Lblmeslek;
        private System.Windows.Forms.Label Lbldurum;
        private System.Windows.Forms.Label Lblmaas;
        private System.Windows.Forms.Label Lblsehir;
        private System.Windows.Forms.Label Lblsoyad;
        private System.Windows.Forms.Label Lblad;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox Cmbsehir;
        private System.Windows.Forms.MaskedTextBox Mtxtmaas;
        private System.Windows.Forms.TextBox Txtmeslek;
        private System.Windows.Forms.TextBox Txtad;
        private System.Windows.Forms.TextBox Txtsoyad;
        private System.Windows.Forms.Button Btngrafikler;
        private System.Windows.Forms.Button Btnistatistik;
        private System.Windows.Forms.Button Btntemizle;
        private System.Windows.Forms.Button Btngüncelle;
        private System.Windows.Forms.Button Btnsil;
        private System.Windows.Forms.Button Btnkaydet;
        private System.Windows.Forms.Button Btnlistele;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelVeriTabanıDataSet personelVeriTabanıDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private PersonelVeriTabanıDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labeldurum;
    }
}

