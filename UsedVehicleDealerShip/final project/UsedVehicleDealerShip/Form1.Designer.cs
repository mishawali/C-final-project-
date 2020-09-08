namespace UsedVehicleDealerShip
{
    partial class MainForm
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
            this.groupBoxDataEntry = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxVehicles = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxMake = new System.Windows.Forms.ComboBox();
            this.dateTimePickerSoldDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.comboBoxVehicleType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumberOfDoors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEngineSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.groupBoxTables = new System.Windows.Forms.GroupBox();
            this.buttonModels = new System.Windows.Forms.Button();
            this.buttonVehicleTypes = new System.Windows.Forms.Button();
            this.buttonMakes = new System.Windows.Forms.Button();
            this.buttonVehicles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxSoldDate = new System.Windows.Forms.CheckBox();
            this.groupBoxDataEntry.SuspendLayout();
            this.groupBoxOperations.SuspendLayout();
            this.groupBoxTables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataEntry
            // 
            this.groupBoxDataEntry.Controls.Add(this.checkBoxSoldDate);
            this.groupBoxDataEntry.Controls.Add(this.label12);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxVehicles);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxModel);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxMake);
            this.groupBoxDataEntry.Controls.Add(this.dateTimePickerSoldDate);
            this.groupBoxDataEntry.Controls.Add(this.label9);
            this.groupBoxDataEntry.Controls.Add(this.textBoxCost);
            this.groupBoxDataEntry.Controls.Add(this.label10);
            this.groupBoxDataEntry.Controls.Add(this.textBoxPrice);
            this.groupBoxDataEntry.Controls.Add(this.label11);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxYear);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxColor);
            this.groupBoxDataEntry.Controls.Add(this.comboBoxVehicleType);
            this.groupBoxDataEntry.Controls.Add(this.label7);
            this.groupBoxDataEntry.Controls.Add(this.label6);
            this.groupBoxDataEntry.Controls.Add(this.label5);
            this.groupBoxDataEntry.Controls.Add(this.textBoxNumberOfDoors);
            this.groupBoxDataEntry.Controls.Add(this.label4);
            this.groupBoxDataEntry.Controls.Add(this.textBoxEngineSize);
            this.groupBoxDataEntry.Controls.Add(this.label3);
            this.groupBoxDataEntry.Controls.Add(this.label2);
            this.groupBoxDataEntry.Controls.Add(this.label1);
            this.groupBoxDataEntry.Location = new System.Drawing.Point(40, 44);
            this.groupBoxDataEntry.Name = "groupBoxDataEntry";
            this.groupBoxDataEntry.Size = new System.Drawing.Size(298, 334);
            this.groupBoxDataEntry.TabIndex = 0;
            this.groupBoxDataEntry.TabStop = false;
            this.groupBoxDataEntry.Text = "Vehicle Data Entry";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Vehicle Id";
            // 
            // comboBoxVehicles
            // 
            this.comboBoxVehicles.FormattingEnabled = true;
            this.comboBoxVehicles.Location = new System.Drawing.Point(110, 23);
            this.comboBoxVehicles.Name = "comboBoxVehicles";
            this.comboBoxVehicles.Size = new System.Drawing.Size(79, 21);
            this.comboBoxVehicles.TabIndex = 6;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(110, 81);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 28;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxMake
            // 
            this.comboBoxMake.FormattingEnabled = true;
            this.comboBoxMake.Location = new System.Drawing.Point(110, 55);
            this.comboBoxMake.Name = "comboBoxMake";
            this.comboBoxMake.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMake.TabIndex = 27;
            this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.comboBoxMake_SelectedIndexChanged);
            // 
            // dateTimePickerSoldDate
            // 
            this.dateTimePickerSoldDate.Location = new System.Drawing.Point(132, 299);
            this.dateTimePickerSoldDate.Name = "dateTimePickerSoldDate";
            this.dateTimePickerSoldDate.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerSoldDate.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sold Date";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(110, 273);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Purchased Cost";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(110, 247);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Price";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2115",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "",
            "",
            ""});
            this.comboBoxYear.Location = new System.Drawing.Point(110, 220);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 20;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Black",
            "White",
            "Purple",
            "Gray",
            "Orange"});
            this.comboBoxColor.Location = new System.Drawing.Point(110, 167);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 19;
            // 
            // comboBoxVehicleType
            // 
            this.comboBoxVehicleType.FormattingEnabled = true;
            this.comboBoxVehicleType.Location = new System.Drawing.Point(110, 193);
            this.comboBoxVehicleType.Name = "comboBoxVehicleType";
            this.comboBoxVehicleType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVehicleType.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color";
            // 
            // textBoxNumberOfDoors
            // 
            this.textBoxNumberOfDoors.Location = new System.Drawing.Point(110, 138);
            this.textBoxNumberOfDoors.Name = "textBoxNumberOfDoors";
            this.textBoxNumberOfDoors.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfDoors.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Doors";
            // 
            // textBoxEngineSize
            // 
            this.textBoxEngineSize.Location = new System.Drawing.Point(110, 111);
            this.textBoxEngineSize.Name = "textBoxEngineSize";
            this.textBoxEngineSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxEngineSize.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Engine Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.buttonExit);
            this.groupBoxOperations.Controls.Add(this.buttonClear);
            this.groupBoxOperations.Controls.Add(this.buttonDelete);
            this.groupBoxOperations.Controls.Add(this.buttonUpdate);
            this.groupBoxOperations.Controls.Add(this.buttonRead);
            this.groupBoxOperations.Controls.Add(this.buttonCreate);
            this.groupBoxOperations.Location = new System.Drawing.Point(366, 31);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Size = new System.Drawing.Size(200, 242);
            this.groupBoxOperations.TabIndex = 1;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Vehicle Operations";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(26, 206);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(26, 169);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(26, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(26, 94);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(26, 65);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(26, 36);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 0;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // groupBoxTables
            // 
            this.groupBoxTables.Controls.Add(this.buttonModels);
            this.groupBoxTables.Controls.Add(this.buttonVehicleTypes);
            this.groupBoxTables.Controls.Add(this.buttonMakes);
            this.groupBoxTables.Controls.Add(this.buttonVehicles);
            this.groupBoxTables.Location = new System.Drawing.Point(43, 384);
            this.groupBoxTables.Name = "groupBoxTables";
            this.groupBoxTables.Size = new System.Drawing.Size(526, 70);
            this.groupBoxTables.TabIndex = 2;
            this.groupBoxTables.TabStop = false;
            this.groupBoxTables.Text = "View Data Tables";
            // 
            // buttonModels
            // 
            this.buttonModels.Location = new System.Drawing.Point(201, 31);
            this.buttonModels.Name = "buttonModels";
            this.buttonModels.Size = new System.Drawing.Size(75, 23);
            this.buttonModels.TabIndex = 4;
            this.buttonModels.Text = "Models";
            this.buttonModels.UseVisualStyleBackColor = true;
            this.buttonModels.Click += new System.EventHandler(this.buttonModels_Click);
            // 
            // buttonVehicleTypes
            // 
            this.buttonVehicleTypes.Location = new System.Drawing.Point(295, 31);
            this.buttonVehicleTypes.Name = "buttonVehicleTypes";
            this.buttonVehicleTypes.Size = new System.Drawing.Size(100, 23);
            this.buttonVehicleTypes.TabIndex = 3;
            this.buttonVehicleTypes.Text = "Vehicle Types";
            this.buttonVehicleTypes.UseVisualStyleBackColor = true;
            this.buttonVehicleTypes.Click += new System.EventHandler(this.buttonVehicleTypes_Click);
            // 
            // buttonMakes
            // 
            this.buttonMakes.Location = new System.Drawing.Point(107, 31);
            this.buttonMakes.Name = "buttonMakes";
            this.buttonMakes.Size = new System.Drawing.Size(75, 23);
            this.buttonMakes.TabIndex = 2;
            this.buttonMakes.Text = "Makes";
            this.buttonMakes.UseVisualStyleBackColor = true;
            this.buttonMakes.Click += new System.EventHandler(this.buttonMakes_Click);
            // 
            // buttonVehicles
            // 
            this.buttonVehicles.Location = new System.Drawing.Point(11, 31);
            this.buttonVehicles.Name = "buttonVehicles";
            this.buttonVehicles.Size = new System.Drawing.Size(75, 23);
            this.buttonVehicles.TabIndex = 1;
            this.buttonVehicles.Text = "Vehicles";
            this.buttonVehicles.UseVisualStyleBackColor = true;
            this.buttonVehicles.Click += new System.EventHandler(this.buttonVehicles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 479);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(526, 135);
            this.dataGridView1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Misha Wali";
            // 
            // checkBoxSoldDate
            // 
            this.checkBoxSoldDate.AutoSize = true;
            this.checkBoxSoldDate.Location = new System.Drawing.Point(110, 299);
            this.checkBoxSoldDate.Name = "checkBoxSoldDate";
            this.checkBoxSoldDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSoldDate.TabIndex = 5;
            this.checkBoxSoldDate.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 626);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxTables);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.groupBoxDataEntry);
            this.Name = "MainForm";
            this.Text = "Used Vehicle Dealership";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxDataEntry.ResumeLayout(false);
            this.groupBoxDataEntry.PerformLayout();
            this.groupBoxOperations.ResumeLayout(false);
            this.groupBoxTables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataEntry;
        private System.Windows.Forms.ComboBox comboBoxVehicleType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumberOfDoors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOperations;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.GroupBox groupBoxTables;
        private System.Windows.Forms.Button buttonModels;
        private System.Windows.Forms.Button buttonVehicleTypes;
        private System.Windows.Forms.Button buttonMakes;
        private System.Windows.Forms.Button buttonVehicles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerSoldDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxMake;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxVehicles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxSoldDate;
    }
}

