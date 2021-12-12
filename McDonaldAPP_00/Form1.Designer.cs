namespace McDonaldAPP_00
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label typeIDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nutritionLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label unitLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.productTypeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeDataSet = new McDonaldAPP_00.ProductTypeDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productTypeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKProductProductTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeProductDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productType_ProductDataSet = new McDonaldAPP_00.ProductType_ProductDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.productTypeTableAdapter = new McDonaldAPP_00.ProductTypeDataSetTableAdapters.ProductTypeTableAdapter();
            this.tableAdapterManager = new McDonaldAPP_00.ProductTypeDataSetTableAdapters.TableAdapterManager();
            this.productTypeTableAdapter1 = new McDonaldAPP_00.ProductType_ProductDataSetTableAdapters.ProductTypeTableAdapter();
            this.productTableAdapter = new McDonaldAPP_00.ProductType_ProductDataSetTableAdapters.ProductTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.productSearchDataSet = new McDonaldAPP_00.ProductSearchDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter1 = new McDonaldAPP_00.ProductSearchDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager1 = new McDonaldAPP_00.ProductSearchDataSetTableAdapters.TableAdapterManager();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.keywordToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.keywordToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.nutritionFactDataSet = new McDonaldAPP_00.NutritionFactDataSet();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter2 = new McDonaldAPP_00.NutritionFactDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager2 = new McDonaldAPP_00.NutritionFactDataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.typeIDTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new McDonaldAPP_00.NutritionFactDataSetTableAdapters.DataTable1TableAdapter();
            this.nutritionListBox = new System.Windows.Forms.ListBox();
            this.productDataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueListBox = new System.Windows.Forms.ListBox();
            this.productDataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitListBox = new System.Windows.Forms.ListBox();
            this.productDataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            typeIDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            nutritionLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingNavigator)).BeginInit();
            this.productTypeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductProductTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeProductDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productType_ProductDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionFactDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.productTypeBindingNavigator);
            this.tabPage1.Controls.Add(this.productTypeDataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // productTypeBindingNavigator
            // 
            this.productTypeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productTypeBindingNavigator.BindingSource = this.productTypeBindingSource;
            this.productTypeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productTypeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productTypeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productTypeBindingNavigatorSaveItem});
            this.productTypeBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.productTypeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productTypeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productTypeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productTypeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productTypeBindingNavigator.Name = "productTypeBindingNavigator";
            this.productTypeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productTypeBindingNavigator.Size = new System.Drawing.Size(821, 25);
            this.productTypeBindingNavigator.TabIndex = 1;
            this.productTypeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataMember = "ProductType";
            this.productTypeBindingSource.DataSource = this.productTypeDataSet;
            // 
            // productTypeDataSet
            // 
            this.productTypeDataSet.DataSetName = "ProductTypeDataSet";
            this.productTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productTypeBindingNavigatorSaveItem
            // 
            this.productTypeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productTypeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productTypeBindingNavigatorSaveItem.Image")));
            this.productTypeBindingNavigatorSaveItem.Name = "productTypeBindingNavigatorSaveItem";
            this.productTypeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productTypeBindingNavigatorSaveItem.Text = "儲存資料";
            this.productTypeBindingNavigatorSaveItem.Click += new System.EventHandler(this.productTypeBindingNavigatorSaveItem_Click_1);
            // 
            // productTypeDataGridView
            // 
            this.productTypeDataGridView.AutoGenerateColumns = false;
            this.productTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.productTypeDataGridView.DataSource = this.productTypeBindingSource;
            this.productTypeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productTypeDataGridView.Location = new System.Drawing.Point(3, 31);
            this.productTypeDataGridView.Name = "productTypeDataGridView";
            this.productTypeDataGridView.RowTemplate.Height = 24;
            this.productTypeDataGridView.Size = new System.Drawing.Size(821, 435);
            this.productTypeDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "typename";
            this.dataGridViewTextBoxColumn2.HeaderText = "typename";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "productlist";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fKProductProductTypeBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 443);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 42;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKProductProductTypeBindingSource
            // 
            this.fKProductProductTypeBindingSource.DataMember = "FK_Product_ProductType";
            this.fKProductProductTypeBindingSource.DataSource = this.productTypeBindingSource1;
            // 
            // productTypeBindingSource1
            // 
            this.productTypeBindingSource1.DataMember = "ProductType";
            this.productTypeBindingSource1.DataSource = this.productTypeProductDataSetBindingSource;
            // 
            // productTypeProductDataSetBindingSource
            // 
            this.productTypeProductDataSetBindingSource.DataSource = this.productType_ProductDataSet;
            this.productTypeProductDataSetBindingSource.Position = 0;
            // 
            // productType_ProductDataSet
            // 
            this.productType_ProductDataSet.DataSetName = "ProductType_ProductDataSet";
            this.productType_ProductDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.productTypeBindingSource1;
            this.comboBox1.DisplayMember = "typename";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(821, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "ID";
            // 
            // productTypeTableAdapter
            // 
            this.productTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTypeTableAdapter = this.productTypeTableAdapter;
            this.tableAdapterManager.UpdateOrder = McDonaldAPP_00.ProductTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productTypeTableAdapter1
            // 
            this.productTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fillByToolStrip);
            this.tabPage3.Controls.Add(this.productDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(827, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "searchproduct";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // productSearchDataSet
            // 
            this.productSearchDataSet.DataSetName = "ProductSearchDataSet";
            this.productSearchDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.productSearchDataSet;
            // 
            // productTableAdapter1
            // 
            this.productTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ProductTableAdapter = this.productTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = McDonaldAPP_00.ProductSearchDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productDataGridView.Location = new System.Drawing.Point(3, 31);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(821, 435);
            this.productDataGridView.TabIndex = 0;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keywordToolStripLabel,
            this.keywordToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(3, 3);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(821, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // keywordToolStripLabel
            // 
            this.keywordToolStripLabel.Name = "keywordToolStripLabel";
            this.keywordToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.keywordToolStripLabel.Text = "keyword:";
            // 
            // keywordToolStripTextBox
            // 
            this.keywordToolStripTextBox.Name = "keywordToolStripTextBox";
            this.keywordToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.fillByToolStripButton.Text = "Search";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 42;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "typeID";
            this.dataGridViewTextBoxColumn4.HeaderText = "typeID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 62;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "description";
            this.dataGridViewTextBoxColumn5.HeaderText = "description";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(unitLabel);
            this.tabPage4.Controls.Add(this.unitListBox);
            this.tabPage4.Controls.Add(valueLabel);
            this.tabPage4.Controls.Add(this.valueListBox);
            this.tabPage4.Controls.Add(nutritionLabel);
            this.tabPage4.Controls.Add(this.nutritionListBox);
            this.tabPage4.Controls.Add(this.bindingNavigator1);
            this.tabPage4.Controls.Add(iDLabel);
            this.tabPage4.Controls.Add(this.iDTextBox);
            this.tabPage4.Controls.Add(typeIDLabel);
            this.tabPage4.Controls.Add(this.typeIDTextBox);
            this.tabPage4.Controls.Add(descriptionLabel);
            this.tabPage4.Controls.Add(this.descriptionTextBox);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(827, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "nutritionfact";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // nutritionFactDataSet
            // 
            this.nutritionFactDataSet.DataSetName = "NutritionFactDataSet";
            this.nutritionFactDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataMember = "Product";
            this.productBindingSource1.DataSource = this.nutritionFactDataSet;
            // 
            // productTableAdapter2
            // 
            this.productTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.NutritionFactTableAdapter = null;
            this.tableAdapterManager2.Product_NutritionTableAdapter = null;
            this.tableAdapterManager2.ProductTableAdapter = this.productTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = McDonaldAPP_00.NutritionFactDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(180, 120);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(20, 12);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(245, 117);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(449, 22);
            this.iDTextBox.TabIndex = 1;
            // 
            // typeIDLabel
            // 
            typeIDLabel.AutoSize = true;
            typeIDLabel.Location = new System.Drawing.Point(180, 148);
            typeIDLabel.Name = "typeIDLabel";
            typeIDLabel.Size = new System.Drawing.Size(43, 12);
            typeIDLabel.TabIndex = 2;
            typeIDLabel.Text = "type ID:";
            // 
            // typeIDTextBox
            // 
            this.typeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "typeID", true));
            this.typeIDTextBox.Location = new System.Drawing.Point(245, 145);
            this.typeIDTextBox.Name = "typeIDTextBox";
            this.typeIDTextBox.Size = new System.Drawing.Size(449, 22);
            this.typeIDTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(180, 176);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(59, 12);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource1, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(245, 173);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(449, 22);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.productBindingSource1;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(821, 25);
            this.bindingNavigator1.TabIndex = 6;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "位置";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem1.Text = "/{0}";
            this.bindingNavigatorCountItem1.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "刪除";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "Product_DataTable1";
            this.dataTable1BindingSource.DataSource = this.productBindingSource1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // nutritionLabel
            // 
            nutritionLabel.AutoSize = true;
            nutritionLabel.Location = new System.Drawing.Point(191, 223);
            nutritionLabel.Name = "nutritionLabel";
            nutritionLabel.Size = new System.Drawing.Size(48, 12);
            nutritionLabel.TabIndex = 7;
            nutritionLabel.Text = "nutrition:";
            // 
            // nutritionListBox
            // 
            this.nutritionListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataTable1BindingSource, "nutrition", true));
            this.nutritionListBox.DataSource = this.productDataTable1BindingSource;
            this.nutritionListBox.DisplayMember = "nutrition";
            this.nutritionListBox.FormattingEnabled = true;
            this.nutritionListBox.ItemHeight = 12;
            this.nutritionListBox.Location = new System.Drawing.Point(245, 223);
            this.nutritionListBox.Name = "nutritionListBox";
            this.nutritionListBox.Size = new System.Drawing.Size(120, 184);
            this.nutritionListBox.TabIndex = 8;
            this.nutritionListBox.ValueMember = "nutrition";
            // 
            // productDataTable1BindingSource
            // 
            this.productDataTable1BindingSource.DataMember = "Product_DataTable1";
            this.productDataTable1BindingSource.DataSource = this.productBindingSource1;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new System.Drawing.Point(374, 223);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(33, 12);
            valueLabel.TabIndex = 9;
            valueLabel.Text = "value:";
            // 
            // valueListBox
            // 
            this.valueListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productDataTable1BindingSource, "value", true));
            this.valueListBox.DataSource = this.productDataTable1BindingSource1;
            this.valueListBox.DisplayMember = "value";
            this.valueListBox.FormattingEnabled = true;
            this.valueListBox.ItemHeight = 12;
            this.valueListBox.Location = new System.Drawing.Point(413, 223);
            this.valueListBox.Name = "valueListBox";
            this.valueListBox.Size = new System.Drawing.Size(120, 184);
            this.valueListBox.TabIndex = 10;
            this.valueListBox.ValueMember = "value";
            // 
            // productDataTable1BindingSource1
            // 
            this.productDataTable1BindingSource1.DataMember = "Product_DataTable1";
            this.productDataTable1BindingSource1.DataSource = this.productBindingSource1;
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(542, 223);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(26, 12);
            unitLabel.TabIndex = 11;
            unitLabel.Text = "unit:";
            // 
            // unitListBox
            // 
            this.unitListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productDataTable1BindingSource, "unit", true));
            this.unitListBox.DataSource = this.productDataTable1BindingSource2;
            this.unitListBox.DisplayMember = "unit";
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.ItemHeight = 12;
            this.unitListBox.Location = new System.Drawing.Point(574, 223);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(120, 184);
            this.unitListBox.TabIndex = 12;
            this.unitListBox.ValueMember = "unit";
            // 
            // productDataTable1BindingSource2
            // 
            this.productDataTable1BindingSource2.DataMember = "Product_DataTable1";
            this.productDataTable1BindingSource2.DataSource = this.productBindingSource1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingNavigator)).EndInit();
            this.productTypeBindingNavigator.ResumeLayout(false);
            this.productTypeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKProductProductTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeProductDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productType_ProductDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSearchDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutritionFactDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataTable1BindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ProductTypeDataSet productTypeDataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private ProductTypeDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter;
        private ProductTypeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productTypeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productTypeBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource productTypeProductDataSetBindingSource;
        private ProductType_ProductDataSet productType_ProductDataSet;
        private System.Windows.Forms.BindingSource productTypeBindingSource1;
        private ProductType_ProductDataSetTableAdapters.ProductTypeTableAdapter productTypeTableAdapter1;
        private System.Windows.Forms.BindingSource fKProductProductTypeBindingSource;
        private ProductType_ProductDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPage3;
        private ProductSearchDataSet productSearchDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private ProductSearchDataSetTableAdapters.ProductTableAdapter productTableAdapter1;
        private ProductSearchDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel keywordToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox keywordToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage4;
        private NutritionFactDataSet nutritionFactDataSet;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private NutritionFactDataSetTableAdapters.ProductTableAdapter productTableAdapter2;
        private NutritionFactDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox typeIDTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private NutritionFactDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ListBox nutritionListBox;
        private System.Windows.Forms.BindingSource productDataTable1BindingSource;
        private System.Windows.Forms.ListBox unitListBox;
        private System.Windows.Forms.BindingSource productDataTable1BindingSource2;
        private System.Windows.Forms.ListBox valueListBox;
        private System.Windows.Forms.BindingSource productDataTable1BindingSource1;
    }
}

