namespace Assignment6
{
    partial class CarCompany
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComapnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteComapnyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddNewCar = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbCompanyID = new System.Windows.Forms.ComboBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.dateYear = new System.Windows.Forms.DateTimePicker();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarId = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbAddNewCar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.companyToolStripMenuItem,
            this.carsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComapnyToolStripMenuItem,
            this.deleteComapnyToolStripMenuItem,
            this.updateCompanyToolStripMenuItem,
            this.showCompanyToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // addComapnyToolStripMenuItem
            // 
            this.addComapnyToolStripMenuItem.Name = "addComapnyToolStripMenuItem";
            this.addComapnyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.addComapnyToolStripMenuItem.Text = "Add Comapny";
            // 
            // deleteComapnyToolStripMenuItem
            // 
            this.deleteComapnyToolStripMenuItem.Name = "deleteComapnyToolStripMenuItem";
            this.deleteComapnyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteComapnyToolStripMenuItem.Text = "Delete Comapny";
            // 
            // updateCompanyToolStripMenuItem
            // 
            this.updateCompanyToolStripMenuItem.Name = "updateCompanyToolStripMenuItem";
            this.updateCompanyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.updateCompanyToolStripMenuItem.Text = "Update Company";
            // 
            // showCompanyToolStripMenuItem
            // 
            this.showCompanyToolStripMenuItem.Name = "showCompanyToolStripMenuItem";
            this.showCompanyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showCompanyToolStripMenuItem.Text = "Show Company";
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.editCarToolStripMenuItem,
            this.deleteCarToolStripMenuItem,
            this.findCarToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // editCarToolStripMenuItem
            // 
            this.editCarToolStripMenuItem.Name = "editCarToolStripMenuItem";
            this.editCarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.editCarToolStripMenuItem.Text = "Edit Car";
            // 
            // deleteCarToolStripMenuItem
            // 
            this.deleteCarToolStripMenuItem.Name = "deleteCarToolStripMenuItem";
            this.deleteCarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.deleteCarToolStripMenuItem.Text = "Delete Car";
            // 
            // findCarToolStripMenuItem
            // 
            this.findCarToolStripMenuItem.Name = "findCarToolStripMenuItem";
            this.findCarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.findCarToolStripMenuItem.Text = "Find Car";
            // 
            // gbAddNewCar
            // 
            this.gbAddNewCar.Controls.Add(this.lblMessage);
            this.gbAddNewCar.Controls.Add(this.btnClose);
            this.gbAddNewCar.Controls.Add(this.btnSubmit);
            this.gbAddNewCar.Controls.Add(this.cbCompanyID);
            this.gbAddNewCar.Controls.Add(this.chkAvailable);
            this.gbAddNewCar.Controls.Add(this.txtPrice);
            this.gbAddNewCar.Controls.Add(this.txtMileage);
            this.gbAddNewCar.Controls.Add(this.dateYear);
            this.gbAddNewCar.Controls.Add(this.TxtModel);
            this.gbAddNewCar.Controls.Add(this.txtBrand);
            this.gbAddNewCar.Controls.Add(this.txtCarId);
            this.gbAddNewCar.Controls.Add(this.label7);
            this.gbAddNewCar.Controls.Add(this.label6);
            this.gbAddNewCar.Controls.Add(this.label5);
            this.gbAddNewCar.Controls.Add(this.label4);
            this.gbAddNewCar.Controls.Add(this.label3);
            this.gbAddNewCar.Controls.Add(this.label2);
            this.gbAddNewCar.Controls.Add(this.label1);
            this.gbAddNewCar.Controls.Add(this.lblCarId);
            this.gbAddNewCar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddNewCar.Location = new System.Drawing.Point(0, 24);
            this.gbAddNewCar.Name = "gbAddNewCar";
            this.gbAddNewCar.Size = new System.Drawing.Size(800, 426);
            this.gbAddNewCar.TabIndex = 1;
            this.gbAddNewCar.TabStop = false;
            this.gbAddNewCar.Text = "Add New Car";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(405, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 38);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(183, 308);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbCompanyID
            // 
            this.cbCompanyID.FormattingEnabled = true;
            this.cbCompanyID.Location = new System.Drawing.Point(504, 242);
            this.cbCompanyID.Name = "cbCompanyID";
            this.cbCompanyID.Size = new System.Drawing.Size(121, 21);
            this.cbCompanyID.TabIndex = 15;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Checked = true;
            this.chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAvailable.Location = new System.Drawing.Point(497, 178);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 14;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(497, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 26);
            this.txtPrice.TabIndex = 13;
            // 
            // txtMileage
            // 
            this.txtMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.Location = new System.Drawing.Point(497, 49);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(199, 26);
            this.txtMileage.TabIndex = 12;
            // 
            // dateYear
            // 
            this.dateYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateYear.Location = new System.Drawing.Point(183, 239);
            this.dateYear.Name = "dateYear";
            this.dateYear.Size = new System.Drawing.Size(134, 20);
            this.dateYear.TabIndex = 11;
            // 
            // TxtModel
            // 
            this.TxtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModel.Location = new System.Drawing.Point(118, 173);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(199, 26);
            this.TxtModel.TabIndex = 10;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(118, 97);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(199, 26);
            this.txtBrand.TabIndex = 9;
            // 
            // txtCarId
            // 
            this.txtCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarId.Location = new System.Drawing.Point(118, 48);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(199, 26);
            this.txtCarId.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Company ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Manufacturing Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brand";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(28, 49);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(55, 20);
            this.lblCarId.TabIndex = 0;
            this.lblCarId.Text = "Car ID";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(180, 374);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 18;
            // 
            // CarCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAddNewCar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarCompany";
            this.Text = "CarCompany";
            this.Load += new System.EventHandler(this.CarCompany_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbAddNewCar.ResumeLayout(false);
            this.gbAddNewCar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComapnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteComapnyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findCarToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAddNewCar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbCompanyID;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.DateTimePicker dateYear;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label lblMessage;
    }
}