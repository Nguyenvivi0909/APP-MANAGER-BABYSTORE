namespace Nhom15_BaybyStore
{
    partial class DoanhThu
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
            this.label5 = new System.Windows.Forms.Label();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.cbbCuahang = new System.Windows.Forms.ComboBox();
            this.btnChon = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtdenngay = new System.Windows.Forms.DateTimePicker();
            this.dttungay = new System.Windows.Forms.DateTimePicker();
            this.lbdoanhso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListHD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 31);
            this.label5.TabIndex = 213;
            this.label5.Text = "Cửa hàng:";
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAll.Location = new System.Drawing.Point(148, 158);
            this.checkAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(220, 35);
            this.checkAll.TabIndex = 212;
            this.checkAll.Text = "Toàn hệ thống";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // cbbCuahang
            // 
            this.cbbCuahang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCuahang.FormattingEnabled = true;
            this.cbbCuahang.Location = new System.Drawing.Point(352, 249);
            this.cbbCuahang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCuahang.Name = "cbbCuahang";
            this.cbbCuahang.Size = new System.Drawing.Size(200, 33);
            this.cbbCuahang.TabIndex = 211;
            this.cbbCuahang.SelectedIndexChanged += new System.EventHandler(this.cbbCuahang_SelectedIndexChanged);
            // 
            // btnChon
            // 
            this.btnChon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.ForeColor = System.Drawing.Color.White;
            this.btnChon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChon.IconColor = System.Drawing.Color.Aquamarine;
            this.btnChon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChon.Location = new System.Drawing.Point(1544, 411);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(104, 46);
            this.btnChon.TabIndex = 210;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = false;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(919, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 31);
            this.label4.TabIndex = 209;
            this.label4.Text = "Đến ngày:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 31);
            this.label3.TabIndex = 208;
            this.label3.Text = "Từ ngày:";
            // 
            // dtdenngay
            // 
            this.dtdenngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdenngay.Location = new System.Drawing.Point(1075, 426);
            this.dtdenngay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtdenngay.Name = "dtdenngay";
            this.dtdenngay.Size = new System.Drawing.Size(200, 38);
            this.dtdenngay.TabIndex = 207;
            // 
            // dttungay
            // 
            this.dttungay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dttungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttungay.Location = new System.Drawing.Point(447, 426);
            this.dttungay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dttungay.Name = "dttungay";
            this.dttungay.Size = new System.Drawing.Size(200, 38);
            this.dttungay.TabIndex = 206;
            // 
            // lbdoanhso
            // 
            this.lbdoanhso.AutoSize = true;
            this.lbdoanhso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdoanhso.Location = new System.Drawing.Point(1861, 1058);
            this.lbdoanhso.Name = "lbdoanhso";
            this.lbdoanhso.Size = new System.Drawing.Size(86, 31);
            this.lbdoanhso.TabIndex = 205;
            this.lbdoanhso.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1673, 1058);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 204;
            this.label2.Text = "Doanh số:";
            // 
            // dgvListHD
            // 
            this.dgvListHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListHD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListHD.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListHD.Location = new System.Drawing.Point(71, 481);
            this.dgvListHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvListHD.Name = "dgvListHD";
            this.dgvListHD.RowHeadersWidth = 82;
            this.dgvListHD.RowTemplate.Height = 33;
            this.dgvListHD.Size = new System.Drawing.Size(1728, 450);
            this.dgvListHD.TabIndex = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.label1.Location = new System.Drawing.Point(137, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 61);
            this.label1.TabIndex = 202;
            this.label1.Text = "DOANH SỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2133, 1178);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.cbbCuahang);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtdenngay);
            this.Controls.Add(this.dttungay);
            this.Controls.Add(this.lbdoanhso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListHD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.ComboBox cbbCuahang;
        private FontAwesome.Sharp.IconButton btnChon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtdenngay;
        private System.Windows.Forms.DateTimePicker dttungay;
        private System.Windows.Forms.Label lbdoanhso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListHD;
        private System.Windows.Forms.Label label1;
    }
}