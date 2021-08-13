namespace miniDerleyiciV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.rTxtInfo = new System.Windows.Forms.RichTextBox();
            this.rTxtOrnek = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rTxtInfo
            // 
            this.rTxtInfo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtInfo.Location = new System.Drawing.Point(12, 12);
            this.rTxtInfo.Name = "rTxtInfo";
            this.rTxtInfo.ReadOnly = true;
            this.rTxtInfo.Size = new System.Drawing.Size(247, 293);
            this.rTxtInfo.TabIndex = 0;
            this.rTxtInfo.Text = "";
            // 
            // rTxtOrnek
            // 
            this.rTxtOrnek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtOrnek.Location = new System.Drawing.Point(265, 12);
            this.rTxtOrnek.Name = "rTxtOrnek";
            this.rTxtOrnek.ReadOnly = true;
            this.rTxtOrnek.Size = new System.Drawing.Size(247, 293);
            this.rTxtOrnek.TabIndex = 1;
            this.rTxtOrnek.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 314);
            this.Controls.Add(this.rTxtOrnek);
            this.Controls.Add(this.rTxtInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Bilgilendirme ve Örnek Kod";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtInfo;
        private System.Windows.Forms.RichTextBox rTxtOrnek;
    }
}