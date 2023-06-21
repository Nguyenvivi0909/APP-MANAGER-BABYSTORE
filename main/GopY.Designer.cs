namespace Nhom15_BaybyStore
{
    partial class GopY
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
            this.txtHovaTen = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnGopY = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtHovaTen
            // 
            this.txtHovaTen.BackColor = System.Drawing.Color.White;
            this.txtHovaTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHovaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHovaTen.Location = new System.Drawing.Point(106, 95);
            this.txtHovaTen.Name = "txtHovaTen";
            this.txtHovaTen.Size = new System.Drawing.Size(706, 32);
            this.txtHovaTen.TabIndex = 211;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.panel4.Location = new System.Drawing.Point(106, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(706, 1);
            this.panel4.TabIndex = 212;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 210;
            this.label3.Text = "Họ và Tên:";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(106, 229);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(706, 303);
            this.txtNoiDung.TabIndex = 213;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 210;
            this.label1.Text = "Nội dung góp ý:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(665, 584);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(142, 35);
            this.btnHuy.TabIndex = 214;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGopY
            // 
            this.btnGopY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(61)))), ((int)(((byte)(127)))));
            this.btnGopY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGopY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGopY.ForeColor = System.Drawing.Color.White;
            this.btnGopY.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGopY.IconColor = System.Drawing.Color.Black;
            this.btnGopY.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGopY.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGopY.Location = new System.Drawing.Point(517, 584);
            this.btnGopY.Name = "btnGopY";
            this.btnGopY.Size = new System.Drawing.Size(142, 35);
            this.btnGopY.TabIndex = 215;
            this.btnGopY.Text = "Góp ý";
            this.btnGopY.UseVisualStyleBackColor = false;
            this.btnGopY.Click += new System.EventHandler(this.btnGopY_Click);
            // 
            // GopY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 682);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGopY);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtHovaTen);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "GopY";
            this.Text = "GopY";
            this.Load += new System.EventHandler(this.GopY_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHovaTen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnHuy;
        private FontAwesome.Sharp.IconButton btnGopY;
    }
}