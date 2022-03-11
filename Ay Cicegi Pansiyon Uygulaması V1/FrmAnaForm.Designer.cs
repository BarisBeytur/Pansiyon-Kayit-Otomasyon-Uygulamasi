namespace Ay_Cicegi_Pansiyon_Uygulaması_V1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
            this.AdminGiris = new System.Windows.Forms.Button();
            this.YeniMusteri = new System.Windows.Forms.Button();
            this.BtnOdalar = new System.Windows.Forms.Button();
            this.BtnMusteriler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminGiris
            // 
            this.AdminGiris.BackColor = System.Drawing.Color.DarkSalmon;
            this.AdminGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminGiris.Location = new System.Drawing.Point(205, 185);
            this.AdminGiris.Name = "AdminGiris";
            this.AdminGiris.Size = new System.Drawing.Size(164, 85);
            this.AdminGiris.TabIndex = 0;
            this.AdminGiris.Text = "Admin Giriş";
            this.AdminGiris.UseVisualStyleBackColor = false;
            this.AdminGiris.Click += new System.EventHandler(this.AdminGiris_Click);
            // 
            // YeniMusteri
            // 
            this.YeniMusteri.BackColor = System.Drawing.Color.DarkSalmon;
            this.YeniMusteri.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YeniMusteri.Location = new System.Drawing.Point(420, 185);
            this.YeniMusteri.Name = "YeniMusteri";
            this.YeniMusteri.Size = new System.Drawing.Size(164, 85);
            this.YeniMusteri.TabIndex = 1;
            this.YeniMusteri.Text = "Yeni Müşteri";
            this.YeniMusteri.UseVisualStyleBackColor = false;
            this.YeniMusteri.Click += new System.EventHandler(this.YeniMusteri_Click);
            // 
            // BtnOdalar
            // 
            this.BtnOdalar.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnOdalar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOdalar.Location = new System.Drawing.Point(615, 185);
            this.BtnOdalar.Name = "BtnOdalar";
            this.BtnOdalar.Size = new System.Drawing.Size(164, 85);
            this.BtnOdalar.TabIndex = 2;
            this.BtnOdalar.Text = "Odalar";
            this.BtnOdalar.UseVisualStyleBackColor = false;
            this.BtnOdalar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnMusteriler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMusteriler.Location = new System.Drawing.Point(205, 298);
            this.BtnMusteriler.Name = "BtnMusteriler";
            this.BtnMusteriler.Size = new System.Drawing.Size(164, 85);
            this.BtnMusteriler.TabIndex = 3;
            this.BtnMusteriler.Text = "Müşteriler";
            this.BtnMusteriler.UseVisualStyleBackColor = false;
            this.BtnMusteriler.Click += new System.EventHandler(this.BtnMusteriler_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 85);
            this.button1.TabIndex = 4;
            this.button1.Text = "Hakkımızda";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(622, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "AYÇİÇEĞİ PANSİYON";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnMusteriler);
            this.Controls.Add(this.BtnOdalar);
            this.Controls.Add(this.YeniMusteri);
            this.Controls.Add(this.AdminGiris);
            this.Name = "FrmAnaForm";
            this.Text = "Ana Form";
            this.Load += new System.EventHandler(this.FrmAnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminGiris;
        private System.Windows.Forms.Button YeniMusteri;
        private System.Windows.Forms.Button BtnOdalar;
        private System.Windows.Forms.Button BtnMusteriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}