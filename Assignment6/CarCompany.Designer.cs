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
            this.findCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAddNewCar = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pTopup = new System.Windows.Forms.Panel();
            this.txtIdToChange = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnIdToChange = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
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
            this.homeContainer = new System.Windows.Forms.SplitContainer();
            this.listCompanies = new System.Windows.Forms.ListView();
            this.listCars = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.pAddNewCar.SuspendLayout();
            this.pTopup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeContainer)).BeginInit();
            this.homeContainer.Panel1.SuspendLayout();
            this.homeContainer.Panel2.SuspendLayout();
            this.homeContainer.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1237, 24);
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
            this.findCarToolStripMenuItem});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // addCarToolStripMenuItem
            // 
            this.addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            this.addCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCarToolStripMenuItem.Text = "Add Car";
            this.addCarToolStripMenuItem.Click += new System.EventHandler(this.addCarToolStripMenuItem_Click);
            // 
            // editCarToolStripMenuItem
            // 
            this.editCarToolStripMenuItem.Name = "editCarToolStripMenuItem";
            this.editCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCarToolStripMenuItem.Text = "Edit Car";
            this.editCarToolStripMenuItem.Click += new System.EventHandler(this.editCarToolStripMenuItem_Click);
            // 
            // findCarToolStripMenuItem
            // 
            this.findCarToolStripMenuItem.Name = "findCarToolStripMenuItem";
            this.findCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findCarToolStripMenuItem.Text = "Show All Cars";
            this.findCarToolStripMenuItem.Click += new System.EventHandler(this.findCarToolStripMenuItem_Click);
            // 
            // pAddNewCar
            // 
            this.pAddNewCar.Controls.Add(this.btnDelete);
            this.pAddNewCar.Controls.Add(this.pTopup);
            this.pAddNewCar.Controls.Add(this.lblMessage);
            this.pAddNewCar.Controls.Add(this.btnClose);
            this.pAddNewCar.Controls.Add(this.btnSubmit);
            this.pAddNewCar.Controls.Add(this.cbCompanyID);
            this.pAddNewCar.Controls.Add(this.chkAvailable);
            this.pAddNewCar.Controls.Add(this.txtPrice);
            this.pAddNewCar.Controls.Add(this.txtMileage);
            this.pAddNewCar.Controls.Add(this.dateYear);
            this.pAddNewCar.Controls.Add(this.TxtModel);
            this.pAddNewCar.Controls.Add(this.txtBrand);
            this.pAddNewCar.Controls.Add(this.txtCarId);
            this.pAddNewCar.Controls.Add(this.label7);
            this.pAddNewCar.Controls.Add(this.label6);
            this.pAddNewCar.Controls.Add(this.label5);
            this.pAddNewCar.Controls.Add(this.label4);
            this.pAddNewCar.Controls.Add(this.label3);
            this.pAddNewCar.Controls.Add(this.label2);
            this.pAddNewCar.Controls.Add(this.label1);
            this.pAddNewCar.Controls.Add(this.lblCarId);
            this.pAddNewCar.Location = new System.Drawing.Point(262, 55);
            this.pAddNewCar.Name = "pAddNewCar";
            this.pAddNewCar.Size = new System.Drawing.Size(800, 426);
            this.pAddNewCar.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(343, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pTopup
            // 
            this.pTopup.Controls.Add(this.txtIdToChange);
            this.pTopup.Controls.Add(this.lblEdit);
            this.pTopup.Controls.Add(this.btnIdToChange);
            this.pTopup.Location = new System.Drawing.Point(50, 126);
            this.pTopup.Name = "pTopup";
            this.pTopup.Size = new System.Drawing.Size(290, 131);
            this.pTopup.TabIndex = 38;
            // 
            // txtIdToChange
            // 
            this.txtIdToChange.Location = new System.Drawing.Point(93, 52);
            this.txtIdToChange.Name = "txtIdToChange";
            this.txtIdToChange.Size = new System.Drawing.Size(100, 20);
            this.txtIdToChange.TabIndex = 2;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(90, 10);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(85, 17);
            this.lblEdit.TabIndex = 1;
            this.lblEdit.Text = "Enter Car ID";
            // 
            // btnIdToChange
            // 
            this.btnIdToChange.Location = new System.Drawing.Point(100, 94);
            this.btnIdToChange.Name = "btnIdToChange";
            this.btnIdToChange.Size = new System.Drawing.Size(75, 23);
            this.btnIdToChange.TabIndex = 0;
            this.btnIdToChange.Text = "Submit";
            this.btnIdToChange.UseVisualStyleBackColor = true;
            this.btnIdToChange.Click += new System.EventHandler(this.btnIdToChange_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(218, 368);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 37;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(505, 302);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 38);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(185, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // cbCompanyID
            // 
            this.cbCompanyID.FormattingEnabled = true;
            this.cbCompanyID.Location = new System.Drawing.Point(542, 236);
            this.cbCompanyID.Name = "cbCompanyID";
            this.cbCompanyID.Size = new System.Drawing.Size(121, 21);
            this.cbCompanyID.TabIndex = 34;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Checked = true;
            this.chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAvailable.Location = new System.Drawing.Point(535, 172);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 33;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(535, 97);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 26);
            this.txtPrice.TabIndex = 32;
            // 
            // txtMileage
            // 
            this.txtMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.Location = new System.Drawing.Point(535, 43);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(199, 26);
            this.txtMileage.TabIndex = 31;
            // 
            // dateYear
            // 
            this.dateYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateYear.Location = new System.Drawing.Point(221, 233);
            this.dateYear.Name = "dateYear";
            this.dateYear.Size = new System.Drawing.Size(134, 20);
            this.dateYear.TabIndex = 30;
            // 
            // TxtModel
            // 
            this.TxtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModel.Location = new System.Drawing.Point(156, 167);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(199, 26);
            this.TxtModel.TabIndex = 29;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(156, 91);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(199, 26);
            this.txtBrand.TabIndex = 28;
            // 
            // txtCarId
            // 
            this.txtCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarId.Location = new System.Drawing.Point(156, 42);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(199, 26);
            this.txtCarId.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Company ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Available";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manufacturing Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Brand";
            // 
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(66, 43);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(55, 20);
            this.lblCarId.TabIndex = 19;
            this.lblCarId.Text = "Car ID";
            // 
            // homeContainer
            // 
            this.homeContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.homeContainer.Location = new System.Drawing.Point(0, 24);
            this.homeContainer.Name = "homeContainer";
            // 
            // homeContainer.Panel1
            // 
            this.homeContainer.Panel1.Controls.Add(this.pAddNewCar);
            this.homeContainer.Panel1.Controls.Add(this.listCompanies);
            // 
            // homeContainer.Panel2
            // 
            this.homeContainer.Panel2.Controls.Add(this.listCars);
            this.homeContainer.Size = new System.Drawing.Size(1237, 536);
            this.homeContainer.SplitterDistance = 865;
            this.homeContainer.TabIndex = 39;
            // 
            // listCompanies
            // 
            this.listCompanies.Location = new System.Drawing.Point(88, 25);
            this.listCompanies.Name = "listCompanies";
            this.listCompanies.Size = new System.Drawing.Size(241, 245);
            this.listCompanies.TabIndex = 0;
            this.listCompanies.UseCompatibleStateImageBehavior = false;
            // 
            // listCars
            // 
            this.listCars.Location = new System.Drawing.Point(30, 71);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(235, 272);
            this.listCars.TabIndex = 0;
            this.listCars.UseCompatibleStateImageBehavior = false;
            this.listCars.View = System.Windows.Forms.View.List;
            // 
            // CarCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 560);
            this.Controls.Add(this.homeContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarCompany";
            this.Text = "CarCompany";
            this.Load += new System.EventHandler(this.CarCompany_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pAddNewCar.ResumeLayout(false);
            this.pAddNewCar.PerformLayout();
            this.pTopup.ResumeLayout(false);
            this.pTopup.PerformLayout();
            this.homeContainer.Panel1.ResumeLayout(false);
            this.homeContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeContainer)).EndInit();
            this.homeContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem findCarToolStripMenuItem;
        private System.Windows.Forms.Panel pAddNewCar;
        private System.Windows.Forms.Label lblMessage;
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
        private System.Windows.Forms.Panel pTopup;
        private System.Windows.Forms.TextBox txtIdToChange;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnIdToChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.SplitContainer homeContainer;
        private System.Windows.Forms.ListView listCompanies;
        private System.Windows.Forms.ListView listCars;
    }
}