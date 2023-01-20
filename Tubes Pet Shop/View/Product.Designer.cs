namespace Tubes_Pet_Shop.View
{
    partial class Product
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
            this.btnExit = new System.Windows.Forms.Button();
            this.GBTombol = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.cbCodeBarang = new System.Windows.Forms.ComboBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.DataProduct = new System.Windows.Forms.DataGridView();
            this.GBTombol.SuspendLayout();
            this.GB2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 139);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // GBTombol
            // 
            this.GBTombol.Controls.Add(this.btnExit);
            this.GBTombol.Controls.Add(this.btnDelete);
            this.GBTombol.Controls.Add(this.btnUpdate);
            this.GBTombol.Controls.Add(this.btnSave);
            this.GBTombol.Controls.Add(this.btnRefresh);
            this.GBTombol.ForeColor = System.Drawing.Color.Black;
            this.GBTombol.Location = new System.Drawing.Point(541, 184);
            this.GBTombol.Name = "GBTombol";
            this.GBTombol.Size = new System.Drawing.Size(250, 173);
            this.GBTombol.TabIndex = 11;
            this.GBTombol.TabStop = false;
            this.GBTombol.Text = "Tombol Action";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(22, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(22, 112);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(200, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GB2
            // 
            this.GB2.Controls.Add(this.groupBox2);
            this.GB2.Controls.Add(this.tbTotal);
            this.GB2.Controls.Add(this.label8);
            this.GB2.Controls.Add(this.tbQty);
            this.GB2.Controls.Add(this.label5);
            this.GB2.Controls.Add(this.label1);
            this.GB2.ForeColor = System.Drawing.Color.White;
            this.GB2.Location = new System.Drawing.Point(8, 180);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(525, 195);
            this.GB2.TabIndex = 10;
            this.GB2.TabStop = false;
            this.GB2.Text = "Form Product";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbHargaBarang);
            this.groupBox2.Controls.Add(this.cbCodeBarang);
            this.groupBox2.Controls.Add(this.tbNamaBarang);
            this.groupBox2.Location = new System.Drawing.Point(69, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 99);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama Barang";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Location = new System.Drawing.Point(246, 68);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(198, 20);
            this.tbHargaBarang.TabIndex = 7;
            // 
            // cbCodeBarang
            // 
            this.cbCodeBarang.FormattingEnabled = true;
            this.cbCodeBarang.Location = new System.Drawing.Point(6, 16);
            this.cbCodeBarang.Name = "cbCodeBarang";
            this.cbCodeBarang.Size = new System.Drawing.Size(193, 21);
            this.cbCodeBarang.TabIndex = 8;
            this.cbCodeBarang.TextChanged += new System.EventHandler(this.cbCodeBarang_TextChanged);
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(6, 65);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(200, 20);
            this.tbNamaBarang.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(89, 155);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(300, 20);
            this.tbTotal.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(89, 125);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(300, 20);
            this.tbQty.TabIndex = 9;
            this.tbQty.TextChanged += new System.EventHandler(this.tbQty_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.DataProduct);
            this.GB1.ForeColor = System.Drawing.Color.Black;
            this.GB1.Location = new System.Drawing.Point(6, 3);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(785, 175);
            this.GB1.TabIndex = 9;
            this.GB1.TabStop = false;
            this.GB1.Text = "Table Product";
            // 
            // DataProduct
            // 
            this.DataProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProduct.Location = new System.Drawing.Point(6, 19);
            this.DataProduct.Name = "DataProduct";
            this.DataProduct.Size = new System.Drawing.Size(773, 139);
            this.DataProduct.TabIndex = 0;
            this.DataProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataProduct_CellClick);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 382);
            this.Controls.Add(this.GBTombol);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.GBTombol.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GB1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox GBTombol;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.DataGridView DataProduct;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.ComboBox cbCodeBarang;
        private System.Windows.Forms.TextBox tbNamaBarang;
    }
}