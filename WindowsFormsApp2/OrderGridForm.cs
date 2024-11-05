using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.OleDb;
using System.Threading;
using System.IO;
using System.Resources;
using System.Reflection;
using System.Configuration;

namespace MCKDS
{
    public partial class OrderGridForm : MetroFramework.Forms.MetroForm
    {
        // bilal 
        private string cs = ConfigurationManager.ConnectionStrings["MCKDSConnectionString"].ConnectionString;
        private string cs2 = ConfigurationManager.ConnectionStrings["retaildb"].ConnectionString;


        public enum ScreenSize { Screen2x3 = 6, Screen2x4 = 8 }
        public const int NoOfOrders = 8;
        public crlOrder[] ScreenDisplayOrder;
        private static crlOrder ActiveOrderCtl;
        private clsCOMDataReader ComDataRead;
        private string LastBumpedOrderId;

        string CurrentStationOrdersType;
        int CurrentStation;
        int NextStation = 0;
        int PreviousStation = 0;
        int OrderStatusID = 0;
        public bool HideHoldOrder;
        public bool OrderPaging = false;

        // bilal 
        public bool MOH = false;
        public bool FOH = false;
        public OrderGridForm()
        {
            InitializeComponent();

        }
        public OrderGridForm(String FormName)
        {
            InitializeComponent();
            this.Text = FormName;
            this.lblFormTitle.Text = FormName;

        }

        private void OrderGridForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mCKDSDataSet2.ItemDetails' table. You can move, or remove it, as needed.
            // this.itemDetailsTableAdapter.Fill(this.mCKDSDataSet2.ItemDetails);
            // TODO: This line of code loads data into the 'mCKDSDataSet1.ItemDetails' table. You can move, or remove it, as needed.

