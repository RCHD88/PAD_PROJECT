namespace PROJECT_PAD_2022.forms
{
    partial class PurchasingForm
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
            this.transaksi = new System.Windows.Forms.TabPage();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.cartDGV = new System.Windows.Forms.DataGridView();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JumlahBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.vendorinactive = new System.Windows.Forms.DataGridView();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.vendorDGV = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseTab = new System.Windows.Forms.TabControl();
            this.transaksi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorinactive)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).BeginInit();
            this.purchaseTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // transaksi
            // 
            this.transaksi.Controls.Add(this.label3);
            this.transaksi.Controls.Add(this.button1);
            this.transaksi.Controls.Add(this.cartDGV);
            this.transaksi.Controls.Add(this.productDGV);
            this.transaksi.Location = new System.Drawing.Point(4, 22);
            this.transaksi.Name = "transaksi";
            this.transaksi.Padding = new System.Windows.Forms.Padding(3);
            this.transaksi.Size = new System.Drawing.Size(982, 537);
            this.transaksi.TabIndex = 4;
            this.transaksi.Text = "tabPage5";
            this.transaksi.UseVisualStyleBackColor = true;
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToDeleteRows = false;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Location = new System.Drawing.Point(25, 24);
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.Size = new System.Drawing.Size(936, 216);
            this.productDGV.TabIndex = 0;
            this.productDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDGV_CellContentClick);
            // 
            // cartDGV
            // 
            this.cartDGV.AllowUserToAddRows = false;
            this.cartDGV.AllowUserToDeleteRows = false;
            this.cartDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nama,
            this.Harga,
            this.JumlahBarang,
            this.SubTotal});
            this.cartDGV.Location = new System.Drawing.Point(25, 287);
            this.cartDGV.Name = "cartDGV";
            this.cartDGV.ReadOnly = true;
            this.cartDGV.Size = new System.Drawing.Size(936, 205);
            this.cartDGV.TabIndex = 1;
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // JumlahBarang
            // 
            this.JumlahBarang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JumlahBarang.HeaderText = "JumlahBarang";
            this.JumlahBarang.Name = "JumlahBarang";
            this.JumlahBarang.ReadOnly = true;
            // 
            // Harga
            // 
            this.Harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harga.HeaderText = "Harga";
            this.Harga.Name = "Harga";
            this.Harga.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nama.HeaderText = "Nama Barang";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cart";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(982, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Detail transaksi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 289);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.vendorinactive);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(982, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inactive vendor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // vendorinactive
            // 
            this.vendorinactive.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorinactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorinactive.Location = new System.Drawing.Point(18, 71);
            this.vendorinactive.Name = "vendorinactive";
            this.vendorinactive.Size = new System.Drawing.Size(704, 289);
            this.vendorinactive.TabIndex = 0;
            this.vendorinactive.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorinactive_CellContentClick);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rating Terjelek",
            "Rating Terbagus",
            "Nama"});
            this.comboBox3.Location = new System.Drawing.Point(68, 36);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sort By :";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.vendorDGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(982, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Active Vendor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // vendorDGV
            // 
            this.vendorDGV.AllowUserToDeleteRows = false;
            this.vendorDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vendorDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDGV.Location = new System.Drawing.Point(18, 71);
            this.vendorDGV.Name = "vendorDGV";
            this.vendorDGV.ReadOnly = true;
            this.vendorDGV.Size = new System.Drawing.Size(704, 289);
            this.vendorDGV.TabIndex = 1;
            this.vendorDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDGV_CellClick);
            this.vendorDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDGV_CellContentClick);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rating Terjelek",
            "Rating Terbagus",
            "Nama"});
            this.comboBox2.Location = new System.Drawing.Point(68, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sort By :";
            // 
            // purchaseTab
            // 
            this.purchaseTab.Controls.Add(this.tabPage1);
            this.purchaseTab.Controls.Add(this.tabPage2);
            this.purchaseTab.Controls.Add(this.tabPage3);
            this.purchaseTab.Controls.Add(this.transaksi);
            this.purchaseTab.Location = new System.Drawing.Point(23, 24);
            this.purchaseTab.Name = "purchaseTab";
            this.purchaseTab.SelectedIndex = 0;
            this.purchaseTab.Size = new System.Drawing.Size(990, 563);
            this.purchaseTab.TabIndex = 0;
            this.purchaseTab.SelectedIndexChanged += new System.EventHandler(this.purchaseTab_SelectedIndexChanged);
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 669);
            this.Controls.Add(this.purchaseTab);
            this.Name = "PurchasingForm";
            this.Text = "PurchasingForm";
            this.Load += new System.EventHandler(this.PurchasingForm_Load);
            this.transaksi.ResumeLayout(false);
            this.transaksi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartDGV)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorinactive)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDGV)).EndInit();
            this.purchaseTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage transaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView cartDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn JumlahBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.DataGridView vendorinactive;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView vendorDGV;
        private System.Windows.Forms.TabControl purchaseTab;
    }
}