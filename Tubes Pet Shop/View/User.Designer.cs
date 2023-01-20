namespace Tubes_Pet_Shop.View
{
    partial class User
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
            this.GBTombol = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.GB2 = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GB1 = new System.Windows.Forms.GroupBox();
            this.DataUser = new System.Windows.Forms.DataGridView();
            this.GBTombol.SuspendLayout();
            this.GB2.SuspendLayout();
            this.GB1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // GBTombol
            // 
            this.GBTombol.Controls.Add(this.btnExit);
            this.GBTombol.Controls.Add(this.btnDelete);
            this.GBTombol.Controls.Add(this.btnUpdate);
            this.GBTombol.Controls.Add(this.btnSave);
            this.GBTombol.Controls.Add(this.btnRefresh);
            this.GBTombol.ForeColor = System.Drawing.Color.Black;
            this.GBTombol.Location = new System.Drawing.Point(541, 186);
            this.GBTombol.Name = "GBTombol";
            this.GBTombol.Size = new System.Drawing.Size(250, 173);
            this.GBTombol.TabIndex = 6;
            this.GBTombol.TabStop = false;
            this.GBTombol.Text = "Tombol Action";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(22, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSimpan_Click);
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
            this.GB2.Controls.Add(this.tbPhone);
            this.GB2.Controls.Add(this.cbRole);
            this.GB2.Controls.Add(this.tbAddress);
            this.GB2.Controls.Add(this.tbName);
            this.GB2.Controls.Add(this.label4);
            this.GB2.Controls.Add(this.label3);
            this.GB2.Controls.Add(this.label2);
            this.GB2.Controls.Add(this.label1);
            this.GB2.ForeColor = System.Drawing.Color.White;
            this.GB2.Location = new System.Drawing.Point(8, 186);
            this.GB2.Name = "GB2";
            this.GB2.Size = new System.Drawing.Size(525, 154);
            this.GB2.TabIndex = 5;
            this.GB2.TabStop = false;
            this.GB2.Text = "Form User";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(89, 84);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(300, 20);
            this.tbPhone.TabIndex = 12;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Kasir",
            "Admin",
            "Pelanggan"});
            this.cbRole.Location = new System.Drawing.Point(89, 113);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(300, 21);
            this.cbRole.TabIndex = 11;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(89, 54);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(300, 20);
            this.tbAddress.TabIndex = 7;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(300, 20);
            this.tbName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // GB1
            // 
            this.GB1.Controls.Add(this.DataUser);
            this.GB1.ForeColor = System.Drawing.Color.Black;
            this.GB1.Location = new System.Drawing.Point(6, 5);
            this.GB1.Name = "GB1";
            this.GB1.Size = new System.Drawing.Size(785, 175);
            this.GB1.TabIndex = 4;
            this.GB1.TabStop = false;
            this.GB1.Text = "Table User";
            // 
            // DataUser
            // 
            this.DataUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataUser.Location = new System.Drawing.Point(6, 19);
            this.DataUser.Name = "DataUser";
            this.DataUser.Size = new System.Drawing.Size(773, 139);
            this.DataUser.TabIndex = 0;
            this.DataUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataUser_CellClick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.GBTombol);
            this.Controls.Add(this.GB2);
            this.Controls.Add(this.GB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.GBTombol.ResumeLayout(false);
            this.GB2.ResumeLayout(false);
            this.GB2.PerformLayout();
            this.GB1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox GBTombol;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox GB2;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GB1;
        private System.Windows.Forms.DataGridView DataUser;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Button btnExit;
    }
}