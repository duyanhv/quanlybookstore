namespace Bai_Tap_Lon_v1._0_
{
    partial class HoaDonXuat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbRestaurantManagementDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_RestaurantManagementDataSet1 = new Bai_Tap_Lon_v1._0_.db_RestaurantManagementDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbHoaDon = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMucGiamGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRestaurantManagementDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RestaurantManagementDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.dbRestaurantManagementDataSet1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(431, 305);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(350, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbRestaurantManagementDataSet1BindingSource
            // 
            this.dbRestaurantManagementDataSet1BindingSource.DataSource = this.db_RestaurantManagementDataSet1;
            this.dbRestaurantManagementDataSet1BindingSource.Position = 0;
            // 
            // db_RestaurantManagementDataSet1
            // 
            this.db_RestaurantManagementDataSet1.DataSetName = "db_RestaurantManagementDataSet1";
            this.db_RestaurantManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "So HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma nhan vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ma khach hang";
            // 
            // cbbHoaDon
            // 
            this.cbbHoaDon.FormattingEnabled = true;
            this.cbbHoaDon.Location = new System.Drawing.Point(159, 22);
            this.cbbHoaDon.Name = "cbbHoaDon";
            this.cbbHoaDon.Size = new System.Drawing.Size(188, 28);
            this.cbbHoaDon.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(159, 82);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(188, 26);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(159, 139);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(188, 26);
            this.txtMaKH.TabIndex = 6;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(159, 196);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(188, 26);
            this.txtMaSach.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ma sach";
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(159, 253);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(188, 26);
            this.txtGiaban.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gia ban";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(159, 308);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(188, 26);
            this.txtSoluong.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "So luong";
            // 
            // txtMucGiamGia
            // 
            this.txtMucGiamGia.Location = new System.Drawing.Point(159, 372);
            this.txtMucGiamGia.Name = "txtMucGiamGia";
            this.txtMucGiamGia.Size = new System.Drawing.Size(188, 26);
            this.txtMucGiamGia.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Muc giam gia";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(431, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 95);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(643, 68);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(138, 95);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 95);
            this.button4.TabIndex = 18;
            this.button4.Text = "INFO HOA DON";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // HoaDonXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 575);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMucGiamGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGiaban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.cbbHoaDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HoaDonXuat";
            this.Text = "HoaDonXuat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbRestaurantManagementDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_RestaurantManagementDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dbRestaurantManagementDataSet1BindingSource;
        private db_RestaurantManagementDataSet1 db_RestaurantManagementDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbHoaDon;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMucGiamGia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button4;
    }
}