            try
            {
                CurrentStation = 1;
                // TODO: This line of code loads data into the 'mCKDSDataSetOrder1.Orders' table. You can move, or remove it, as needed.
                this.ordersTableAdapter.Fill(this.mCKDSDataSetOrder1.Orders);


                if (this.Text == "Front of House (FOH)") // Expedite Station
                {
                    CurrentStation = 2;
                    LoadCurrentStationOrdersType();
                    chkHideHoldOrders.Visible = true;
                    ordersTableAdapter.Adapter.SelectCommand.CommandText = GetFOHQuery();
                    this.ordersTableAdapter.Fill(this.mCKDSDataSetOrder1.Orders);
                    mGridSummary.Visible = false;
                }
                if (CurrentStation == 1)
                {
                    //Summary Table Data 
                    this.itemDetailsTableAdapter.Fill(this.mCKDSDataSet2.ItemDetails);

                    panSummary.Visible = true;
                    mGridSummary.Visible = true;
                }
                //
                createOrderControls();
                poluateOrders();

                //Fullscreen();
                //SetActiveOrdderCtl(ScreenDisplayOrder[0]);

                ComDataRead = new clsCOMDataReader();
                ComDataRead.OpenPort();
                ComDataRead.comDataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(comdata_read);
                tmrDataRefresh.Enabled = true;
            }
            catch (Exception ex)
            {
                ErrorMessageHandler("Unable to Connect KDS Server", ex);
            }



        }
        public void comdata_read(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            try
            {
                SerialPort sp = (SerialPort)sender;
                string value = sp.ReadExisting();

                KeyPressEventArgs ke = new KeyPressEventArgs(value[0]);
                this.Invoke(new Action(() => this.OnKeyPress(ke)));
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

        }
        private void SetActiveOrdderCtl(crlOrder pOrderCtl)
        {
            try
            {
                if (pOrderCtl.OrderNo != null)
                {
                    SetDeactiveOrdderCtl();
                    ActiveOrderCtl = pOrderCtl;

                    ActiveOrderCtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                    //ActiveOrderCtl.SelectedOrder(true);
                    ActiveOrderCtl.Focus();
                    lblCurrentOrderNo.Text = "Selected Order" + ActiveOrderCtl.OrderNo;

                }
            }
            catch (Exception e)
            {
                //ErrorMessageHandler("Unable to Set Active Order", ex);
            }

        }
        private void SetActiveOrdderCtl(int pOrderIndex)
        {
            int Oindex = pOrderIndex;
            if ((Oindex >= 0) & (ScreenDisplayOrder[Oindex].Visible == true))
            {

                crlOrder currentOrder = ScreenDisplayOrder[Oindex];
                if (currentOrder.OrderNo != null)
                {
                    SetDeactiveOrdderCtl();
                    ActiveOrderCtl = currentOrder;

                    ActiveOrderCtl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;


                    //ActiveOrderCtl.SelectedOrder(true);
                    ActiveOrderCtl.Focus();
                    lblCurrentOrderNo.Text = "Selected Order" + ActiveOrderCtl.OrderNo;
                }
            }
        }
        private string getOrderLines(string OrderId, int isMOH)
        {
            try
            {
                dbClass dbcls = new dbClass();
                DataSet ds = dbcls.GetOrdersLines(OrderId, isMOH);

                string n = null;

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ConvertOrderdetailsToHTML(ds.Tables[0]);
                }
                return n;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void SetDeactiveOrdderCtl()
        {

            if ((ActiveOrderCtl != null) && (ActiveOrderCtl.OrderNo != null))
            {
                // ActiveOrderCtl.SelectedOrder(true);
                ActiveOrderCtl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }

        }
        private void OrderGridForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyMapping(e.KeyChar);
        }
        public void KeyMapping(char inputkey)
        {
            try
            {
                switch (inputkey)
                {
                    case 'a':
                    case '1':
                        SetActiveOrdderCtl(0);
                        bumpActiveOrder();
                        break;
                    case 'b':
                    case '5':
                        SetActiveOrdderCtl(4);
                        bumpActiveOrder();
                        break;
                    case 'c':
                    case '2':
                        SetActiveOrdderCtl(1);
                        bumpActiveOrder();
                        break;
                    case 'd':
                    case '6':
                        SetActiveOrdderCtl(5);
                        bumpActiveOrder();
                        break;
                    case 'e':
                    case '3':
                        SetActiveOrdderCtl(2);
                        bumpActiveOrder();
                        break;
                    case 'f':
                    case '7':
                        SetActiveOrdderCtl(6);
                        bumpActiveOrder();
                        break;
                    case 'g':
                    case '4':
                        SetActiveOrdderCtl(3);
                        bumpActiveOrder();
                        break;
                    case 'h':
                    case '8':
                        SetActiveOrdderCtl(7);
                        bumpActiveOrder();
                        break;
                    case 'i':
                        break;
                    case 'j':
                        if ((ActiveOrderCtl != null) && (ActiveOrderCtl.Tag != null) && (ActiveOrderCtl.Tag != ""))
                        {
                            if ((ScreenDisplayOrder.Length - 1 > (int)ActiveOrderCtl.Tag) &
                                (metroGrid1.RowCount - 1 > (int)ActiveOrderCtl.Tag))
                                SetActiveOrdderCtl(ScreenDisplayOrder[(int)ActiveOrderCtl.Tag + 1]);
                            else
                                SetActiveOrdderCtl(ScreenDisplayOrder[0]);

                        }
                        break;
                    case 'k':
                        //case '8':
                        chkHideHoldOrders.Checked = !chkHideHoldOrders.Checked;
                        RefreshScreen();
                        break;
                    case 'l':
                        break;
                    case 'm':
                    case '9':
                        RecallLastbumpOrder();
                        break;
                    case '0':
                        OrderPaging = true;
                        RefreshScreen();
                        break;
                    case 'n':
                    case (char)Keys.Enter:
                        bumpActiveOrder();

                        break;
                    case 'o':
                    case (char)Keys.Left:
                    case '/':
                        if ((ActiveOrderCtl != null) && (ActiveOrderCtl.Tag != null) && (ActiveOrderCtl.Tag != "") && ((int)ActiveOrderCtl.Tag > 0))

                            SetActiveOrdderCtl(ScreenDisplayOrder[(int)ActiveOrderCtl.Tag - 1]);
                        else
                            if (metroGrid1.RowCount > ScreenDisplayOrder.Length)
                            SetActiveOrdderCtl(ScreenDisplayOrder[ScreenDisplayOrder.Length - 1]);
                        else
                            SetActiveOrdderCtl(ScreenDisplayOrder[metroGrid1.RowCount - 1]);

                        break;
                    case 'p':
                    case (char)Keys.Right:
                    case '*':
                        if ((ActiveOrderCtl != null) && (ActiveOrderCtl.Tag != null) && (ActiveOrderCtl.Tag != ""))
                        {
                            if ((ScreenDisplayOrder.Length - 1 > (int)ActiveOrderCtl.Tag) &
                                (metroGrid1.RowCount - 1 > (int)ActiveOrderCtl.Tag))
                                SetActiveOrdderCtl(ScreenDisplayOrder[(int)ActiveOrderCtl.Tag + 1]);
                            else
                                SetActiveOrdderCtl(ScreenDisplayOrder[0]);

                        }
                        break;
                    case (char)Keys.PageDown:
                        //case '*':
                        OrderPaging = !OrderPaging;
                        RefreshScreen();

                        break;
                    case (char)Keys.PageUp:
                        //case '*':
                        OrderPaging = false;
                        RefreshScreen();

                        break;
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                ErrorMessageHandler("Invalid Key Pushing " + inputkey, ex);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                //MessageBox.Show("You pressed Up arrow key");
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                //MessageBox.Show("You pressed Down arrow key");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                KeyMapping((char)keyData);

                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                KeyMapping((char)keyData);

                return true;
            }
            if (keyData == Keys.Divide)
            {
                KeyMapping((char)keyData);

                return true;
            }
            if (keyData == Keys.Multiply)
            {
                KeyMapping((char)keyData);

                return true;
            }

            if (keyData == Keys.NumPad1)
            {
                KeyMapping('1');

                return true;
            }
            if (keyData == Keys.NumPad2)
            {
                KeyMapping('2');

                return true;
            }
            if (keyData == Keys.NumPad3)
            {
                KeyMapping('3');

                return true;
            }
            if (keyData == Keys.NumPad4)
            {
                KeyMapping('4');

                return true;
            }
            if (keyData == Keys.NumPad5)
            {
                KeyMapping('5');

                return true;
            }
            if (keyData == Keys.NumPad6)
            {
                KeyMapping('6');

                return true;
            }
            if (keyData == Keys.NumPad7)
            {
                KeyMapping('7');

                return true;
            }
            if (keyData == Keys.NumPad8)
            {
                KeyMapping('8');

                return true;
            }

            if (keyData == Keys.NumPad0)
            {
                KeyMapping('0');

                return true;
            }

            if (keyData == Keys.Enter)
            {
                KeyMapping((char)Keys.Enter);

                return true;
            }

            if (keyData == Keys.PageDown)
            {
                KeyMapping((char)Keys.PageDown);
                return true;
            }

            if (keyData == Keys.PageUp)
            {
                KeyMapping((char)Keys.PageUp);
                return true;
            }

            //KeyMapping((char)keyData);


            //return true;
            return base.ProcessCmdKey(ref msg, keyData);
        }

        struct clientRect
        {
            public Point location;
            public int width;
            public int height;
        };
        // this should be in the scope your class
        clientRect restore;
        bool fullscreen = false;
        private void Form2_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                fullscreen = false;
                Fullscreen();

            }
        }
        void Fullscreen()
        {
            if (fullscreen == false)
            {
                this.restore.location = this.Location;
                this.restore.width = this.Width;
                this.restore.height = this.Height;
                this.TopMost = true;
                this.Location = new Point(0, 0);
                this.FormBorderStyle = FormBorderStyle.None;
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.Bounds.Height;
            }
            else
            {
                this.TopMost = false;
                this.Location = this.restore.location;
                this.Width = this.restore.width;
                this.Height = this.restore.height;
                // these are the two variables you may wish to change, depending
                // on the design of your form (WindowState and FormBorderStyle)
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void createOrderControls()
        {
            ScreenDisplayOrder = new crlOrder[NoOfOrders];
            const int OrderPadding = 20;
            int counter = 0;
            int posX = OrderPadding;
            int posY = 0;

            int _ScreenWidth = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //int _ScreenHeight = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            int _ScreenHeight = 786;

            int height = (_ScreenHeight / 2) - 75;
            int width = (_ScreenWidth / 4) - 75;

            if (width < 266)
                width = 266;

            // MessageBox.Show(" Screen Width:" + _ScreenWidth + " ScrHeight:" + _ScreenHeight + " OrderHeight: " + height + " OrderWidth" + width);


            while (counter < NoOfOrders)
            {
                ScreenDisplayOrder[counter] = new crlOrder();
                ScreenDisplayOrder[counter].Visible = false;
                ScreenDisplayOrder[counter].BorderStyle = System.Windows.Forms.BorderStyle.None;
                ScreenDisplayOrder[counter].Tag = counter + 1;
                ScreenDisplayOrder[counter].Height = height;
                ScreenDisplayOrder[counter].Width = width;

                ScreenDisplayOrder[counter].Left = posX;
                ScreenDisplayOrder[counter].Top = posY;

                panOrders.Controls.Add(ScreenDisplayOrder[counter]);
                posX = posX + ScreenDisplayOrder[counter].Width + OrderPadding;
                if ((counter + 1) % 4 == 0)
                {
                    posX = OrderPadding;
                    posY += height + OrderPadding;
                }

                ScreenDisplayOrder[counter].OrderCtlClick += new System.EventHandler(ctlOrderButtonHandler);
                ScreenDisplayOrder[counter].OrderCtleKeyPressed += new System.Windows.Forms.KeyPressEventHandler(OrderGridForm_KeyPress);
                ScreenDisplayOrder[counter].BumpOrderClick += new System.EventHandler(ctlOrderBumClickHandler);
                //ScreenDisplayOrder[counter].Click += new System.EventHandler(ctlOrderButtonHandler);
                //ScreenDisplayOrder[counter].Paint += new System.Windows.Forms.PaintEventHandler(OrderCtl_Paint);
                //ScreenDisplayOrder[counter].KeyPress += new System.Windows.Forms.KeyPressEventHandler(OrderGridForm_KeyPress);
                counter++;
            }
        }
        private void ctlOrderButtonHandler(object sender, EventArgs e)
        {
            //SetActiveOrdderCtl((crlOrder)sender);

            crlOrder OCtl = (crlOrder)sender;
            if ((ActiveOrderCtl != null) && (OCtl.Tag != ActiveOrderCtl.Tag))
            {
                SetActiveOrdderCtl(OCtl);
            }
        }
        private void ctlOrderBumClickHandler(object sender, EventArgs e)
        {
            crlOrder OCtl = (crlOrder)sender;
            if ((OCtl.Tag != null))
            {
                SetActiveOrdderCtl(OCtl);
                bumpActiveOrder();
            }
        }
        //private int CheckIsMoh(string OrderNo)
        //{
        //    int isprevent = 0;
        //    SqlConnection con = new SqlConnection(cs);
        //    string query = @"
        //              select distinct ord.OrderNo , rit.ITEMID,rit.MOH  from Orders as ord 
        //              inner join RetailChannelDatabase.ax.RETAILINVENTTABLE as rit
        //              on ord.ItemID = rit.ITEMID  COLLATE Latin1_General_CI_AS 
        //              inner join RetailChannelDatabase.ax.RETAILTRANSACTIONSALESTRANS as rtst 
        //              on rtst.TRANSACTIONID = ord.TransactionID COLLATE Latin1_General_CI_AS
        //              where ord.OrderNo = @ordno";
        //    SqlDataAdapter sda = new SqlDataAdapter(query, con);
        //    sda.SelectCommand.Parameters.AddWithValue("@ordno", OrderNo);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    if (dt.Rows.Count > 0)
        //    {
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            if (int.Parse(dr["MOH"].ToString()) == 1)
        //            {
        //                isprevent = 1;
        //            }
        //        }
        //    }
        //    return isprevent;
        //}

        // bilal khan 

        private void RemoveDuplicateHdsOrders(string hdsoid)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from Orders where HdsOrderId ='" + hdsoid + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["TransactionType"].ToString() == "2" && dr["OrderStatusId"].ToString() == "1")
                        {
                            string deleteHdsDuplicatOrder = @"delete from Orders where HdsOrderId = @hdsOrdId 
                                                              and TransactionType=@transType and OrderStatusId = @OrderStatusid";
                            SqlCommand cmd = new SqlCommand(deleteHdsDuplicatOrder, con);
                            cmd.Parameters.AddWithValue("@hdsOrdId", hdsoid);
                            cmd.Parameters.AddWithValue("@transType", dr["TransactionType"].ToString());
                            cmd.Parameters.AddWithValue("@OrderStatusid", dr["OrderStatusId"].ToString());
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "");
            }
        }

