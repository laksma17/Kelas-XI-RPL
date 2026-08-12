namespace Kalkulator_Sederhana
{
    partial class Form1
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
            this.judul = new System.Windows.Forms.Label();
            this.textAngka1 = new System.Windows.Forms.TextBox();
            this.textAngka2 = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.Aksi = new System.Windows.Forms.Label();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // judul
            // 
            this.judul.AutoSize = true;
            this.judul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(48, 19);
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(299, 38);
            this.judul.TabIndex = 1;
            this.judul.Text = "Kalkulator Sederhana";
            this.judul.Click += new System.EventHandler(this.lblHasil_Click);
            // 
            // textAngka1
            // 
            this.textAngka1.Location = new System.Drawing.Point(31, 121);
            this.textAngka1.Name = "textAngka1";
            this.textAngka1.Size = new System.Drawing.Size(268, 26);
            this.textAngka1.TabIndex = 2;
            this.textAngka1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textAngka2
            // 
            this.textAngka2.Location = new System.Drawing.Point(31, 209);
            this.textAngka2.Name = "textAngka2";
            this.textAngka2.Size = new System.Drawing.Size(268, 26);
            this.textAngka2.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(31, 324);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(268, 30);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Angka 2";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasil.Location = new System.Drawing.Point(26, 248);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(70, 28);
            this.lblHasil.TabIndex = 1;
            this.lblHasil.Text = "Hasil :";
            // 
            // Aksi
            // 
            this.Aksi.AutoSize = true;
            this.Aksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aksi.Location = new System.Drawing.Point(137, 296);
            this.Aksi.Name = "Aksi";
            this.Aksi.Size = new System.Drawing.Size(54, 25);
            this.Aksi.TabIndex = 5;
            this.Aksi.Text = "Aksi";
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(31, 360);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(268, 30);
            this.btnKurang.TabIndex = 4;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(31, 396);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(268, 30);
            this.btnBagi.TabIndex = 4;
            this.btnBagi.Text = "Bagi";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(31, 432);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(268, 30);
            this.btnKali.TabIndex = 4;
            this.btnKali.Text = "Kali";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 573);
            this.Controls.Add(this.Aksi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.textAngka2);
            this.Controls.Add(this.textAngka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label judul;
        private System.Windows.Forms.TextBox textAngka1;
        private System.Windows.Forms.TextBox textAngka2;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label Aksi;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Button btnKali;
    }
}

