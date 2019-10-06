namespace linus
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
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstDanhSachChon = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnChonDonLe = new System.Windows.Forms.Button();
            this.btnChonToanBo = new System.Windows.Forms.Button();
            this.btnXoaDonLe = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.Location = new System.Drawing.Point(12, 25);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(191, 238);
            this.lstDanhSach.TabIndex = 0;
            // 
            // lstDanhSachChon
            // 
            this.lstDanhSachChon.FormattingEnabled = true;
            this.lstDanhSachChon.Location = new System.Drawing.Point(278, 25);
            this.lstDanhSachChon.Name = "lstDanhSachChon";
            this.lstDanhSachChon.Size = new System.Drawing.Size(191, 238);
            this.lstDanhSachChon.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChonDonLe
            // 
            this.btnChonDonLe.Location = new System.Drawing.Point(209, 70);
            this.btnChonDonLe.Name = "btnChonDonLe";
            this.btnChonDonLe.Size = new System.Drawing.Size(63, 25);
            this.btnChonDonLe.TabIndex = 3;
            this.btnChonDonLe.Text = ">";
            this.btnChonDonLe.UseVisualStyleBackColor = true;
            this.btnChonDonLe.Click += new System.EventHandler(this.btnChonDonLe_Click);
            // 
            // btnChonToanBo
            // 
            this.btnChonToanBo.Location = new System.Drawing.Point(209, 111);
            this.btnChonToanBo.Name = "btnChonToanBo";
            this.btnChonToanBo.Size = new System.Drawing.Size(63, 25);
            this.btnChonToanBo.TabIndex = 4;
            this.btnChonToanBo.Text = ">>";
            this.btnChonToanBo.UseVisualStyleBackColor = true;
            this.btnChonToanBo.Click += new System.EventHandler(this.btnChonToanBo_Click);
            // 
            // btnXoaDonLe
            // 
            this.btnXoaDonLe.Location = new System.Drawing.Point(209, 152);
            this.btnXoaDonLe.Name = "btnXoaDonLe";
            this.btnXoaDonLe.Size = new System.Drawing.Size(63, 25);
            this.btnXoaDonLe.TabIndex = 5;
            this.btnXoaDonLe.Text = "<";
            this.btnXoaDonLe.UseVisualStyleBackColor = true;
            this.btnXoaDonLe.Click += new System.EventHandler(this.btnXoaDonLe_Click);
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Location = new System.Drawing.Point(209, 194);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(63, 25);
            this.btnXoaToanBo.TabIndex = 6;
            this.btnXoaToanBo.Text = "<<";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.Location = new System.Drawing.Point(275, 9);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(75, 13);
            this.lblDanhSachChon.TabIndex = 7;
            this.lblDanhSachChon.Text = "Sách đã chọn";
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(12, 9);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(59, 13);
            this.lblDanhSach.TabIndex = 8;
            this.lblDanhSach.Text = "Danh sách";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 301);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.btnXoaToanBo);
            this.Controls.Add(this.btnXoaDonLe);
            this.Controls.Add(this.btnChonToanBo);
            this.Controls.Add(this.btnChonDonLe);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDanhSachChon);
            this.Controls.Add(this.lstDanhSach);
            this.Name = "Form1";
            this.Text = "Chọn sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ListBox lstDanhSachChon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnChonDonLe;
        private System.Windows.Forms.Button btnChonToanBo;
        private System.Windows.Forms.Button btnXoaDonLe;
        private System.Windows.Forms.Button btnXoaToanBo;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.Label lblDanhSach;
    }
}

