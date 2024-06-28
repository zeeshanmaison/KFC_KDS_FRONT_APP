
namespace MCKDS
{
    partial class FryingStation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FryingStation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mCKDSDataSet = new MCKDS.MCKDSDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CurRow = new System.Windows.Forms.Label();
            this.CurrentTimePeriod = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmRefreshScreen = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblErrorMSG = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemTableAdapter1 = new MCKDS.MCKDSDataSetTableAdapters.ItemTableAdapter();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectedQty2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectedQty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProjectedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CumulativeFriedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NeedtoFry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnHand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FriedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSlot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slot2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeight = 60;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Unit,
            this.ProjectedQty2,
            this.ProjectedQty1,
            this.ProjectedQty,
            this.CumulativeFriedQty,
            this.NeedtoFry,
            this.OnHand,
            this.FriedQty,
            this.ItemId,
            this.DateFrom,
            this.DateTo,
            this.CATEGORY,
            this.CSlot,
            this.slot1,
            this.slot2});
            this.metroGrid1.DataSource = this.itemBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(34, 185);
            this.metroGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(8)))), ((int)(((byte)(12)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(212)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidth = 9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 43;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1882, 542);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_RowLeave);
            this.metroGrid1.SelectionChanged += new System.EventHandler(this.metroGrid1_SelectionChanged);
            this.metroGrid1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_KeyPress);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.mCKDSDataSet;
            // 
            // mCKDSDataSet
            // 
            this.mCKDSDataSet.DataSetName = "MCKDSDataSet";
            this.mCKDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 82);
            this.label1.TabIndex = 6;
            this.label1.Text = "Frying Station";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroPanel1.BackgroundImage")));
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 15;
            this.metroPanel1.Location = new System.Drawing.Point(16, 18);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(130, 120);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 15;
            // 
            // CurRow
            // 
            this.CurRow.AutoSize = true;
            this.CurRow.Location = new System.Drawing.Point(1182, 158);
            this.CurRow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurRow.Name = "CurRow";
            this.CurRow.Size = new System.Drawing.Size(94, 20);
            this.CurRow.TabIndex = 7;
            this.CurRow.Text = "CurrentRow";
            this.CurRow.Visible = false;
            // 
            // CurrentTimePeriod
            // 
            this.CurrentTimePeriod.AutoSize = true;
            this.CurrentTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimePeriod.Location = new System.Drawing.Point(1374, 155);
            this.CurrentTimePeriod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentTimePeriod.Name = "CurrentTimePeriod";
            this.CurrentTimePeriod.Size = new System.Drawing.Size(194, 25);
            this.CurrentTimePeriod.TabIndex = 8;
            this.CurrentTimePeriod.Text = "CurrentTimePeriod";
            this.CurrentTimePeriod.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmRefreshScreen
            // 
            this.tmRefreshScreen.Enabled = true;
            this.tmRefreshScreen.Interval = 10000;
            this.tmRefreshScreen.Tick += new System.EventHandler(this.tmRefreshScreen_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(572, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Visible = false;
            // 
            // lblErrorMSG
            // 
            this.lblErrorMSG.AutoSize = true;
            this.lblErrorMSG.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMSG.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMSG.Location = new System.Drawing.Point(724, 560);
            this.lblErrorMSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMSG.Name = "lblErrorMSG";
            this.lblErrorMSG.Size = new System.Drawing.Size(161, 64);
            this.lblErrorMSG.TabIndex = 10;
            this.lblErrorMSG.Text = "label2";
            this.lblErrorMSG.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1797, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Day";
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "PRODUCT";
            this.ItemName.MinimumWidth = 8;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "UOM";
            this.Unit.MinimumWidth = 8;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 130;
            // 
            // ProjectedQty2
            // 
            this.ProjectedQty2.DataPropertyName = "ProjectedQty2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProjectedQty2.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectedQty2.HeaderText = "PROJECTION2";
            this.ProjectedQty2.MinimumWidth = 8;
            this.ProjectedQty2.Name = "ProjectedQty2";
            this.ProjectedQty2.ReadOnly = true;
            this.ProjectedQty2.Width = 210;
            // 
            // ProjectedQty1
            // 
            this.ProjectedQty1.DataPropertyName = "ProjectedQty1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProjectedQty1.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectedQty1.HeaderText = "PROJECTION1";
            this.ProjectedQty1.MinimumWidth = 8;
            this.ProjectedQty1.Name = "ProjectedQty1";
            this.ProjectedQty1.ReadOnly = true;
            this.ProjectedQty1.Width = 210;
            // 
            // ProjectedQty
            // 
            this.ProjectedQty.DataPropertyName = "ProjectedQty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProjectedQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectedQty.HeaderText = "PROJECTION";
            this.ProjectedQty.MinimumWidth = 8;
            this.ProjectedQty.Name = "ProjectedQty";
            this.ProjectedQty.ReadOnly = true;
            this.ProjectedQty.ToolTipText = "Fried Item Projection Quantity";
            this.ProjectedQty.Width = 210;
            // 
            // CumulativeFriedQty
            // 
            this.CumulativeFriedQty.DataPropertyName = "CFriedQty";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CumulativeFriedQty.DefaultCellStyle = dataGridViewCellStyle5;
            this.CumulativeFriedQty.HeaderText = "COOKED";
            this.CumulativeFriedQty.MinimumWidth = 8;
            this.CumulativeFriedQty.Name = "CumulativeFriedQty";
            this.CumulativeFriedQty.ReadOnly = true;
            this.CumulativeFriedQty.ToolTipText = "Cumulative Fried Qty in current Period";
            this.CumulativeFriedQty.Width = 185;
            // 
            // NeedtoFry
            // 
            this.NeedtoFry.DataPropertyName = "NeedtoFry";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.NeedtoFry.DefaultCellStyle = dataGridViewCellStyle6;
            this.NeedtoFry.HeaderText = "BALANCE TO COOK";
            this.NeedtoFry.MinimumWidth = 8;
            this.NeedtoFry.Name = "NeedtoFry";
            this.NeedtoFry.ReadOnly = true;
            this.NeedtoFry.ToolTipText = "Need to Fry item in current period";
            this.NeedtoFry.Width = 175;
            // 
            // OnHand
            // 
            this.OnHand.DataPropertyName = "OnHand";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.OnHand.DefaultCellStyle = dataGridViewCellStyle7;
            this.OnHand.HeaderText = "ON HAND";
            this.OnHand.MinimumWidth = 8;
            this.OnHand.Name = "OnHand";
            this.OnHand.ReadOnly = true;
            this.OnHand.Width = 180;
            // 
            // FriedQty
            // 
            this.FriedQty.HeaderText = "INPUT";
            this.FriedQty.MinimumWidth = 8;
            this.FriedQty.Name = "FriedQty";
            this.FriedQty.ToolTipText = "Currently Fried Quantity";
            this.FriedQty.Width = 150;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemId";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.MinimumWidth = 8;
            this.ItemId.Name = "ItemId";
            this.ItemId.Visible = false;
            this.ItemId.Width = 150;
            // 
            // DateFrom
            // 
            this.DateFrom.DataPropertyName = "DateFrom";
            this.DateFrom.HeaderText = "DateFrom";
            this.DateFrom.MinimumWidth = 8;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Visible = false;
            this.DateFrom.Width = 150;
            // 
            // DateTo
            // 
            this.DateTo.DataPropertyName = "DateTo";
            this.DateTo.HeaderText = "DateTo";
            this.DateTo.MinimumWidth = 8;
            this.DateTo.Name = "DateTo";
            this.DateTo.Visible = false;
            this.DateTo.Width = 150;
            // 
            // CATEGORY
            // 
            this.CATEGORY.DataPropertyName = "CATEGORY";
            this.CATEGORY.HeaderText = "Category";
            this.CATEGORY.MinimumWidth = 8;
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            this.CATEGORY.Visible = false;
            this.CATEGORY.Width = 130;
            // 
            // CSlot
            // 
            this.CSlot.DataPropertyName = "CSlot";
            this.CSlot.HeaderText = "CSlot";
            this.CSlot.MinimumWidth = 8;
            this.CSlot.Name = "CSlot";
            this.CSlot.ReadOnly = true;
            this.CSlot.Visible = false;
            this.CSlot.Width = 150;
            // 
            // slot1
            // 
            this.slot1.DataPropertyName = "slot1";
            this.slot1.HeaderText = "slot1";
            this.slot1.MinimumWidth = 8;
            this.slot1.Name = "slot1";
            this.slot1.ReadOnly = true;
            this.slot1.Visible = false;
            this.slot1.Width = 150;
            // 
            // slot2
            // 
            this.slot2.DataPropertyName = "slot2";
            this.slot2.HeaderText = "slot2";
            this.slot2.MinimumWidth = 8;
            this.slot2.Name = "slot2";
            this.slot2.ReadOnly = true;
            this.slot2.Visible = false;
            this.slot2.Width = 150;
            // 
            // FryingStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1946, 758);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblErrorMSG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CurrentTimePeriod);
            this.Controls.Add(this.CurRow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FryingStation";
            this.Padding = new System.Windows.Forms.Padding(34, 185, 30, 31);
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderGridForm_FormClosing);
            this.Load += new System.EventHandler(this.FryingStation_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FringStationForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCKDSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label CurRow;
        private System.Windows.Forms.Label CurrentTimePeriod;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer tmRefreshScreen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private MCKDSDataSetTableAdapters.ItemTableAdapter itemTableAdapter1;
        private MCKDSDataSet mCKDSDataSet;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label lblErrorMSG;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectedQty2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectedQty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProjectedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn CumulativeFriedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NeedtoFry;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnHand;
        private System.Windows.Forms.DataGridViewTextBoxColumn FriedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSlot;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot1;
        private System.Windows.Forms.DataGridViewTextBoxColumn slot2;
    }
}