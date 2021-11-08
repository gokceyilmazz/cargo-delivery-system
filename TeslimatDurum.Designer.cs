namespace KargoSistemi
{
    partial class TeslimatDurum
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
            this.yer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enlem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boylam = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yerAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimatDurumu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl4 = new System.Windows.Forms.Label();
            this.tesNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teslimat Yeri:";
            // 
            // yer
            // 
            this.yer.Location = new System.Drawing.Point(320, 81);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(183, 22);
            this.yer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enlem:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // enlem
            // 
            this.enlem.Location = new System.Drawing.Point(320, 123);
            this.enlem.Name = "enlem";
            this.enlem.Size = new System.Drawing.Size(183, 22);
            this.enlem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Boylam:";
            // 
            // boylam
            // 
            this.boylam.Location = new System.Drawing.Point(320, 164);
            this.boylam.Name = "boylam";
            this.boylam.Size = new System.Drawing.Size(183, 22);
            this.boylam.TabIndex = 5;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(702, 202);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(116, 32);
            this.ekle.TabIndex = 6;
            this.ekle.Text = "Teslim Edildi";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YerId,
            this.yerAdi,
            this.Latitude,
            this.Longitude,
            this.teslimatDurumu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(951, 276);
            this.dataGridView1.TabIndex = 7;
            // 
            // YerId
            // 
            this.YerId.DataPropertyName = "yerId";
            this.YerId.HeaderText = "Kargo No";
            this.YerId.MinimumWidth = 6;
            this.YerId.Name = "YerId";
            // 
            // yerAdi
            // 
            this.yerAdi.DataPropertyName = "yerAdi";
            this.yerAdi.HeaderText = "Adres";
            this.yerAdi.MinimumWidth = 6;
            this.yerAdi.Name = "yerAdi";
            // 
            // Latitude
            // 
            this.Latitude.DataPropertyName = "latitude";
            this.Latitude.HeaderText = "Enlem";
            this.Latitude.MinimumWidth = 6;
            this.Latitude.Name = "Latitude";
            // 
            // Longitude
            // 
            this.Longitude.DataPropertyName = "longitude";
            this.Longitude.HeaderText = "Boylam";
            this.Longitude.MinimumWidth = 6;
            this.Longitude.Name = "Longitude";
            // 
            // teslimatDurumu
            // 
            this.teslimatDurumu.DataPropertyName = "teslimatDurumu";
            this.teslimatDurumu.HeaderText = "Teslimat Durumu";
            this.teslimatDurumu.MinimumWidth = 6;
            this.teslimatDurumu.Name = "teslimatDurumu";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(192, 42);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(87, 17);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Teslimat No:";
            // 
            // tesNo
            // 
            this.tesNo.Location = new System.Drawing.Point(320, 42);
            this.tesNo.Name = "tesNo";
            this.tesNo.Size = new System.Drawing.Size(183, 22);
            this.tesNo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Kargoyu Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::KargoSistemi.Properties.Resources.geri5;
            this.button2.Location = new System.Drawing.Point(12, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 60);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeslimatDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tesNo);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.boylam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enlem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.label1);
            this.Name = "TeslimatDurum";
            this.Text = "Teslimat Durum Ekranı";
            this.Load += new System.EventHandler(this.AdresEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enlem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boylam;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox tesNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn YerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn yerAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimatDurumu;
    }
}