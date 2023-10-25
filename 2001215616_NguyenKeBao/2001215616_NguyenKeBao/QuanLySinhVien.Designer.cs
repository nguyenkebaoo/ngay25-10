namespace _2001215616_NguyenKeBao
{
    partial class QuanLySinhVien
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
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.them = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.hienthi = new System.Windows.Forms.Button();
            this.ttsinhvien = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(34, 52);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(24, 13);
            this.id.TabIndex = 0;
            this.id.Text = "ID: ";
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(34, 84);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 1;
            this.name.Text = "Name: ";
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(83, 49);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(153, 20);
            this.text_id.TabIndex = 2;
            // 
            // text_Name
            // 
            this.text_Name.Location = new System.Drawing.Point(81, 81);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(155, 20);
            this.text_Name.TabIndex = 3;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(37, 120);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(75, 23);
            this.them.TabIndex = 4;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(142, 120);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(75, 23);
            this.xoa.TabIndex = 5;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Location = new System.Drawing.Point(37, 149);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(75, 23);
            this.sua.TabIndex = 6;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // hienthi
            // 
            this.hienthi.Location = new System.Drawing.Point(142, 149);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(75, 23);
            this.hienthi.TabIndex = 7;
            this.hienthi.Text = "Hiển thị";
            this.hienthi.UseVisualStyleBackColor = true;
            this.hienthi.Click += new System.EventHandler(this.hienthi_Click);
            // 
            // ttsinhvien
            // 
            this.ttsinhvien.AutoSize = true;
            this.ttsinhvien.Location = new System.Drawing.Point(37, 203);
            this.ttsinhvien.Name = "ttsinhvien";
            this.ttsinhvien.Size = new System.Drawing.Size(0, 13);
            this.ttsinhvien.TabIndex = 8;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(259, 139);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 9;
            this.connect.Text = "Kết nối";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(37, 178);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(240, 150);
            this.dgvSinhVien.TabIndex = 0;
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 353);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.ttsinhvien);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Name = "QuanLySinhVien";
            this.Text = "QuanLySinhVien";
            this.Load += new System.EventHandler(this.QuanLySinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button hienthi;
        private System.Windows.Forms.Label ttsinhvien;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.DataGridView dgvSinhVien;
    }
}