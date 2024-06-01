
namespace ŞİRKETOTOMASYONUUU
{
    partial class İLETİŞİM
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
            this.RTBADRES = new System.Windows.Forms.RichTextBox();
            this.TXTVERGİ = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTKAYIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTBADRES
            // 
            this.RTBADRES.Location = new System.Drawing.Point(182, 224);
            this.RTBADRES.Name = "RTBADRES";
            this.RTBADRES.Size = new System.Drawing.Size(128, 65);
            this.RTBADRES.TabIndex = 24;
            this.RTBADRES.Text = "";
            // 
            // TXTVERGİ
            // 
            this.TXTVERGİ.Location = new System.Drawing.Point(182, 146);
            this.TXTVERGİ.Name = "TXTVERGİ";
            this.TXTVERGİ.Size = new System.Drawing.Size(128, 20);
            this.TXTVERGİ.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(182, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(131, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 27;
            this.label10.Text = "MAİL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(120, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "KONU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "MESAJ:";
            // 
            // BTKAYIT
            // 
            this.BTKAYIT.Location = new System.Drawing.Point(182, 322);
            this.BTKAYIT.Name = "BTKAYIT";
            this.BTKAYIT.Size = new System.Drawing.Size(128, 23);
            this.BTKAYIT.TabIndex = 30;
            this.BTKAYIT.Text = "GÖNDER";
            this.BTKAYIT.UseVisualStyleBackColor = true;
            this.BTKAYIT.Click += new System.EventHandler(this.BTKAYIT_Click);
            // 
            // İLETİŞİM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.BTKAYIT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TXTVERGİ);
            this.Controls.Add(this.RTBADRES);
            this.Name = "İLETİŞİM";
            this.Text = "İLETİŞİM";
            this.Load += new System.EventHandler(this.İLETİŞİM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBADRES;
        private System.Windows.Forms.TextBox TXTVERGİ;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTKAYIT;
    }
}