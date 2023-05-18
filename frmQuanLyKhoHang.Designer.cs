namespace QuanLyShopQuanAo
{
    partial class frmQuanLyKhoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyKhoHang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pbSanPham = new System.Windows.Forms.PictureBox();
            this.btnao = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(470, 349);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 31);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(560, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 32);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(121, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã sản phẩm";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(216, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Tên sản phẩm";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // pbSanPham
            // 
            this.pbSanPham.Image = ((System.Drawing.Image)(resources.GetObject("pbSanPham.Image")));
            this.pbSanPham.InitialImage = null;
            this.pbSanPham.Location = new System.Drawing.Point(596, 72);
            this.pbSanPham.Margin = new System.Windows.Forms.Padding(2);
            this.pbSanPham.Name = "pbSanPham";
            this.pbSanPham.Size = new System.Drawing.Size(234, 349);
            this.pbSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSanPham.TabIndex = 17;
            this.pbSanPham.TabStop = false;
            // 
            // btnao
            // 
            this.btnao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnao.FlatAppearance.BorderSize = 0;
            this.btnao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnao.Image = ((System.Drawing.Image)(resources.GetObject("btnao.Image")));
            this.btnao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnao.Location = new System.Drawing.Point(1, 72);
            this.btnao.Name = "btnao";
            this.btnao.Size = new System.Drawing.Size(114, 65);
            this.btnao.TabIndex = 47;
            this.btnao.Text = "Áo";
            this.btnao.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 65);
            this.button1.TabIndex = 48;
            this.button1.Text = "Quần";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnao);
            this.Controls.Add(this.pbSanPham);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQuanLyKhoHang";
            this.Text = "Quản Lý Kho Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pbSanPham;
        private System.Windows.Forms.Button btnao;
        private System.Windows.Forms.Button button1;
    }
}