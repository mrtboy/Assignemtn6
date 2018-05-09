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
            this.updateCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCarId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCarId = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.TxtModel = new System.Windows.Forms.TextBox();
            this.dateYear = new System.Windows.Forms.DateTimePicker();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkAvailable = new System.Windows.Forms.CheckBox();
            this.cbCompanyID = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMessagCompany = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pTopup = new System.Windows.Forms.Panel();
            this.txtIdToChange = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.btnIdToChange = new System.Windows.Forms.Button();
            this.pAddNewCar = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.listCars = new System.Windows.Forms.ListView();
            this.listCompanies = new System.Windows.Forms.ListView();
            this.pCompanyManagement = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCompanyId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnCloseComapny = new System.Windows.Forms.Button();
            this.btnSubmitCompany = new System.Windows.Forms.Button();
            this.pGetId = new System.Windows.Forms.Panel();
            this.txtIdCompanyToChange = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSubmitIdToChange = new System.Windows.Forms.Button();
            this.showCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pShowCarsInCompany = new System.Windows.Forms.Panel();
            this.txtShowCarsId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.showAllCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pTopup.SuspendLayout();
            this.pAddNewCar.SuspendLayout();
            this.pCompanyManagement.SuspendLayout();
            this.pGetId.SuspendLayout();
            this.pShowCarsInCompany.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1505, 24);
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
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addComapnyToolStripMenuItem,
            this.updateCompanyToolStripMenuItem,
            this.showCarsToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.companyToolStripMenuItem.Text = "Company";
            // 
            // addComapnyToolStripMenuItem
            // 
            this.addComapnyToolStripMenuItem.Name = "addComapnyToolStripMenuItem";
            this.addComapnyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addComapnyToolStripMenuItem.Text = "Add Comapny";
            this.addComapnyToolStripMenuItem.Click += new System.EventHandler(this.addComapnyToolStripMenuItem_Click);
            // 
            // updateCompanyToolStripMenuItem
            // 
            this.updateCompanyToolStripMenuItem.Name = "updateCompanyToolStripMenuItem";
            this.updateCompanyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateCompanyToolStripMenuItem.Text = "Update Company";
            this.updateCompanyToolStripMenuItem.Click += new System.EventHandler(this.updateCompanyToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCarToolStripMenuItem,
            this.editCarToolStripMenuItem,
            this.showAllCarsToolStripMenuItem});
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
            // lblCarId
            // 
            this.lblCarId.AutoSize = true;
            this.lblCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarId.Location = new System.Drawing.Point(67, 67);
            this.lblCarId.Name = "lblCarId";
            this.lblCarId.Size = new System.Drawing.Size(55, 20);
            this.lblCarId.TabIndex = 19;
            this.lblCarId.Text = "Car ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Manufacturing Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mileage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(440, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Available";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Company ID";
            // 
            // txtCarId
            // 
            this.txtCarId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarId.Location = new System.Drawing.Point(157, 66);
            this.txtCarId.Name = "txtCarId";
            this.txtCarId.Size = new System.Drawing.Size(199, 26);
            this.txtCarId.TabIndex = 27;
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.Location = new System.Drawing.Point(157, 115);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(199, 26);
            this.txtBrand.TabIndex = 28;
            // 
            // TxtModel
            // 
            this.TxtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModel.Location = new System.Drawing.Point(157, 191);
            this.TxtModel.Name = "TxtModel";
            this.TxtModel.Size = new System.Drawing.Size(199, 26);
            this.TxtModel.TabIndex = 29;
            // 
            // dateYear
            // 
            this.dateYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateYear.Location = new System.Drawing.Point(222, 257);
            this.dateYear.Name = "dateYear";
            this.dateYear.Size = new System.Drawing.Size(134, 20);
            this.dateYear.TabIndex = 30;
            // 
            // txtMileage
            // 
            this.txtMileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMileage.Location = new System.Drawing.Point(536, 67);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(199, 26);
            this.txtMileage.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(536, 121);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(199, 26);
            this.txtPrice.TabIndex = 32;
            // 
            // chkAvailable
            // 
            this.chkAvailable.AutoSize = true;
            this.chkAvailable.Checked = true;
            this.chkAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAvailable.Location = new System.Drawing.Point(536, 196);
            this.chkAvailable.Name = "chkAvailable";
            this.chkAvailable.Size = new System.Drawing.Size(15, 14);
            this.chkAvailable.TabIndex = 33;
            this.chkAvailable.UseVisualStyleBackColor = true;
            // 
            // cbCompanyID
            // 
            this.cbCompanyID.FormattingEnabled = true;
            this.cbCompanyID.Location = new System.Drawing.Point(543, 260);
            this.cbCompanyID.Name = "cbCompanyID";
            this.cbCompanyID.Size = new System.Drawing.Size(121, 21);
            this.cbCompanyID.TabIndex = 34;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(186, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(118, 38);
            this.btnSubmit.TabIndex = 35;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Green;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(506, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(118, 38);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblMessagCompany
            // 
            this.lblMessagCompany.AutoSize = true;
            this.lblMessagCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessagCompany.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessagCompany.Location = new System.Drawing.Point(169, 387);
            this.lblMessagCompany.Name = "lblMessagCompany";
            this.lblMessagCompany.Size = new System.Drawing.Size(0, 17);
            this.lblMessagCompany.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(344, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 38);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pTopup
            // 
            this.pTopup.Controls.Add(this.button3);
            this.pTopup.Controls.Add(this.txtIdToChange);
            this.pTopup.Controls.Add(this.lblEdit);
            this.pTopup.Controls.Add(this.btnIdToChange);
            this.pTopup.Location = new System.Drawing.Point(983, 60);
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
            this.lblEdit.Location = new System.Drawing.Point(97, 12);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(85, 17);
            this.lblEdit.TabIndex = 1;
            this.lblEdit.Text = "Enter Car ID";
            // 
            // btnIdToChange
            // 
            this.btnIdToChange.Location = new System.Drawing.Point(66, 94);
            this.btnIdToChange.Name = "btnIdToChange";
            this.btnIdToChange.Size = new System.Drawing.Size(75, 23);
            this.btnIdToChange.TabIndex = 0;
            this.btnIdToChange.Text = "Submit";
            this.btnIdToChange.UseVisualStyleBackColor = true;
            this.btnIdToChange.Click += new System.EventHandler(this.btnIdToChange_Click);
            // 
            // pAddNewCar
            // 
            this.pAddNewCar.Controls.Add(this.lblMessage);
            this.pAddNewCar.Controls.Add(this.label12);
            this.pAddNewCar.Controls.Add(this.btnDelete);
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
            this.pAddNewCar.Location = new System.Drawing.Point(705, 224);
            this.pAddNewCar.Name = "pAddNewCar";
            this.pAddNewCar.Size = new System.Drawing.Size(785, 426);
            this.pAddNewCar.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMessage.Location = new System.Drawing.Point(204, 387);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(282, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 26);
            this.label12.TabIndex = 49;
            this.label12.Text = "Car Management";
            // 
            // listCars
            // 
            this.listCars.Location = new System.Drawing.Point(705, 27);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(785, 659);
            this.listCars.TabIndex = 3;
            this.listCars.UseCompatibleStateImageBehavior = false;
            this.listCars.View = System.Windows.Forms.View.List;
            // 
            // listCompanies
            // 
            this.listCompanies.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listCompanies.Location = new System.Drawing.Point(12, 27);
            this.listCompanies.Name = "listCompanies";
            this.listCompanies.Size = new System.Drawing.Size(687, 659);
            this.listCompanies.TabIndex = 39;
            this.listCompanies.UseCompatibleStateImageBehavior = false;
            this.listCompanies.View = System.Windows.Forms.View.List;
            // 
            // pCompanyManagement
            // 
            this.pCompanyManagement.Controls.Add(this.txtCompanyName);
            this.pCompanyManagement.Controls.Add(this.label15);
            this.pCompanyManagement.Controls.Add(this.label8);
            this.pCompanyManagement.Controls.Add(this.txtAddress);
            this.pCompanyManagement.Controls.Add(this.lblMessagCompany);
            this.pCompanyManagement.Controls.Add(this.txtPhoneNumber);
            this.pCompanyManagement.Controls.Add(this.txtCompanyId);
            this.pCompanyManagement.Controls.Add(this.label9);
            this.pCompanyManagement.Controls.Add(this.label10);
            this.pCompanyManagement.Controls.Add(this.label11);
            this.pCompanyManagement.Controls.Add(this.btnDeleteCompany);
            this.pCompanyManagement.Controls.Add(this.btnCloseComapny);
            this.pCompanyManagement.Controls.Add(this.btnSubmitCompany);
            this.pCompanyManagement.Location = new System.Drawing.Point(25, 224);
            this.pCompanyManagement.Name = "pCompanyManagement";
            this.pCompanyManagement.Size = new System.Drawing.Size(658, 426);
            this.pCompanyManagement.TabIndex = 40;
            this.pCompanyManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.pCompanyManagement_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(190, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 26);
            this.label8.TabIndex = 48;
            this.label8.Text = "Company Management";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(230, 148);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(362, 89);
            this.txtAddress.TabIndex = 47;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(230, 243);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(362, 26);
            this.txtPhoneNumber.TabIndex = 46;
            // 
            // txtCompanyId
            // 
            this.txtCompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyId.Location = new System.Drawing.Point(230, 61);
            this.txtCompanyId.Name = "txtCompanyId";
            this.txtCompanyId.Size = new System.Drawing.Size(362, 26);
            this.txtCompanyId.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(75, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Phone Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(75, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(75, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 42;
            this.label11.Text = "Company Id";
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCompany.Location = new System.Drawing.Point(263, 326);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(118, 38);
            this.btnDeleteCompany.TabIndex = 41;
            this.btnDeleteCompany.Text = "Delete";
            this.btnDeleteCompany.UseVisualStyleBackColor = false;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnCloseComapny
            // 
            this.btnCloseComapny.BackColor = System.Drawing.Color.Green;
            this.btnCloseComapny.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseComapny.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseComapny.Location = new System.Drawing.Point(425, 326);
            this.btnCloseComapny.Name = "btnCloseComapny";
            this.btnCloseComapny.Size = new System.Drawing.Size(118, 38);
            this.btnCloseComapny.TabIndex = 40;
            this.btnCloseComapny.Text = "Close";
            this.btnCloseComapny.UseVisualStyleBackColor = false;
            this.btnCloseComapny.Click += new System.EventHandler(this.btnCloseComapny_Click);
            // 
            // btnSubmitCompany
            // 
            this.btnSubmitCompany.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubmitCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitCompany.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmitCompany.Location = new System.Drawing.Point(105, 326);
            this.btnSubmitCompany.Name = "btnSubmitCompany";
            this.btnSubmitCompany.Size = new System.Drawing.Size(118, 38);
            this.btnSubmitCompany.TabIndex = 39;
            this.btnSubmitCompany.Text = "Submit";
            this.btnSubmitCompany.UseVisualStyleBackColor = false;
            this.btnSubmitCompany.Click += new System.EventHandler(this.btnSubmitCompany_Click);
            // 
            // pGetId
            // 
            this.pGetId.Controls.Add(this.btnCancel);
            this.pGetId.Controls.Add(this.txtIdCompanyToChange);
            this.pGetId.Controls.Add(this.label13);
            this.pGetId.Controls.Add(this.btnSubmitIdToChange);
            this.pGetId.Location = new System.Drawing.Point(194, 60);
            this.pGetId.Name = "pGetId";
            this.pGetId.Size = new System.Drawing.Size(290, 131);
            this.pGetId.TabIndex = 39;
            // 
            // txtIdCompanyToChange
            // 
            this.txtIdCompanyToChange.Location = new System.Drawing.Point(93, 52);
            this.txtIdCompanyToChange.Name = "txtIdCompanyToChange";
            this.txtIdCompanyToChange.Size = new System.Drawing.Size(100, 20);
            this.txtIdCompanyToChange.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(80, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Enter Company ID";
            // 
            // btnSubmitIdToChange
            // 
            this.btnSubmitIdToChange.Location = new System.Drawing.Point(61, 94);
            this.btnSubmitIdToChange.Name = "btnSubmitIdToChange";
            this.btnSubmitIdToChange.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitIdToChange.TabIndex = 0;
            this.btnSubmitIdToChange.Text = "Submit";
            this.btnSubmitIdToChange.UseVisualStyleBackColor = true;
            this.btnSubmitIdToChange.Click += new System.EventHandler(this.btnSubmitIdToChange_Click);
            // 
            // showCarsToolStripMenuItem
            // 
            this.showCarsToolStripMenuItem.Name = "showCarsToolStripMenuItem";
            this.showCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showCarsToolStripMenuItem.Text = "Show Cars";
            this.showCarsToolStripMenuItem.Click += new System.EventHandler(this.showCarsToolStripMenuItem_Click);
            // 
            // pShowCarsInCompany
            // 
            this.pShowCarsInCompany.Controls.Add(this.button2);
            this.pShowCarsInCompany.Controls.Add(this.txtShowCarsId);
            this.pShowCarsInCompany.Controls.Add(this.label14);
            this.pShowCarsInCompany.Controls.Add(this.button1);
            this.pShowCarsInCompany.Location = new System.Drawing.Point(557, 60);
            this.pShowCarsInCompany.Name = "pShowCarsInCompany";
            this.pShowCarsInCompany.Size = new System.Drawing.Size(290, 131);
            this.pShowCarsInCompany.TabIndex = 40;
            // 
            // txtShowCarsId
            // 
            this.txtShowCarsId.Location = new System.Drawing.Point(93, 52);
            this.txtShowCarsId.Name = "txtShowCarsId";
            this.txtShowCarsId.Size = new System.Drawing.Size(100, 20);
            this.txtShowCarsId.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(65, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 17);
            this.label14.TabIndex = 1;
            this.label14.Text = "Show Cars in Company";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(157, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(166, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // showAllCarsToolStripMenuItem
            // 
            this.showAllCarsToolStripMenuItem.Name = "showAllCarsToolStripMenuItem";
            this.showAllCarsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllCarsToolStripMenuItem.Text = "Show All Cars";
            this.showAllCarsToolStripMenuItem.Click += new System.EventHandler(this.showAllCarsToolStripMenuItem_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(230, 100);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(362, 26);
            this.txtCompanyName.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 49;
            this.label15.Text = "Name";
            // 
            // CarCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 763);
            this.Controls.Add(this.pShowCarsInCompany);
            this.Controls.Add(this.pGetId);
            this.Controls.Add(this.pCompanyManagement);
            this.Controls.Add(this.listCompanies);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pAddNewCar);
            this.Controls.Add(this.pTopup);
            this.Controls.Add(this.listCars);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarCompany";
            this.Text = "CarCompany";
            this.Load += new System.EventHandler(this.CarCompany_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pTopup.ResumeLayout(false);
            this.pTopup.PerformLayout();
            this.pAddNewCar.ResumeLayout(false);
            this.pAddNewCar.PerformLayout();
            this.pCompanyManagement.ResumeLayout(false);
            this.pCompanyManagement.PerformLayout();
            this.pGetId.ResumeLayout(false);
            this.pGetId.PerformLayout();
            this.pShowCarsInCompany.ResumeLayout(false);
            this.pShowCarsInCompany.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem updateCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCarToolStripMenuItem;
        private System.Windows.Forms.Label lblCarId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCarId;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox TxtModel;
        private System.Windows.Forms.DateTimePicker dateYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkAvailable;
        private System.Windows.Forms.ComboBox cbCompanyID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMessagCompany;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pTopup;
        private System.Windows.Forms.TextBox txtIdToChange;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Button btnIdToChange;
        private System.Windows.Forms.Panel pAddNewCar;
        private System.Windows.Forms.ListView listCars;
        private System.Windows.Forms.ListView listCompanies;
        private System.Windows.Forms.Panel pCompanyManagement;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCompanyId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnCloseComapny;
        private System.Windows.Forms.Button btnSubmitCompany;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pGetId;
        private System.Windows.Forms.TextBox txtIdCompanyToChange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSubmitIdToChange;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ToolStripMenuItem showCarsToolStripMenuItem;
        private System.Windows.Forms.Panel pShowCarsInCompany;
        private System.Windows.Forms.TextBox txtShowCarsId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem showAllCarsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label15;
    }
}