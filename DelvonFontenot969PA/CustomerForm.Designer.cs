﻿namespace DelvonFontenot969PA
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCustomerInfo = new System.Windows.Forms.GroupBox();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.tbCustCountry = new System.Windows.Forms.TextBox();
            this.tbCustCity = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.cbCustZip = new System.Windows.Forms.ComboBox();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.lblLastupdate = new System.Windows.Forms.Label();
            this.tbCustPhone = new System.Windows.Forms.TextBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tbCustName = new System.Windows.Forms.TextBox();
            this.tbCustAdd = new System.Windows.Forms.TextBox();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbCustomer.Controls.Add(this.btnClose);
            this.gbCustomer.Controls.Add(this.pictureBox1);
            this.gbCustomer.Controls.Add(this.gbCustomerInfo);
            this.gbCustomer.Controls.Add(this.btnSaveCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(12, 23);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(543, 292);
            this.gbCustomer.TabIndex = 12;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(464, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // gbCustomerInfo
            // 
            this.gbCustomerInfo.Controls.Add(this.btnNewAddress);
            this.gbCustomerInfo.Controls.Add(this.btnEditAddress);
            this.gbCustomerInfo.Controls.Add(this.tbCustCountry);
            this.gbCustomerInfo.Controls.Add(this.tbCustCity);
            this.gbCustomerInfo.Controls.Add(this.lblCustID);
            this.gbCustomerInfo.Controls.Add(this.cbCustZip);
            this.gbCustomerInfo.Controls.Add(this.lblLastUpdated);
            this.gbCustomerInfo.Controls.Add(this.lblLastupdate);
            this.gbCustomerInfo.Controls.Add(this.tbCustPhone);
            this.gbCustomerInfo.Controls.Add(this.lb6);
            this.gbCustomerInfo.Controls.Add(this.lbl5);
            this.gbCustomerInfo.Controls.Add(this.label1);
            this.gbCustomerInfo.Controls.Add(this.lbl7);
            this.gbCustomerInfo.Controls.Add(this.lbl1);
            this.gbCustomerInfo.Controls.Add(this.lbl2);
            this.gbCustomerInfo.Controls.Add(this.lbl3);
            this.gbCustomerInfo.Controls.Add(this.tbCustName);
            this.gbCustomerInfo.Controls.Add(this.tbCustAdd);
            this.gbCustomerInfo.Location = new System.Drawing.Point(6, 19);
            this.gbCustomerInfo.Name = "gbCustomerInfo";
            this.gbCustomerInfo.Size = new System.Drawing.Size(271, 267);
            this.gbCustomerInfo.TabIndex = 29;
            this.gbCustomerInfo.TabStop = false;
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Location = new System.Drawing.Point(186, 238);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(79, 23);
            this.btnNewAddress.TabIndex = 39;
            this.btnNewAddress.Text = "New Address";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Location = new System.Drawing.Point(95, 238);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(85, 23);
            this.btnEditAddress.TabIndex = 38;
            this.btnEditAddress.Text = "Edit Address";
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // tbCustCountry
            // 
            this.tbCustCountry.Enabled = false;
            this.tbCustCountry.Location = new System.Drawing.Point(82, 174);
            this.tbCustCountry.Name = "tbCustCountry";
            this.tbCustCountry.Size = new System.Drawing.Size(126, 20);
            this.tbCustCountry.TabIndex = 37;
            // 
            // tbCustCity
            // 
            this.tbCustCity.Enabled = false;
            this.tbCustCity.Location = new System.Drawing.Point(81, 121);
            this.tbCustCity.Name = "tbCustCity";
            this.tbCustCity.Size = new System.Drawing.Size(126, 20);
            this.tbCustCity.TabIndex = 36;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.Location = new System.Drawing.Point(77, 22);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(98, 15);
            this.lblCustID.TabIndex = 35;
            this.lblCustID.Text = "Auto Generated";
            // 
            // cbCustZip
            // 
            this.cbCustZip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustZip.Enabled = false;
            this.cbCustZip.FormattingEnabled = true;
            this.cbCustZip.ItemHeight = 13;
            this.cbCustZip.Location = new System.Drawing.Point(81, 147);
            this.cbCustZip.Name = "cbCustZip";
            this.cbCustZip.Size = new System.Drawing.Size(127, 21);
            this.cbCustZip.TabIndex = 33;
            this.cbCustZip.SelectedIndexChanged += new System.EventHandler(this.cbCustZip_SelectedIndexChanged);
            this.cbCustZip.TextChanged += new System.EventHandler(this.cbCustZip_TextChanged);
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastUpdated.Location = new System.Drawing.Point(86, 210);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(31, 13);
            this.lblLastUpdated.TabIndex = 31;
            this.lblLastUpdated.Text = "Last";
            // 
            // lblLastupdate
            // 
            this.lblLastupdate.AutoSize = true;
            this.lblLastupdate.Location = new System.Drawing.Point(6, 210);
            this.lblLastupdate.Name = "lblLastupdate";
            this.lblLastupdate.Size = new System.Drawing.Size(74, 13);
            this.lblLastupdate.TabIndex = 30;
            this.lblLastupdate.Text = "Last Updated:";
            // 
            // tbCustPhone
            // 
            this.tbCustPhone.Enabled = false;
            this.tbCustPhone.Location = new System.Drawing.Point(80, 70);
            this.tbCustPhone.Name = "tbCustPhone";
            this.tbCustPhone.Size = new System.Drawing.Size(127, 20);
            this.tbCustPhone.TabIndex = 2;
            this.tbCustPhone.TextChanged += new System.EventHandler(this.tbCustPhone_TextChanged);
            this.tbCustPhone.Leave += new System.EventHandler(this.tbCustPhone_Leave);
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Location = new System.Drawing.Point(22, 155);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(50, 13);
            this.lb6.TabIndex = 7;
            this.lb6.Text = "Zip Code";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(48, 129);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(24, 13);
            this.lbl5.TabIndex = 6;
            this.lbl5.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Country";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(23, 75);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(48, 13);
            this.lbl7.TabIndex = 8;
            this.lbl7.Text = "Phone #";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 21;
            this.lbl1.Text = "Customer ID";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(36, 52);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(35, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Name";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(26, 103);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(45, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Address";
            // 
            // tbCustName
            // 
            this.tbCustName.BackColor = System.Drawing.SystemColors.Window;
            this.tbCustName.Location = new System.Drawing.Point(80, 45);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Size = new System.Drawing.Size(128, 20);
            this.tbCustName.TabIndex = 1;
            this.tbCustName.TextChanged += new System.EventHandler(this.tbCustName_TextChanged);
            this.tbCustName.Leave += new System.EventHandler(this.tbCustName_Leave);
            // 
            // tbCustAdd
            // 
            this.tbCustAdd.Enabled = false;
            this.tbCustAdd.Location = new System.Drawing.Point(80, 95);
            this.tbCustAdd.Name = "tbCustAdd";
            this.tbCustAdd.Size = new System.Drawing.Size(128, 20);
            this.tbCustAdd.TabIndex = 3;
            this.tbCustAdd.TextChanged += new System.EventHandler(this.tbCustAdd_TextChanged);
            this.tbCustAdd.Leave += new System.EventHandler(this.tbCustAdd_Leave);
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.Location = new System.Drawing.Point(378, 263);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCustomer.TabIndex = 5;
            this.btnSaveCustomer.Text = "Save";
            this.btnSaveCustomer.UseVisualStyleBackColor = true;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(567, 344);
            this.Controls.Add(this.gbCustomer);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.gbCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbCustomerInfo.ResumeLayout(false);
            this.gbCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox gbCustomerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.GroupBox gbCustomer;
        internal System.Windows.Forms.TextBox tbCustName;
        internal System.Windows.Forms.TextBox tbCustPhone;
        internal System.Windows.Forms.TextBox tbCustAdd;
        internal System.Windows.Forms.Label lblLastUpdated;
        internal System.Windows.Forms.Label lblCustID;
        internal System.Windows.Forms.ComboBox cbCustZip;
        internal System.Windows.Forms.Label lblLastupdate;
        internal System.Windows.Forms.TextBox tbCustCountry;
        internal System.Windows.Forms.TextBox tbCustCity;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button btnEditAddress;
        internal System.Windows.Forms.Button btnNewAddress;
    }
}