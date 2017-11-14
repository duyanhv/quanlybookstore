namespace Bai_Tap_Lon_v1._0_
{
    partial class Form1
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
            this.quanLyGiaoDichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsRecieptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ranOutOfGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsoldGoodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByPriceRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quantityToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyGiaoDichToolStripMenuItem,
            this.quanLyKhoToolStripMenuItem,
            this.productToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLyGiaoDichToolStripMenuItem
            // 
            this.quanLyGiaoDichToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBillToolStripMenuItem,
            this.editReceiptToolStripMenuItem});
            this.quanLyGiaoDichToolStripMenuItem.Name = "quanLyGiaoDichToolStripMenuItem";
            this.quanLyGiaoDichToolStripMenuItem.Size = new System.Drawing.Size(174, 29);
            this.quanLyGiaoDichToolStripMenuItem.Text = "Sales Management";
            // 
            // createBillToolStripMenuItem
            // 
            this.createBillToolStripMenuItem.Name = "createBillToolStripMenuItem";
            this.createBillToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.createBillToolStripMenuItem.Text = "Hoa don xuat";
            // 
            // editReceiptToolStripMenuItem
            // 
            this.editReceiptToolStripMenuItem.Name = "editReceiptToolStripMenuItem";
            this.editReceiptToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.editReceiptToolStripMenuItem.Text = "Hoa don nhap";
            this.editReceiptToolStripMenuItem.Click += new System.EventHandler(this.editReceiptToolStripMenuItem_Click);
            // 
            // quanLyKhoToolStripMenuItem
            // 
            this.quanLyKhoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.editProductInfoToolStripMenuItem,
            this.deleteProductToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.goodsRecieptToolStripMenuItem,
            this.alertToolStripMenuItem1});
            this.quanLyKhoToolStripMenuItem.Name = "quanLyKhoToolStripMenuItem";
            this.quanLyKhoToolStripMenuItem.Size = new System.Drawing.Size(222, 29);
            this.quanLyKhoToolStripMenuItem.Text = "Warehouse management";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.addProductToolStripMenuItem.Text = "Add product";
            // 
            // editProductInfoToolStripMenuItem
            // 
            this.editProductInfoToolStripMenuItem.Name = "editProductInfoToolStripMenuItem";
            this.editProductInfoToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.editProductInfoToolStripMenuItem.Text = "Edit product info";
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.deleteProductToolStripMenuItem.Text = "Delete product";
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.goodsToolStripMenuItem.Text = "Goods Issue";
            // 
            // goodsRecieptToolStripMenuItem
            // 
            this.goodsRecieptToolStripMenuItem.Name = "goodsRecieptToolStripMenuItem";
            this.goodsRecieptToolStripMenuItem.Size = new System.Drawing.Size(230, 30);
            this.goodsRecieptToolStripMenuItem.Text = "Goods Reciept";
            // 
            // alertToolStripMenuItem1
            // 
            this.alertToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ranOutOfGoodsToolStripMenuItem,
            this.unsoldGoodsToolStripMenuItem});
            this.alertToolStripMenuItem1.Name = "alertToolStripMenuItem1";
            this.alertToolStripMenuItem1.Size = new System.Drawing.Size(230, 30);
            this.alertToolStripMenuItem1.Text = "Alert";
            // 
            // ranOutOfGoodsToolStripMenuItem
            // 
            this.ranOutOfGoodsToolStripMenuItem.Name = "ranOutOfGoodsToolStripMenuItem";
            this.ranOutOfGoodsToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.ranOutOfGoodsToolStripMenuItem.Text = "Ran out of Goods";
            // 
            // unsoldGoodsToolStripMenuItem
            // 
            this.unsoldGoodsToolStripMenuItem.Name = "unsoldGoodsToolStripMenuItem";
            this.unsoldGoodsToolStripMenuItem.Size = new System.Drawing.Size(238, 30);
            this.unsoldGoodsToolStripMenuItem.Text = "Unsold Goods";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByNameToolStripMenuItem,
            this.searchByTypeToolStripMenuItem,
            this.searchByAuthorToolStripMenuItem,
            this.searchByPriceRangeToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(141, 29);
            this.productToolStripMenuItem.Text = "Product search";
            // 
            // searchByNameToolStripMenuItem
            // 
            this.searchByNameToolStripMenuItem.Name = "searchByNameToolStripMenuItem";
            this.searchByNameToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.searchByNameToolStripMenuItem.Text = "Search by name";
            // 
            // searchByTypeToolStripMenuItem
            // 
            this.searchByTypeToolStripMenuItem.Name = "searchByTypeToolStripMenuItem";
            this.searchByTypeToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.searchByTypeToolStripMenuItem.Text = "Search by type";
            // 
            // searchByAuthorToolStripMenuItem
            // 
            this.searchByAuthorToolStripMenuItem.Name = "searchByAuthorToolStripMenuItem";
            this.searchByAuthorToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.searchByAuthorToolStripMenuItem.Text = "Search by author";
            // 
            // searchByPriceRangeToolStripMenuItem
            // 
            this.searchByPriceRangeToolStripMenuItem.Name = "searchByPriceRangeToolStripMenuItem";
            this.searchByPriceRangeToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.searchByPriceRangeToolStripMenuItem.Text = "Search by price range";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyReportToolStripMenuItem,
            this.monthlyReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // dailyReportToolStripMenuItem
            // 
            this.dailyReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueToolStripMenuItem,
            this.quantityToolStripMenuItem});
            this.dailyReportToolStripMenuItem.Name = "dailyReportToolStripMenuItem";
            this.dailyReportToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.dailyReportToolStripMenuItem.Text = "Daily report";
            this.dailyReportToolStripMenuItem.Click += new System.EventHandler(this.dailyReportToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.revenueToolStripMenuItem.Text = "Revenue";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // quantityToolStripMenuItem
            // 
            this.quantityToolStripMenuItem.Name = "quantityToolStripMenuItem";
            this.quantityToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.quantityToolStripMenuItem.Text = "Quantity";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.revenueToolStripMenuItem1,
            this.quantityToolStripMenuItem1});
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.monthlyReportToolStripMenuItem.Text = "Periodical Report";
            // 
            // revenueToolStripMenuItem1
            // 
            this.revenueToolStripMenuItem1.Name = "revenueToolStripMenuItem1";
            this.revenueToolStripMenuItem1.Size = new System.Drawing.Size(164, 30);
            this.revenueToolStripMenuItem1.Text = "Revenue";
            // 
            // quantityToolStripMenuItem1
            // 
            this.quantityToolStripMenuItem1.Name = "quantityToolStripMenuItem1";
            this.quantityToolStripMenuItem1.Size = new System.Drawing.Size(164, 30);
            this.quantityToolStripMenuItem1.Text = "Quantity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1165, 754);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bookstore Sale Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyGiaoDichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsRecieptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByAuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchByPriceRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quantityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quantityToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ranOutOfGoodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsoldGoodsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

