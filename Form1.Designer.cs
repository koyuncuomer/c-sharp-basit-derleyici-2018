namespace miniDerleyiciV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rTxtGiris = new System.Windows.Forms.RichTextBox();
            this.rTxtKonsol = new System.Windows.Forms.RichTextBox();
            this.btnDerle = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxtGiris
            // 
            this.rTxtGiris.BackColor = System.Drawing.SystemColors.Info;
            this.rTxtGiris.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtGiris.Location = new System.Drawing.Point(12, 32);
            this.rTxtGiris.Name = "rTxtGiris";
            this.rTxtGiris.Size = new System.Drawing.Size(427, 223);
            this.rTxtGiris.TabIndex = 0;
            this.rTxtGiris.Text = "";
            // 
            // rTxtKonsol
            // 
            this.rTxtKonsol.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtKonsol.Location = new System.Drawing.Point(12, 260);
            this.rTxtKonsol.Name = "rTxtKonsol";
            this.rTxtKonsol.ReadOnly = true;
            this.rTxtKonsol.Size = new System.Drawing.Size(427, 182);
            this.rTxtKonsol.TabIndex = 1;
            this.rTxtKonsol.Text = "";
            // 
            // btnDerle
            // 
            this.btnDerle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDerle.ForeColor = System.Drawing.Color.Red;
            this.btnDerle.Location = new System.Drawing.Point(356, 206);
            this.btnDerle.Name = "btnDerle";
            this.btnDerle.Size = new System.Drawing.Size(83, 48);
            this.btnDerle.TabIndex = 2;
            this.btnDerle.Text = "Derle ve Çalıştır";
            this.btnDerle.UseVisualStyleBackColor = true;
            this.btnDerle.Click += new System.EventHandler(this.btnDerle_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Red;
            this.btnInfo.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInfo.ForeColor = System.Drawing.Color.Yellow;
            this.btnInfo.Location = new System.Drawing.Point(12, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(232, 32);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Bilgilendirme ve Örnek Kod";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 450);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnDerle);
            this.Controls.Add(this.rTxtKonsol);
            this.Controls.Add(this.rTxtGiris);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Basit Dil Derleyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtGiris;
        private System.Windows.Forms.RichTextBox rTxtKonsol;
        private System.Windows.Forms.Button btnDerle;
        private System.Windows.Forms.Button btnInfo;
    }
}

