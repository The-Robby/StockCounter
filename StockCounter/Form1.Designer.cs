namespace StockCounter
{
    partial class Form1
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
            this.amnt_prod = new System.Windows.Forms.NumericUpDown();
            this.productBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newcnnData = new StockCounter.newcnnData();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_prod = new System.Windows.Forms.ComboBox();
            this.correctMainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bar_prod = new System.Windows.Forms.ComboBox();
            this.type_prod = new System.Windows.Forms.ComboBox();
            this.typesBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newcnnDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lblIfConnected = new System.Windows.Forms.Label();
            this.productBETableAdapter = new StockCounter.newcnnDataTableAdapters.ProductBETableAdapter();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hulpnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leverancier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_update = new System.Windows.Forms.Label();
            this.label_save = new System.Windows.Forms.Label();
            this.btn_remove_one = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_check_low = new System.Windows.Forms.Button();
            this.lever_prod = new System.Windows.Forms.ComboBox();
            this.leverancierBEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hulpnr_prod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productBEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.leverancierBETableAdapter = new StockCounter.newcnnDataTableAdapters.LeverancierBETableAdapter();
            this.typesBETableAdapter = new StockCounter.newcnnDataTableAdapters.TypesBETableAdapter();
            this.checkstock_prod = new System.Windows.Forms.NumericUpDown();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.leverancierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delLev = new System.Windows.Forms.Button();
            this.btn_delType = new System.Windows.Forms.Button();
            this.correctMainTableAdapter = new StockCounter.newcnnDataTableAdapters.CorrectMainTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.amnt_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcnnData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctMainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcnnDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leverancierBEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkstock_prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // amnt_prod
            // 
            this.amnt_prod.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.correctMainBindingSource, "StockCount", true));
            this.amnt_prod.Location = new System.Drawing.Point(725, 165);
            this.amnt_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amnt_prod.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.amnt_prod.Name = "amnt_prod";
            this.amnt_prod.Size = new System.Drawing.Size(160, 22);
            this.amnt_prod.TabIndex = 2;
            this.amnt_prod.ValueChanged += new System.EventHandler(this.amnt_prod_ValueChanged);
            // 
            // productBEBindingSource
            // 
            this.productBEBindingSource.DataMember = "ProductBE";
            this.productBEBindingSource.DataSource = this.newcnnData;
            // 
            // newcnnData
            // 
            this.newcnnData.DataSetName = "newcnnData";
            this.newcnnData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name of product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Scan the barcode and triple check you didn\'t alter the scan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Type of product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount in stock";
            // 
            // name_prod
            // 
            this.name_prod.DataSource = this.correctMainBindingSource;
            this.name_prod.DisplayMember = "Name";
            this.name_prod.FormattingEnabled = true;
            this.name_prod.Location = new System.Drawing.Point(259, 113);
            this.name_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.name_prod.Name = "name_prod";
            this.name_prod.Size = new System.Drawing.Size(407, 24);
            this.name_prod.TabIndex = 8;
            this.name_prod.SelectedIndexChanged += new System.EventHandler(this.name_prod_SelectedIndexChanged);
            // 
            // correctMainBindingSource
            // 
            this.correctMainBindingSource.DataMember = "CorrectMain";
            this.correctMainBindingSource.DataSource = this.newcnnData;
            // 
            // bar_prod
            // 
            this.bar_prod.DataSource = this.correctMainBindingSource;
            this.bar_prod.DisplayMember = "Barcode";
            this.bar_prod.FormattingEnabled = true;
            this.bar_prod.Location = new System.Drawing.Point(259, 60);
            this.bar_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bar_prod.Name = "bar_prod";
            this.bar_prod.Size = new System.Drawing.Size(407, 24);
            this.bar_prod.TabIndex = 9;
            this.bar_prod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bar_prod_KeyDown);
            // 
            // type_prod
            // 
            this.type_prod.DataSource = this.typesBEBindingSource;
            this.type_prod.DisplayMember = "Type";
            this.type_prod.FormattingEnabled = true;
            this.type_prod.Location = new System.Drawing.Point(259, 164);
            this.type_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.type_prod.Name = "type_prod";
            this.type_prod.Size = new System.Drawing.Size(407, 24);
            this.type_prod.TabIndex = 10;
            // 
            // typesBEBindingSource
            // 
            this.typesBEBindingSource.DataMember = "TypesBE";
            this.typesBEBindingSource.DataSource = this.newcnnDataBindingSource;
            // 
            // newcnnDataBindingSource
            // 
            this.newcnnDataBindingSource.DataSource = this.newcnnData;
            this.newcnnDataBindingSource.Position = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn_save.Location = new System.Drawing.Point(59, 15);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 54);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_connect.Location = new System.Drawing.Point(59, 94);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(100, 57);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "Connect with DB";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lblIfConnected
            // 
            this.lblIfConnected.AutoSize = true;
            this.lblIfConnected.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::StockCounter.Properties.Settings.Default, "Connectionlbl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblIfConnected.Location = new System.Drawing.Point(59, 154);
            this.lblIfConnected.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIfConnected.Name = "lblIfConnected";
            this.lblIfConnected.Size = new System.Drawing.Size(113, 16);
            this.lblIfConnected.TabIndex = 13;
            this.lblIfConnected.Text = global::StockCounter.Properties.Settings.Default.Connectionlbl;
            this.lblIfConnected.Click += new System.EventHandler(this.lblIfConnected_Click);
            // 
            // productBETableAdapter
            // 
            this.productBETableAdapter.ClearBeforeFill = true;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_update.Location = new System.Drawing.Point(59, 174);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 57);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update DB";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hulpnummerDataGridViewTextBoxColumn,
            this.stockCountDataGridViewTextBoxColumn,
            this.Type,
            this.Leverancier});
            this.dataGridView1.DataSource = this.correctMainBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 257);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(943, 566);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // barcodeDataGridViewTextBoxColumn
            // 
            this.barcodeDataGridViewTextBoxColumn.DataPropertyName = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.HeaderText = "Barcode";
            this.barcodeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.barcodeDataGridViewTextBoxColumn.Name = "barcodeDataGridViewTextBoxColumn";
            this.barcodeDataGridViewTextBoxColumn.Width = 85;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 70;
            // 
            // hulpnummerDataGridViewTextBoxColumn
            // 
            this.hulpnummerDataGridViewTextBoxColumn.DataPropertyName = "Hulpnummer";
            this.hulpnummerDataGridViewTextBoxColumn.HeaderText = "Hulpnummer";
            this.hulpnummerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hulpnummerDataGridViewTextBoxColumn.Name = "hulpnummerDataGridViewTextBoxColumn";
            this.hulpnummerDataGridViewTextBoxColumn.Width = 109;
            // 
            // stockCountDataGridViewTextBoxColumn
            // 
            this.stockCountDataGridViewTextBoxColumn.DataPropertyName = "StockCount";
            this.stockCountDataGridViewTextBoxColumn.HeaderText = "StockCount";
            this.stockCountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stockCountDataGridViewTextBoxColumn.Name = "stockCountDataGridViewTextBoxColumn";
            this.stockCountDataGridViewTextBoxColumn.Width = 101;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 65;
            // 
            // Leverancier
            // 
            this.Leverancier.DataPropertyName = "Leverancier";
            this.Leverancier.HeaderText = "Leverancier";
            this.Leverancier.Name = "Leverancier";
            this.Leverancier.Width = 104;
            // 
            // productBEBindingSource1
            // 
            this.productBEBindingSource1.DataMember = "ProductBE";
            this.productBEBindingSource1.DataSource = this.newcnnData;
            // 
            // label_update
            // 
            this.label_update.AutoSize = true;
            this.label_update.Location = new System.Drawing.Point(59, 234);
            this.label_update.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_update.Name = "label_update";
            this.label_update.Size = new System.Drawing.Size(192, 16);
            this.label_update.TabIndex = 16;
            this.label_update.Text = "Only for name or type changes!";
            // 
            // label_save
            // 
            this.label_save.AutoSize = true;
            this.label_save.Location = new System.Drawing.Point(59, 74);
            this.label_save.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_save.Name = "label_save";
            this.label_save.Size = new System.Drawing.Size(118, 16);
            this.label_save.TabIndex = 17;
            this.label_save.Text = "Only for new items!";
            // 
            // btn_remove_one
            // 
            this.btn_remove_one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_remove_one.Location = new System.Drawing.Point(1264, 15);
            this.btn_remove_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_remove_one.Name = "btn_remove_one";
            this.btn_remove_one.Size = new System.Drawing.Size(228, 201);
            this.btn_remove_one.TabIndex = 18;
            this.btn_remove_one.Text = "Remove 1 out of storage";
            this.btn_remove_one.UseVisualStyleBackColor = false;
            this.btn_remove_one.Click += new System.EventHandler(this.btn_remove_one_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_refresh.Location = new System.Drawing.Point(303, 201);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(147, 49);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.Location = new System.Drawing.Point(457, 201);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(147, 49);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "Delete product";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_check_low
            // 
            this.btn_check_low.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_check_low.Location = new System.Drawing.Point(893, 143);
            this.btn_check_low.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_check_low.Name = "btn_check_low";
            this.btn_check_low.Size = new System.Drawing.Size(160, 49);
            this.btn_check_low.TabIndex = 21;
            this.btn_check_low.Text = "Check which ones are low on stock";
            this.btn_check_low.UseVisualStyleBackColor = false;
            this.btn_check_low.Click += new System.EventHandler(this.btn_check_low_Click);
            // 
            // lever_prod
            // 
            this.lever_prod.DataSource = this.leverancierBEBindingSource;
            this.lever_prod.DisplayMember = "Leverancier";
            this.lever_prod.FormattingEnabled = true;
            this.lever_prod.Location = new System.Drawing.Point(725, 60);
            this.lever_prod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lever_prod.Name = "lever_prod";
            this.lever_prod.Size = new System.Drawing.Size(297, 24);
            this.lever_prod.TabIndex = 22;
            // 
            // leverancierBEBindingSource
            // 
            this.leverancierBEBindingSource.DataMember = "LeverancierBE";
            this.leverancierBEBindingSource.DataSource = this.newcnnDataBindingSource;
            // 
            // hulpnr_prod
            // 
            this.hulpnr_prod.DataSource = this.correctMainBindingSource;
            this.hulpnr_prod.DisplayMember = "Hulpnummer";
            this.hulpnr_prod.FormattingEnabled = true;
            this.hulpnr_prod.Location = new System.Drawing.Point(725, 111);
            this.hulpnr_prod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hulpnr_prod.Name = "hulpnr_prod";
            this.hulpnr_prod.Size = new System.Drawing.Size(297, 24);
            this.hulpnr_prod.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(725, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Leverancier";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(725, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hulpnummer";
            // 
            // productBEBindingSource2
            // 
            this.productBEBindingSource2.DataMember = "ProductBE";
            this.productBEBindingSource2.DataSource = this.newcnnDataBindingSource;
            // 
            // leverancierBETableAdapter
            // 
            this.leverancierBETableAdapter.ClearBeforeFill = true;
            // 
            // typesBETableAdapter
            // 
            this.typesBETableAdapter.ClearBeforeFill = true;
            // 
            // checkstock_prod
            // 
            this.checkstock_prod.Location = new System.Drawing.Point(1033, 158);
            this.checkstock_prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkstock_prod.Name = "checkstock_prod";
            this.checkstock_prod.Size = new System.Drawing.Size(45, 22);
            this.checkstock_prod.TabIndex = 26;
            this.checkstock_prod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.typesBEBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(1009, 257);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(237, 566);
            this.dataGridView2.TabIndex = 27;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 65;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.leverancierDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.leverancierBEBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(1255, 257);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(237, 566);
            this.dataGridView3.TabIndex = 28;
            // 
            // leverancierDataGridViewTextBoxColumn
            // 
            this.leverancierDataGridViewTextBoxColumn.DataPropertyName = "Leverancier";
            this.leverancierDataGridViewTextBoxColumn.HeaderText = "Leverancier";
            this.leverancierDataGridViewTextBoxColumn.Name = "leverancierDataGridViewTextBoxColumn";
            this.leverancierDataGridViewTextBoxColumn.ReadOnly = true;
            this.leverancierDataGridViewTextBoxColumn.Width = 104;
            // 
            // btn_delLev
            // 
            this.btn_delLev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delLev.Location = new System.Drawing.Point(1255, 226);
            this.btn_delLev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delLev.Name = "btn_delLev";
            this.btn_delLev.Size = new System.Drawing.Size(141, 30);
            this.btn_delLev.TabIndex = 30;
            this.btn_delLev.Text = "Delete Leverancier";
            this.btn_delLev.UseVisualStyleBackColor = false;
            this.btn_delLev.Click += new System.EventHandler(this.btn_delLev_Click);
            // 
            // btn_delType
            // 
            this.btn_delType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delType.Location = new System.Drawing.Point(1009, 226);
            this.btn_delType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delType.Name = "btn_delType";
            this.btn_delType.Size = new System.Drawing.Size(141, 30);
            this.btn_delType.TabIndex = 32;
            this.btn_delType.Text = "Delete Type";
            this.btn_delType.UseVisualStyleBackColor = false;
            this.btn_delType.Click += new System.EventHandler(this.btn_delType_Click);
            // 
            // correctMainTableAdapter
            // 
            this.correctMainTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1508, 849);
            this.Controls.Add(this.btn_delType);
            this.Controls.Add(this.btn_delLev);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.checkstock_prod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hulpnr_prod);
            this.Controls.Add(this.lever_prod);
            this.Controls.Add(this.btn_check_low);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_remove_one);
            this.Controls.Add(this.label_save);
            this.Controls.Add(this.label_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lblIfConnected);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.type_prod);
            this.Controls.Add(this.bar_prod);
            this.Controls.Add(this.name_prod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amnt_prod);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Stock Counter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amnt_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcnnData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctMainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcnnDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leverancierBEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkstock_prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown amnt_prod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox name_prod;
        private System.Windows.Forms.ComboBox bar_prod;
        private System.Windows.Forms.ComboBox type_prod;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lblIfConnected;
        private newcnnData newcnnData;
        private System.Windows.Forms.BindingSource productBEBindingSource;
        private newcnnDataTableAdapters.ProductBETableAdapter productBETableAdapter;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource productBEBindingSource1;
        private System.Windows.Forms.Label label_update;
        private System.Windows.Forms.Label label_save;
        private System.Windows.Forms.Button btn_remove_one;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_check_low;
        private System.Windows.Forms.ComboBox lever_prod;
        private System.Windows.Forms.ComboBox hulpnr_prod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource newcnnDataBindingSource;
        private System.Windows.Forms.BindingSource productBEBindingSource2;
        private System.Windows.Forms.BindingSource leverancierBEBindingSource;
        private newcnnDataTableAdapters.LeverancierBETableAdapter leverancierBETableAdapter;
        private System.Windows.Forms.BindingSource typesBEBindingSource;
        private newcnnDataTableAdapters.TypesBETableAdapter typesBETableAdapter;
        private System.Windows.Forms.NumericUpDown checkstock_prod;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_delLev;
        private System.Windows.Forms.Button btn_delType;
        private System.Windows.Forms.BindingSource correctMainBindingSource;
        private newcnnDataTableAdapters.CorrectMainTableAdapter correctMainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hulpnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leverancier;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leverancierDataGridViewTextBoxColumn;
    }
}

