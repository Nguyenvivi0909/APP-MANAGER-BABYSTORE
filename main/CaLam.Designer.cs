namespace Nhom15_BaybyStore
{
    partial class CaLam
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
            this.dgvCaLam = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiGianCaLam = new System.Windows.Forms.TextBox();
            this.txtIDCaLam = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaCaLam = new FontAwesome.Sharp.IconButton();
            this.btnXoaCaLam = new FontAwesome.Sharp.IconButton();
            this.btnThemCaLam = new FontAwesome.Sharp.IconButton();
            this.btnLamMoi = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaLam
            // 
            this.dgvCaLam.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCaLam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCaLam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaLam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCaLam.EnableHeadersVisualStyles = false;
            this.dgvCaLam.Location = new System.Drawing.Point(12, 105);
            this.dgvCaLam.Name = "dgvCaLam";
            this.dgvCaLam.RowHeadersWidth = 62;
            this.dgvCaLam.RowTemplate.Height = 28;
            this.dgvCaLam.Size = new System.Drawing.Size(427, 447);
            this.dgvCaLam.TabIndex = 176;
            this.dgvCaLam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaLam_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 29);
            this.label7.TabIndex = 175;
            this.label7.Text = "Danh sách ca làm";
            // 
            // txtThoiGianCaLam
            // 
            this.txtThoiGianCaLam.BackColor = System.Drawing.Color.White;
            this.txtThoiGianCaLam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThoiGianCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianCaLam.Location = new System.Drawing.Point(566, 225);
            this.txtThoiGianCaLam.Name = "txtThoiGianCaLam";
            this.txtThoiGianCaLam.Size = new System.Drawing.Size(291, 32);
            this.txtThoiGianCaLam.TabIndex = 181;
            // 
            // txtIDCaLam
            // 
            this.txtIDCaLam.BackColor = System.Drawing.Color.White;
            this.txtIDCaLam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCaLam.Location = new System.Drawing.Point(566, 121);
            this.txtIDCaLam.Name = "txtIDCaLam";
            this.txtIDCaLam.ReadOnly = true;
            this.txtIDCaLam.Size = new System.Drawing.Size(291, 32);
            this.txtIDCaLam.TabIndex = 178;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel3.Location = new System.Drawing.Point(566, 157);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 1);
            this.panel3.TabIndex = 179;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(566, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 177;
            this.label8.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(566, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 1);
            this.panel1.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 180;
            this.label1.Text = "Thời gian:";
            // 
            // btnSuaCaLam
            // 
            this.btnSuaCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnSuaCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCaLam.ForeColor = System.Drawing.Color.White;
            this.btnSuaCaLam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSuaCaLam.IconColor = System.Drawing.Color.Black;
            this.btnSuaCaLam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaCaLam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaCaLam.Location = new System.Drawing.Point(641, 336);
            this.btnSuaCaLam.Name = "btnSuaCaLam";
            this.btnSuaCaLam.Size = new System.Drawing.Size(142, 35);
            this.btnSuaCaLam.TabIndex = 183;
            this.btnSuaCaLam.Text = "Sửa";
            this.btnSuaCaLam.UseVisualStyleBackColor = false;
            this.btnSuaCaLam.Click += new System.EventHandler(this.btnSuaCaLam_Click);
            // 
            // btnXoaCaLam
            // 
            this.btnXoaCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnXoaCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCaLam.ForeColor = System.Drawing.Color.White;
            this.btnXoaCaLam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaCaLam.IconColor = System.Drawing.Color.Black;
            this.btnXoaCaLam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaCaLam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCaLam.Location = new System.Drawing.Point(824, 336);
            this.btnXoaCaLam.Name = "btnXoaCaLam";
            this.btnXoaCaLam.Size = new System.Drawing.Size(142, 35);
            this.btnXoaCaLam.TabIndex = 185;
            this.btnXoaCaLam.Text = "Xóa";
            this.btnXoaCaLam.UseVisualStyleBackColor = false;
            this.btnXoaCaLam.Click += new System.EventHandler(this.btnXoaCaLam_Click);
            // 
            // btnThemCaLam
            // 
            this.btnThemCaLam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnThemCaLam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCaLam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCaLam.ForeColor = System.Drawing.Color.White;
            this.btnThemCaLam.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemCaLam.IconColor = System.Drawing.Color.Black;
            this.btnThemCaLam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemCaLam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCaLam.Location = new System.Drawing.Point(457, 336);
            this.btnThemCaLam.Name = "btnThemCaLam";
            this.btnThemCaLam.Size = new System.Drawing.Size(142, 35);
            this.btnThemCaLam.TabIndex = 184;
            this.btnThemCaLam.Text = "Thêm";
            this.btnThemCaLam.UseVisualStyleBackColor = false;
            this.btnThemCaLam.Click += new System.EventHandler(this.btnThemCaLam_Click);
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
            this.btnLamMoi.Location = new System.Drawing.Point(641, 424);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(142, 35);
            this.btnLamMoi.TabIndex = 185;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdCa";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Thoigian";
            this.Column2.HeaderText = "Thời gian";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // CaLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 564);
            this.Controls.Add(this.btnSuaCaLam);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoaCaLam);
            this.Controls.Add(this.btnThemCaLam);
            this.Controls.Add(this.txtThoiGianCaLam);
            this.Controls.Add(this.txtIDCaLam);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCaLam);
            this.Controls.Add(this.label7);
            this.Name = "CaLam";
            this.Text = "CaLam";
            this.Load += new System.EventHandler(this.CaLam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaLam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCaLam;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton btnSuaCaLam;
        private FontAwesome.Sharp.IconButton btnXoaCaLam;
        private FontAwesome.Sharp.IconButton btnThemCaLam;
        private System.Windows.Forms.TextBox txtThoiGianCaLam;
        private System.Windows.Forms.TextBox txtIDCaLam;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}