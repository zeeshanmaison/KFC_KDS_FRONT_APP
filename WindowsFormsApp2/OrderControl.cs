using System;
using System.Drawing;
using System.Windows.Forms;

namespace MCKDS
{
    public partial class crlOrder : UserControl
    {
        public const int cOrderTHTime = 3;
        public event EventHandler OrderCtlClick;
        public event KeyPressEventHandler OrderCtleKeyPressed;
        public event EventHandler BumpOrderClick;

        public String OrderID;
        //public enum enOrderType { 
        //DineIn=1,
        //DineOut=2,
        //Takeway=3,
        //DriveThrough=4
        //}
        //private enOrderType OrderTypevalue;
        public crlOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void setTitleColor(string pOrderType)
        {
            if (pOrderType == "DELIVERY") { panHeader.BackColor = Color.Blue; }
            else if (pOrderType == "EAT IN") { panHeader.BackColor = Color.Green; }
            else if (pOrderType == "EAT OUT") { panHeader.BackColor = Color.Orange; }
            else if (pOrderType == "DRIVE THRU") { panHeader.BackColor = Color.Purple; }

        }
        public bool SetOrderBlink
        {
            get { return timer1.Enabled; }
            set { timer1.Enabled = value; if (!value) { lblOrderNo.Visible = true; } }
        }

        public bool SetOrderTimeBlink
        {
            get { return LateOrder.Enabled; }
            set { LateOrder.Enabled = value; if (!value) { lblOrderTime.Visible = true; } }
        }

        public string OrderNo
        {
            get { return lblOrderNo.Text; }
            set { lblOrderNo.Text = value; }
        }
        public string OrderTime
        {
            get { return lblOrderTime.Text; }
            set { lblOrderTime.Text = value; }
        }
        public String OrderType
        {
            get { return lblOrderType.Text; }
            set
            {
                lblOrderType.Text = value.ToString();
                setTitleColor(lblOrderType.Text);

            }
        }
        public String OrderSource
        {
            get { return lblOrderSource.Text; }
            set
            {
                if (value != null)
                    lblOrderSource.Text = value.ToString();
            }
        }
        public string OrderDetails
        {
            get { return wbOrderDetails.DocumentText; }
            set { wbOrderDetails.DocumentText = value; }
        }
        public Boolean OrderBumped
        {
            get { return CheckedPannel.Visible; }
            set { CheckedPannel.Visible = value; }
        }
        public Boolean OrderBumpEnabled
        {
            get { return panel1.Visible; }
            set { panel1.Visible = value; }
        }

        public Boolean OrderRecall
        {
            get { return panelOrderRecall.Visible; }
            set { panelOrderRecall.Visible = value; }
        }

        public Boolean SetOrderOnHold
        {
            get { return panOnHold.Visible; }
            set { panOnHold.Visible = value; }
        }
        private void panHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        protected void OrderCtl_Click(object sender, EventArgs e)
        {

            if (this.OrderCtlClick != null)
                this.OrderCtlClick(this, e);
        }
        protected void OrderCtl_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.OrderCtleKeyPressed != null)
                this.OrderCtleKeyPressed(this, e);
        }

        private void crlOrder_Load(object sender, EventArgs e)
        {
            wbOrderDetails.GotFocus += new System.EventHandler(OrderCtl_Click);
            wbOrderDetails.Width = this.Width - 4;
            wbOrderDetails.Height = this.Height - 50;
            lblOrderNo.Visible = true;

            //if (this.Text == "Expedite Station")
            //{
            //    Bitmap bmp = new Bitmap(System.Reflection.Assembly.GetEntryAssembly().
            //    GetManifestResourceStream(@"~\WindowsFormsApp2\images\pause.png"));

            //    panel1.BackgroundImage = bmp;
            //}

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (this.BumpOrderClick != null)
                this.BumpOrderClick(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblOrderNo.Visible == true)
            {
                lblOrderNo.Visible = false;
            }
            else
            {
                lblOrderNo.Visible = true;
            }
        }

        private void LateOrder_Tick(object sender, EventArgs e)
        {
            try
            {
                string s = lblOrderTime.Text;
                DateTime dt = DateTime.ParseExact(s, "HH:mm:ss",
                                            System.Globalization.CultureInfo.InvariantCulture);


                if ((dt.Minute + dt.Hour * 60) >= cOrderTHTime)
                    lblOrderTime.Visible = !lblOrderTime.Visible;
                else
                    lblOrderTime.Visible = true;
            }
            catch (Exception ex)
            {
                lblOrderTime.Visible = true;
            }
        }
    }
}
