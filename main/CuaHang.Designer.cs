namespace Nhom15_BaybyStore
{
    partial class CuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dgvCuaHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTmKiemCuaHang = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtIDCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDQuanLy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSuaCuaHang = new FontAwesome.Sharp.IconButton();
            this.btnXoaCuaHang = new FontAwesome.Sharp.IconButton();
            this.btnThemCuaHang = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel3.Location = new System.Drawing.Point(1091, 497);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 1);
            this.panel3.TabIndex = 82;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(1091, 461);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(291, 32);
            this.txtDiaChi.TabIndex = 81;
            // 
            // dgvCuaHang
            // 
            this.dgvCuaHang.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuaHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuaHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCuaHang.EnableHeadersVisualStyles = false;
            this.dgvCuaHang.Location = new System.Drawing.Point(21, 153);
            this.dgvCuaHang.Name = "dgvCuaHang";
            this.dgvCuaHang.RowHeadersWidth = 62;
            this.dgvCuaHang.RowTemplate.Height = 28;
            this.dgvCuaHang.Size = new System.Drawing.Size(762, 550);
            this.dgvCuaHang.TabIndex = 88;
            this.dgvCuaHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuaHang_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdCH";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Diachi";
            this.Column2.HeaderText = "Quản lý";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdQL";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 280;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1086, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Địa chỉ:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(122, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 1);
            this.panel4.TabIndex = 76;
            // 
            // txtTmKiemCuaHang
            // 
            this.txtTmKiemCuaHang.BackColor = System.Drawing.Color.White;
            this.txtTmKiemCuaHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTmKiemCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTmKiemCuaHang.Location = new System.Drawing.Point(122, 92);
            this.txtTmKiemCuaHang.Name = "txtTmKiemCuaHang";
            this.txtTmKiemCuaHang.Size = new System.Drawing.Size(408, 32);
            this.txtTmKiemCuaHang.TabIndex = 75;
            this.txtTmKiemCuaHang.TextChanged += new System.EventHandler(this.txtTmKiemCuaHang_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(1094, 370);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 1);
            this.panel2.TabIndex = 74;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(1090, 303);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(98, 20);
            this.lb2.TabIndex = 71;
            this.lb2.Text = "ID Quản lý:";
            // 
            // txtIDCH
            // 
            this.txtIDCH.BackColor = System.Drawing.Color.White;
            this.txtIDCH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCH.Location = new System.Drawing.Point(1091, 224);
            this.txtIDCH.Name = "txtIDCH";
            this.txtIDCH.ReadOnly = true;
            this.txtIDCH.Size = new System.Drawing.Size(291, 32);
            this.txtIDCH.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1086, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "ID:";
            // 
            // txtIDQuanLy
            // 
            this.txtIDQuanLy.BackColor = System.Drawing.Color.White;
            this.txtIDQuanLy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDQuanLy.Location = new System.Drawing.Point(1094, 334);
            this.txtIDQuanLy.Name = "txtIDQuanLy";
            this.txtIDQuanLy.Size = new System.Drawing.Size(291, 32);
            this.txtIDQuanLy.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(674, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 29);
            this.label7.TabIndex = 72;
            this.label7.Text = "Danh sách của hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(1094, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 70;
            // 
            // btnSuaCuaHang
            // 
            this.btnSuaCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnSuaCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCuaHang.ForeColor = System.Drawing.Color.White;
            this.btnSuaCuaHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaCuaHang.IconColor = System.Drawing.Color.Black;
            this.btnSuaCuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCuaHang.Location = new System.Drawing.Point(1229, 605);
            this.btnSuaCuaHang.Name = "btnSuaCuaHang";
            this.btnSuaCuaHang.Size = new System.Drawing.Size(142, 35);
            this.btnSuaCuaHang.TabIndex = 84;
            this.btnSuaCuaHang.Text = "Sửa";
            this.btnSuaCuaHang.UseVisualStyleBackColor = false;
            this.btnSuaCuaHang.Click += new System.EventHandler(this.btnSuaCuaHang_Click);
            // 
            // btnXoaCuaHang
            // 
            this.btnXoaCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnXoaCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCuaHang.ForeColor = System.Drawing.Color.White;
            this.btnXoaCuaHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaCuaHang.IconColor = System.Drawing.Color.Black;
            this.btnXoaCuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCuaHang.Location = new System.Drawing.Point(1081, 605);
            this.btnXoaCuaHang.Name = "btnXoaCuaHang";
            this.btnXoaCuaHang.Size = new System.Drawing.Size(142, 35);
            this.btnXoaCuaHang.TabIndex = 87;
            this.btnXoaCuaHang.Text = "Xóa";
            this.btnXoaCuaHang.UseVisualStyleBackColor = false;
            this.btnXoaCuaHang.Click += new System.EventHandler(this.btnXoaCuaHang_Click);
            // 
            // btnThemCuaHang
            // 
            this.btnThemCuaHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnThemCuaHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCuaHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCuaHang.ForeColor = System.Drawing.Color.White;
            this.btnThemCuaHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemCuaHang.IconColor = System.Drawing.Color.Black;
            this.btnThemCuaHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemCuaHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCuaHang.Location = new System.Drawing.Point(932, 605);
            this.btnThemCuaHang.Name = "btnThemCuaHang";
            this.btnThemCuaHang.Size = new System.Drawing.Size(142, 35);
            this.btnThemCuaHang.TabIndex = 85;
            this.btnThemCuaHang.Text = "Thêm";
            this.btnThemCuaHang.UseVisualStyleBackColor = false;
            this.btnThemCuaHang.Click += new System.EventHandler(this.btnThemCuaHang_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTimKiem.IconColor = System.Drawing.Color.Aquamarine;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.Location = new System.Drawing.Point(562, 92);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(142, 35);
            this.btnTimKiem.TabIndex = 86;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(67, 97);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 35);
            this.iconPictureBox1.TabIndex = 83;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLamMoi.IconColor = System.Drawing.Color.Black;
            this.btnLamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.Location = new System.Drawing.Point(1377, 605);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 35);
            this.btnLamMoi.TabIndex = 85;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // CuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.dgvCuaHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSuaCuaHang);
            this.Controls.Add(this.btnXoaCuaHang);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnThemCuaHang);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.txtTmKiemCuaHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.txtIDCH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDQuanLy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CuaHang";
            this.Text = "CuaHang";
            this.Load += new System.EventHandler(this.CuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvCuaHang;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnSuaCuaHang;
        private FontAwesome.Sharp.IconButton btnXoaCuaHang;
        private FontAwesome.Sharp.IconButton btnThemCuaHang;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtTmKiemCuaHang;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtIDCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDQuanLy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private FontAwesome.Sharp.IconButton btnLamMoi;
    }
}