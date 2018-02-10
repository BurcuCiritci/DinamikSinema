namespace DinamikSinema
{
    partial class frmSatis
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
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.txbOgr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMenu = new System.Windows.Forms.TextBox();
            this.txbGozluk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Sayısı :";
            // 
            // btnToplam
            // 
            this.btnToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToplam.Location = new System.Drawing.Point(16, 181);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(110, 33);
            this.btnToplam.TabIndex = 4;
            this.btnToplam.Text = "TOPLAM :";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOk.Location = new System.Drawing.Point(147, 221);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "TAMAM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(162, 194);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(51, 20);
            this.lblToplam.TabIndex = 6;
            this.lblToplam.Text = "label2";
            this.lblToplam.Visible = false;
            // 
            // txbOgr
            // 
            this.txbOgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbOgr.Location = new System.Drawing.Point(147, 47);
            this.txbOgr.Name = "txbOgr";
            this.txbOgr.Size = new System.Drawing.Size(100, 26);
            this.txbOgr.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menu Sayısı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gözlük Sayısı:";
            // 
            // txbMenu
            // 
            this.txbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbMenu.Location = new System.Drawing.Point(147, 86);
            this.txbMenu.Name = "txbMenu";
            this.txbMenu.Size = new System.Drawing.Size(100, 26);
            this.txbMenu.TabIndex = 11;
            // 
            // txbGozluk
            // 
            this.txbGozluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txbGozluk.Location = new System.Drawing.Point(147, 127);
            this.txbGozluk.Name = "txbGozluk";
            this.txbGozluk.Size = new System.Drawing.Size(100, 26);
            this.txbGozluk.TabIndex = 12;
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txbGozluk);
            this.Controls.Add(this.txbMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbOgr);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.label1);
            this.Name = "frmSatis";
            this.Text = "frmSatis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.TextBox txbOgr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMenu;
        private System.Windows.Forms.TextBox txbGozluk;
    }
}