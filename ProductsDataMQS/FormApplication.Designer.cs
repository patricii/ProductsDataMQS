namespace ProductsDataMQS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridViewMQS = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pYieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primePassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeFailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primeHandleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totYieldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totPassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgPASSTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totFailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totHandleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyMQSDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mQSRequestDatabaseDataSet = new ProductsDataMQS.MQSRequestDatabaseDataSet();
            this.groupBoxProductData = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxEdit = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEnableLogin = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelUserLogin = new System.Windows.Forms.Label();
            this.textBoxThandle = new System.Windows.Forms.TextBox();
            this.labelTHandle = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelSite = new System.Windows.Forms.Label();
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxNPI = new System.Windows.Forms.TextBox();
            this.labelNPI = new System.Windows.Forms.Label();
            this.textBoxMchTime = new System.Windows.Forms.TextBox();
            this.labelMchTime = new System.Windows.Forms.Label();
            this.textBoxCsvFolder = new System.Windows.Forms.TextBox();
            this.labelCsvFile = new System.Windows.Forms.Label();
            this.textBoxTTime = new System.Windows.Forms.TextBox();
            this.labelTestTime = new System.Windows.Forms.Label();
            this.textBoxTYield = new System.Windows.Forms.TextBox();
            this.labelTotalYield = new System.Windows.Forms.Label();
            this.textBoxTFail = new System.Windows.Forms.TextBox();
            this.labelTotalFail = new System.Windows.Forms.Label();
            this.textBoxTPass = new System.Windows.Forms.TextBox();
            this.labelTotalPass = new System.Windows.Forms.Label();
            this.textBoxPYield = new System.Windows.Forms.TextBox();
            this.labelPYield = new System.Windows.Forms.Label();
            this.textBoxPrimeFail = new System.Windows.Forms.TextBox();
            this.labelPrimeFail = new System.Windows.Forms.Label();
            this.textBoxPrimePass = new System.Windows.Forms.TextBox();
            this.labelPrimePass = new System.Windows.Forms.Label();
            this.textBoxProcess = new System.Windows.Forms.TextBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.labelFamily = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonInsertDB = new System.Windows.Forms.Button();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonUpdateToDb = new System.Windows.Forms.Button();
            this.comboBoxListToADDdb = new System.Windows.Forms.ComboBox();
            this.richTextBoxCompare = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterCount = new System.Windows.Forms.TextBox();
            this.labelFilterCount = new System.Windows.Forms.Label();
            this.textBoxFilterValue = new System.Windows.Forms.TextBox();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.labelStatusCompare = new System.Windows.Forms.Label();
            this.buttonCompareAvg = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveNew = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.labelCreatePassword = new System.Windows.Forms.Label();
            this.textBoxCreateUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginSetting = new System.Windows.Forms.Label();
            this.dailyMQSDataTableAdapter = new ProductsDataMQS.MQSRequestDatabaseDataSetTableAdapters.DailyMQSDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMQS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMQSDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mQSRequestDatabaseDataSet)).BeginInit();
            this.groupBoxProductData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMQS
            // 
            this.dataGridViewMQS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewMQS.AutoGenerateColumns = false;
            this.dataGridViewMQS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMQS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.processDataGridViewTextBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.pYieldDataGridViewTextBoxColumn,
            this.primePassDataGridViewTextBoxColumn,
            this.primeFailDataGridViewTextBoxColumn,
            this.primeHandleDataGridViewTextBoxColumn,
            this.totYieldDataGridViewTextBoxColumn,
            this.totPassDataGridViewTextBoxColumn,
            this.avgPASSTimeDataGridViewTextBoxColumn,
            this.totFailDataGridViewTextBoxColumn,
            this.totHandleDataGridViewTextBoxColumn});
            this.dataGridViewMQS.DataSource = this.dailyMQSDataBindingSource;
            this.dataGridViewMQS.Location = new System.Drawing.Point(11, 242);
            this.dataGridViewMQS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewMQS.Name = "dataGridViewMQS";
            this.dataGridViewMQS.RowHeadersWidth = 51;
            this.dataGridViewMQS.Size = new System.Drawing.Size(1009, 585);
            this.dataGridViewMQS.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.Width = 95;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.Width = 125;
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "Process";
            this.processDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            this.processDataGridViewTextBoxColumn.Width = 90;
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "Technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.technologyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            this.technologyDataGridViewTextBoxColumn.Width = 125;
            // 
            // pYieldDataGridViewTextBoxColumn
            // 
            this.pYieldDataGridViewTextBoxColumn.DataPropertyName = "PYield";
            this.pYieldDataGridViewTextBoxColumn.HeaderText = "PYield";
            this.pYieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pYieldDataGridViewTextBoxColumn.Name = "pYieldDataGridViewTextBoxColumn";
            this.pYieldDataGridViewTextBoxColumn.Width = 60;
            // 
            // primePassDataGridViewTextBoxColumn
            // 
            this.primePassDataGridViewTextBoxColumn.DataPropertyName = "PrimePass";
            this.primePassDataGridViewTextBoxColumn.HeaderText = "PrimePass";
            this.primePassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primePassDataGridViewTextBoxColumn.Name = "primePassDataGridViewTextBoxColumn";
            this.primePassDataGridViewTextBoxColumn.Width = 60;
            // 
            // primeFailDataGridViewTextBoxColumn
            // 
            this.primeFailDataGridViewTextBoxColumn.DataPropertyName = "PrimeFail";
            this.primeFailDataGridViewTextBoxColumn.HeaderText = "PrimeFail";
            this.primeFailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primeFailDataGridViewTextBoxColumn.Name = "primeFailDataGridViewTextBoxColumn";
            this.primeFailDataGridViewTextBoxColumn.Width = 60;
            // 
            // primeHandleDataGridViewTextBoxColumn
            // 
            this.primeHandleDataGridViewTextBoxColumn.DataPropertyName = "PrimeHandle";
            this.primeHandleDataGridViewTextBoxColumn.HeaderText = "PrimeHandle";
            this.primeHandleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.primeHandleDataGridViewTextBoxColumn.Name = "primeHandleDataGridViewTextBoxColumn";
            this.primeHandleDataGridViewTextBoxColumn.Visible = false;
            this.primeHandleDataGridViewTextBoxColumn.Width = 65;
            // 
            // totYieldDataGridViewTextBoxColumn
            // 
            this.totYieldDataGridViewTextBoxColumn.DataPropertyName = "TotYield";
            this.totYieldDataGridViewTextBoxColumn.HeaderText = "TotYield";
            this.totYieldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totYieldDataGridViewTextBoxColumn.Name = "totYieldDataGridViewTextBoxColumn";
            this.totYieldDataGridViewTextBoxColumn.Visible = false;
            this.totYieldDataGridViewTextBoxColumn.Width = 50;
            // 
            // totPassDataGridViewTextBoxColumn
            // 
            this.totPassDataGridViewTextBoxColumn.DataPropertyName = "TotPass";
            this.totPassDataGridViewTextBoxColumn.HeaderText = "TotPass";
            this.totPassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totPassDataGridViewTextBoxColumn.Name = "totPassDataGridViewTextBoxColumn";
            this.totPassDataGridViewTextBoxColumn.Visible = false;
            this.totPassDataGridViewTextBoxColumn.Width = 50;
            // 
            // avgPASSTimeDataGridViewTextBoxColumn
            // 
            this.avgPASSTimeDataGridViewTextBoxColumn.DataPropertyName = "AvgPASSTime";
            this.avgPASSTimeDataGridViewTextBoxColumn.HeaderText = "AvgPASSTime";
            this.avgPASSTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avgPASSTimeDataGridViewTextBoxColumn.Name = "avgPASSTimeDataGridViewTextBoxColumn";
            this.avgPASSTimeDataGridViewTextBoxColumn.Width = 80;
            // 
            // totFailDataGridViewTextBoxColumn
            // 
            this.totFailDataGridViewTextBoxColumn.DataPropertyName = "TotFail";
            this.totFailDataGridViewTextBoxColumn.HeaderText = "TotFail";
            this.totFailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totFailDataGridViewTextBoxColumn.Name = "totFailDataGridViewTextBoxColumn";
            this.totFailDataGridViewTextBoxColumn.Visible = false;
            this.totFailDataGridViewTextBoxColumn.Width = 50;
            // 
            // totHandleDataGridViewTextBoxColumn
            // 
            this.totHandleDataGridViewTextBoxColumn.DataPropertyName = "TotHandle";
            this.totHandleDataGridViewTextBoxColumn.HeaderText = "TotHandle";
            this.totHandleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totHandleDataGridViewTextBoxColumn.Name = "totHandleDataGridViewTextBoxColumn";
            this.totHandleDataGridViewTextBoxColumn.Width = 60;
            // 
            // dailyMQSDataBindingSource
            // 
            this.dailyMQSDataBindingSource.DataMember = "DailyMQSData";
            this.dailyMQSDataBindingSource.DataSource = this.mQSRequestDatabaseDataSet;
            // 
            // mQSRequestDatabaseDataSet
            // 
            this.mQSRequestDatabaseDataSet.DataSetName = "MQSRequestDatabaseDataSet";
            this.mQSRequestDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxProductData
            // 
            this.groupBoxProductData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProductData.Controls.Add(this.groupBox4);
            this.groupBoxProductData.Controls.Add(this.labelUserLogin);
            this.groupBoxProductData.Controls.Add(this.textBoxThandle);
            this.groupBoxProductData.Controls.Add(this.labelTHandle);
            this.groupBoxProductData.Controls.Add(this.textBoxLocation);
            this.groupBoxProductData.Controls.Add(this.labelSite);
            this.groupBoxProductData.Controls.Add(this.labelLogo);
            this.groupBoxProductData.Controls.Add(this.textBoxNPI);
            this.groupBoxProductData.Controls.Add(this.labelNPI);
            this.groupBoxProductData.Controls.Add(this.textBoxMchTime);
            this.groupBoxProductData.Controls.Add(this.labelMchTime);
            this.groupBoxProductData.Controls.Add(this.textBoxCsvFolder);
            this.groupBoxProductData.Controls.Add(this.labelCsvFile);
            this.groupBoxProductData.Controls.Add(this.textBoxTTime);
            this.groupBoxProductData.Controls.Add(this.labelTestTime);
            this.groupBoxProductData.Controls.Add(this.textBoxTYield);
            this.groupBoxProductData.Controls.Add(this.labelTotalYield);
            this.groupBoxProductData.Controls.Add(this.textBoxTFail);
            this.groupBoxProductData.Controls.Add(this.labelTotalFail);
            this.groupBoxProductData.Controls.Add(this.textBoxTPass);
            this.groupBoxProductData.Controls.Add(this.labelTotalPass);
            this.groupBoxProductData.Controls.Add(this.textBoxPYield);
            this.groupBoxProductData.Controls.Add(this.labelPYield);
            this.groupBoxProductData.Controls.Add(this.textBoxPrimeFail);
            this.groupBoxProductData.Controls.Add(this.labelPrimeFail);
            this.groupBoxProductData.Controls.Add(this.textBoxPrimePass);
            this.groupBoxProductData.Controls.Add(this.labelPrimePass);
            this.groupBoxProductData.Controls.Add(this.textBoxProcess);
            this.groupBoxProductData.Controls.Add(this.labelProcess);
            this.groupBoxProductData.Controls.Add(this.textBoxFamily);
            this.groupBoxProductData.Controls.Add(this.labelFamily);
            this.groupBoxProductData.Controls.Add(this.textBoxProductName);
            this.groupBoxProductData.Controls.Add(this.labelProductName);
            this.groupBoxProductData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductData.Location = new System.Drawing.Point(8, 7);
            this.groupBoxProductData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProductData.Name = "groupBoxProductData";
            this.groupBoxProductData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxProductData.Size = new System.Drawing.Size(1465, 193);
            this.groupBoxProductData.TabIndex = 1;
            this.groupBoxProductData.TabStop = false;
            this.groupBoxProductData.Text = "Product Infos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxEdit);
            this.groupBox4.Controls.Add(this.buttonSave);
            this.groupBox4.Controls.Add(this.buttonEnableLogin);
            this.groupBox4.Controls.Add(this.buttonDelete);
            this.groupBox4.Controls.Add(this.buttonAddNew);
            this.groupBox4.Location = new System.Drawing.Point(23, 57);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(347, 121);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Edit DB";
            // 
            // checkBoxEdit
            // 
            this.checkBoxEdit.AutoSize = true;
            this.checkBoxEdit.Enabled = false;
            this.checkBoxEdit.Location = new System.Drawing.Point(8, 94);
            this.checkBoxEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEdit.Name = "checkBoxEdit";
            this.checkBoxEdit.Size = new System.Drawing.Size(75, 22);
            this.checkBoxEdit.TabIndex = 41;
            this.checkBoxEdit.Text = "Enable";
            this.checkBoxEdit.UseVisualStyleBackColor = true;
            this.checkBoxEdit.CheckedChanged += new System.EventHandler(this.checkBoxEdit_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(129, 84);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 31);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEnableLogin
            // 
            this.buttonEnableLogin.Location = new System.Drawing.Point(8, 32);
            this.buttonEnableLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEnableLogin.Name = "buttonEnableLogin";
            this.buttonEnableLogin.Size = new System.Drawing.Size(93, 42);
            this.buttonEnableLogin.TabIndex = 39;
            this.buttonEnableLogin.Text = "Login >>";
            this.buttonEnableLogin.UseVisualStyleBackColor = true;
            this.buttonEnableLogin.Click += new System.EventHandler(this.buttonEnableLogin_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(247, 84);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(92, 31);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Enabled = false;
            this.buttonAddNew.Location = new System.Drawing.Point(129, 30);
            this.buttonAddNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(209, 46);
            this.buttonAddNew.TabIndex = 33;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // labelUserLogin
            // 
            this.labelUserLogin.AutoSize = true;
            this.labelUserLogin.Location = new System.Drawing.Point(223, 34);
            this.labelUserLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserLogin.Name = "labelUserLogin";
            this.labelUserLogin.Size = new System.Drawing.Size(0, 18);
            this.labelUserLogin.TabIndex = 41;
            // 
            // textBoxThandle
            // 
            this.textBoxThandle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotHandle", true));
            this.textBoxThandle.Location = new System.Drawing.Point(829, 153);
            this.textBoxThandle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxThandle.Name = "textBoxThandle";
            this.textBoxThandle.Size = new System.Drawing.Size(112, 24);
            this.textBoxThandle.TabIndex = 38;
            this.textBoxThandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxThandle.TextChanged += new System.EventHandler(this.textBoxThandle_TextChanged);
            // 
            // labelTHandle
            // 
            this.labelTHandle.AutoSize = true;
            this.labelTHandle.Location = new System.Drawing.Point(733, 159);
            this.labelTHandle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTHandle.Name = "labelTHandle";
            this.labelTHandle.Size = new System.Drawing.Size(84, 18);
            this.labelTHandle.TabIndex = 37;
            this.labelTHandle.Text = "Tot Handle:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Location", true));
            this.textBoxLocation.Location = new System.Drawing.Point(481, 155);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(236, 24);
            this.textBoxLocation.TabIndex = 36;
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(404, 159);
            this.labelSite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(69, 18);
            this.labelSite.TabIndex = 35;
            this.labelSite.Text = "Location:";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Teal;
            this.labelLogo.Location = new System.Drawing.Point(8, 25);
            this.labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(177, 25);
            this.labelLogo.TabIndex = 32;
            this.labelLogo.Text = "Product Data MQS";
            // 
            // textBoxNPI
            // 
            this.textBoxNPI.Location = new System.Drawing.Point(1307, 118);
            this.textBoxNPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNPI.Name = "textBoxNPI";
            this.textBoxNPI.Size = new System.Drawing.Size(121, 24);
            this.textBoxNPI.TabIndex = 29;
            this.textBoxNPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNPI
            // 
            this.labelNPI.AutoSize = true;
            this.labelNPI.Location = new System.Drawing.Point(1208, 122);
            this.labelNPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNPI.Name = "labelNPI";
            this.labelNPI.Size = new System.Drawing.Size(73, 18);
            this.labelNPI.TabIndex = 28;
            this.labelNPI.Text = "NPI Time:";
            // 
            // textBoxMchTime
            // 
            this.textBoxMchTime.Location = new System.Drawing.Point(1307, 87);
            this.textBoxMchTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMchTime.Name = "textBoxMchTime";
            this.textBoxMchTime.Size = new System.Drawing.Size(121, 24);
            this.textBoxMchTime.TabIndex = 27;
            this.textBoxMchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMchTime
            // 
            this.labelMchTime.AutoSize = true;
            this.labelMchTime.Location = new System.Drawing.Point(1208, 94);
            this.labelMchTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMchTime.Name = "labelMchTime";
            this.labelMchTime.Size = new System.Drawing.Size(84, 18);
            this.labelMchTime.TabIndex = 26;
            this.labelMchTime.Text = "MCH Time:";
            // 
            // textBoxCsvFolder
            // 
            this.textBoxCsvFolder.Enabled = false;
            this.textBoxCsvFolder.Location = new System.Drawing.Point(1056, 151);
            this.textBoxCsvFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCsvFolder.Name = "textBoxCsvFolder";
            this.textBoxCsvFolder.Size = new System.Drawing.Size(372, 24);
            this.textBoxCsvFolder.TabIndex = 24;
            this.textBoxCsvFolder.Text = "C:\\ProductDataMQS\\rawdata\\DailyMQSData.csv";
            // 
            // labelCsvFile
            // 
            this.labelCsvFile.AutoSize = true;
            this.labelCsvFile.Location = new System.Drawing.Point(968, 159);
            this.labelCsvFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCsvFile.Name = "labelCsvFile";
            this.labelCsvFile.Size = new System.Drawing.Size(65, 18);
            this.labelCsvFile.TabIndex = 23;
            this.labelCsvFile.Text = "Csv File:";
            // 
            // textBoxTTime
            // 
            this.textBoxTTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "AvgPASSTime", true));
            this.textBoxTTime.Location = new System.Drawing.Point(1307, 54);
            this.textBoxTTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTTime.Name = "textBoxTTime";
            this.textBoxTTime.Size = new System.Drawing.Size(121, 24);
            this.textBoxTTime.TabIndex = 19;
            this.textBoxTTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTTime.TextChanged += new System.EventHandler(this.textBoxTTime_TextChanged);
            // 
            // labelTestTime
            // 
            this.labelTestTime.AutoSize = true;
            this.labelTestTime.Location = new System.Drawing.Point(1208, 63);
            this.labelTestTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTestTime.Name = "labelTestTime";
            this.labelTestTime.Size = new System.Drawing.Size(78, 18);
            this.labelTestTime.TabIndex = 18;
            this.labelTestTime.Text = "Test Time:";
            // 
            // textBoxTYield
            // 
            this.textBoxTYield.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotYield", true));
            this.textBoxTYield.Location = new System.Drawing.Point(1056, 54);
            this.textBoxTYield.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTYield.Name = "textBoxTYield";
            this.textBoxTYield.Size = new System.Drawing.Size(112, 24);
            this.textBoxTYield.TabIndex = 17;
            this.textBoxTYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalYield
            // 
            this.labelTotalYield.AutoSize = true;
            this.labelTotalYield.Location = new System.Drawing.Point(968, 63);
            this.labelTotalYield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalYield.Name = "labelTotalYield";
            this.labelTotalYield.Size = new System.Drawing.Size(80, 18);
            this.labelTotalYield.TabIndex = 16;
            this.labelTotalYield.Text = "Total Yield:";
            // 
            // textBoxTFail
            // 
            this.textBoxTFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotFail", true));
            this.textBoxTFail.Location = new System.Drawing.Point(1056, 118);
            this.textBoxTFail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTFail.Name = "textBoxTFail";
            this.textBoxTFail.Size = new System.Drawing.Size(112, 24);
            this.textBoxTFail.TabIndex = 15;
            this.textBoxTFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalFail
            // 
            this.labelTotalFail.AutoSize = true;
            this.labelTotalFail.Location = new System.Drawing.Point(968, 127);
            this.labelTotalFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalFail.Name = "labelTotalFail";
            this.labelTotalFail.Size = new System.Drawing.Size(72, 18);
            this.labelTotalFail.TabIndex = 14;
            this.labelTotalFail.Text = "Total Fail:";
            // 
            // textBoxTPass
            // 
            this.textBoxTPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotPass", true));
            this.textBoxTPass.Location = new System.Drawing.Point(1056, 86);
            this.textBoxTPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTPass.Name = "textBoxTPass";
            this.textBoxTPass.Size = new System.Drawing.Size(112, 24);
            this.textBoxTPass.TabIndex = 13;
            this.textBoxTPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalPass
            // 
            this.labelTotalPass.AutoSize = true;
            this.labelTotalPass.Location = new System.Drawing.Point(968, 95);
            this.labelTotalPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPass.Name = "labelTotalPass";
            this.labelTotalPass.Size = new System.Drawing.Size(83, 18);
            this.labelTotalPass.TabIndex = 12;
            this.labelTotalPass.Text = "Total Pass:";
            // 
            // textBoxPYield
            // 
            this.textBoxPYield.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PYield", true));
            this.textBoxPYield.Location = new System.Drawing.Point(829, 54);
            this.textBoxPYield.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPYield.Name = "textBoxPYield";
            this.textBoxPYield.Size = new System.Drawing.Size(112, 24);
            this.textBoxPYield.TabIndex = 11;
            this.textBoxPYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPYield.TextChanged += new System.EventHandler(this.textBoxPYield_TextChanged);
            // 
            // labelPYield
            // 
            this.labelPYield.AutoSize = true;
            this.labelPYield.Location = new System.Drawing.Point(733, 63);
            this.labelPYield.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPYield.Name = "labelPYield";
            this.labelPYield.Size = new System.Drawing.Size(53, 18);
            this.labelPYield.TabIndex = 10;
            this.labelPYield.Text = "PYield:";
            // 
            // textBoxPrimeFail
            // 
            this.textBoxPrimeFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PrimeFail", true));
            this.textBoxPrimeFail.Location = new System.Drawing.Point(829, 118);
            this.textBoxPrimeFail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrimeFail.Name = "textBoxPrimeFail";
            this.textBoxPrimeFail.Size = new System.Drawing.Size(112, 24);
            this.textBoxPrimeFail.TabIndex = 9;
            this.textBoxPrimeFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPrimeFail
            // 
            this.labelPrimeFail.AutoSize = true;
            this.labelPrimeFail.Location = new System.Drawing.Point(733, 127);
            this.labelPrimeFail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrimeFail.Name = "labelPrimeFail";
            this.labelPrimeFail.Size = new System.Drawing.Size(78, 18);
            this.labelPrimeFail.TabIndex = 8;
            this.labelPrimeFail.Text = "Prime Fail:";
            // 
            // textBoxPrimePass
            // 
            this.textBoxPrimePass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PrimePass", true));
            this.textBoxPrimePass.Location = new System.Drawing.Point(829, 86);
            this.textBoxPrimePass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrimePass.Name = "textBoxPrimePass";
            this.textBoxPrimePass.Size = new System.Drawing.Size(112, 24);
            this.textBoxPrimePass.TabIndex = 7;
            this.textBoxPrimePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPrimePass
            // 
            this.labelPrimePass.AutoSize = true;
            this.labelPrimePass.Location = new System.Drawing.Point(733, 95);
            this.labelPrimePass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrimePass.Name = "labelPrimePass";
            this.labelPrimePass.Size = new System.Drawing.Size(89, 18);
            this.labelPrimePass.TabIndex = 6;
            this.labelPrimePass.Text = "Prime Pass:";
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Process", true));
            this.textBoxProcess.Location = new System.Drawing.Point(481, 86);
            this.textBoxProcess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(236, 24);
            this.textBoxProcess.TabIndex = 5;
            this.textBoxProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProcess.TextChanged += new System.EventHandler(this.textBoxProcess_TextChanged);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(404, 96);
            this.labelProcess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(68, 18);
            this.labelProcess.TabIndex = 4;
            this.labelProcess.Text = "Process:";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Family", true));
            this.textBoxFamily.Location = new System.Drawing.Point(481, 54);
            this.textBoxFamily.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(236, 24);
            this.textBoxFamily.TabIndex = 3;
            this.textBoxFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFamily.TextChanged += new System.EventHandler(this.textBoxFamily_TextChanged);
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(404, 64);
            this.labelFamily.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(55, 18);
            this.labelFamily.TabIndex = 2;
            this.labelFamily.Text = "Family:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Technology", true));
            this.textBoxProductName.Location = new System.Drawing.Point(481, 119);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(236, 24);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(404, 128);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(64, 18);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product:";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(16, 209);
            this.buttonPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(93, 26);
            this.buttonPrev.TabIndex = 21;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(117, 209);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(93, 26);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonInsertDB
            // 
            this.buttonInsertDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInsertDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonInsertDB.Enabled = false;
            this.buttonInsertDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertDB.Location = new System.Drawing.Point(89, 139);
            this.buttonInsertDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInsertDB.Name = "buttonInsertDB";
            this.buttonInsertDB.Size = new System.Drawing.Size(184, 44);
            this.buttonInsertDB.TabIndex = 31;
            this.buttonInsertDB.Text = "Create DataBase";
            this.buttonInsertDB.UseVisualStyleBackColor = false;
            this.buttonInsertDB.Click += new System.EventHandler(this.buttonInsertDB_Click);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.ForeColor = System.Drawing.Color.Teal;
            this.labelUpdate.Location = new System.Drawing.Point(65, 102);
            this.labelUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(0, 20);
            this.labelUpdate.TabIndex = 30;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(60, 23);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(225, 78);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "MQS Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelDev.Location = new System.Drawing.Point(1, 891);
            this.labelDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(138, 15);
            this.labelDev.TabIndex = 2;
            this.labelDev.Text = "Developed by A. Patricio";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(1733, 878);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 28);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1829, 866);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRefresh);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.richTextBoxCompare);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxFilterCount);
            this.tabPage1.Controls.Add(this.labelFilterCount);
            this.tabPage1.Controls.Add(this.textBoxFilterValue);
            this.tabPage1.Controls.Add(this.labelCriteria);
            this.tabPage1.Controls.Add(this.labelStatusCompare);
            this.tabPage1.Controls.Add(this.buttonCompareAvg);
            this.tabPage1.Controls.Add(this.dataGridViewMQS);
            this.tabPage1.Controls.Add(this.groupBoxProductData);
            this.tabPage1.Controls.Add(this.buttonPrev);
            this.tabPage1.Controls.Add(this.buttonNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1821, 837);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MQS Product Infos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(832, 209);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(169, 26);
            this.buttonRefresh.TabIndex = 43;
            this.buttonRefresh.Text = "Refresh DataBase";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.buttonUpdateToDb);
            this.groupBox3.Controls.Add(this.comboBoxListToADDdb);
            this.groupBox3.Location = new System.Drawing.Point(1028, 692);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(783, 123);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Insert To DB";
            // 
            // buttonUpdateToDb
            // 
            this.buttonUpdateToDb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdateToDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdateToDb.Enabled = false;
            this.buttonUpdateToDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonUpdateToDb.Location = new System.Drawing.Point(303, 58);
            this.buttonUpdateToDb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdateToDb.Name = "buttonUpdateToDb";
            this.buttonUpdateToDb.Size = new System.Drawing.Size(184, 55);
            this.buttonUpdateToDb.TabIndex = 33;
            this.buttonUpdateToDb.Text = "Update To DB";
            this.buttonUpdateToDb.UseVisualStyleBackColor = false;
            this.buttonUpdateToDb.Click += new System.EventHandler(this.buttonUpdateToDb_Click);
            // 
            // comboBoxListToADDdb
            // 
            this.comboBoxListToADDdb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxListToADDdb.Enabled = false;
            this.comboBoxListToADDdb.FormattingEnabled = true;
            this.comboBoxListToADDdb.Location = new System.Drawing.Point(20, 23);
            this.comboBoxListToADDdb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxListToADDdb.Name = "comboBoxListToADDdb";
            this.comboBoxListToADDdb.Size = new System.Drawing.Size(753, 24);
            this.comboBoxListToADDdb.TabIndex = 32;
            // 
            // richTextBoxCompare
            // 
            this.richTextBoxCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCompare.Location = new System.Drawing.Point(1028, 262);
            this.richTextBoxCompare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxCompare.Name = "richTextBoxCompare";
            this.richTextBoxCompare.Size = new System.Drawing.Size(781, 420);
            this.richTextBoxCompare.TabIndex = 41;
            this.richTextBoxCompare.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.buttonInsertDB);
            this.groupBox1.Controls.Add(this.labelUpdate);
            this.groupBox1.Location = new System.Drawing.Point(1481, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(316, 193);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // textBoxFilterCount
            // 
            this.textBoxFilterCount.Location = new System.Drawing.Point(1639, 230);
            this.textBoxFilterCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterCount.Name = "textBoxFilterCount";
            this.textBoxFilterCount.Size = new System.Drawing.Size(37, 22);
            this.textBoxFilterCount.TabIndex = 38;
            this.textBoxFilterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFilterCount
            // 
            this.labelFilterCount.AutoSize = true;
            this.labelFilterCount.Location = new System.Drawing.Point(1548, 239);
            this.labelFilterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterCount.Name = "labelFilterCount";
            this.labelFilterCount.Size = new System.Drawing.Size(76, 16);
            this.labelFilterCount.TabIndex = 37;
            this.labelFilterCount.Text = "Filter Count:";
            // 
            // textBoxFilterValue
            // 
            this.textBoxFilterValue.Location = new System.Drawing.Point(1481, 230);
            this.textBoxFilterValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterValue.Name = "textBoxFilterValue";
            this.textBoxFilterValue.Size = new System.Drawing.Size(37, 22);
            this.textBoxFilterValue.TabIndex = 36;
            this.textBoxFilterValue.Text = "10";
            this.textBoxFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilterValue.TextChanged += new System.EventHandler(this.textBoxFilterValue_TextChanged);
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Location = new System.Drawing.Point(1313, 239);
            this.labelCriteria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(154, 16);
            this.labelCriteria.TabIndex = 35;
            this.labelCriteria.Text = "Minimum Delta Value (s):";
            // 
            // labelStatusCompare
            // 
            this.labelStatusCompare.AutoSize = true;
            this.labelStatusCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusCompare.ForeColor = System.Drawing.Color.Teal;
            this.labelStatusCompare.Location = new System.Drawing.Point(1281, 206);
            this.labelStatusCompare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusCompare.Name = "labelStatusCompare";
            this.labelStatusCompare.Size = new System.Drawing.Size(0, 20);
            this.labelStatusCompare.TabIndex = 33;
            // 
            // buttonCompareAvg
            // 
            this.buttonCompareAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompareAvg.Location = new System.Drawing.Point(1028, 210);
            this.buttonCompareAvg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCompareAvg.Name = "buttonCompareAvg";
            this.buttonCompareAvg.Size = new System.Drawing.Size(228, 44);
            this.buttonCompareAvg.TabIndex = 32;
            this.buttonCompareAvg.Text = "Compare Test Time";
            this.buttonCompareAvg.UseVisualStyleBackColor = true;
            this.buttonCompareAvg.Click += new System.EventHandler(this.buttonCompareAvg_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.labelLoginSetting);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1821, 837);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Login Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxConfirmPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonSaveNew);
            this.groupBox2.Controls.Add(this.buttonNewUser);
            this.groupBox2.Controls.Add(this.textBoxCreatePassword);
            this.groupBox2.Controls.Add(this.labelCreatePassword);
            this.groupBox2.Controls.Add(this.textBoxCreateUserName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(320, 334);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create User and Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Enabled = false;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(27, 235);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(245, 24);
            this.textBoxConfirmPassword.TabIndex = 7;
            this.textBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm Password:";
            // 
            // buttonSaveNew
            // 
            this.buttonSaveNew.Enabled = false;
            this.buttonSaveNew.Location = new System.Drawing.Point(188, 278);
            this.buttonSaveNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveNew.Name = "buttonSaveNew";
            this.buttonSaveNew.Size = new System.Drawing.Size(85, 48);
            this.buttonSaveNew.TabIndex = 5;
            this.buttonSaveNew.Text = "Save";
            this.buttonSaveNew.UseVisualStyleBackColor = true;
            this.buttonSaveNew.Click += new System.EventHandler(this.buttonSaveNew_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(27, 25);
            this.buttonNewUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(85, 46);
            this.buttonNewUser.TabIndex = 4;
            this.buttonNewUser.Text = "New";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.Enabled = false;
            this.textBoxCreatePassword.Location = new System.Drawing.Point(27, 174);
            this.textBoxCreatePassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(245, 24);
            this.textBoxCreatePassword.TabIndex = 3;
            this.textBoxCreatePassword.UseSystemPasswordChar = true;
            // 
            // labelCreatePassword
            // 
            this.labelCreatePassword.AutoSize = true;
            this.labelCreatePassword.Location = new System.Drawing.Point(23, 153);
            this.labelCreatePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreatePassword.Name = "labelCreatePassword";
            this.labelCreatePassword.Size = new System.Drawing.Size(79, 18);
            this.labelCreatePassword.TabIndex = 2;
            this.labelCreatePassword.Text = "Password:";
            // 
            // textBoxCreateUserName
            // 
            this.textBoxCreateUserName.Enabled = false;
            this.textBoxCreateUserName.Location = new System.Drawing.Point(27, 106);
            this.textBoxCreateUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCreateUserName.Name = "textBoxCreateUserName";
            this.textBoxCreateUserName.Size = new System.Drawing.Size(245, 24);
            this.textBoxCreateUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // labelLoginSetting
            // 
            this.labelLoginSetting.AutoSize = true;
            this.labelLoginSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginSetting.ForeColor = System.Drawing.Color.Teal;
            this.labelLoginSetting.Location = new System.Drawing.Point(8, 25);
            this.labelLoginSetting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginSetting.Name = "labelLoginSetting";
            this.labelLoginSetting.Size = new System.Drawing.Size(126, 25);
            this.labelLoginSetting.TabIndex = 33;
            this.labelLoginSetting.Text = "Login Setting";
            // 
            // dailyMQSDataTableAdapter
            // 
            this.dailyMQSDataTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 912);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Data MQS v1.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMQS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMQSDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mQSRequestDatabaseDataSet)).EndInit();
            this.groupBoxProductData.ResumeLayout(false);
            this.groupBoxProductData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMQS;
        private System.Windows.Forms.GroupBox groupBoxProductData;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.TextBox textBoxProcess;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxPYield;
        private System.Windows.Forms.Label labelPYield;
        private System.Windows.Forms.TextBox textBoxPrimeFail;
        private System.Windows.Forms.Label labelPrimeFail;
        private System.Windows.Forms.TextBox textBoxPrimePass;
        private System.Windows.Forms.Label labelPrimePass;
        private System.Windows.Forms.TextBox textBoxTTime;
        private System.Windows.Forms.Label labelTestTime;
        private System.Windows.Forms.TextBox textBoxTYield;
        private System.Windows.Forms.Label labelTotalYield;
        private System.Windows.Forms.TextBox textBoxTFail;
        private System.Windows.Forms.Label labelTotalFail;
        private System.Windows.Forms.TextBox textBoxTPass;
        private System.Windows.Forms.Label labelTotalPass;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxCsvFolder;
        private System.Windows.Forms.Label labelCsvFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MQSRequestDatabaseDataSet mQSRequestDatabaseDataSet;
        private System.Windows.Forms.BindingSource dailyMQSDataBindingSource;
        private MQSRequestDatabaseDataSetTableAdapters.DailyMQSDataTableAdapter dailyMQSDataTableAdapter;
        private System.Windows.Forms.TextBox textBoxMchTime;
        private System.Windows.Forms.Label labelMchTime;
        private System.Windows.Forms.TextBox textBoxNPI;
        private System.Windows.Forms.Label labelNPI;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelStatusCompare;
        private System.Windows.Forms.Label labelLogo;
        public System.Windows.Forms.Button buttonCompareAvg;
        public System.Windows.Forms.TextBox textBoxFilterCount;
        private System.Windows.Forms.Label labelFilterCount;
        public System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.Label labelCriteria;
        public System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RichTextBox richTextBoxCompare;
        private System.Windows.Forms.TextBox textBoxThandle;
        private System.Windows.Forms.Label labelTHandle;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelSite;
        private System.Windows.Forms.Button buttonEnableLogin;
        public System.Windows.Forms.Button buttonInsertDB;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonAddNew;
        public System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSaveNew;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.TextBox textBoxCreatePassword;
        private System.Windows.Forms.Label labelCreatePassword;
        private System.Windows.Forms.TextBox textBoxCreateUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginSetting;
        public System.Windows.Forms.Label labelUserLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn processDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pYieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primePassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeFailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primeHandleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totYieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totPassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgPASSTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totFailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totHandleDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.ComboBox comboBoxListToADDdb;
        public System.Windows.Forms.Button buttonUpdateToDb;
        private System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.CheckBox checkBoxEdit;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

