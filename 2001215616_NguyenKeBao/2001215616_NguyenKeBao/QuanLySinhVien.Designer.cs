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
            this.ttsinhvien = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.comboBoxSV = new System.Windows.Forms.ComboBox();
            this.hienthi = new System.Windows.Forms.Button();
            this.hienthitatca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hienthitatca)).BeginInit();
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
            this.connect.Location = new System.Drawing.Point(252, 149);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 9;
            this.connect.Text = "Kết nối";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.Location = new System.Drawing.Point(37, 216);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.Size = new System.Drawing.Size(290, 52);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // comboBoxSV
            // 
            this.comboBoxSV.FormattingEnabled = true;
            this.comboBoxSV.Location = new System.Drawing.Point(37, 189);
            this.comboBoxSV.Name = "comboBoxSV";
            this.comboBoxSV.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSV.TabIndex = 10;
            this.comboBoxSV.SelectedIndexChanged += new System.EventHandler(this.comboBoxSV_SelectedIndexChanged);
            // 
            // hienthi
            // 
            this.hienthi.Location = new System.Drawing.Point(142, 149);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(75, 23);
            this.hienthi.TabIndex = 11;
            this.hienthi.Text = "Hiển Thị";
            this.hienthi.UseVisualStyleBackColor = true;
            this.hienthi.Click += new System.EventHandler(this.hienthi_Click);
            // 
            // hienthitatca
            // 
            this.hienthitatca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hienthitatca.Location = new System.Drawing.Point(333, 52);
            this.hienthitatca.Name = "hienthitatca";
            this.hienthitatca.Size = new System.Drawing.Size(284, 150);
            this.hienthitatca.TabIndex = 12;
            this.hienthitatca.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // QuanLySinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 353);
            this.Controls.Add(this.hienthitatca);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.comboBoxSV);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.ttsinhvien);
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
            ((System.ComponentModel.ISupportInitialize)(this.hienthitatca)).EndInit();
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
        private System.Windows.Forms.Label ttsinhvien;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.ComboBox comboBoxSV;
        private System.Windows.Forms.Button hienthi;
        private System.Windows.Forms.DataGridView hienthitatca;
    }
}