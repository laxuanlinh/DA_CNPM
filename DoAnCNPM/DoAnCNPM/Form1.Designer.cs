namespace DoAnCNPM
{
    partial class frm_main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_capnhat = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_docgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_tacgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_nxb = new System.Windows.Forms.ToolStripMenuItem();
            this.item_capnhat_linhvuc = new System.Windows.Forms.ToolStripMenuItem();
            this.item_timkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.item_timkiem_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_timkiem_docgia = new System.Windows.Forms.ToolStripMenuItem();
            this.item_muontra_sach = new System.Windows.Forms.ToolStripMenuItem();
            this.item_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.item_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_muontra_sach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem_sach = new System.Windows.Forms.Button();
            this.btn_timkiem_docgia = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_capnhat_linhvuc = new System.Windows.Forms.Button();
            this.btn_capnhat_nxb = new System.Windows.Forms.Button();
            this.btn_capnhat_tacgia = new System.Windows.Forms.Button();
            this.btn_capnhat_docgia = new System.Windows.Forms.Button();
            this.btn_capnhat_sach = new System.Windows.Forms.Button();
            this.btn_capnhat_nhanvien = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_capnhat,
            this.item_timkiem,
            this.item_muontra_sach,
            this.item_baocao,
            this.item_thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_capnhat
            // 
            this.item_capnhat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_capnhat_nhanvien,
            this.item_capnhat_sach,
            this.item_capnhat_docgia,
            this.item_capnhat_tacgia,
            this.item_capnhat_nxb,
            this.item_capnhat_linhvuc});
            this.item_capnhat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat.Name = "item_capnhat";
            this.item_capnhat.Size = new System.Drawing.Size(72, 21);
            this.item_capnhat.Text = "Cập nhật";
            // 
            // item_capnhat_nhanvien
            // 
            this.item_capnhat_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_nhanvien.Name = "item_capnhat_nhanvien";
            this.item_capnhat_nhanvien.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_nhanvien.Text = "Nhân viên";
            this.item_capnhat_nhanvien.Click += new System.EventHandler(this.btn_capnhat_nhanvien_Click);
            // 
            // item_capnhat_sach
            // 
            this.item_capnhat_sach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_sach.Name = "item_capnhat_sach";
            this.item_capnhat_sach.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_sach.Text = "Sách";
            this.item_capnhat_sach.Click += new System.EventHandler(this.btn_capnhat_sach_Click);
            // 
            // item_capnhat_docgia
            // 
            this.item_capnhat_docgia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_docgia.Name = "item_capnhat_docgia";
            this.item_capnhat_docgia.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_docgia.Text = "Độc giả";
            this.item_capnhat_docgia.Click += new System.EventHandler(this.btn_capnhat_docgia_Click);
            // 
            // item_capnhat_tacgia
            // 
            this.item_capnhat_tacgia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_tacgia.Name = "item_capnhat_tacgia";
            this.item_capnhat_tacgia.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_tacgia.Text = "Tác giả";
            this.item_capnhat_tacgia.Click += new System.EventHandler(this.btn_capnhat_tacgia_Click);
            // 
            // item_capnhat_nxb
            // 
            this.item_capnhat_nxb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_nxb.Name = "item_capnhat_nxb";
            this.item_capnhat_nxb.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_nxb.Text = "Nhà xuất bản ";
            this.item_capnhat_nxb.Click += new System.EventHandler(this.btn_capnhat_nxb_Click);
            // 
            // item_capnhat_linhvuc
            // 
            this.item_capnhat_linhvuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_capnhat_linhvuc.Name = "item_capnhat_linhvuc";
            this.item_capnhat_linhvuc.Size = new System.Drawing.Size(158, 22);
            this.item_capnhat_linhvuc.Text = "Lĩnh vực";
            this.item_capnhat_linhvuc.Click += new System.EventHandler(this.btn_capnhat_linhvuc_Click);
            // 
            // item_timkiem
            // 
            this.item_timkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_timkiem_sach,
            this.item_timkiem_docgia});
            this.item_timkiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_timkiem.Name = "item_timkiem";
            this.item_timkiem.Size = new System.Drawing.Size(72, 21);
            this.item_timkiem.Text = "Tìm kiếm";
            // 
            // item_timkiem_sach
            // 
            this.item_timkiem_sach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_timkiem_sach.Name = "item_timkiem_sach";
            this.item_timkiem_sach.Size = new System.Drawing.Size(152, 22);
            this.item_timkiem_sach.Text = "Sách";
            this.item_timkiem_sach.Click += new System.EventHandler(this.btn_timkiem_sach_Click);
            // 
            // item_timkiem_docgia
            // 
            this.item_timkiem_docgia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_timkiem_docgia.Name = "item_timkiem_docgia";
            this.item_timkiem_docgia.Size = new System.Drawing.Size(121, 22);
            this.item_timkiem_docgia.Text = "Độc giả";
            // 
            // item_muontra_sach
            // 
            this.item_muontra_sach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_muontra_sach.Name = "item_muontra_sach";
            this.item_muontra_sach.Size = new System.Drawing.Size(106, 21);
            this.item_muontra_sach.Text = "Mượn/trả sách";
            // 
            // item_baocao
            // 
            this.item_baocao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_baocao.Name = "item_baocao";
            this.item_baocao.Size = new System.Drawing.Size(67, 21);
            this.item_baocao.Text = "Báo cáo";
            // 
            // item_thoat
            // 
            this.item_thoat.Name = "item_thoat";
            this.item_thoat.Size = new System.Drawing.Size(53, 21);
            this.item_thoat.Text = "Thoát";
            this.item_thoat.Click += new System.EventHandler(this.item_thoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Location = new System.Drawing.Point(6, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 529);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button11);
            this.groupBox4.Controls.Add(this.button10);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(767, 134);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 320);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Báo cáo";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(6, 47);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(177, 33);
            this.button11.TabIndex = 0;
            this.button11.Text = "Báo cáo";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 88);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(177, 33);
            this.button10.TabIndex = 0;
            this.button10.Text = "Báo cáo";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_muontra_sach);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(535, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 320);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mượn/ trả sách";
            // 
            // btn_muontra_sach
            // 
            this.btn_muontra_sach.Location = new System.Drawing.Point(6, 47);
            this.btn_muontra_sach.Name = "btn_muontra_sach";
            this.btn_muontra_sach.Size = new System.Drawing.Size(177, 33);
            this.btn_muontra_sach.TabIndex = 0;
            this.btn_muontra_sach.Text = "Mượn / Trả sách";
            this.btn_muontra_sach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_timkiem_sach);
            this.groupBox2.Controls.Add(this.btn_timkiem_docgia);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(279, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 320);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btn_timkiem_sach
            // 
            this.btn_timkiem_sach.Location = new System.Drawing.Point(6, 47);
            this.btn_timkiem_sach.Name = "btn_timkiem_sach";
            this.btn_timkiem_sach.Size = new System.Drawing.Size(177, 33);
            this.btn_timkiem_sach.TabIndex = 0;
            this.btn_timkiem_sach.Text = "Tìm kiếm Sách";
            this.btn_timkiem_sach.UseVisualStyleBackColor = true;
            this.btn_timkiem_sach.Click += new System.EventHandler(this.btn_timkiem_sach_Click);
            // 
            // btn_timkiem_docgia
            // 
            this.btn_timkiem_docgia.Location = new System.Drawing.Point(6, 88);
            this.btn_timkiem_docgia.Name = "btn_timkiem_docgia";
            this.btn_timkiem_docgia.Size = new System.Drawing.Size(177, 33);
            this.btn_timkiem_docgia.TabIndex = 0;
            this.btn_timkiem_docgia.Text = "Tìm kiếm độc giả";
            this.btn_timkiem_docgia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_capnhat_linhvuc);
            this.groupBox1.Controls.Add(this.btn_capnhat_nxb);
            this.groupBox1.Controls.Add(this.btn_capnhat_tacgia);
            this.groupBox1.Controls.Add(this.btn_capnhat_docgia);
            this.groupBox1.Controls.Add(this.btn_capnhat_sach);
            this.groupBox1.Controls.Add(this.btn_capnhat_nhanvien);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 320);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cập nhật";
            // 
            // btn_capnhat_linhvuc
            // 
            this.btn_capnhat_linhvuc.Location = new System.Drawing.Point(6, 253);
            this.btn_capnhat_linhvuc.Name = "btn_capnhat_linhvuc";
            this.btn_capnhat_linhvuc.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_linhvuc.TabIndex = 0;
            this.btn_capnhat_linhvuc.Text = "Cập nhật lĩnh vực";
            this.btn_capnhat_linhvuc.UseVisualStyleBackColor = true;
            this.btn_capnhat_linhvuc.Click += new System.EventHandler(this.btn_capnhat_linhvuc_Click);
            // 
            // btn_capnhat_nxb
            // 
            this.btn_capnhat_nxb.Location = new System.Drawing.Point(6, 211);
            this.btn_capnhat_nxb.Name = "btn_capnhat_nxb";
            this.btn_capnhat_nxb.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_nxb.TabIndex = 0;
            this.btn_capnhat_nxb.Text = "Cập nhật nhà xuât bản";
            this.btn_capnhat_nxb.UseVisualStyleBackColor = true;
            this.btn_capnhat_nxb.Click += new System.EventHandler(this.btn_capnhat_nxb_Click);
            // 
            // btn_capnhat_tacgia
            // 
            this.btn_capnhat_tacgia.Location = new System.Drawing.Point(6, 170);
            this.btn_capnhat_tacgia.Name = "btn_capnhat_tacgia";
            this.btn_capnhat_tacgia.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_tacgia.TabIndex = 0;
            this.btn_capnhat_tacgia.Text = "Cập nhật tác giả";
            this.btn_capnhat_tacgia.UseVisualStyleBackColor = true;
            this.btn_capnhat_tacgia.Click += new System.EventHandler(this.btn_capnhat_tacgia_Click);
            // 
            // btn_capnhat_docgia
            // 
            this.btn_capnhat_docgia.Location = new System.Drawing.Point(6, 130);
            this.btn_capnhat_docgia.Name = "btn_capnhat_docgia";
            this.btn_capnhat_docgia.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_docgia.TabIndex = 0;
            this.btn_capnhat_docgia.Text = "Cập nhật độc giả";
            this.btn_capnhat_docgia.UseVisualStyleBackColor = true;
            this.btn_capnhat_docgia.Click += new System.EventHandler(this.btn_capnhat_docgia_Click);
            // 
            // btn_capnhat_sach
            // 
            this.btn_capnhat_sach.Location = new System.Drawing.Point(6, 88);
            this.btn_capnhat_sach.Name = "btn_capnhat_sach";
            this.btn_capnhat_sach.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_sach.TabIndex = 0;
            this.btn_capnhat_sach.Text = "Cập nhật sách";
            this.btn_capnhat_sach.UseVisualStyleBackColor = true;
            this.btn_capnhat_sach.Click += new System.EventHandler(this.btn_capnhat_sach_Click);
            // 
            // btn_capnhat_nhanvien
            // 
            this.btn_capnhat_nhanvien.Location = new System.Drawing.Point(6, 47);
            this.btn_capnhat_nhanvien.Name = "btn_capnhat_nhanvien";
            this.btn_capnhat_nhanvien.Size = new System.Drawing.Size(177, 33);
            this.btn_capnhat_nhanvien.TabIndex = 0;
            this.btn_capnhat_nhanvien.Text = "Cập nhật nhân viên";
            this.btn_capnhat_nhanvien.UseVisualStyleBackColor = true;
            this.btn_capnhat_nhanvien.Click += new System.EventHandler(this.btn_capnhat_nhanvien_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(336, 74);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(288, 42);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Quản lý thư viện";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "frm_main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_nhanvien;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_sach;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_docgia;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_tacgia;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_nxb;
        private System.Windows.Forms.ToolStripMenuItem item_capnhat_linhvuc;
        private System.Windows.Forms.ToolStripMenuItem item_timkiem;
        private System.Windows.Forms.ToolStripMenuItem item_timkiem_sach;
        private System.Windows.Forms.ToolStripMenuItem item_timkiem_docgia;
        private System.Windows.Forms.ToolStripMenuItem item_muontra_sach;
        private System.Windows.Forms.ToolStripMenuItem item_baocao;
        private System.Windows.Forms.ToolStripMenuItem item_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_muontra_sach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_timkiem_sach;
        private System.Windows.Forms.Button btn_timkiem_docgia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_capnhat_linhvuc;
        private System.Windows.Forms.Button btn_capnhat_nxb;
        private System.Windows.Forms.Button btn_capnhat_tacgia;
        private System.Windows.Forms.Button btn_capnhat_docgia;
        private System.Windows.Forms.Button btn_capnhat_sach;
        private System.Windows.Forms.Button btn_capnhat_nhanvien;
        private System.Windows.Forms.Label lbl_title;
    }
}

