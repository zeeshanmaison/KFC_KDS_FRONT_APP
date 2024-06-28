
namespace MCKDS
{
    partial class OrderGridForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderGridForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panOrders = new MetroFramework.Controls.MetroPanel();
            this.panSummary = new System.Windows.Forms.Panel();
            this.mGridSummary = new MetroFramework.Controls.MetroGrid();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCKDSDataSet2 = new MCKDS.MCKDSDataSet2();
            this.lblErrorMSG = new System.Windows.Forms.Label();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.orderNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDSOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCKDSDataSetOrder1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCKDSDataSetOrder1 = new MCKDS.MCKDSDataSetOrder();
            this.mCKDSDataSet1 = new MCKDS.MCKDSDataSet1();
            this.btnRefreshScreen = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDataRefresh = new System.Windows.Forms.Timer(this.components);
            this.panTitle = new MetroFramework.Controls.MetroPanel();
            this.chkHideHoldOrders = new System.Windows.Forms.CheckBox();
            this.lblCustomStationName = new System.Windows.Forms.Label();
            this.TodayTime = new System.Windows.Forms.Label();
            this.lblTotalOrder = new System.Windows.Forms.Label();
            this.lblCurrentOrderNo = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroGrid2 = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersTableAdapter = new MCKDS.MCKDSDataSetOrderTableAdapters.OrdersTableAdapter();
            this.itemDetailsTableAdapter = new MCKDS.MCKDSDataSet2TableAdapters.ItemDetailsTableAdapter();
            this.panOrders.SuspendLayout();
            this.panSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGridSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSetOrder1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSetOrder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet1)).BeginInit();
            this.panTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panOrders
            // 
            this.panOrders.BackColor = System.Drawing.Color.Transparent;
            this.panOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panOrders.BackgroundImage")));
            this.panOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panOrders.Controls.Add(this.panSummary);
            this.panOrders.Controls.Add(this.lblErrorMSG);
            this.panOrders.Controls.Add(this.metroGrid1);
            this.panOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panOrders.HorizontalScrollbarBarColor = true;
            this.panOrders.HorizontalScrollbarHighlightOnWheel = false;
            this.panOrders.HorizontalScrollbarSize = 10;
            this.panOrders.Location = new System.Drawing.Point(20, 120);
            this.panOrders.Name = "panOrders";
            this.panOrders.Size = new System.Drawing.Size(645, 362);
            this.panOrders.TabIndex = 0;
            this.panOrders.VerticalScrollbarBarColor = true;
            this.panOrders.VerticalScrollbarHighlightOnWheel = false;
            this.panOrders.VerticalScrollbarSize = 10;
            this.panOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.panOrders_Paint);
            // 
            // panSummary
            // 
            this.panSummary.BackColor = System.Drawing.Color.Transparent;
            this.panSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSummary.Controls.Add(this.mGridSummary);
            this.panSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.panSummary.Location = new System.Drawing.Point(479, 0);
            this.panSummary.Name = "panSummary";
            this.panSummary.Size = new System.Drawing.Size(166, 362);
            this.panSummary.TabIndex = 20;
            this.panSummary.Visible = false;
            // 
            // mGridSummary
            // 
            this.mGridSummary.AllowUserToAddRows = false;
            this.mGridSummary.AllowUserToDeleteRows = false;
            this.mGridSummary.AllowUserToOrderColumns = true;
            this.mGridSummary.AllowUserToResizeColumns = false;
            this.mGridSummary.AllowUserToResizeRows = false;
            this.mGridSummary.AutoGenerateColumns = false;
            this.mGridSummary.BackgroundColor = System.Drawing.Color.White;
            this.mGridSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridSummary.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridSummary.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mGridSummary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridSummary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridSummary.ColumnHeadersHeight = 35;
            this.mGridSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.mGridSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.SCategory,
            this.Summary});
            this.mGridSummary.DataSource = this.itemDetailsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridSummary.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridSummary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mGridSummary.Enabled = false;
            this.mGridSummary.EnableHeadersVisualStyles = false;
            this.mGridSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridSummary.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mGridSummary.Location = new System.Drawing.Point(7, -1);
            this.mGridSummary.Name = "mGridSummary";
            this.mGridSummary.ReadOnly = true;
            this.mGridSummary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridSummary.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridSummary.RowHeadersVisible = false;
            this.mGridSummary.RowHeadersWidth = 45;
            this.mGridSummary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridSummary.RowTemplate.Height = 30;
            this.mGridSummary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mGridSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridSummary.Size = new System.Drawing.Size(147, 649);
            this.mGridSummary.TabIndex = 20;
            this.mGridSummary.TabStop = false;
            this.mGridSummary.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.mGridSummary_CellFormatting);
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            this.categoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // SCategory
            // 
            this.SCategory.DataPropertyName = "SCategory";
            this.SCategory.HeaderText = "SCategory";
            this.SCategory.MinimumWidth = 8;
            this.SCategory.Name = "SCategory";
            this.SCategory.ReadOnly = true;
            this.SCategory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SCategory.Visible = false;
            this.SCategory.Width = 150;
            // 
            // Summary
            // 
            this.Summary.DataPropertyName = "SCategory";
            this.Summary.HeaderText = "Summary";
            this.Summary.MinimumWidth = 8;
            this.Summary.Name = "Summary";
            this.Summary.ReadOnly = true;
            this.Summary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Summary.Width = 200;
            // 
            // itemDetailsBindingSource
            // 
            this.itemDetailsBindingSource.DataMember = "ItemDetails";
            this.itemDetailsBindingSource.DataSource = this.mCKDSDataSet2;
            // 
            // mCKDSDataSet2
            // 
            this.mCKDSDataSet2.DataSetName = "MCKDSDataSet2";
            this.mCKDSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblErrorMSG
            // 
            this.lblErrorMSG.AutoSize = true;
            this.lblErrorMSG.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMSG.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMSG.Location = new System.Drawing.Point(509, 270);
            this.lblErrorMSG.Name = "lblErrorMSG";
            this.lblErrorMSG.Size = new System.Drawing.Size(108, 42);
            this.lblErrorMSG.TabIndex = 3;
            this.lblErrorMSG.Text = "label2";
            this.lblErrorMSG.Visible = false;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNoDataGridViewTextBoxColumn,
            this.orderTypeDataGridViewTextBoxColumn,
            this.createdOnDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.OrderTime,
            this.TransactionType,
            this.OrderSource,
            this.HDSOrderId,
            this.OrderState,
            this.NextOrderStatus});
            this.metroGrid1.DataSource = this.ordersBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(1060, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 62;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(152, 446);
            this.metroGrid1.TabIndex = 2;
            this.metroGrid1.Visible = false;
            // 
            // orderNoDataGridViewTextBoxColumn
            // 
            this.orderNoDataGridViewTextBoxColumn.DataPropertyName = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.HeaderText = "OrderNo";
            this.orderNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderNoDataGridViewTextBoxColumn.Name = "orderNoDataGridViewTextBoxColumn";
            this.orderNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderTypeDataGridViewTextBoxColumn
            // 
            this.orderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType";
            this.orderTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderTypeDataGridViewTextBoxColumn.Name = "orderTypeDataGridViewTextBoxColumn";
            this.orderTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // createdOnDataGridViewTextBoxColumn
            // 
            this.createdOnDataGridViewTextBoxColumn.DataPropertyName = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.HeaderText = "CreatedOn";
            this.createdOnDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.createdOnDataGridViewTextBoxColumn.Name = "createdOnDataGridViewTextBoxColumn";
            this.createdOnDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderStatusDataGridViewTextBoxColumn
            // 
            this.orderStatusDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.HeaderText = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderStatusDataGridViewTextBoxColumn.Name = "orderStatusDataGridViewTextBoxColumn";
            this.orderStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // OrderTime
            // 
            this.OrderTime.DataPropertyName = "OrderTime";
            this.OrderTime.HeaderText = "OrderTime";
            this.OrderTime.MinimumWidth = 8;
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            this.OrderTime.Width = 150;
            // 
            // TransactionType
            // 
            this.TransactionType.DataPropertyName = "TransactionType";
            this.TransactionType.HeaderText = "TransactionType";
            this.TransactionType.MinimumWidth = 8;
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.Width = 150;
            // 
            // OrderSource
            // 
            this.OrderSource.DataPropertyName = "OrderSource";
            this.OrderSource.HeaderText = "OrderSource";
            this.OrderSource.MinimumWidth = 8;
            this.OrderSource.Name = "OrderSource";
            this.OrderSource.Width = 150;
            // 
            // HDSOrderId
            // 
            this.HDSOrderId.DataPropertyName = "HDSOrderId";
            this.HDSOrderId.HeaderText = "HDSOrderId";
            this.HDSOrderId.MinimumWidth = 8;
            this.HDSOrderId.Name = "HDSOrderId";
            this.HDSOrderId.Width = 150;
            // 
            // OrderState
            // 
            this.OrderState.DataPropertyName = "OrderState";
            this.OrderState.HeaderText = "OrderState";
            this.OrderState.MinimumWidth = 8;
            this.OrderState.Name = "OrderState";
            this.OrderState.Width = 150;
            // 
            // NextOrderStatus
            // 
            this.NextOrderStatus.DataPropertyName = "NextOrderStatus";
            this.NextOrderStatus.HeaderText = "NextOrderStatus";
            this.NextOrderStatus.MinimumWidth = 8;
            this.NextOrderStatus.Name = "NextOrderStatus";
            this.NextOrderStatus.Width = 150;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.mCKDSDataSetOrder1BindingSource;
            // 
            // mCKDSDataSetOrder1BindingSource
            // 
            this.mCKDSDataSetOrder1BindingSource.DataSource = this.mCKDSDataSetOrder1;
            this.mCKDSDataSetOrder1BindingSource.Position = 0;
            // 
            // mCKDSDataSetOrder1
            // 
            this.mCKDSDataSetOrder1.DataSetName = "MCKDSDataSetOrder";
            this.mCKDSDataSetOrder1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mCKDSDataSet1
            // 
            this.mCKDSDataSet1.DataSetName = "MCKDSDataSet1";
            this.mCKDSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefreshScreen
            // 
            this.btnRefreshScreen.Location = new System.Drawing.Point(1083, 34);
            this.btnRefreshScreen.Name = "btnRefreshScreen";
            this.btnRefreshScreen.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshScreen.TabIndex = 4;
            this.btnRefreshScreen.Text = "Refresh";
            this.btnRefreshScreen.UseSelectable = true;
            this.btnRefreshScreen.Visible = false;
            this.btnRefreshScreen.Click += new System.EventHandler(this.btnRefreshScreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // tmrDataRefresh
            // 
            this.tmrDataRefresh.Interval = 3000;
            this.tmrDataRefresh.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panTitle
            // 
            this.panTitle.BackColor = System.Drawing.Color.Transparent;
            this.panTitle.Controls.Add(this.chkHideHoldOrders);
            this.panTitle.Controls.Add(this.lblCustomStationName);
            this.panTitle.Controls.Add(this.TodayTime);
            this.panTitle.Controls.Add(this.lblTotalOrder);
            this.panTitle.Controls.Add(this.lblCurrentOrderNo);
            this.panTitle.Controls.Add(this.lblFormTitle);
            this.panTitle.Controls.Add(this.metroPanel2);
            this.panTitle.Controls.Add(this.metroGrid2);
            this.panTitle.HorizontalScrollbarBarColor = true;
            this.panTitle.HorizontalScrollbarHighlightOnWheel = false;
            this.panTitle.HorizontalScrollbarSize = 10;
            this.panTitle.Location = new System.Drawing.Point(23, 20);
            this.panTitle.Name = "panTitle";
            this.panTitle.Size = new System.Drawing.Size(1051, 100);
            this.panTitle.TabIndex = 15;
            this.panTitle.VerticalScrollbarBarColor = true;
            this.panTitle.VerticalScrollbarHighlightOnWheel = false;
            this.panTitle.VerticalScrollbarSize = 10;
            // 
            // chkHideHoldOrders
            // 
            this.chkHideHoldOrders.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkHideHoldOrders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkHideHoldOrders.BackgroundImage")));
            this.chkHideHoldOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkHideHoldOrders.Location = new System.Drawing.Point(106, 72);
            this.chkHideHoldOrders.Name = "chkHideHoldOrders";
            this.chkHideHoldOrders.Size = new System.Drawing.Size(33, 28);
            this.chkHideHoldOrders.TabIndex = 17;
            this.chkHideHoldOrders.UseVisualStyleBackColor = true;
            this.chkHideHoldOrders.Visible = false;
            this.chkHideHoldOrders.CheckedChanged += new System.EventHandler(this.chkHideHoldOrders_CheckedChanged);
            // 
            // lblCustomStationName
            // 
            this.lblCustomStationName.AutoSize = true;
            this.lblCustomStationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomStationName.ForeColor = System.Drawing.Color.Red;
            this.lblCustomStationName.Location = new System.Drawing.Point(571, 36);
            this.lblCustomStationName.Name = "lblCustomStationName";
            this.lblCustomStationName.Size = new System.Drawing.Size(48, 42);
            this.lblCustomStationName.TabIndex = 18;
            this.lblCustomStationName.Text = "...";
            this.lblCustomStationName.Visible = false;
            // 
            // TodayTime
            // 
            this.TodayTime.AutoSize = true;
            this.TodayTime.Location = new System.Drawing.Point(668, 81);
            this.TodayTime.Name = "TodayTime";
            this.TodayTime.Size = new System.Drawing.Size(30, 13);
            this.TodayTime.TabIndex = 14;
            this.TodayTime.Text = "Time";
            this.TodayTime.Visible = false;
            // 
            // lblTotalOrder
            // 
            this.lblTotalOrder.AutoSize = true;
            this.lblTotalOrder.Location = new System.Drawing.Point(14, 81);
            this.lblTotalOrder.Name = "lblTotalOrder";
            this.lblTotalOrder.Size = new System.Drawing.Size(65, 13);
            this.lblTotalOrder.TabIndex = 13;
            this.lblTotalOrder.Text = "Total Orders";
            // 
            // lblCurrentOrderNo
            // 
            this.lblCurrentOrderNo.AutoSize = true;
            this.lblCurrentOrderNo.Location = new System.Drawing.Point(338, 81);
            this.lblCurrentOrderNo.Name = "lblCurrentOrderNo";
            this.lblCurrentOrderNo.Size = new System.Drawing.Size(84, 13);
            this.lblCurrentOrderNo.TabIndex = 12;
            this.lblCurrentOrderNo.Text = "Selected Order: ";
            this.lblCurrentOrderNo.Visible = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(96, 23);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(285, 55);
            this.lblFormTitle.TabIndex = 11;
            this.lblFormTitle.Text = "KDS Station";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel2.BackgroundImage")));
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(87, 78);
            this.metroPanel2.TabIndex = 10;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroGrid2
            // 
            this.metroGrid2.AllowUserToResizeRows = false;
            this.metroGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid2.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid2.EnableHeadersVisualStyles = false;
            this.metroGrid2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid2.Location = new System.Drawing.Point(613, 205);
            this.metroGrid2.Name = "metroGrid2";
            this.metroGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid2.RowHeadersWidth = 62;
            this.metroGrid2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid2.Size = new System.Drawing.Size(128, 102);
            this.metroGrid2.TabIndex = 2;
            this.metroGrid2.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Order";
            this.dataGridViewTextBoxColumn6.HeaderText = "Order";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Type";
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Created On";
            this.dataGridViewTextBoxColumn8.HeaderText = "Created On";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn9.HeaderText = "Status";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // itemDetailsTableAdapter
            // 
            this.itemDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // OrderGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(685, 502);
            this.Controls.Add(this.panTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshScreen);
            this.Controls.Add(this.panOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "OrderGridForm";
            this.Padding = new System.Windows.Forms.Padding(20, 120, 20, 20);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "KDS";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderGridForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderGridForm_Load);
            this.Shown += new System.EventHandler(this.OrderGridForm_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderGridForm_KeyPress);
            this.panOrders.ResumeLayout(false);
            this.panOrders.PerformLayout();
            this.panSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mGridSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSetOrder1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSetOrder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet1)).EndInit();
            this.panTitle.ResumeLayout(false);
            this.panTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panOrders;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnRefreshScreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrDataRefresh;
        private MetroFramework.Controls.MetroPanel panTitle;
        private System.Windows.Forms.Label TodayTime;
        private System.Windows.Forms.Label lblTotalOrder;
        private System.Windows.Forms.Label lblCurrentOrderNo;
        private System.Windows.Forms.Label lblFormTitle;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid metroGrid2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private MCKDSDataSetOrderTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private MCKDSDataSetOrder mCKDSDataSetOrder1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource mCKDSDataSetOrder1BindingSource;
        private System.Windows.Forms.Label lblErrorMSG;
        private System.Windows.Forms.CheckBox chkHideHoldOrders;
        private System.Windows.Forms.Label lblCustomStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDSOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderState;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextOrderStatus;
        private MCKDSDataSet1 mCKDSDataSet1;
        private MCKDSDataSet2 mCKDSDataSet2;
        private System.Windows.Forms.BindingSource itemDetailsBindingSource;
        private MCKDSDataSet2TableAdapters.ItemDetailsTableAdapter itemDetailsTableAdapter;
        private System.Windows.Forms.Panel panSummary;
        private MetroFramework.Controls.MetroGrid mGridSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summary;
    }
}