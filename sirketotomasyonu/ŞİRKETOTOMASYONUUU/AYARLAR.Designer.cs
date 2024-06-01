
namespace ŞİRKETOTOMASYONUUU
{
    partial class AYARLAR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTGÜNCEL = new System.Windows.Forms.Button();
            this.BTSİL = new System.Windows.Forms.Button();
            this.BTKAYIT = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TXTVERGİ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(332, 426);
            this.dataGridView1.TabIndex = 7;
            // 
            // BTGÜNCEL
            // 
            this.BTGÜNCEL.Location = new System.Drawing.Point(465, 313);
            this.BTGÜNCEL.Name = "BTGÜNCEL";
            this.BTGÜNCEL.Size = new System.Drawing.Size(128, 23);
            this.BTGÜNCEL.TabIndex = 21;
            this.BTGÜNCEL.Text = "GÜNCELLE";
            this.BTGÜNCEL.UseVisualStyleBackColor = true;
            // 
            // BTSİL
            // 
            this.BTSİL.Location = new System.Drawing.Point(465, 257);
            this.BTSİL.Name = "BTSİL";
            this.BTSİL.Size = new System.Drawing.Size(128, 23);
            this.BTSİL.TabIndex = 20;
            this.BTSİL.Text = "SİL";
            this.BTSİL.UseVisualStyleBackColor = true;
            // 
            // BTKAYIT
            // 
            this.BTKAYIT.Location = new System.Drawing.Point(465, 199);
            this.BTKAYIT.Name = "BTKAYIT";
            this.BTKAYIT.Size = new System.Drawing.Size(128, 23);
            this.BTKAYIT.TabIndex = 19;
            this.BTKAYIT.Text = "KAYDET";
            this.BTKAYIT.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(465, 116);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(128, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(128, 20);
            this.textBox2.TabIndex = 31;
            // 
            // TXTVERGİ
            // 
            this.TXTVERGİ.Location = new System.Drawing.Point(465, 142);
            this.TXTVERGİ.Name = "TXTVERGİ";
            this.TXTVERGİ.Size = new System.Drawing.Size(128, 20);
            this.TXTVERGİ.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "ŞİFRE:";
            // 
            // AYARLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TXTVERGİ);
            this.Controls.Add(this.BTGÜNCEL);
            this.Controls.Add(this.BTSİL);
            this.Controls.Add(this.BTKAYIT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AYARLAR";
            this.Text = "AYARLAR";
            this.Load += new System.EventHandler(this.AYARLAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTGÜNCEL;
        private System.Windows.Forms.Button BTSİL;
        private System.Windows.Forms.Button BTKAYIT;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TXTVERGİ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}