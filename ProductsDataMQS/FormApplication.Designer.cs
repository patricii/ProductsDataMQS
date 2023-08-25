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
            this.dailyMQSDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mQSRequestDatabaseDataSet = new ProductsDataMQS.MQSRequestDatabaseDataSet();
            this.groupBoxProductData = new System.Windows.Forms.GroupBox();
            this.labelLogo = new System.Windows.Forms.Label();
            this.textBoxNPI = new System.Windows.Forms.TextBox();
            this.labelNPI = new System.Windows.Forms.Label();
            this.textBoxMchTime = new System.Windows.Forms.TextBox();
            this.labelMchTime = new System.Windows.Forms.Label();
            this.textBoxAllInfos = new System.Windows.Forms.TextBox();
            this.textBoxCsvFolder = new System.Windows.Forms.TextBox();
            this.labelCsvFile = new System.Windows.Forms.Label();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
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
            this.buttonInsertDB = new System.Windows.Forms.Button();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFilterCount = new System.Windows.Forms.TextBox();
            this.labelFilterCount = new System.Windows.Forms.Label();
            this.textBoxFilterValue = new System.Windows.Forms.TextBox();
            this.labelCriteria = new System.Windows.Forms.Label();
            this.labelStatusCompare = new System.Windows.Forms.Label();
            this.buttonCompareAvg = new System.Windows.Forms.Button();
            this.dailyMQSDataTableAdapter = new ProductsDataMQS.MQSRequestDatabaseDataSetTableAdapters.DailyMQSDataTableAdapter();
            this.richTextBoxCompare = new System.Windows.Forms.RichTextBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxThandle = new System.Windows.Forms.TextBox();
            this.labelTHandle = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelSite = new System.Windows.Forms.Label();
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
            this.buttonEnableLogin = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMQS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMQSDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mQSRequestDatabaseDataSet)).BeginInit();
            this.groupBoxProductData.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMQS
            // 
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
            this.dataGridViewMQS.Location = new System.Drawing.Point(8, 197);
            this.dataGridViewMQS.Name = "dataGridViewMQS";
            this.dataGridViewMQS.Size = new System.Drawing.Size(843, 475);
            this.dataGridViewMQS.TabIndex = 0;
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
            this.groupBoxProductData.Controls.Add(this.buttonDelete);
            this.groupBoxProductData.Controls.Add(this.buttonEnableLogin);
            this.groupBoxProductData.Controls.Add(this.textBoxThandle);
            this.groupBoxProductData.Controls.Add(this.labelTHandle);
            this.groupBoxProductData.Controls.Add(this.textBoxLocation);
            this.groupBoxProductData.Controls.Add(this.labelSite);
            this.groupBoxProductData.Controls.Add(this.buttonSave);
            this.groupBoxProductData.Controls.Add(this.buttonAddNew);
            this.groupBoxProductData.Controls.Add(this.labelLogo);
            this.groupBoxProductData.Controls.Add(this.textBoxNPI);
            this.groupBoxProductData.Controls.Add(this.labelNPI);
            this.groupBoxProductData.Controls.Add(this.textBoxMchTime);
            this.groupBoxProductData.Controls.Add(this.labelMchTime);
            this.groupBoxProductData.Controls.Add(this.textBoxAllInfos);
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
            this.groupBoxProductData.Location = new System.Drawing.Point(6, 6);
            this.groupBoxProductData.Name = "groupBoxProductData";
            this.groupBoxProductData.Size = new System.Drawing.Size(1213, 157);
            this.groupBoxProductData.TabIndex = 1;
            this.groupBoxProductData.TabStop = false;
            this.groupBoxProductData.Text = "Product Infos";
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.Teal;
            this.labelLogo.Location = new System.Drawing.Point(613, 7);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(143, 20);
            this.labelLogo.TabIndex = 32;
            this.labelLogo.Text = "Product Data MQS";
            // 
            // textBoxNPI
            // 
            this.textBoxNPI.Location = new System.Drawing.Point(888, 87);
            this.textBoxNPI.Name = "textBoxNPI";
            this.textBoxNPI.Size = new System.Drawing.Size(83, 21);
            this.textBoxNPI.TabIndex = 29;
            this.textBoxNPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNPI
            // 
            this.labelNPI.AutoSize = true;
            this.labelNPI.Location = new System.Drawing.Point(814, 90);
            this.labelNPI.Name = "labelNPI";
            this.labelNPI.Size = new System.Drawing.Size(61, 15);
            this.labelNPI.TabIndex = 28;
            this.labelNPI.Text = "NPI Time:";
            // 
            // textBoxMchTime
            // 
            this.textBoxMchTime.Location = new System.Drawing.Point(888, 62);
            this.textBoxMchTime.Name = "textBoxMchTime";
            this.textBoxMchTime.Size = new System.Drawing.Size(83, 21);
            this.textBoxMchTime.TabIndex = 27;
            this.textBoxMchTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMchTime
            // 
            this.labelMchTime.AutoSize = true;
            this.labelMchTime.Location = new System.Drawing.Point(814, 67);
            this.labelMchTime.Name = "labelMchTime";
            this.labelMchTime.Size = new System.Drawing.Size(69, 15);
            this.labelMchTime.TabIndex = 26;
            this.labelMchTime.Text = "MCH Time:";
            // 
            // textBoxAllInfos
            // 
            this.textBoxAllInfos.Location = new System.Drawing.Point(518, 130);
            this.textBoxAllInfos.Name = "textBoxAllInfos";
            this.textBoxAllInfos.Size = new System.Drawing.Size(683, 21);
            this.textBoxAllInfos.TabIndex = 25;
            this.textBoxAllInfos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCsvFolder
            // 
            this.textBoxCsvFolder.Enabled = false;
            this.textBoxCsvFolder.Location = new System.Drawing.Point(239, 130);
            this.textBoxCsvFolder.Name = "textBoxCsvFolder";
            this.textBoxCsvFolder.Size = new System.Drawing.Size(273, 21);
            this.textBoxCsvFolder.TabIndex = 24;
            this.textBoxCsvFolder.Text = "C:\\ProductDataMQS\\rawdata\\DailyMQSData.csv";
            // 
            // labelCsvFile
            // 
            this.labelCsvFile.AutoSize = true;
            this.labelCsvFile.Location = new System.Drawing.Point(186, 136);
            this.labelCsvFile.Name = "labelCsvFile";
            this.labelCsvFile.Size = new System.Drawing.Size(52, 15);
            this.labelCsvFile.TabIndex = 23;
            this.labelCsvFile.Text = "Csv File:";
            // 
            // buttonPrev
            // 
            this.buttonPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(12, 170);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(70, 21);
            this.buttonPrev.TabIndex = 21;
            this.buttonPrev.Text = "<<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(88, 170);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(70, 21);
            this.buttonNext.TabIndex = 20;
            this.buttonNext.Text = ">>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxTTime
            // 
            this.textBoxTTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "AvgPASSTime", true));
            this.textBoxTTime.Location = new System.Drawing.Point(888, 35);
            this.textBoxTTime.Name = "textBoxTTime";
            this.textBoxTTime.Size = new System.Drawing.Size(83, 21);
            this.textBoxTTime.TabIndex = 19;
            this.textBoxTTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTTime.TextChanged += new System.EventHandler(this.textBoxTTime_TextChanged);
            // 
            // labelTestTime
            // 
            this.labelTestTime.AutoSize = true;
            this.labelTestTime.Location = new System.Drawing.Point(814, 42);
            this.labelTestTime.Name = "labelTestTime";
            this.labelTestTime.Size = new System.Drawing.Size(64, 15);
            this.labelTestTime.TabIndex = 18;
            this.labelTestTime.Text = "Test Time:";
            // 
            // textBoxTYield
            // 
            this.textBoxTYield.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotYield", true));
            this.textBoxTYield.Location = new System.Drawing.Point(691, 35);
            this.textBoxTYield.Name = "textBoxTYield";
            this.textBoxTYield.Size = new System.Drawing.Size(104, 21);
            this.textBoxTYield.TabIndex = 17;
            this.textBoxTYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalYield
            // 
            this.labelTotalYield.AutoSize = true;
            this.labelTotalYield.Location = new System.Drawing.Point(625, 42);
            this.labelTotalYield.Name = "labelTotalYield";
            this.labelTotalYield.Size = new System.Drawing.Size(67, 15);
            this.labelTotalYield.TabIndex = 16;
            this.labelTotalYield.Text = "Total Yield:";
            // 
            // textBoxTFail
            // 
            this.textBoxTFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotFail", true));
            this.textBoxTFail.Location = new System.Drawing.Point(691, 87);
            this.textBoxTFail.Name = "textBoxTFail";
            this.textBoxTFail.Size = new System.Drawing.Size(104, 21);
            this.textBoxTFail.TabIndex = 15;
            this.textBoxTFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalFail
            // 
            this.labelTotalFail.AutoSize = true;
            this.labelTotalFail.Location = new System.Drawing.Point(625, 94);
            this.labelTotalFail.Name = "labelTotalFail";
            this.labelTotalFail.Size = new System.Drawing.Size(60, 15);
            this.labelTotalFail.TabIndex = 14;
            this.labelTotalFail.Text = "Total Fail:";
            // 
            // textBoxTPass
            // 
            this.textBoxTPass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotPass", true));
            this.textBoxTPass.Location = new System.Drawing.Point(691, 61);
            this.textBoxTPass.Name = "textBoxTPass";
            this.textBoxTPass.Size = new System.Drawing.Size(104, 21);
            this.textBoxTPass.TabIndex = 13;
            this.textBoxTPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTotalPass
            // 
            this.labelTotalPass.AutoSize = true;
            this.labelTotalPass.Location = new System.Drawing.Point(625, 68);
            this.labelTotalPass.Name = "labelTotalPass";
            this.labelTotalPass.Size = new System.Drawing.Size(67, 15);
            this.labelTotalPass.TabIndex = 12;
            this.labelTotalPass.Text = "Total Pass:";
            // 
            // textBoxPYield
            // 
            this.textBoxPYield.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PYield", true));
            this.textBoxPYield.Location = new System.Drawing.Point(505, 35);
            this.textBoxPYield.Name = "textBoxPYield";
            this.textBoxPYield.Size = new System.Drawing.Size(104, 21);
            this.textBoxPYield.TabIndex = 11;
            this.textBoxPYield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPYield.TextChanged += new System.EventHandler(this.textBoxPYield_TextChanged);
            // 
            // labelPYield
            // 
            this.labelPYield.AutoSize = true;
            this.labelPYield.Location = new System.Drawing.Point(433, 42);
            this.labelPYield.Name = "labelPYield";
            this.labelPYield.Size = new System.Drawing.Size(45, 15);
            this.labelPYield.TabIndex = 10;
            this.labelPYield.Text = "PYield:";
            // 
            // textBoxPrimeFail
            // 
            this.textBoxPrimeFail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PrimeFail", true));
            this.textBoxPrimeFail.Location = new System.Drawing.Point(505, 87);
            this.textBoxPrimeFail.Name = "textBoxPrimeFail";
            this.textBoxPrimeFail.Size = new System.Drawing.Size(104, 21);
            this.textBoxPrimeFail.TabIndex = 9;
            this.textBoxPrimeFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPrimeFail
            // 
            this.labelPrimeFail.AutoSize = true;
            this.labelPrimeFail.Location = new System.Drawing.Point(433, 94);
            this.labelPrimeFail.Name = "labelPrimeFail";
            this.labelPrimeFail.Size = new System.Drawing.Size(66, 15);
            this.labelPrimeFail.TabIndex = 8;
            this.labelPrimeFail.Text = "Prime Fail:";
            // 
            // textBoxPrimePass
            // 
            this.textBoxPrimePass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "PrimePass", true));
            this.textBoxPrimePass.Location = new System.Drawing.Point(505, 61);
            this.textBoxPrimePass.Name = "textBoxPrimePass";
            this.textBoxPrimePass.Size = new System.Drawing.Size(104, 21);
            this.textBoxPrimePass.TabIndex = 7;
            this.textBoxPrimePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPrimePass
            // 
            this.labelPrimePass.AutoSize = true;
            this.labelPrimePass.Location = new System.Drawing.Point(433, 68);
            this.labelPrimePass.Name = "labelPrimePass";
            this.labelPrimePass.Size = new System.Drawing.Size(73, 15);
            this.labelPrimePass.TabIndex = 6;
            this.labelPrimePass.Text = "Prime Pass:";
            // 
            // textBoxProcess
            // 
            this.textBoxProcess.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Process", true));
            this.textBoxProcess.Location = new System.Drawing.Point(239, 35);
            this.textBoxProcess.Name = "textBoxProcess";
            this.textBoxProcess.Size = new System.Drawing.Size(178, 21);
            this.textBoxProcess.TabIndex = 5;
            this.textBoxProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProcess.TextChanged += new System.EventHandler(this.textBoxProcess_TextChanged);
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(186, 42);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(54, 15);
            this.labelProcess.TabIndex = 4;
            this.labelProcess.Text = "Process:";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Family", true));
            this.textBoxFamily.Location = new System.Drawing.Point(239, 61);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(178, 21);
            this.textBoxFamily.TabIndex = 3;
            this.textBoxFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFamily.TextChanged += new System.EventHandler(this.textBoxFamily_TextChanged);
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(186, 68);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(46, 15);
            this.labelFamily.TabIndex = 2;
            this.labelFamily.Text = "Family:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Technology", true));
            this.textBoxProductName.Location = new System.Drawing.Point(239, 88);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(178, 21);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(186, 95);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(52, 15);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product:";
            // 
            // buttonInsertDB
            // 
            this.buttonInsertDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonInsertDB.Enabled = false;
            this.buttonInsertDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInsertDB.Location = new System.Drawing.Point(20, 113);
            this.buttonInsertDB.Name = "buttonInsertDB";
            this.buttonInsertDB.Size = new System.Drawing.Size(116, 38);
            this.buttonInsertDB.TabIndex = 31;
            this.buttonInsertDB.Text = "Insert To db";
            this.buttonInsertDB.UseVisualStyleBackColor = false;
            this.buttonInsertDB.Click += new System.EventHandler(this.buttonInsertDB_Click);
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.ForeColor = System.Drawing.Color.Teal;
            this.labelUpdate.Location = new System.Drawing.Point(26, 82);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(0, 24);
            this.labelUpdate.TabIndex = 30;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Teal;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(6, 20);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 57);
            this.buttonUpdate.TabIndex = 22;
            this.buttonUpdate.Text = "MQS Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.labelDev.Location = new System.Drawing.Point(2, 727);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(107, 12);
            this.labelDev.TabIndex = 2;
            this.labelDev.Text = "Developed by A. Patricio";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1301, 713);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(94, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1399, 704);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1391, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MQS Product Infos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonUpdate);
            this.groupBox1.Controls.Add(this.labelUpdate);
            this.groupBox1.Controls.Add(this.buttonInsertDB);
            this.groupBox1.Location = new System.Drawing.Point(1225, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 157);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // textBoxFilterCount
            // 
            this.textBoxFilterCount.Location = new System.Drawing.Point(1297, 202);
            this.textBoxFilterCount.Name = "textBoxFilterCount";
            this.textBoxFilterCount.Size = new System.Drawing.Size(29, 20);
            this.textBoxFilterCount.TabIndex = 38;
            this.textBoxFilterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFilterCount
            // 
            this.labelFilterCount.AutoSize = true;
            this.labelFilterCount.Location = new System.Drawing.Point(1229, 209);
            this.labelFilterCount.Name = "labelFilterCount";
            this.labelFilterCount.Size = new System.Drawing.Size(63, 13);
            this.labelFilterCount.TabIndex = 37;
            this.labelFilterCount.Text = "Filter Count:";
            // 
            // textBoxFilterValue
            // 
            this.textBoxFilterValue.Location = new System.Drawing.Point(1179, 202);
            this.textBoxFilterValue.Name = "textBoxFilterValue";
            this.textBoxFilterValue.Size = new System.Drawing.Size(29, 20);
            this.textBoxFilterValue.TabIndex = 36;
            this.textBoxFilterValue.Text = "10";
            this.textBoxFilterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxFilterValue.TextChanged += new System.EventHandler(this.textBoxFilterValue_TextChanged);
            // 
            // labelCriteria
            // 
            this.labelCriteria.AutoSize = true;
            this.labelCriteria.Location = new System.Drawing.Point(1053, 209);
            this.labelCriteria.Name = "labelCriteria";
            this.labelCriteria.Size = new System.Drawing.Size(123, 13);
            this.labelCriteria.TabIndex = 35;
            this.labelCriteria.Text = "Minimum Delta Value (s):";
            // 
            // labelStatusCompare
            // 
            this.labelStatusCompare.AutoSize = true;
            this.labelStatusCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusCompare.ForeColor = System.Drawing.Color.Teal;
            this.labelStatusCompare.Location = new System.Drawing.Point(1040, 180);
            this.labelStatusCompare.Name = "labelStatusCompare";
            this.labelStatusCompare.Size = new System.Drawing.Size(0, 16);
            this.labelStatusCompare.TabIndex = 33;
            // 
            // buttonCompareAvg
            // 
            this.buttonCompareAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompareAvg.Location = new System.Drawing.Point(857, 170);
            this.buttonCompareAvg.Name = "buttonCompareAvg";
            this.buttonCompareAvg.Size = new System.Drawing.Size(171, 52);
            this.buttonCompareAvg.TabIndex = 32;
            this.buttonCompareAvg.Text = "Compare Test Time";
            this.buttonCompareAvg.UseVisualStyleBackColor = true;
            this.buttonCompareAvg.Click += new System.EventHandler(this.buttonCompareAvg_Click);
            // 
            // dailyMQSDataTableAdapter
            // 
            this.dailyMQSDataTableAdapter.ClearBeforeFill = true;
            // 
            // richTextBoxCompare
            // 
            this.richTextBoxCompare.Location = new System.Drawing.Point(857, 229);
            this.richTextBoxCompare.Name = "richTextBoxCompare";
            this.richTextBoxCompare.Size = new System.Drawing.Size(524, 443);
            this.richTextBoxCompare.TabIndex = 41;
            this.richTextBoxCompare.Text = "";
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Enabled = false;
            this.buttonAddNew.Location = new System.Drawing.Point(6, 55);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(156, 34);
            this.buttonAddNew.TabIndex = 33;
            this.buttonAddNew.Text = "Add New";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(6, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 34);
            this.buttonSave.TabIndex = 34;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxThandle
            // 
            this.textBoxThandle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "TotHandle", true));
            this.textBoxThandle.Location = new System.Drawing.Point(1062, 62);
            this.textBoxThandle.Name = "textBoxThandle";
            this.textBoxThandle.Size = new System.Drawing.Size(83, 21);
            this.textBoxThandle.TabIndex = 38;
            this.textBoxThandle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTHandle
            // 
            this.labelTHandle.AutoSize = true;
            this.labelTHandle.Location = new System.Drawing.Point(981, 67);
            this.labelTHandle.Name = "labelTHandle";
            this.labelTHandle.Size = new System.Drawing.Size(80, 15);
            this.labelTHandle.TabIndex = 37;
            this.labelTHandle.Text = "Total Handle:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dailyMQSDataBindingSource, "Location", true));
            this.textBoxLocation.Location = new System.Drawing.Point(1062, 35);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(139, 21);
            this.textBoxLocation.TabIndex = 36;
            this.textBoxLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSite
            // 
            this.labelSite.AutoSize = true;
            this.labelSite.Location = new System.Drawing.Point(981, 42);
            this.labelSite.Name = "labelSite";
            this.labelSite.Size = new System.Drawing.Size(57, 15);
            this.labelSite.TabIndex = 35;
            this.labelSite.Text = "Location:";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Family";
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            // 
            // processDataGridViewTextBoxColumn
            // 
            this.processDataGridViewTextBoxColumn.DataPropertyName = "Process";
            this.processDataGridViewTextBoxColumn.HeaderText = "Process";
            this.processDataGridViewTextBoxColumn.Name = "processDataGridViewTextBoxColumn";
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "Technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            // 
            // pYieldDataGridViewTextBoxColumn
            // 
            this.pYieldDataGridViewTextBoxColumn.DataPropertyName = "PYield";
            this.pYieldDataGridViewTextBoxColumn.HeaderText = "PYield";
            this.pYieldDataGridViewTextBoxColumn.Name = "pYieldDataGridViewTextBoxColumn";
            // 
            // primePassDataGridViewTextBoxColumn
            // 
            this.primePassDataGridViewTextBoxColumn.DataPropertyName = "PrimePass";
            this.primePassDataGridViewTextBoxColumn.HeaderText = "PrimePass";
            this.primePassDataGridViewTextBoxColumn.Name = "primePassDataGridViewTextBoxColumn";
            // 
            // primeFailDataGridViewTextBoxColumn
            // 
            this.primeFailDataGridViewTextBoxColumn.DataPropertyName = "PrimeFail";
            this.primeFailDataGridViewTextBoxColumn.HeaderText = "PrimeFail";
            this.primeFailDataGridViewTextBoxColumn.Name = "primeFailDataGridViewTextBoxColumn";
            // 
            // primeHandleDataGridViewTextBoxColumn
            // 
            this.primeHandleDataGridViewTextBoxColumn.DataPropertyName = "PrimeHandle";
            this.primeHandleDataGridViewTextBoxColumn.HeaderText = "PrimeHandle";
            this.primeHandleDataGridViewTextBoxColumn.Name = "primeHandleDataGridViewTextBoxColumn";
            this.primeHandleDataGridViewTextBoxColumn.Visible = false;
            // 
            // totYieldDataGridViewTextBoxColumn
            // 
            this.totYieldDataGridViewTextBoxColumn.DataPropertyName = "TotYield";
            this.totYieldDataGridViewTextBoxColumn.HeaderText = "TotYield";
            this.totYieldDataGridViewTextBoxColumn.Name = "totYieldDataGridViewTextBoxColumn";
            this.totYieldDataGridViewTextBoxColumn.Visible = false;
            // 
            // totPassDataGridViewTextBoxColumn
            // 
            this.totPassDataGridViewTextBoxColumn.DataPropertyName = "TotPass";
            this.totPassDataGridViewTextBoxColumn.HeaderText = "TotPass";
            this.totPassDataGridViewTextBoxColumn.Name = "totPassDataGridViewTextBoxColumn";
            this.totPassDataGridViewTextBoxColumn.Visible = false;
            // 
            // avgPASSTimeDataGridViewTextBoxColumn
            // 
            this.avgPASSTimeDataGridViewTextBoxColumn.DataPropertyName = "AvgPASSTime";
            this.avgPASSTimeDataGridViewTextBoxColumn.HeaderText = "AvgPASSTime";
            this.avgPASSTimeDataGridViewTextBoxColumn.Name = "avgPASSTimeDataGridViewTextBoxColumn";
            // 
            // totFailDataGridViewTextBoxColumn
            // 
            this.totFailDataGridViewTextBoxColumn.DataPropertyName = "TotFail";
            this.totFailDataGridViewTextBoxColumn.HeaderText = "TotFail";
            this.totFailDataGridViewTextBoxColumn.Name = "totFailDataGridViewTextBoxColumn";
            this.totFailDataGridViewTextBoxColumn.Visible = false;
            // 
            // totHandleDataGridViewTextBoxColumn
            // 
            this.totHandleDataGridViewTextBoxColumn.DataPropertyName = "TotHandle";
            this.totHandleDataGridViewTextBoxColumn.HeaderText = "TotHandle";
            this.totHandleDataGridViewTextBoxColumn.Name = "totHandleDataGridViewTextBoxColumn";
            // 
            // buttonEnableLogin
            // 
            this.buttonEnableLogin.Location = new System.Drawing.Point(6, 20);
            this.buttonEnableLogin.Name = "buttonEnableLogin";
            this.buttonEnableLogin.Size = new System.Drawing.Size(58, 23);
            this.buttonEnableLogin.TabIndex = 39;
            this.buttonEnableLogin.Text = "Login";
            this.buttonEnableLogin.UseVisualStyleBackColor = true;
            this.buttonEnableLogin.Click += new System.EventHandler(this.buttonEnableLogin_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(87, 92);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 34);
            this.buttonDelete.TabIndex = 40;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelDev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Data MQS v1.1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMQS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyMQSDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mQSRequestDatabaseDataSet)).EndInit();
            this.groupBoxProductData.ResumeLayout(false);
            this.groupBoxProductData.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxAllInfos;
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
        private System.Windows.Forms.Button buttonEnableLogin;
        public System.Windows.Forms.Button buttonInsertDB;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonAddNew;
        public System.Windows.Forms.Button buttonDelete;
    }
}

