namespace Baikiemtra
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDanhMucSanPham = new System.Windows.Forms.Button();
            this.btnDanhMucKhachHang = new System.Windows.Forms.Button();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnDanhMucSanPham
            // 
            this.btnDanhMucSanPham.Location = new System.Drawing.Point(95, 179);
            this.btnDanhMucSanPham.Name = "btnDanhMucSanPham";
            this.btnDanhMucSanPham.Size = new System.Drawing.Size(172, 95);
            this.btnDanhMucSanPham.TabIndex = 2;
            this.btnDanhMucSanPham.Text = "Danh mục sản phẩm";
            this.btnDanhMucSanPham.UseVisualStyleBackColor = true;
            // 
            // btnDanhMucKhachHang
            // 
            this.btnDanhMucKhachHang.Location = new System.Drawing.Point(326, 179);
            this.btnDanhMucKhachHang.Name = "btnDanhMucKhachHang";
            this.btnDanhMucKhachHang.Size = new System.Drawing.Size(156, 95);
            this.btnDanhMucKhachHang.TabIndex = 3;
            this.btnDanhMucKhachHang.Text = "Danh mục khách hàng";
            this.btnDanhMucKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnDonHang
            // 
            this.btnDonHang.Location = new System.Drawing.Point(556, 179);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(149, 95);
            this.btnDonHang.TabIndex = 4;
            this.btnDonHang.Text = "Đơn hàng";
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDonHang);
            this.Controls.Add(this.btnDanhMucKhachHang);
            this.Controls.Add(this.btnDanhMucSanPham);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDanhMucSanPham;
        private System.Windows.Forms.Button btnDanhMucKhachHang;
        private System.Windows.Forms.Button btnDonHang;
    }
}