        //-----------------------------bilal khan

        public void CheckItemWiseMoh(string ItemId)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs2);
                string query = "select * from ax.RETAILINVENTTABLE where ItemId = '" + ItemId + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    if ( int.Parse(dr["MOH"].ToString()) == 1 )
                    {
                        FOH = true;  
                    }
                    else
                    {
                        MOH = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void CheckFohOrders(string orderid)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "select * from Orders where OrderId = '" +orderid+ "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        CheckItemWiseMoh(dr["ItemId"].ToString());
                    }
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        public void SwichToFoh(string OrderId)
        {
            try
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "update orders set OrderStatusId = 2 , OrderStatus='Expeditor' where OrderId='"+OrderId+"'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        //(usman khan)
        public void poluateOrders()
        {
            int i = 0;
            int isMOH = 1;
            bool isFOHOnly = false;
            string orderId = null;
            // bilal 
            string gethdsorderid = string.Empty;
            string OrderId = string.Empty;
            //------------------------------------bilal khan
            //int OrderPage=NoOfOrders* Page;

            int y = 0; int NextOrder = 0;
            if (OrderPaging)
            {
                if (metroGrid1.Rows.Count < 8)
                { 
                    OrderPaging = false; 
                    return; 
                }
                else
                {
                    NextOrder = 8;
                }
            }

            if (ScreenDisplayOrder == null) return;

            lblTotalOrder.Text = "Total Orders " + metroGrid1.Rows.Count.ToString();
            if (ActiveOrderCtl != null)
                lblCurrentOrderNo.Text = "Selected Order " + ActiveOrderCtl.OrderNo;
             

            /*
           if (ScreenDisplayOrder == null) return;

            lblTotalOrder.Text = "Total Orders " + metroGrid1.Rows.Count.ToString();
            if (ActiveOrderCtl != null)w
                lblCurrentOrderNo.Text = "Selected Order " + ActiveOrderCtl.OrderNo;

         
            //foreach (DataGridViewRow row in metroGrid1.Rows)
            for(int i1 = NextOrder; i1 < metroGrid1.Rows.Count; i1++)
            {
                DataGridViewRow row = metroGrid1.Rows[i1];
                if (i < (NoOfOrders))
                {
             */

            //foreach (DataGridViewRow row in metroGrid1.Rows)
            for (int i1 = NextOrder; i1 < metroGrid1.Rows.Count; i1++)
            {
                DataGridViewRow row = metroGrid1.Rows[i1];
                if (i < (NoOfOrders))
                {
                    string TransactionT = row.Cells[6].Value.ToString();
                    if (this.Text == "Front of House (FOH)") // Expedite Station
                    {
                        isMOH = 0;
                        if (TransactionT == "36")
                        {
                            ScreenDisplayOrder[i].SetOrderOnHold = true;
                        }
                        else
                        {
                            ScreenDisplayOrder[i].SetOrderOnHold = false;
                        }
                    }
                    //Order ID mapping

                    DataGridViewCell OrderID = row.Cells[0];
                    ScreenDisplayOrder[i].OrderID = row.Cells[4].Value.ToString();
                    orderId = row.Cells[4].Value.ToString();
                    ScreenDisplayOrder[i].OrderNo = row.Cells[0].Value.ToString(); //dgvc.Value.ToString();
                    DataGridViewCell OrderType = row.Cells[1];
                    ScreenDisplayOrder[i].OrderType = OrderType.Value.ToString();
                    if (row.Cells["OrderSource"].Value != null)
                        ScreenDisplayOrder[i].OrderSource = getOrderSource(row.Cells["OrderSource"].Value.ToString());

                    //------------------------------------bilal khan 

                    CheckFohOrders(orderId);

                    if (FOH == true && MOH == false )
                    {
                        SwichToFoh(orderId);
                    }

                    FOH = false;
                    MOH = false;

                    // bilal 
                    if (ScreenDisplayOrder[i].OrderSource == "                                                            : Source: ")
                    {
                        ScreenDisplayOrder[i].OrderSource = "KIOSK";
                    }
                    //---------------------------------------end section 


                    //(usman)
                    isFOHOnly = SqlService.GetItemIDIsFOHOnly(orderId);

                    if (row.Cells[3].Value != null)
                    {
                        var orderstatus = row.Cells[3].Value.ToString();

                        if (orderstatus == "Preparation" && CurrentStation == 2)
                        {
                            if (isFOHOnly)
                            {
                                ScreenDisplayOrder[i].OrderBumpEnabled = true;
                                ScreenDisplayOrder[i].SetOrderOnHold = false;
                            }
                            else
                            {
                                ScreenDisplayOrder[i].OrderBumpEnabled = false;
                            }
                            ScreenDisplayOrder[i].SetOrderOnHold = false;
                        }
                        else
                        {
                            ScreenDisplayOrder[i].OrderBumpEnabled = true;

                        }
                    }

                    DataGridViewCell OrderTime = row.Cells[2];
                    string dt = Convert.ToDateTime(OrderTime.Value).ToLongDateString();

                    //ScreenDisplayOrder[i].OrderTime = GetOrderTime(Convert.ToDateTime(OrderTime.Value.ToString())) + " min";
                    ScreenDisplayOrder[i].OrderTime = row.Cells[5].Value.ToString();

                    ScreenDisplayOrder[i].OrderBumped = false;
                    ScreenDisplayOrder[i].Enabled = true;

                    ScreenDisplayOrder[i].Visible = true;
                    ScreenDisplayOrder[i].Tag = i;

                    var status = row.Cells[10].Value.ToString();
                    if (status == "1" || status == "0")
                        ScreenDisplayOrder[i].SetOrderBlink = true;
                    else
                    {
                        ScreenDisplayOrder[i].SetOrderBlink = false;
                    }

                    ScreenDisplayOrder[i].OrderDetails = getOrderLines(row.Cells[4].Value.ToString(), isMOH);


                    //(usman Khan)
                    //string orderLines = getOrderLines(row.Cells[4].Value.ToString(), isMOH);

                    //if (orderLines == null || orderLines == string.Empty || orderLines == "")
                    //{
                    //    ScreenDisplayOrder[i].Visible = false;
                    //}
                    //else
                    //{
                    //    ScreenDisplayOrder[i].Visible = true;
                    //}
                    i++;
                }
            }

            for (int j = i; j < NoOfOrders; j++)
            {
                ScreenDisplayOrder[j].Visible = false;
                ScreenDisplayOrder[j].Tag = "";

            }
            // MessageBox.Show("Data: " + OrderDetails);
        }
                                
        private string getOrderSource(String pOrderSource)
        {
            string OrderDetails = pOrderSource;
            string[] OrderSourcedetails = pOrderSource.Split(';');
            if (OrderSourcedetails.Length > 1)
            {
                string TPID = OrderSourcedetails[1].Replace("ThirdPartyOrder:", "");
                string TP = OrderSourcedetails[2].Replace("Source: ", "");
                OrderDetails = TP + ":" + TPID;
            }
            return OrderDetails;
        }
        //(usman khan)
        public static string ConvertOrderdetailsToHTML(DataTable dt)
        {
            string OrderScource = "";
            string State = "";
            string html = string.Empty;
            string a = string.Empty;

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string item = row.Field<string>("Items");
                    if (item.Contains(" | "))
                    {
                        row["Items"] = row["Items"].ToString().Replace(" | ", "</br>");
                    }
                }
                html = @"<table style=font-family:Calibri;font-size:14px;>";
                html += "<b>" + OrderScource + "</b>";
                //add header row
                html += "<tr style=font-weight:bold;>";
                for (int i = 0; i < 2; i++)
                    html += "<td>" + dt.Columns[i].ColumnName + "</td>";
                html += "</tr>";
                //add rows
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    State = dt.Rows[i][3].ToString();
                    if (State == "Cancelled")
                    {
                        html += @"<tr style=text-decoration:line-through;>";
                        for (int j = 0; j < 2; j++)
                            html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
                        html += "</tr>";
                    }
                    else
                    {
                        html += "<tr>";
                        for (int j = 0; j < 2; j++)
                            html += "<td >" + dt.Rows[i][j].ToString() + "</td>";
                        html += "</tr>";
                    }
                }
                html += "</table>";
            }

            return html;
        }
        private String GetOrderTime(DateTime pOrderTime)
        {
            String OrderTime;
            OrderTime = Math.Round(DateTime.Now.Subtract(pOrderTime).TotalMinutes, 2).ToString();

            OrderTime = OrderTime.Replace(".", ":");
            return OrderTime;

        }
        public void RefreshScreen()
        {
            dbClass dbcls = new dbClass();

            if (ReFillGrid())
            {
                poluateOrders();
                bool orderstate = dbcls.ResetBlinkingOrders();
            }
        }

        //(usman khan)
        private void bumpActiveOrder()
        {
            bool isFOHOnly = false;
            if (ActiveOrderCtl != null)
            {
                try
                {
                    dbClass dbcls = new dbClass();
                    OrderStatusID = dbcls.GetOrderStatusID(ActiveOrderCtl.OrderID);

                    isFOHOnly = SqlService.GetItemIDIsFOHOnly(ActiveOrderCtl.OrderID);


                    if (CurrentStation == 2 && OrderStatusID == 1)
                    {
                        if (!isFOHOnly)
                        {
                            return;
                        }
                    }


                    string orderstate = dbcls.GetOrderState(ActiveOrderCtl.OrderID);

                    if (orderstate == "Cancelled")
                    { OrderStatusID = 5; }

                    //if (orderstate != "Cancelled")
                    //{ OrderStatusID = dbcls.GetOrderStatusID(ActiveOrderCtl.OrderID); }
                    //else { OrderStatusID = 5; }

                    int TransactionType = dbcls.GetTransactionType(ActiveOrderCtl.OrderID);

                    if (TransactionType == 2)
                    {   
                        ActiveOrderCtl.OrderBumped = true;

                        //if (orderstate != "Cancelled")
                        //{ OrderStatusID = dbcls.GetOrderStatusID(ActiveOrderCtl.OrderID); }
                        //else { OrderStatusID = 5; }

                        string values = dbcls.GetConfiguration(3);
                        char[] spearator = { ',' };
                        string[] stationslist = values.Split(spearator);

                        NextStation = GetNextStation(stationslist, OrderStatusID);
                        
                        if (dbcls.BumpOrder(ActiveOrderCtl.OrderID, NextStation))
                        {
                            int milliseconds = 500;
                            Thread.Sleep(milliseconds);
                            LastBumpedOrderId = ActiveOrderCtl.OrderID;
                            this.RefreshScreen();
                        }
                        else
                        {
                            MessageBox.Show("Message: Unable to update");
                        }
                    }

                    else if (TransactionType == 36 && OrderStatusID == 1)
                    {
                        ActiveOrderCtl.OrderBumped = true;

                        //if (orderstate != "Cancelled")
                        //{ OrderStatusID = dbcls.GetOrderStatusID(ActiveOrderCtl.OrderID); }
                        //else { OrderStatusID = 5; }
                        string values = dbcls.GetConfiguration(3);
                        char[] spearator = { ',' };
                        string[] stationslist = values.Split(spearator);

                        NextStation = GetNextStation(stationslist, OrderStatusID);

                        if (dbcls.BumpOrder(ActiveOrderCtl.OrderID, NextStation))
                        {
                            int milliseconds = 600;
                            Thread.Sleep(milliseconds);
                            LastBumpedOrderId = ActiveOrderCtl.OrderID;
                            this.RefreshScreen();
                        }
                        else
                        {
                            MessageBox.Show("Message: Unable to update");
                        }
                    }
                    else if (TransactionType == 36 && orderstate == "Cancelled")
                    {
                        ActiveOrderCtl.OrderBumped = true;
                        string values = dbcls.GetConfiguration(3);
                        char[] spearator = { ',' };
                        string[] stationslist = values.Split(spearator);

                        NextStation = GetNextStation(stationslist, 5);

                        if (dbcls.BumpOrder(ActiveOrderCtl.OrderID, NextStation))
                        {
                            int milliseconds = 600;
                            Thread.Sleep(milliseconds);
                            LastBumpedOrderId = ActiveOrderCtl.OrderID;
                            this.RefreshScreen();
                        }
                        else
                        {
                            MessageBox.Show("Message: Unable to update");
                        }
                    }
                    else 
                    {
                        //if (TransactionType == 36 && OrderStatusID == 2)
                        //{
                        //    ActiveOrderCtl.OrderBumped = true;
                        //    string values = dbcls.GetConfiguration(3);
                        //    char[] spearator = { ',' };
                        //    string[] stationslist = values.Split(spearator);

                        //    NextStation = GetNextStation(stationslist, 5);

                        //    if (dbcls.BumpOrder(ActiveOrderCtl.OrderID, NextStation))
                        //    {
                        //        int milliseconds = 600;
                        //        Thread.Sleep(milliseconds);
                        //        LastBumpedOrderId = ActiveOrderCtl.OrderID;
                        //        this.RefreshScreen();
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("Message: Unable to update");
                        //    }
                        //}
                    }
                }
                catch (Exception e)
                {
                    //ErrorMessageHandler("Unable to Bump Order", ex);
                }
            }
        }
        private void RecallLastbumpOrder()
        {
            if (LastBumpedOrderId != null)
            {
                //ActiveOrderCtl.OrderRecall = true;

                dbClass dbcls = new dbClass();
                OrderStatusID = dbcls.GetOrderStatusID(LastBumpedOrderId);
                string values = dbcls.GetConfiguration(3);
                char[] spearator = { ',' };
                string[] stationslist = values.Split(spearator);

                PreviousStation = GetPreviousStation(stationslist, OrderStatusID);

                if (dbcls.ReCallLastOrder(LastBumpedOrderId, PreviousStation))
                {
                    int milliseconds = 100;
                    Thread.Sleep(milliseconds);
                    LastBumpedOrderId = null;
                    this.RefreshScreen();

                }
                else
                {
                    //ErrorMessageHandler("Unable to recall Last Order", ex);
                    MessageBox.Show("Message: Unable to recall Last Order");
                }
            }

        }
        private void btnRefreshScreen_Click(object sender, EventArgs e)
        {
            //RefreshScreen();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            RefreshScreen();
        }
        private void OrderGridForm_Shown(object sender, EventArgs e)
        {
            RefreshScreen();
            if (ScreenDisplayOrder != null)
                SetActiveOrdderCtl(ScreenDisplayOrder[0]);
        }
        private void OrderGridForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ComDataRead != null)
                ComDataRead.close();
            this.Dispose(true);
        }

        private bool ReFillGrid()
        {
            try
            {
                if (this.Text == "Front of House (FOH)") // Expedite Station
                {
                    ordersTableAdapter.Adapter.SelectCommand.CommandText = GetFOHQuery();
                }
                this.ordersTableAdapter.Fill(this.mCKDSDataSetOrder1.Orders);
                if (CurrentStation == 1)
                {
                    this.itemDetailsTableAdapter.Fill(this.mCKDSDataSet2.ItemDetails);
                }
                ClearMsgtoPanel();
                return true;
            }
            catch (System.Exception ex)
            {
                ErrorMessageHandler("Unable to Connect KDS Server", ex);
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }

        }


        private void ErrorMessageHandler(String Msg, Exception e)
        {
            //MessageBox.Show(Msg);
            WriteMsgtoPanel(Msg);
            //WritetoLogfile(Msg,e);
        }
        private void WriteMsgtoPanel(String Msg)
        {

            lblErrorMSG.Text = Msg;
            lblErrorMSG.Visible = true;
        }
        private void ClearMsgtoPanel()
        {
            lblErrorMSG.Text = "";
            lblErrorMSG.Visible = false;

        }

        public int GetNextStation(string[] Values, int CurrentStationID)
        {
            try
            {
                int NS = CurrentStationID + 1;

                NextStation = Convert.ToInt32(Values[NS]);
                return NextStation;
            }
            catch (Exception)
            {
                return NextStation = 4;
            }
        }

        public int GetPreviousStation(string[] Values, int OrderStatus)
        {
            try
            {
                int NS = OrderStatus - 1;
                if (NS >= 1)
                {
                    //NS = NS - 1;
                    PreviousStation = Convert.ToInt32(Values[NS]);
                }
                return PreviousStation;
            }
            catch (Exception)
            {
                return PreviousStation;
            }
        }


        private void chkHideHoldOrders_CheckedChanged(object sender, EventArgs e)
        {
            HideHoldOrder = chkHideHoldOrders.Checked;
            SetHoldImage();
            RefreshScreen();
        }

        private void LoadCurrentStationOrdersType()
        {
            string tmpStr = "";
            CurrentStationOrdersType = "";
            string StationName = "";
            string filepath = @"Settings.txt";
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                StationName = lines[0].Substring(2, lines[0].Length - 2);
                lblCustomStationName.Text = StationName;
                lblCustomStationName.Visible = true;
                char[] spearator2 = { ',' };
                string[] channelslist = lines[2].Split(spearator2);

                foreach (string line in channelslist)
                {
                    if (line == "EAT IN")
                    {
                        tmpStr += tmpStr != "" ? tmpStr = "'EAT IN'" : tmpStr = "'EAT IN'";
                    }
                    else if (line == "EAT OUT")
                    {
                        tmpStr += tmpStr != "" ? tmpStr = ",'EAT OUT'" : tmpStr = "'EAT OUT'";
                    }
                    else if (line == "DELIVERY")
                    {
                        tmpStr += tmpStr != "" ? tmpStr = ",'DELIVERY'" : tmpStr = "'DELIVERY'";
                    }
                    else if (line == "DRIVE THRU")
                    {
                        tmpStr += tmpStr != "" ? tmpStr = ",'DRIVE THRU'" : tmpStr = "'DRIVE THRU'";
                    }
                    else if (line == "EMPLOYEE MEAL")
                    {
                        tmpStr += tmpStr != "" ? tmpStr = ",'EMPLOYEE MEAL'" : tmpStr = "'EMPLOYEE MEAL'";
                    }
                }
                CurrentStationOrdersType = tmpStr;
            }
        }

        private string GetFOHQuery()
        {
            string HideOnHoldOrdersQuery = "";
            string FOHQuery = "";

            if (HideHoldOrder)
            {
                HideOnHoldOrdersQuery = " and (isnull(OnHold,0) <>1)";
            }

            FOHQuery = @"SELECT Orderid, OrderType, MIN(TransactionType) as TransactionType, SUBSTRING(OrderSource, 0, 100) AS OrderSource, MIN(CreatedOn) as CreatedOn, OrderStatus, OrderNo, CONVERT(varchar(8),
                            DATEADD(SECOND, DATEDIFF(SECOND, MIN(CreatedOn), GETDATE()), 0), 114) OrderTime ,OrderState, OrderStatusID , MIN(NextOrderStatus) as NextOrderStatus
                            FROM Orders WHERE OrderStatusid in (1,2) " + HideOnHoldOrdersQuery + @"and OrderType in (" + CurrentStationOrdersType + @")
                            Group BY[Orderid], OrderType, OrderSource, OrderStatus, OrderNo, OrderState, OrderStatusID
                            ORDER BY MIN(CreatedOn)";
            return FOHQuery;
        }

        private void SetHoldImage()
        {
            if (HideHoldOrder)
            {
                ResourceManager rm = new ResourceManager("MCKDS.OrderGridForm", Assembly.GetExecutingAssembly());
                System.Drawing.Image myImage = (System.Drawing.Image)rm.GetObject("Pause_1");
                chkHideHoldOrders.BackgroundImage = myImage;
                chkHideHoldOrders.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                ResourceManager rm = new ResourceManager("MCKDS.OrderGridForm", Assembly.GetExecutingAssembly());
                System.Drawing.Image myImage = (System.Drawing.Image)rm.GetObject("Pause_2");
                chkHideHoldOrders.BackgroundImage = myImage;
                chkHideHoldOrders.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void mGridSummary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.mGridSummary.Columns[e.ColumnIndex].Name == "Summary")
            {
                //if (e.Value.ToString() == "Sandwich" || e.Value.ToString() == "Snacks")
                //{

                // mGridSummary.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Verdana", 11, FontStyle.Bold); //Font(mGridSummary.Font, FontStyle.Bold);
                //mGridSummary.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                mGridSummary.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Orange;
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hey!");
        }

    }
}