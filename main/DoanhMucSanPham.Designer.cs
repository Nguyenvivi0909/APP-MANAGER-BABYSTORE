namespace Nhom15_BaybyStore
{
    partial class DoanhMucSanPham
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTimKiemDoanhMuc = new System.Windows.Forms.TextBox();
            this.dgvDoanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenDoanhMuc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDDoanhMuc = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSuaDoanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnXoaDoanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnThemDoanhMuc = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(408, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 1);
            this.panel4.TabIndex = 163;
            // 
            // txtTimKiemDoanhMuc
            // 
            this.txtTimKiemDoanhMuc.BackColor = System.Drawing.Color.White;
            this.txtTimKiemDoanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemDoanhMuc.Location = new System.Drawing.Point(408, 88);
            this.txtTimKiemDoanhMuc.Name = "txtTimKiemDoanhMuc";
            this.txtTimKiemDoanhMuc.Size = new System.Drawing.Size(386, 32);
            this.txtTimKiemDoanhMuc.TabIndex = 162;
            this.txtTimKiemDoanhMuc.TextChanged += new System.EventHandler(this.txtTimKiemDoanhMuc_TextChanged);
            // 
            // dgvDoanhMuc
            // 
            this.dgvDoanhMuc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvDoanhMuc.EnableHeadersVisualStyles = false;
            this.dgvDoanhMuc.Location = new System.Drawing.Point(353, 142);
            this.dgvDoanhMuc.Name = "dgvDoanhMuc";
            this.dgvDoanhMuc.RowHeadersWidth = 62;
            this.dgvDoanhMuc.RowTemplate.Height = 28;
            this.dgvDoanhMuc.Size = new System.Drawing.Size(615, 412);
            this.dgvDoanhMuc.TabIndex = 161;
            this.dgvDoanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoanhMuc_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdDM";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDM";
            this.Column2.HeaderText = "Tên doanh mục";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(509, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 29);
            this.label7.TabIndex = 160;
            this.label7.Text = "Doanh mục sản phẩm";
            // 
            // txtTenDoanhMuc
            // 
            this.txtTenDoanhMuc.BackColor = System.Drawing.Color.White;
            this.txtTenDoanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoanhMuc.Location = new System.Drawing.Point(14, 230);
            this.txtTenDoanhMuc.Name = "txtTenDoanhMuc";
            this.txtTenDoanhMuc.Size = new System.Drawing.Size(291, 32);
            this.txtTenDoanhMuc.TabIndex = 152;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(14, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 151;
            this.label1.Text = "Tên doanh mục";
            // 
            // txtIDDoanhMuc
            // 
            this.txtIDDoanhMuc.BackColor = System.Drawing.Color.White;
            this.txtIDDoanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDoanhMuc.Location = new System.Drawing.Point(14, 126);
            this.txtIDDoanhMuc.Name = "txtIDDoanhMuc";
            this.txtIDDoanhMuc.ReadOnly = true;
            this.txtIDDoanhMuc.Size = new System.Drawing.Size(291, 32);
            this.txtIDDoanhMuc.TabIndex = 149;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel3.Location = new System.Drawing.Point(14, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 1);
            this.panel3.TabIndex = 150;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 148;
            this.label8.Text = "ID:";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(353, 92);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 35);
            this.iconPictureBox1.TabIndex = 164;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnSuaDoanhMuc
            // 
            this.btnSuaDoanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnSuaDoanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDoanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnSuaDoanhMuc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaDoanhMuc.IconColor = System.Drawing.Color.Black;
            this.btnSuaDoanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaDoanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaDoanhMuc.Location = new System.Drawing.Point(80, 431);
            this.btnSuaDoanhMuc.Name = "btnSuaDoanhMuc";
            this.btnSuaDoanhMuc.Size = new System.Drawing.Size(142, 35);
            this.btnSuaDoanhMuc.TabIndex = 157;
            this.btnSuaDoanhMuc.Text = "Sửa";
            this.btnSuaDoanhMuc.UseVisualStyleBackColor = false;
            this.btnSuaDoanhMuc.Click += new System.EventHandler(this.btnSuaDoanhMuc_Click);
            // 
            // btnXoaDoanhMuc
            // 
            this.btnXoaDoanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnXoaDoanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDoanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnXoaDoanhMuc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaDoanhMuc.IconColor = System.Drawing.Color.Black;
            this.btnXoaDoanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaDoanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDoanhMuc.Location = new System.Drawing.Point(76, 500);
            this.btnXoaDoanhMuc.Name = "btnXoaDoanhMuc";
            this.btnXoaDoanhMuc.Size = new System.Drawing.Size(142, 35);
            this.btnXoaDoanhMuc.TabIndex = 159;
            this.btnXoaDoanhMuc.Text = "Xóa";
            this.btnXoaDoanhMuc.UseVisualStyleBackColor = false;
            this.btnXoaDoanhMuc.Click += new System.EventHandler(this.btnXoaDoanhMuc_Click);
            // 
            // btnThemDoanhMuc
            // 
            this.btnThemDoanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnThemDoanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDoanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDoanhMuc.ForeColor = System.Drawing.Color.White;
            this.btnThemDoanhMuc.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemDoanhMuc.IconColor = System.Drawing.Color.Black;
            this.btnThemDoanhMuc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemDoanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDoanhMuc.Location = new System.Drawing.Point(76, 360);
            this.btnThemDoanhMuc.Name = "btnThemDoanhMuc";
            this.btnThemDoanhMuc.Size = new System.Drawing.Size(142, 35);
            this.btnThemDoanhMuc.TabIndex = 158;
            this.btnThemDoanhMuc.Text = "Thêm";
            this.btnThemDoanhMuc.UseVisualStyleBackColor = false;
            this.btnThemDoanhMuc.Click += new System.EventHandler(this.btnThemDoanhMuc_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(76, 295);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 35);
            this.btnLamMoi.TabIndex = 166;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // DoanhMucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtTimKiemDoanhMuc);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.dgvDoanhMuc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSuaDoanhMuc);
            this.Controls.Add(this.btnXoaDoanhMuc);
            this.Controls.Add(this.btnThemDoanhMuc);
            this.Controls.Add(this.txtTenDoanhMuc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDDoanhMuc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Name = "DoanhMucSanPham";
            this.Text = "DoanhMucSanPham";
            this.Load += new System.EventHandler(this.DoanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTimKiemDoanhMuc;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dgvDoanhMuc;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnSuaDoanhMuc;
        private FontAwesome.Sharp.IconButton btnXoaDoanhMuc;
        private FontAwesome.Sharp.IconButton btnThemDoanhMuc;
        private System.Windows.Forms.TextBox txtTenDoanhMuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDDoanhMuc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}